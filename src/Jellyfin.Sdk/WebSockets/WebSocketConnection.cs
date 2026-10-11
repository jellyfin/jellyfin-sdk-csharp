using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Sdk.Generated.Models;

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// A single open WebSocket connection. Outgoing messages are sent one at a time, in the order they were queued.
/// </summary>
internal sealed class WebSocketConnection : IDisposable
{
    private static readonly byte[] _keepAlivePayload = WebSocketMessageSerializer.Serialize(nameof(SessionMessageType.KeepAlive));

    private readonly object _sendLock = new();
    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly TimeSpan _closeTimeout;
    private Task _sendQueue = Task.CompletedTask;
    private Timer? _keepAliveTimer;
    private int _closing;

    public WebSocketConnection(
        WebSocket socket,
        WebSocketConnectionTarget target,
        TimeSpan closeTimeout,
        CancellationToken cancellationToken)
    {
        Socket = socket;
        Target = target;
        _closeTimeout = closeTimeout;
        _cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        CancellationToken = _cancellationTokenSource.Token;
    }

    public WebSocket Socket { get; }

    public WebSocketConnectionTarget Target { get; }

    /// <summary>
    /// Gets the token cancelled when the connection is aborted.
    /// </summary>
    public CancellationToken CancellationToken { get; }

    /// <summary>
    /// Gets a value indicating whether the client asked to close this connection.
    /// </summary>
    public bool IsClosing => Volatile.Read(ref _closing) == 1;

    /// <summary>
    /// Queue a text message.
    /// </summary>
    /// <param name="payload">The UTF-8 encoded message.</param>
    public void Send(byte[] payload)
        => Enqueue(cancellationToken => Socket.SendAsync(
            new ArraySegment<byte>(payload),
            WebSocketMessageType.Text,
            true,
            cancellationToken));

    /// <summary>
    /// Send a keep alive message now and then at every interval.
    /// </summary>
    /// <param name="interval">The keep alive interval.</param>
    public void StartKeepAlive(TimeSpan interval)
    {
        lock (_sendLock)
        {
            if (IsClosing)
            {
                return;
            }

            _keepAliveTimer?.Dispose();
            _keepAliveTimer = new Timer(_ => Send(_keepAlivePayload), null, TimeSpan.Zero, interval);
        }
    }

    /// <summary>
    /// Start a graceful close. The connection is aborted when the server does not answer in time.
    /// </summary>
    public void Close()
    {
        if (Interlocked.Exchange(ref _closing, 1) == 1)
        {
            return;
        }

        StopKeepAlive();
        Enqueue(cancellationToken => Socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, string.Empty, cancellationToken));
        AbortAfterCloseTimeout();
    }

    /// <summary>
    /// Answer a close frame sent by the server. The connection is aborted when queued sends do not finish in time.
    /// </summary>
    /// <returns>A <see cref="Task"/> that completes when the close frame was sent.</returns>
    public Task AcknowledgeCloseAsync()
    {
        StopKeepAlive();
        if (Socket.State == WebSocketState.CloseReceived)
        {
            Enqueue(cancellationToken => Socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, string.Empty, cancellationToken));
        }

        AbortAfterCloseTimeout();
        lock (_sendLock)
        {
            return _sendQueue;
        }
    }

    public void Dispose()
    {
        StopKeepAlive();
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource.Dispose();
        Socket.Dispose();
    }

    private void AbortAfterCloseTimeout()
    {
        try
        {
            _cancellationTokenSource.CancelAfter(_closeTimeout);
        }
        catch (ObjectDisposedException)
        {
            // Connection already ended.
        }
    }

    private void StopKeepAlive()
    {
        lock (_sendLock)
        {
            _keepAliveTimer?.Dispose();
            _keepAliveTimer = null;
        }
    }

    private void Enqueue(Func<CancellationToken, Task> operation)
    {
        lock (_sendLock)
        {
            _sendQueue = RunAfterAsync(_sendQueue, operation);
        }
    }

    private async Task RunAfterAsync(Task previous, Func<CancellationToken, Task> operation)
    {
        await previous.ConfigureAwait(false);
        if (CancellationToken.IsCancellationRequested)
        {
            return;
        }

        try
        {
            await operation(CancellationToken).ConfigureAwait(false);
        }
        catch (Exception)
        {
            // Send failures end the connection, which the receive loop reports.
        }
    }
}
