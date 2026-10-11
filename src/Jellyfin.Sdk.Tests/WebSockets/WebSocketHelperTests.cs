using System.Net.WebSockets;
using System.Text;
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.WebSockets;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Jellyfin.Sdk.Tests.WebSockets;

public class WebSocketHelperTests
{
    [Theory]
    [InlineData("https://demo.jellyfin.org/stable", "wss://demo.jellyfin.org/stable/socket")]
    [InlineData("https://demo.jellyfin.org/stable/", "wss://demo.jellyfin.org/stable/socket")]
    [InlineData("http://192.168.1.2:8096", "ws://192.168.1.2:8096/socket")]
    public void ConnectionTarget_BuildsSocketUri(string serverUrl, string expected)
    {
        var settings = new JellyfinSdkSettings();
        settings.SetServerUrl(serverUrl);
        settings.SetAccessToken("token");

        var target = WebSocketConnectionTarget.FromSettings(settings);

        Assert.Equal(new Uri(expected), target!.Uri);
        Assert.Equal("MediaBrowser Token=\"token\"", target.AuthorizationHeader);
    }

    [Theory]
    [InlineData(null, "token")]
    [InlineData("https://demo.jellyfin.org", null)]
    [InlineData("not a url", "token")]
    public void ConnectionTarget_MissingSettings_ReturnsNull(string? serverUrl, string? accessToken)
    {
        var settings = new JellyfinSdkSettings();
        settings.SetServerUrl(serverUrl);
        settings.SetAccessToken(accessToken);

        Assert.Null(WebSocketConnectionTarget.FromSettings(settings));
    }

    [Fact]
    public void ExponentialReconnectPolicy_GrowsUntilMaxDelay()
    {
        var policy = new ExponentialReconnectPolicy(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(5), 2);

        Assert.Equal(
            [1, 2, 4, 5, 5],
            Enumerable.Range(1, 5).Select(attempt => policy.GetReconnectDelay(attempt)!.Value.TotalSeconds));
    }

    [Fact]
    public void Serializer_DeserializesEveryOutboundMessageType()
    {
        var messageTypes = typeof(OutboundWebSocketMessage).GetProperties()
            .Select(p => p.PropertyType)
            .Where(t => typeof(IOutboundWebSocketMessage).IsAssignableFrom(t))
            .ToList();

        Assert.NotEmpty(messageTypes);
        foreach (var type in messageTypes)
        {
            var messageType = ((IOutboundWebSocketMessage)Activator.CreateInstance(type)!).MessageType;
            var json = Encoding.UTF8.GetBytes($$"""{"MessageType":"{{messageType}}"}""");

            Assert.IsType(type, WebSocketMessageSerializer.Deserialize(json));
        }
    }

    [Fact]
    public void Serializer_UnknownMessageType_ReturnsNull()
    {
        Assert.Null(WebSocketMessageSerializer.Deserialize("""{"MessageType":"SomeFutureMessage"}"""u8.ToArray()));
        Assert.Null(WebSocketMessageSerializer.Deserialize("""{"Data":1}"""u8.ToArray()));
    }

    [Fact]
    public void Serializer_FilteredMessageType_ReturnsNull()
    {
        var json = """{"MessageType":"LibraryChanged","Data":{"ItemsAdded":["a"]}}"""u8.ToArray();

        Assert.Null(WebSocketMessageSerializer.Deserialize(json, messageType => messageType != SessionMessageType.LibraryChanged));
        Assert.IsType<LibraryChangedMessage>(WebSocketMessageSerializer.Deserialize(json, _ => true));
    }

    [Fact]
    public void Serializer_DeserializesGuidData()
    {
        var message = WebSocketMessageSerializer.Deserialize(
            """{"MessageType":"UserDeleted","Data":"0f8fad5bd9cb469fa16570867728950e"}"""u8.ToArray());

        Assert.Equal(Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"), Assert.IsType<UserDeletedMessage>(message).Data);
    }

    [Fact]
    public void Serializer_AdditionalDataArray_SurvivesPayloadReuse()
    {
        var payload = Encoding.UTF8.GetBytes(
            """{"MessageType":"Sessions","Data":[{"NowPlayingItem":{"ProviderIds":{"Unknown":[1,2,3]}}}]}""");

        var message = Assert.IsType<SessionsMessage>(WebSocketMessageSerializer.Deserialize(payload));
        Array.Fill(payload, (byte)'x');

        var providerIds = message.Data![0].NowPlayingItem!.ProviderIds!;
        Assert.Equal(3, Assert.IsType<UntypedArray>(providerIds.AdditionalData["Unknown"]).GetValue().Count());
    }

    [Fact]
    public async Task Connection_AcknowledgeCloseWithStuckSend_AbortsAfterCloseTimeout()
    {
        var target = new WebSocketConnectionTarget(new Uri("ws://localhost/socket"), "token", "MediaBrowser Token=\"token\"");
        using var connection = new WebSocketConnection(new StuckSendWebSocket(), target, TimeSpan.FromMilliseconds(100), CancellationToken.None);
        connection.Send([1]);

        await connection.AcknowledgeCloseAsync().WaitAsync(TimeSpan.FromSeconds(5), TestContext.Current.CancellationToken);
        Assert.True(connection.CancellationToken.IsCancellationRequested);
    }

    /// <summary>
    /// A socket whose peer sent a close frame and stopped reading, so sends never finish.
    /// </summary>
    private sealed class StuckSendWebSocket : WebSocket
    {
        public override WebSocketCloseStatus? CloseStatus => WebSocketCloseStatus.NormalClosure;

        public override string? CloseStatusDescription => null;

        public override string? SubProtocol => null;

        public override WebSocketState State => WebSocketState.CloseReceived;

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

        public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
            => throw new NotSupportedException();

        public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
            => Task.Delay(Timeout.Infinite, cancellationToken);
    }
}
