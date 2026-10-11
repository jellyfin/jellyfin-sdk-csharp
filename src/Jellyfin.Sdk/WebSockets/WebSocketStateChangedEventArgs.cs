using System;

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// Event arguments for a WebSocket connection state change.
/// </summary>
public sealed class WebSocketStateChangedEventArgs : EventArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebSocketStateChangedEventArgs"/> class.
    /// </summary>
    /// <param name="state">The new connection state.</param>
    /// <param name="error">The error that caused the disconnect, if any.</param>
    public WebSocketStateChangedEventArgs(WebSocketConnectionState state, Exception? error)
    {
        State = state;
        Error = error;
    }

    /// <summary>
    /// Gets the new connection state.
    /// </summary>
    public WebSocketConnectionState State { get; }

    /// <summary>
    /// Gets the error that caused the connection to drop, if any.
    /// </summary>
    public Exception? Error { get; }
}
