using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Sdk.Generated.Models;
#if !NET5_0_OR_GREATER
using System.Runtime.InteropServices;
#endif

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// Maintains a WebSocket connection to the Jellyfin server configured in <see cref="JellyfinSdkSettings"/>.
/// </summary>
/// <remarks>
/// The connection opens when the first subscription is added and the settings contain a server url and access token,
/// and closes after <see cref="JellyfinWebSocketOptions.IdleTimeout"/> once every subscription is disposed.
/// Each connection attempt reads the server url and access token from the settings, call <see cref="Reconnect"/>
/// after changing them. Subscribing to sessions, activity log entries or scheduled tasks with
/// <see cref="Subscribe{TMessage}"/> sends the matching start and stop messages to the server.
/// </remarks>
public sealed partial class JellyfinWebSocketClient : IDisposable
{
    private const int ReceiveBufferSize = 16 * 1024;

    // Matches SessionWebSocketListener.WebSocketLostTimeout on the server.
    private const int DefaultLostTimeoutSeconds = 60;
    private static readonly TimeSpan _closeTimeout = TimeSpan.FromSeconds(5);

    // One keep alive interval, half the server's 60 second lost timeout, resets the reconnect attempts.
    private static readonly TimeSpan _stableConnectionTime = TimeSpan.FromSeconds(30);

    // SemaphoreSlim.WaitAsync accepts at most int.MaxValue milliseconds.
    private static readonly TimeSpan _maxReconnectDelay = TimeSpan.FromMilliseconds(int.MaxValue);

    // The longest period System.Threading.Timer accepts.
    private static readonly TimeSpan _maxKeepAliveInterval = TimeSpan.FromMilliseconds(uint.MaxValue - 1);

    private static readonly Dictionary<SessionMessageType, (string Start, string Stop)> _periodicMessageTypes = new()
    {
        [SessionMessageType.Sessions] = (nameof(SessionMessageType.SessionsStart), nameof(SessionMessageType.SessionsStop)),
        [SessionMessageType.ActivityLogEntry] = (nameof(SessionMessageType.ActivityLogEntryStart), nameof(SessionMessageType.ActivityLogEntryStop)),
        [SessionMessageType.ScheduledTasksInfo] = (nameof(SessionMessageType.ScheduledTasksInfoStart), nameof(SessionMessageType.ScheduledTasksInfoStop))
    };

    // Set while this thread runs a handler or event for the run loop, where waiting for the run loop deadlocks.
    [ThreadStatic]
    private static JellyfinWebSocketClient? _callbackClient;

    private readonly JellyfinSdkSettings _settings;
    private readonly JellyfinWebSocketOptions _options;
    private readonly Func<WebSocketConnectionTarget, CancellationToken, Task<WebSocket>> _connect;
    private readonly object _lock = new();
    private readonly Dictionary<SessionMessageType, int> _periodicSubscriptions = new();
    [SuppressMessage("Usage", "CA2213:Disposable fields should be disposed", Justification = "Disposed when the run loop exits.")]
    private readonly SemaphoreSlim _signal = new(0, 1);

    [SuppressMessage("Usage", "CA2213:Disposable fields should be disposed", Justification = "Disposed when the run loop exits.")]
    private readonly CancellationTokenSource _disposeCancellationTokenSource = new();
    private readonly Task _runTask;

    private WebSocketSubscription[] _subscriptions = [];
    private WebSocketConnection? _connection;
    private Timer? _idleTimer;
    private WebSocketConnectionState _state;
    private int _failedAttempts;
    private bool _stoppedReconnecting;
    private bool _disposed;

    /// <summary>
    /// Initializes a new instance of the <see cref="JellyfinWebSocketClient"/> class.
    /// </summary>
    /// <param name="settings">The Jellyfin sdk settings.</param>
    /// <param name="options">The WebSocket options.</param>
    public JellyfinWebSocketClient(JellyfinSdkSettings settings, JellyfinWebSocketOptions? options = null)
        : this(settings, options, null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JellyfinWebSocketClient"/> class.
    /// </summary>
    /// <param name="settings">The Jellyfin sdk settings.</param>
    /// <param name="options">The WebSocket options.</param>
    /// <param name="connect">Opens the WebSocket, overridden in tests.</param>
    internal JellyfinWebSocketClient(
        JellyfinSdkSettings settings,
        JellyfinWebSocketOptions? options,
        Func<WebSocketConnectionTarget, CancellationToken, Task<WebSocket>>? connect)
    {
        _settings = settings;
        _options = options ?? new JellyfinWebSocketOptions();
        _connect = connect ?? ConnectClientWebSocketAsync;

        _runTask = Task.Run(RunAsync);
    }

    /// <summary>
    /// The event that fires when the connection state changes.
    /// </summary>
    public event EventHandler<WebSocketStateChangedEventArgs>? StateChanged;

    /// <summary>
    /// The event that fires when a message cannot be read or a message handler throws.
    /// </summary>
    public event EventHandler<TypedEventArgs<Exception>>? ErrorOccurred;

    /// <summary>
    /// Gets the current connection state.
    /// </summary>
    public WebSocketConnectionState State
    {
        get
        {
            lock (_lock)
            {
                return _state;
            }
        }
    }

    /// <summary>
    /// Subscribe to a message type.
    /// </summary>
    /// <param name="handler">The message handler. Handlers run on the receive loop and should return quickly.</param>
    /// <typeparam name="TMessage">The message type, for example <see cref="LibraryChangedMessage"/>.</typeparam>
    /// <returns>A subscription that removes the handler when disposed.</returns>
    public IDisposable Subscribe<TMessage>(Action<TMessage> handler)
        where TMessage : class, IOutboundWebSocketMessage, new()
    {
        ThrowIfNull(handler, nameof(handler));

        return AddSubscription(new WebSocketSubscription(this, GetMessageType<TMessage>(), message => handler((TMessage)message)));
    }

    /// <summary>
    /// Subscribe to all messages, except keep alive messages.
    /// </summary>
    /// <remarks>
    /// Does not start the periodic sessions, activity log or scheduled task messages. Those arrive only while a
    /// <see cref="Subscribe{TMessage}"/> subscription for their type exists.
    /// </remarks>
    /// <param name="handler">The message handler. Handlers run on the receive loop and should return quickly.</param>
    /// <returns>A subscription that removes the handler when disposed.</returns>
    public IDisposable SubscribeAll(Action<IOutboundWebSocketMessage> handler)
    {
        ThrowIfNull(handler, nameof(handler));

        return AddSubscription(new WebSocketSubscription(this, null, handler));
    }

    /// <summary>
    /// Close the current connection, if any, and connect again immediately.
    /// Call after changing the server url or access token in <see cref="JellyfinSdkSettings"/>.
    /// Also resumes reconnecting after the <see cref="IWebSocketReconnectPolicy"/> gave up.
    /// </summary>
    public void Reconnect()
    {
        lock (_lock)
        {
            ThrowIfDisposed();

            _failedAttempts = 0;
            CloseOrSignal();
        }
    }

    /// <inheritdoc />
    public void Dispose()
    {
        WebSocketSubscription[] subscriptions;
        lock (_lock)
        {
            if (_disposed)
            {
                return;
            }

            subscriptions = _subscriptions;
            _disposed = true;

            try
            {
                // Fallback in case the graceful close does not complete.
                _disposeCancellationTokenSource.CancelAfter(_closeTimeout);
            }
            catch (ObjectDisposedException)
            {
                // Run loop already ended.
            }

            _subscriptions = [];
            _periodicSubscriptions.Clear();
            _idleTimer?.Dispose();
            _idleTimer = null;
            _connection?.Close();
        }

        Signal();

        foreach (var subscription in subscriptions)
        {
            subscription.Complete();
        }
    }

    internal void RemoveSubscription(WebSocketSubscription subscription)
    {
        lock (_lock)
        {
            var index = Array.IndexOf(_subscriptions, subscription);
            if (index < 0)
            {
                return;
            }

            var subscriptions = new WebSocketSubscription[_subscriptions.Length - 1];
            Array.Copy(_subscriptions, 0, subscriptions, 0, index);
            Array.Copy(_subscriptions, index + 1, subscriptions, index, subscriptions.Length - index);
            _subscriptions = subscriptions;

            foreach (var messageType in GetPeriodicMessageTypes(subscription))
            {
                var count = _periodicSubscriptions[messageType] - 1;
                if (count > 0)
                {
                    _periodicSubscriptions[messageType] = count;
                    continue;
                }

                _periodicSubscriptions.Remove(messageType);
                _connection?.Send(WebSocketMessageSerializer.Serialize(_periodicMessageTypes[messageType].Stop));
            }

            if (_subscriptions.Length == 0)
            {
                ScheduleIdleClose();
            }
        }
    }

    private static SessionMessageType GetMessageType<TMessage>()
        where TMessage : class, IOutboundWebSocketMessage, new()
        => new TMessage().MessageType
            ?? throw new ArgumentException($"{typeof(TMessage).Name} has no message type.", nameof(TMessage));

    private static SessionMessageType[] GetPeriodicMessageTypes(WebSocketSubscription subscription)
        => subscription.MessageType is { } messageType && _periodicMessageTypes.ContainsKey(messageType) ? [messageType] : [];

    private WebSocketSubscription AddSubscription(WebSocketSubscription subscription)
    {
        lock (_lock)
        {
            ThrowIfDisposed();

            var wasEmpty = _subscriptions.Length == 0;
            var subscriptions = new WebSocketSubscription[_subscriptions.Length + 1];
            _subscriptions.CopyTo(subscriptions, 0);
            subscriptions[subscriptions.Length - 1] = subscription;
            _subscriptions = subscriptions;

            _idleTimer?.Dispose();
            _idleTimer = null;

            foreach (var messageType in GetPeriodicMessageTypes(subscription))
            {
                _periodicSubscriptions.TryGetValue(messageType, out var count);
                _periodicSubscriptions[messageType] = count + 1;
                if (count == 0)
                {
                    _connection?.Send(CreateStartMessage(messageType));
                }
            }

            if ((wasEmpty || _stoppedReconnecting) && _connection is null)
            {
                _failedAttempts = 0;
                Signal();
            }
        }

        return subscription;
    }

    private byte[] CreateStartMessage(SessionMessageType messageType)
    {
        // Data is "$initialDelay,$interval" in milliseconds.
        var interval = (long)_options.PeriodicMessageInterval.TotalMilliseconds;
        return WebSocketMessageSerializer.Serialize(
            _periodicMessageTypes[messageType].Start,
            "0," + interval.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    /// Close the connection once it has been idle for <see cref="JellyfinWebSocketOptions.IdleTimeout"/>.
    /// Must be called while holding <see cref="_lock"/>.
    /// </summary>
    private void ScheduleIdleClose()
    {
        if (_connection is null || _options.IdleTimeout == Timeout.InfiniteTimeSpan)
        {
            return;
        }

        if (_options.IdleTimeout <= TimeSpan.Zero)
        {
            _connection.Close();
            return;
        }

        _idleTimer?.Dispose();
        _idleTimer = new Timer(
            _ =>
            {
                lock (_lock)
                {
                    if (_subscriptions.Length == 0)
                    {
                        _connection?.Close();
                    }
                }
            },
            null,
            _options.IdleTimeout,
            Timeout.InfiniteTimeSpan);
    }

    private async Task RunAsync()
    {
        var cancellationToken = _disposeCancellationTokenSource.Token;
        try
        {
            while (!IsDisposed())
            {
                TimeSpan delay;
                try
                {
                    delay = await ConnectOnceAsync(cancellationToken).ConfigureAwait(false);
                }
                catch (Exception ex) when (!cancellationToken.IsCancellationRequested)
                {
                    // Keep the client usable, wait for a new subscription or Reconnect().
                    ReportError(ex);
                    SetState(WebSocketConnectionState.Disconnected, null);
                    lock (_lock)
                    {
                        _stoppedReconnecting = true;
                    }

                    delay = Timeout.InfiniteTimeSpan;
                }

                await _signal.WaitAsync(delay, cancellationToken).ConfigureAwait(false);
            }
        }
        catch (Exception) when (cancellationToken.IsCancellationRequested)
        {
            // Disposed. A socket aborted by the dispose fallback can throw more than OperationCanceledException.
        }
        finally
        {
            SetState(WebSocketConnectionState.Disconnected, null);
            _disposeCancellationTokenSource.Dispose();
            _signal.Dispose();
        }
    }

    /// <summary>
    /// Connect when there are subscriptions and settings, and receive messages until the connection ends.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>How long to wait for a wake up before the next attempt.</returns>
    private async Task<TimeSpan> ConnectOnceAsync(CancellationToken cancellationToken)
    {
        WebSocketConnectionTarget? target;
        lock (_lock)
        {
            target = _subscriptions.Length == 0 ? null : WebSocketConnectionTarget.FromSettings(_settings);
            if (target is null)
            {
                // Wait for a new subscription or Reconnect().
                return Timeout.InfiniteTimeSpan;
            }

            _stoppedReconnecting = false;

            // Clear wake ups that happened before this connection attempt.
            ClearSignal();
        }

        var error = await RunConnectionAsync(target, cancellationToken).ConfigureAwait(false);
        if (error is null)
        {
            // Closed by the client, decide again whether to connect.
            SetState(WebSocketConnectionState.Disconnected, null);
            return TimeSpan.Zero;
        }

        TimeSpan? delay;
        lock (_lock)
        {
            _failedAttempts++;
            delay = _subscriptions.Length == 0 ? null : _options.ReconnectPolicy.GetReconnectDelay(_failedAttempts);
            _stoppedReconnecting = delay is null && _subscriptions.Length > 0;
        }

        SetState(WebSocketConnectionState.Disconnected, error);

        if (delay is null)
        {
            // Wait for a new subscription or Reconnect().
            return Timeout.InfiniteTimeSpan;
        }

        return delay.Value < TimeSpan.Zero
            ? TimeSpan.Zero
            : delay.Value > _maxReconnectDelay ? _maxReconnectDelay : delay.Value;
    }

    /// <summary>
    /// Connect and receive messages until the connection ends.
    /// </summary>
    /// <returns>The error that ended the connection, or <c>null</c> when the client closed it.</returns>
    private async Task<Exception?> RunConnectionAsync(WebSocketConnectionTarget target, CancellationToken cancellationToken)
    {
        SetState(WebSocketConnectionState.Connecting, null);

        WebSocket socket;
        try
        {
            socket = await _connect(target, cancellationToken).ConfigureAwait(false);
        }
        catch (Exception ex) when (!cancellationToken.IsCancellationRequested)
        {
            return ex;
        }

        using var connection = new WebSocketConnection(socket, target, _closeTimeout, cancellationToken);
        var uptime = Stopwatch.StartNew();
        try
        {
            bool closing;
            lock (_lock)
            {
                _connection = connection;

                // This connection answers wake ups while connecting, such as Reconnect().
                // The target check below catches settings changed in the meantime.
                ClearSignal();

                closing = _disposed || !target.Equals(WebSocketConnectionTarget.FromSettings(_settings));
                if (closing)
                {
                    connection.Close();
                }
                else
                {
                    foreach (var messageType in _periodicSubscriptions.Keys)
                    {
                        connection.Send(CreateStartMessage(messageType));
                    }

                    if (_subscriptions.Length == 0)
                    {
                        ScheduleIdleClose();
                    }
                }
            }

            if (!closing)
            {
                SetState(WebSocketConnectionState.Connected, null);
            }

            return await ReceiveAsync(connection).ConfigureAwait(false);
        }
        finally
        {
            ClearConnection(uptime.Elapsed >= _stableConnectionTime);
        }
    }

    private void ClearConnection(bool wasStable)
    {
        lock (_lock)
        {
            _connection = null;
            _idleTimer?.Dispose();
            _idleTimer = null;

            // Connections that drop right after opening keep backing off.
            if (wasStable)
            {
                _failedAttempts = 0;
            }
        }
    }

    /// <summary>
    /// Close the current connection, which makes the run loop connect again, or wake the run loop when there is none.
    /// Must be called while holding <see cref="_lock"/>.
    /// </summary>
    private void CloseOrSignal()
    {
        if (_connection is null)
        {
            Signal();
        }
        else
        {
            _connection.Close();
        }
    }

    /// <summary>
    /// Remove a pending wake up. Must be called while holding <see cref="_lock"/>.
    /// </summary>
    private void ClearSignal()
    {
        // Completes synchronously with a zero timeout. SemaphoreSlim.Wait is not supported in browsers.
        _ = _signal.WaitAsync(0, CancellationToken.None);
    }

    private bool IsDisposed()
    {
        lock (_lock)
        {
            return _disposed;
        }
    }

    private async Task<Exception?> ReceiveAsync(WebSocketConnection connection)
    {
        var buffer = new byte[ReceiveBufferSize];
        using var message = new MemoryStream();
        try
        {
            while (true)
            {
                var result = await connection.Socket
                    .ReceiveAsync(new ArraySegment<byte>(buffer), connection.CancellationToken)
                    .ConfigureAwait(false);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await connection.AcknowledgeCloseAsync().ConfigureAwait(false);
                    return connection.IsClosing
                        ? null
                        : new WebSocketException(
                            WebSocketError.ConnectionClosedPrematurely,
                            $"The server closed the connection: {result.CloseStatus} {result.CloseStatusDescription}");
                }

#pragma warning disable CA1849 // MemoryStream writes do not block.
                message.Write(buffer, 0, result.Count);
#pragma warning restore CA1849
                if (!result.EndOfMessage)
                {
                    continue;
                }

                if (result.MessageType == WebSocketMessageType.Text)
                {
                    HandleMessage(connection, new ReadOnlyMemory<byte>(message.GetBuffer(), 0, (int)message.Length));
                }

                message.SetLength(0);
            }
        }
        catch (Exception ex) when (!_disposeCancellationTokenSource.IsCancellationRequested)
        {
            return connection.IsClosing ? null : ex;
        }
    }

    private void HandleMessage(WebSocketConnection connection, ReadOnlyMemory<byte> payload)
    {
        IOutboundWebSocketMessage? message;
        try
        {
            message = WebSocketMessageSerializer.Deserialize(payload, IsReceived);
        }
        catch (Exception ex)
        {
            ReportError(ex);
            return;
        }

        if (message?.MessageType is not { } messageType)
        {
            // Message type added in a newer server version, or no subscription receives it.
            return;
        }

        if (message is ForceKeepAliveMessage forceKeepAlive)
        {
            // The server drops the connection after Data seconds without a keep alive, send one every half of that.
            var lostTimeout = forceKeepAlive.Data is > 0 ? forceKeepAlive.Data.Value : DefaultLostTimeoutSeconds;
            var interval = TimeSpan.FromSeconds(lostTimeout / 2.0);
            connection.StartKeepAlive(interval > _maxKeepAliveInterval ? _maxKeepAliveInterval : interval);
        }

        foreach (var subscription in Volatile.Read(ref _subscriptions))
        {
            if (!subscription.Receives(messageType))
            {
                continue;
            }

            var previous = EnterCallback();
            try
            {
                subscription.Handler(message);
            }
            catch (Exception ex)
            {
                ReportError(ex);
            }
            finally
            {
                _callbackClient = previous;
            }
        }
    }

    /// <summary>
    /// Whether a message type needs to be read, checked before the message is deserialized.
    /// </summary>
    private bool IsReceived(SessionMessageType messageType)
    {
        if (messageType == SessionMessageType.ForceKeepAlive)
        {
            // Starts the keep alive.
            return true;
        }

        foreach (var subscription in Volatile.Read(ref _subscriptions))
        {
            if (subscription.Receives(messageType))
            {
                return true;
            }
        }

        return false;
    }

    private void SetState(WebSocketConnectionState state, Exception? error)
    {
        lock (_lock)
        {
            if (_state == state && error is null)
            {
                return;
            }

            _state = state;
        }

        var previous = EnterCallback();
        try
        {
            StateChanged?.Invoke(this, new WebSocketStateChangedEventArgs(state, error));
        }
        catch (Exception ex)
        {
            ReportError(ex);
        }
        finally
        {
            _callbackClient = previous;
        }
    }

    private void ReportError(Exception exception)
    {
        var previous = EnterCallback();
        try
        {
            ErrorOccurred?.Invoke(this, new TypedEventArgs<Exception>(exception));
        }
        catch (Exception)
        {
            // Ignore errors from error handlers.
        }
        finally
        {
            _callbackClient = previous;
        }
    }

    /// <summary>
    /// Mark this thread as running a callback of this client, returning the previous mark to restore.
    /// </summary>
    private JellyfinWebSocketClient? EnterCallback()
    {
        var previous = _callbackClient;
        _callbackClient = this;
        return previous;
    }

    private static void ThrowIfNull(object? value, string paramName)
    {
#if NET8_0_OR_GREATER
        ArgumentNullException.ThrowIfNull(value, paramName);
#else
        if (value is null)
        {
            throw new ArgumentNullException(paramName);
        }
#endif
    }

    private void ThrowIfDisposed()
    {
#if NET8_0_OR_GREATER
        ObjectDisposedException.ThrowIf(_disposed, this);
#else
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(JellyfinWebSocketClient));
        }
#endif
    }

    private void Signal()
    {
        try
        {
            _signal.Release();
        }
        catch (SemaphoreFullException)
        {
            // Already signaled.
        }
        catch (ObjectDisposedException)
        {
            // Run loop ended.
        }
    }

    private async Task<WebSocket> ConnectClientWebSocketAsync(WebSocketConnectionTarget target, CancellationToken cancellationToken)
    {
        var socket = new ClientWebSocket();
        try
        {
            var uri = target.Uri;
            if (IsBrowser())
            {
                // Browsers do not allow setting headers on WebSocket requests.
                uri = new UriBuilder(uri) { Query = "ApiKey=" + Uri.EscapeDataString(target.AccessToken) }.Uri;
            }
            else
            {
                SetAuthorizationHeader(socket.Options, target.AuthorizationHeader);
            }

            _options.ConfigureWebSocket?.Invoke(socket.Options);
            await socket.ConnectAsync(uri, cancellationToken).ConfigureAwait(false);
            return socket;
        }
        catch
        {
            socket.Dispose();
            throw;
        }
    }

#if NET5_0_OR_GREATER
    [System.Runtime.Versioning.SupportedOSPlatformGuard("browser")]
    private static bool IsBrowser() => OperatingSystem.IsBrowser();

    [System.Runtime.Versioning.UnsupportedOSPlatform("browser")]
#else
    private static bool IsBrowser() => RuntimeInformation.IsOSPlatform(OSPlatform.Create("BROWSER"));

#endif
    private static void SetAuthorizationHeader(ClientWebSocketOptions options, string authorizationHeader)
        => options.SetRequestHeader("Authorization", authorizationHeader);
}
