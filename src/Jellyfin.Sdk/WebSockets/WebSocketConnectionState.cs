namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// The connection state of a <see cref="JellyfinWebSocketClient"/>.
/// </summary>
public enum WebSocketConnectionState
{
    /// <summary>
    /// There is no connection.
    /// </summary>
    Disconnected = 0,

    /// <summary>
    /// A connection attempt is in progress.
    /// </summary>
    Connecting = 1,

    /// <summary>
    /// The connection is open.
    /// </summary>
    Connected = 2
}
