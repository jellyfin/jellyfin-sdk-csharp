using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Channels;
using Jellyfin.Sdk.WebSockets;

namespace Jellyfin.Sdk.Tests.WebSockets;

/// <summary>
/// In-process WebSocket server connected to the client over loopback TCP.
/// </summary>
internal sealed class FakeWebSocketServer : IDisposable
{
    private static readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);

    private readonly TcpListener _listener = new(IPAddress.Loopback, 0);
    private readonly Channel<FakeServerConnection> _connections = Channel.CreateUnbounded<FakeServerConnection>();
    private readonly List<WebSocketConnectionTarget> _targets = [];

    public FakeWebSocketServer()
    {
        _listener.Start();
    }

    public bool RejectConnections { get; set; }

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

    public async Task<WebSocket> ConnectAsync(WebSocketConnectionTarget target, CancellationToken cancellationToken)
    {
        lock (_targets)
        {
            _targets.Add(target);
        }

        if (RejectConnections)
        {
            throw new WebSocketException("Connection rejected");
        }

        var client = new TcpClient();
        await client.ConnectAsync((IPEndPoint)_listener.LocalEndpoint, cancellationToken);
        var server = await _listener.AcceptTcpClientAsync(cancellationToken);

        var serverSocket = WebSocket.CreateFromStream(server.GetStream(), isServer: true, subProtocol: null, Timeout.InfiniteTimeSpan);
        _connections.Writer.TryWrite(new FakeServerConnection(serverSocket));

        return WebSocket.CreateFromStream(client.GetStream(), isServer: false, subProtocol: null, Timeout.InfiniteTimeSpan);
    }

    public async Task<FakeServerConnection> AcceptAsync()
    {
        using var cts = new CancellationTokenSource(_timeout);
        return await _connections.Reader.ReadAsync(cts.Token);
    }

    public void Dispose() => _listener.Dispose();
}

internal sealed class FakeServerConnection : IDisposable
{
    private static readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);

    public FakeServerConnection(WebSocket socket)
    {
        Socket = socket;
    }

    public WebSocket Socket { get; }

    /// <summary>
    /// Receive the next text message.
    /// </summary>
    /// <returns>The message, or <c>null</c> when the client closed the connection.</returns>
    public async Task<string?> ReceiveAsync()
    {
        using var cts = new CancellationTokenSource(_timeout);
        var buffer = new byte[4096];
        using var message = new MemoryStream();
        while (true)
        {
            var result = await Socket.ReceiveAsync(buffer, cts.Token);
            if (result.MessageType == WebSocketMessageType.Close)
            {
                await Socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, string.Empty, cts.Token);
                return null;
            }

            message.Write(buffer, 0, result.Count);
            if (result.EndOfMessage)
            {
                return Encoding.UTF8.GetString(message.ToArray());
            }
        }
    }

    public Task SendAsync(string message)
        => Socket.SendAsync(Encoding.UTF8.GetBytes(message), WebSocketMessageType.Text, true, CancellationToken.None);

    public void Dispose() => Socket.Dispose();
}
