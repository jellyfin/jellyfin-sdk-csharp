using System.Net.WebSockets;
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.WebSockets;

namespace Jellyfin.Sdk.Tests.WebSockets;

public sealed class JellyfinWebSocketClientTests : IDisposable
{
    private static readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);

    private readonly FakeWebSocketServer _server = new();
    private readonly JellyfinSdkSettings _settings = new();

    public JellyfinWebSocketClientTests()
    {
        _settings.Initialize("Tests", "1.0.0", "Test Device", "test-device");
        _settings.SetServerUrl("http://localhost:8096");
        _settings.SetAccessToken("token");
    }

    [Fact]
    public async Task Subscribe_PeriodicMessage_SendsStartAndReceivesMessages()
    {
        using var client = CreateClient();
        var received = NewCompletionSource<SessionsMessage>();
        using var subscription = client.Subscribe<SessionsMessage>(received.SetResult);

        using var connection = await _server.AcceptAsync();
        Assert.Equal("""{"MessageType":"SessionsStart","Data":"0,1000"}""", await connection.ReceiveAsync());

        await connection.SendAsync("""
            {"MessageType":"Sessions","MessageId":"0f8fad5bd9cb469fa16570867728950e","Data":[{"Id":"abc","UserName":"guest"}]}
            """);

        var message = await received.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken);
        Assert.Equal(SessionMessageType.Sessions, message.MessageType);
        Assert.Equal(Guid.Parse("0f8fad5bd9cb469fa16570867728950e"), message.MessageId);
        Assert.Equal("guest", Assert.Single(message.Data!).UserName);
    }

    [Fact]
    public async Task Subscribe_OnlyReceivesSubscribedType()
    {
        using var client = CreateClient();
        var received = NewCompletionSource<LibraryChangedMessage>();
        using var subscription = client.Subscribe<LibraryChangedMessage>(received.SetResult);

        using var connection = await _server.AcceptAsync();
        await connection.SendAsync("""{"MessageType":"UserDataChanged","Data":{"UserId":"0f8fad5bd9cb469fa16570867728950e"}}""");
        await connection.SendAsync("""{"MessageType":"LibraryChanged","Data":{"ItemsAdded":["a","b"]}}""");

        var message = await received.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken);
        Assert.Equal(["a", "b"], message.Data!.ItemsAdded!);
    }

    [Fact]
    public async Task SubscribeAll_SendsNoStartMessagesAndSkipsKeepAlive()
    {
        using var client = CreateClient(new JellyfinWebSocketOptions { IdleTimeout = TimeSpan.Zero });
        var received = NewCompletionSource<IOutboundWebSocketMessage>();
        var subscription = client.SubscribeAll(m => received.TrySetResult(m));

        using var connection = await _server.AcceptAsync();
        await connection.SendAsync("""{"MessageType":"KeepAlive"}""");
        await connection.SendAsync("""{"MessageType":"RestartRequired"}""");
        Assert.IsType<RestartRequiredMessage>(await received.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken));

        subscription.Dispose();

        // The close is the first frame the client sends.
        Assert.Null(await connection.ReceiveAsync());
    }

    [Fact]
    public async Task SubscribeAll_ReceivesPeriodicMessagesStartedByTypedSubscription()
    {
        using var client = CreateClient();
        var received = NewCompletionSource<IOutboundWebSocketMessage>();
        using var all = client.SubscribeAll(m => received.TrySetResult(m));
        using var sessions = client.Subscribe<SessionsMessage>(_ => { });

        using var connection = await _server.AcceptAsync();
        Assert.Equal("""{"MessageType":"SessionsStart","Data":"0,1000"}""", await connection.ReceiveAsync());
        await connection.SendAsync("""{"MessageType":"Sessions","Data":[]}""");

        Assert.IsType<SessionsMessage>(await received.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken));
    }

    [Fact]
    public async Task Subscribe_SameTypeTwice_SendsStartAndStopOnce()
    {
        using var client = CreateClient(new JellyfinWebSocketOptions { IdleTimeout = TimeSpan.Zero });
        var first = client.Subscribe<SessionsMessage>(_ => { });
        using var connection = await _server.AcceptAsync();
        Assert.Equal("""{"MessageType":"SessionsStart","Data":"0,1000"}""", await connection.ReceiveAsync());

        var second = client.Subscribe<SessionsMessage>(_ => { });
        first.Dispose();
        second.Dispose();

        // The next message after the start is the stop, followed by the close.
        Assert.Equal("""{"MessageType":"SessionsStop"}""", await connection.ReceiveAsync());
        Assert.Null(await connection.ReceiveAsync());
    }

    [Fact]
    public async Task ForceKeepAlive_SendsKeepAlive()
    {
        using var client = CreateClient();
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        using var connection = await _server.AcceptAsync();
        await connection.SendAsync("""{"MessageType":"ForceKeepAlive","Data":60}""");

        Assert.Equal("""{"MessageType":"KeepAlive"}""", await connection.ReceiveAsync());
    }

    [Fact]
    public async Task ServerDisconnect_Reconnects()
    {
        using var client = CreateClient(new JellyfinWebSocketOptions
        {
            ReconnectPolicy = FixedDelay(TimeSpan.FromMilliseconds(10))
        });
        var disconnected = NewCompletionSource<Exception?>();
        client.StateChanged += (_, e) =>
        {
            if (e.State == WebSocketConnectionState.Disconnected)
            {
                disconnected.TrySetResult(e.Error);
            }
        };
        using var subscription = client.Subscribe<SessionsMessage>(_ => { });

        var first = await _server.AcceptAsync();
        Assert.Equal("""{"MessageType":"SessionsStart","Data":"0,1000"}""", await first.ReceiveAsync());
        first.Socket.Abort();
        first.Dispose();

        Assert.NotNull(await disconnected.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken));

        using var second = await _server.AcceptAsync();
        Assert.Equal("""{"MessageType":"SessionsStart","Data":"0,1000"}""", await second.ReceiveAsync());
    }

    [Fact]
    public async Task ServerClose_Reconnects()
    {
        using var client = CreateClient(new JellyfinWebSocketOptions
        {
            ReconnectPolicy = FixedDelay(TimeSpan.FromMilliseconds(10))
        });
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        using var first = await _server.AcceptAsync();
        await first.Socket.CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus.EndpointUnavailable, "restarting", CancellationToken.None);

        using var second = await _server.AcceptAsync();
        Assert.Equal(2, _server.Targets.Count);
    }

    [Fact]
    public async Task AccessTokenChange_ReconnectUsesNewToken()
    {
        using var client = CreateClient();
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        using var first = await _server.AcceptAsync();
        _settings.SetAccessToken("new-token");
        client.Reconnect();

        Assert.Null(await first.ReceiveAsync());
        using var second = await _server.AcceptAsync();

        var target = _server.Targets[^1];
        Assert.Equal("new-token", target.AccessToken);
        Assert.Equal("MediaBrowser Token=\"new-token\"", target.AuthorizationHeader);
    }

    [Fact]
    public async Task NoAccessToken_WaitsForReconnect()
    {
        _settings.SetAccessToken(null);
        using var client = CreateClient();
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        await Task.Delay(200, TestContext.Current.CancellationToken);
        Assert.Empty(_server.Targets);
        Assert.Equal(WebSocketConnectionState.Disconnected, client.State);

        _settings.SetAccessToken("token");
        client.Reconnect();
        using var connection = await _server.AcceptAsync();
    }

    [Fact]
    public async Task NoSubscriptions_DoesNotConnect()
    {
        using var client = CreateClient();

        await Task.Delay(200, TestContext.Current.CancellationToken);
        Assert.Empty(_server.Targets);
    }

    [Fact]
    public async Task ReconnectPolicyGivesUp_ReconnectResumes()
    {
        _server.RejectConnections = true;
        using var client = CreateClient(new JellyfinWebSocketOptions
        {
            ReconnectPolicy = new GiveUpAfterReconnectPolicy(2)
        });
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        await WaitUntilAsync(() => _server.Targets.Count == 2);
        await Task.Delay(200, TestContext.Current.CancellationToken);
        Assert.Equal(2, _server.Targets.Count);

        _server.RejectConnections = false;
        client.Reconnect();
        using var connection = await _server.AcceptAsync();
    }

    [Fact]
    public async Task InvalidMessage_RaisesErrorAndKeepsConnection()
    {
        using var client = CreateClient();
        var error = NewCompletionSource<Exception>();
        client.ErrorOccurred += (_, e) => error.TrySetResult(e.Content);
        var received = NewCompletionSource<LibraryChangedMessage>();
        using var subscription = client.Subscribe<LibraryChangedMessage>(received.SetResult);

        using var connection = await _server.AcceptAsync();
        await connection.SendAsync("not json");
        await connection.SendAsync("""{"MessageType":"SomeFutureMessage"}""");
        await connection.SendAsync("""{"MessageType":"LibraryChanged"}""");

        Assert.NotNull(await error.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken));
        await received.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken);
    }

    [Fact]
    public async Task HandlerException_RaisesError()
    {
        using var client = CreateClient();
        var error = NewCompletionSource<Exception>();
        client.ErrorOccurred += (_, e) => error.TrySetResult(e.Content);
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => throw new InvalidOperationException("handler"));

        using var connection = await _server.AcceptAsync();
        await connection.SendAsync("""{"MessageType":"LibraryChanged"}""");

        Assert.Equal("handler", (await error.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken)).Message);
    }

    [Fact]
    public async Task Dispose_ClosesConnection()
    {
        var client = CreateClient();
        client.Subscribe<LibraryChangedMessage>(_ => { });
        using var connection = await _server.AcceptAsync();

        client.Dispose();

        Assert.Null(await connection.ReceiveAsync());
        Assert.Throws<ObjectDisposedException>(() => client.Subscribe<LibraryChangedMessage>(_ => { }));
    }

    [Fact]
    public async Task ReconnectPolicyThrows_ReconnectResumes()
    {
        _server.RejectConnections = true;
        var client = CreateClient(new JellyfinWebSocketOptions { ReconnectPolicy = new ThrowingReconnectPolicy() });
        var error = NewCompletionSource<Exception>();
        client.ErrorOccurred += (_, e) => error.TrySetResult(e.Content);
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        Assert.IsType<InvalidOperationException>(await error.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken));
        Assert.Equal(WebSocketConnectionState.Disconnected, client.State);

        _server.RejectConnections = false;
        client.Reconnect();
        using var connection = await _server.AcceptAsync();

        client.Dispose();
    }

    [Fact]
    public async Task ReconnectPolicyNegativeDelay_ReconnectsImmediately()
    {
        using var client = CreateClient(new JellyfinWebSocketOptions { ReconnectPolicy = new NegativeDelayReconnectPolicy() });
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        var first = await _server.AcceptAsync();
        first.Socket.Abort();
        first.Dispose();

        using var second = await _server.AcceptAsync();
    }

    [Fact]
    public void ReconnectPolicies_RejectNegativeDelays()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new ExponentialReconnectPolicy(TimeSpan.FromSeconds(-1)));
    }

    [Fact]
    public async Task ConnectionDropsRightAfterOpening_BacksOff()
    {
        var policy = new RecordingReconnectPolicy();
        using var client = CreateClient(new JellyfinWebSocketOptions { ReconnectPolicy = policy });
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        for (var i = 0; i < 3; i++)
        {
            using var connection = await _server.AcceptAsync();
            connection.Socket.Abort();
        }

        await WaitUntilAsync(() => policy.Attempts.Count >= 3);
        Assert.Equal([1, 2, 3], policy.Attempts.Take(3));
    }

    [Fact]
    public async Task InfiniteIdleTimeout_KeepsConnectionOpen()
    {
        using var client = CreateClient(new JellyfinWebSocketOptions { IdleTimeout = Timeout.InfiniteTimeSpan });
        var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });
        using var connection = await _server.AcceptAsync();

        subscription.Dispose();

        var receive = connection.ReceiveAsync();
        Assert.NotSame(receive, await Task.WhenAny(receive, Task.Delay(300, TestContext.Current.CancellationToken)));
        Assert.Equal(WebSocketConnectionState.Connected, client.State);
    }

    [Fact]
    public void IdleTimeout_RejectsInvalidValues()
    {
        var options = new JellyfinWebSocketOptions();

        Assert.Throws<ArgumentOutOfRangeException>(() => options.IdleTimeout = TimeSpan.MaxValue);
        Assert.Throws<ArgumentOutOfRangeException>(() => options.IdleTimeout = TimeSpan.FromSeconds(-1));
        Assert.Throws<ArgumentNullException>(() => options.ReconnectPolicy = null!);
    }

    [Fact]
    public async Task AccessTokenClearedWhileConnecting_DoesNotReportConnected()
    {
        var connecting = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        var gate = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        using var client = new JellyfinWebSocketClient(_settings, null, async (target, cancellationToken) =>
        {
            connecting.TrySetResult();
            await gate.Task;
            return await _server.ConnectAsync(target, cancellationToken);
        });
        var states = new List<WebSocketConnectionState>();
        client.StateChanged += (_, e) =>
        {
            lock (states)
            {
                states.Add(e.State);
            }
        };
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        await connecting.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken);
        _settings.SetAccessToken(null);
        gate.SetResult();

        using var connection = await _server.AcceptAsync();
        Assert.Null(await connection.ReceiveAsync());
        lock (states)
        {
            Assert.DoesNotContain(WebSocketConnectionState.Connected, states);
        }
    }

    [Fact]
    public void Subscribe_NullHandler_NamesParameter()
    {
        using var client = CreateClient();

        Assert.Equal("handler", Assert.Throws<ArgumentNullException>(() => client.Subscribe<LibraryChangedMessage>(null!)).ParamName);
        Assert.Equal("handler", Assert.Throws<ArgumentNullException>(() => client.SubscribeAll(null!)).ParamName);
    }

    [Fact]
    public async Task SettingsChange_ConnectsOnReconnect()
    {
        var connector = new RejectingConnector();
        using var client = new JellyfinWebSocketClient(
            _settings,
            new JellyfinWebSocketOptions { ReconnectPolicy = FixedDelay(TimeSpan.FromHours(1)) },
            connector.ConnectAsync);
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });
        await WaitUntilAsync(() => connector.Targets.Count == 1);

        _settings.SetServerUrl("http://other:8096");
        _settings.SetAccessToken("new-token");
        await Task.Delay(200, TestContext.Current.CancellationToken);
        Assert.Single(connector.Targets);

        client.Reconnect();

        await WaitUntilAsync(() => connector.Targets.Count == 2);
        var target = connector.Targets[1];
        Assert.Equal("other", target.Uri.Host);
        Assert.Equal("new-token", target.AccessToken);
    }

    [Fact]
    public async Task ReconnectPolicyGivesUp_NewSubscriptionResumesConnecting()
    {
        _server.RejectConnections = true;
        using var client = CreateClient(new JellyfinWebSocketOptions
        {
            ReconnectPolicy = new GiveUpAfterReconnectPolicy(2)
        });
        using var first = client.Subscribe<LibraryChangedMessage>(_ => { });

        await WaitUntilAsync(() => _server.Targets.Count == 2);
        await Task.Delay(200, TestContext.Current.CancellationToken);
        Assert.Equal(2, _server.Targets.Count);

        _server.RejectConnections = false;
        using var second = client.Subscribe<SessionsMessage>(_ => { });

        using var connection = await _server.AcceptAsync();
    }

    [Fact]
    public async Task ForceKeepAlive_HugeData_KeepsConnection()
    {
        await using var client = CreateClient(new JellyfinWebSocketOptions
        {
            ReconnectPolicy = FixedDelay(TimeSpan.FromMilliseconds(10))
        });
        var disconnected = NewCompletionSource<Exception?>();
        client.StateChanged += (_, e) =>
        {
            if (e.State == WebSocketConnectionState.Disconnected)
            {
                disconnected.TrySetResult(e.Error);
            }
        };
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });

        using var connection = await _server.AcceptAsync();
        await connection.SendAsync("""{"MessageType":"ForceKeepAlive","Data":2147483647}""");

        Assert.Equal("""{"MessageType":"KeepAlive"}""", await connection.ReceiveAsync());
        var finished = await Task.WhenAny(disconnected.Task, Task.Delay(500, TestContext.Current.CancellationToken));
        Assert.NotSame(disconnected.Task, finished);
        Assert.Single(_server.Targets);
    }

    [Fact]
    public async Task DisposeAsync_BlockedOnFromHandler_DoesNotDeadlock()
    {
        var client = CreateClient();
        var completed = NewCompletionSource<bool>();
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ =>
            completed.TrySetResult(client.DisposeAsync().AsTask().Wait(TimeSpan.FromSeconds(3))));

        using var connection = await _server.AcceptAsync();
        await connection.SendAsync("""{"MessageType":"LibraryChanged"}""");

        Assert.True(await completed.Task.WaitAsync(_timeout, TestContext.Current.CancellationToken));
        Assert.Null(await connection.ReceiveAsync());
        await client.DisposeAsync().AsTask().WaitAsync(_timeout, TestContext.Current.CancellationToken);
    }

    [Fact]
    public async Task DisposeAsync_SocketThrowsAfterAbort_DoesNotThrow()
    {
        using var client = new JellyfinWebSocketClient(
            _settings,
            null,
            (_, _) => Task.FromResult<WebSocket>(new ThrowAfterAbortWebSocket()));
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });
        await WaitUntilAsync(() => client.State == WebSocketConnectionState.Connected);

        await client.DisposeAsync().AsTask().WaitAsync(_timeout, TestContext.Current.CancellationToken);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1000)]
    public void PeriodicMessageInterval_RejectsZeroAndNegative(int milliseconds)
    {
        var options = new JellyfinWebSocketOptions();

        Assert.Throws<ArgumentOutOfRangeException>(() => options.PeriodicMessageInterval = TimeSpan.FromMilliseconds(milliseconds));
    }

    public void Dispose() => _server.Dispose();

    private JellyfinWebSocketClient CreateClient(JellyfinWebSocketOptions? options = null)
        => new(_settings, options, _server.ConnectAsync);

    private static ExponentialReconnectPolicy FixedDelay(TimeSpan delay) => new(delay, delay);

    private static TaskCompletionSource<T> NewCompletionSource<T>()
        => new(TaskCreationOptions.RunContinuationsAsynchronously);

    private static async Task WaitUntilAsync(Func<bool> condition)
    {
        using var cts = new CancellationTokenSource(_timeout);
        while (!condition())
        {
            await Task.Delay(10, cts.Token);
        }
    }

    private sealed class GiveUpAfterReconnectPolicy(int attempts) : IWebSocketReconnectPolicy
    {
        public TimeSpan? GetReconnectDelay(int attempt) => attempt < attempts ? TimeSpan.FromMilliseconds(10) : null;
    }

    private sealed class ThrowingReconnectPolicy : IWebSocketReconnectPolicy
    {
        public TimeSpan? GetReconnectDelay(int attempt) => throw new InvalidOperationException("policy");
    }

    private sealed class NegativeDelayReconnectPolicy : IWebSocketReconnectPolicy
    {
        public TimeSpan? GetReconnectDelay(int attempt) => TimeSpan.FromSeconds(-5);
    }

    private sealed class RecordingReconnectPolicy : IWebSocketReconnectPolicy
    {
        private readonly List<int> _attempts = [];

        public IReadOnlyList<int> Attempts
        {
            get
            {
                lock (_attempts)
                {
                    return [.. _attempts];
                }
            }
        }

        public TimeSpan? GetReconnectDelay(int attempt)
        {
            lock (_attempts)
            {
                _attempts.Add(attempt);
            }

            return TimeSpan.FromMilliseconds(10);
        }
    }

    private sealed class RejectingConnector
    {
        private readonly List<WebSocketConnectionTarget> _targets = [];

        public IReadOnlyList<WebSocketConnectionTarget> Targets
        {
            get
            {
                lock (_targets)
                {
                    return [.. _targets];
                }
            }
        }

        public Task<WebSocket> ConnectAsync(WebSocketConnectionTarget target, CancellationToken cancellationToken)
        {
            lock (_targets)
            {
                _targets.Add(target);
            }

            throw new WebSocketException("Connection rejected");
        }
    }

    /// <summary>
    /// Waits for the abort, then throws a <see cref="WebSocketException"/> instead of an <see cref="OperationCanceledException"/>.
    /// </summary>
    private sealed class ThrowAfterAbortWebSocket : WebSocket
    {
        public override WebSocketCloseStatus? CloseStatus => null;

        public override string? CloseStatusDescription => null;

        public override string? SubProtocol => null;

        public override WebSocketState State => WebSocketState.Open;

        public override void Abort()
        {
        }

        public override Task CloseAsync(WebSocketCloseStatus closeStatus, string? statusDescription, CancellationToken cancellationToken)
            => Task.CompletedTask;

        public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string? statusDescription, CancellationToken cancellationToken)
            => Task.CompletedTask;

        public override void Dispose()
        {
        }

        public override async Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
        {
            try
            {
                await Task.Delay(Timeout.Infinite, cancellationToken);
            }
            catch (OperationCanceledException)
            {
            }

            await Task.Delay(300, CancellationToken.None);
            throw new WebSocketException(WebSocketError.ConnectionClosedPrematurely);
        }

        public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
            => Task.CompletedTask;
    }
}
