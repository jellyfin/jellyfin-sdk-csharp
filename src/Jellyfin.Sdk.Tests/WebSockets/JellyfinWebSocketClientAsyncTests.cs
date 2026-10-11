using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.WebSockets;

namespace Jellyfin.Sdk.Tests.WebSockets;

public sealed class JellyfinWebSocketClientAsyncTests : IDisposable
{
    private static readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);

    private readonly FakeWebSocketServer _server = new();
    private readonly JellyfinSdkSettings _settings = new();

    public JellyfinWebSocketClientAsyncTests()
    {
        _settings.Initialize("Tests", "1.0.0", "Test Device", "test-device");
        _settings.SetServerUrl("http://localhost:8096");
        _settings.SetAccessToken("token");
    }

    [Fact]
    public async Task SubscribeAsync_ReceivesMessagesAndStopsWhenEnumerationEnds()
    {
        await using var client = CreateClient();
        var serverTask = Task.Run(async () =>
        {
            using var connection = await _server.AcceptAsync();
            Assert.Equal("""{"MessageType":"SessionsStart","Data":"0,1000"}""", await connection.ReceiveAsync());
            await connection.SendAsync("""{"MessageType":"Sessions","Data":[{"UserName":"first"}]}""");
            await connection.SendAsync("""{"MessageType":"Sessions","Data":[{"UserName":"second"}]}""");
            Assert.Equal("""{"MessageType":"SessionsStop"}""", await connection.ReceiveAsync());
            Assert.Null(await connection.ReceiveAsync());
        }, TestContext.Current.CancellationToken);

        var userNames = new List<string?>();
        await foreach (var message in client.SubscribeAsync<SessionsMessage>(TestContext.Current.CancellationToken))
        {
            userNames.Add(Assert.Single(message.Data!).UserName);
            if (userNames.Count == 2)
            {
                break;
            }
        }

        Assert.Equal(["first", "second"], userNames);
        await serverTask.WaitAsync(_timeout, TestContext.Current.CancellationToken);
    }

    [Fact]
    public async Task SubscribeAsync_Cancelled_Unsubscribes()
    {
        await using var client = CreateClient();
        using var cts = new CancellationTokenSource();
        var enumeration = Task.Run(async () =>
        {
            await foreach (var message in client.SubscribeAsync<SessionsMessage>(cts.Token))
            {
            }
        }, TestContext.Current.CancellationToken);

        using var connection = await _server.AcceptAsync();
        Assert.Equal("""{"MessageType":"SessionsStart","Data":"0,1000"}""", await connection.ReceiveAsync());

        await cts.CancelAsync();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(() => enumeration.WaitAsync(_timeout, TestContext.Current.CancellationToken));
        Assert.Equal("""{"MessageType":"SessionsStop"}""", await connection.ReceiveAsync());
    }

    [Fact]
    public async Task SubscribeAllAsync_CompletesWhenClientDisposed()
    {
        var client = CreateClient();
        var received = new List<IOutboundWebSocketMessage>();
        var enumeration = Task.Run(async () =>
        {
            await foreach (var message in client.SubscribeAllAsync(TestContext.Current.CancellationToken))
            {
                received.Add(message);
            }
        }, TestContext.Current.CancellationToken);

        using var connection = await _server.AcceptAsync();
        await connection.SendAsync("""{"MessageType":"KeepAlive"}""");
        await connection.SendAsync("""{"MessageType":"RestartRequired"}""");
        await WaitUntilAsync(() => received.Count == 1);

        // Answer the close.
        var closed = Task.Run(async () =>
        {
            while (await connection.ReceiveAsync() is not null)
            {
            }
        }, TestContext.Current.CancellationToken);

        await client.DisposeAsync();
        await closed.WaitAsync(_timeout, TestContext.Current.CancellationToken);

        await enumeration.WaitAsync(_timeout, TestContext.Current.CancellationToken);
        Assert.IsType<RestartRequiredMessage>(Assert.Single(received));
    }

    [Fact]
    public async Task DisposeAsync_WaitsForConnectionToClose()
    {
        var client = CreateClient();
        using var subscription = client.Subscribe<LibraryChangedMessage>(_ => { });
        using var connection = await _server.AcceptAsync();
        var closed = Task.Run(connection.ReceiveAsync);

        await client.DisposeAsync().AsTask().WaitAsync(_timeout, TestContext.Current.CancellationToken);

        Assert.Equal(WebSocketConnectionState.Disconnected, client.State);
        Assert.Null(await closed.WaitAsync(_timeout, TestContext.Current.CancellationToken));
    }

    [Fact]
    public async Task SubscribeAsync_AfterDispose_Throws()
    {
        var client = CreateClient();
        await client.DisposeAsync();

        await Assert.ThrowsAsync<ObjectDisposedException>(async () =>
        {
            await foreach (var message in client.SubscribeAsync<LibraryChangedMessage>(TestContext.Current.CancellationToken))
            {
            }
        });
    }

    [Fact]
    public async Task SubscribeAsync_FullBuffer_DropsOldestMessages()
    {
        await using var client = CreateClient(new JellyfinWebSocketOptions { IdleTimeout = TimeSpan.Zero, StreamBufferCapacity = 1 });
        var receivedCount = 0;
        using var counter = client.Subscribe<LibraryChangedMessage>(_ => Interlocked.Increment(ref receivedCount));
        await using var enumerator = client.SubscribeAsync<LibraryChangedMessage>(TestContext.Current.CancellationToken).GetAsyncEnumerator(TestContext.Current.CancellationToken);
        var first = enumerator.MoveNextAsync();

        using var connection = await _server.AcceptAsync();
        await connection.SendAsync("""{"MessageType":"LibraryChanged","Data":{"ItemsAdded":["1"]}}""");
        Assert.True(await first);
        Assert.Equal("1", Assert.Single(enumerator.Current.Data!.ItemsAdded!));

        // Both arrive while the reader is busy, the buffer keeps only the newest.
        await connection.SendAsync("""{"MessageType":"LibraryChanged","Data":{"ItemsAdded":["2"]}}""");
        await connection.SendAsync("""{"MessageType":"LibraryChanged","Data":{"ItemsAdded":["3"]}}""");
        await WaitUntilAsync(() => Volatile.Read(ref receivedCount) == 3);

        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal("3", Assert.Single(enumerator.Current.Data!.ItemsAdded!));
    }

    public void Dispose() => _server.Dispose();

    private JellyfinWebSocketClient CreateClient(JellyfinWebSocketOptions? options = null)
        => new(_settings, options ?? new JellyfinWebSocketOptions { IdleTimeout = TimeSpan.Zero }, _server.ConnectAsync);

    private static async Task WaitUntilAsync(Func<bool> condition)
    {
        using var cts = new CancellationTokenSource(_timeout);
        while (!condition())
        {
            await Task.Delay(10, cts.Token);
        }
    }
}
