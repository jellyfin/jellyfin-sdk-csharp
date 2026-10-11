using System;

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// Decides how long to wait before reconnecting after the WebSocket connection drops.
/// </summary>
public interface IWebSocketReconnectPolicy
{
    /// <summary>
    /// Get the delay before the next reconnect attempt.
    /// </summary>
    /// <param name="attempt">The number of consecutive failed connections, starting at 1.</param>
    /// <returns>The delay, or <c>null</c> to stop reconnecting.</returns>
    TimeSpan? GetReconnectDelay(int attempt);
}
