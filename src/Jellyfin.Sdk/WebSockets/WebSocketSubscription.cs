using System;
using System.Threading;
using Jellyfin.Sdk.Generated.Models;

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// A message handler registered with <see cref="JellyfinWebSocketClient"/>. Disposing it removes the handler.
/// </summary>
internal sealed class WebSocketSubscription : IDisposable
{
    private readonly JellyfinWebSocketClient _client;
    private readonly Action? _completed;
    private int _disposed;

    public WebSocketSubscription(
        JellyfinWebSocketClient client,
        SessionMessageType? messageType,
        Action<IOutboundWebSocketMessage> handler,
        Action? completed = null)
    {
        _client = client;
        _completed = completed;
        MessageType = messageType;
        Handler = handler;
    }

    /// <summary>
    /// Gets the message type to receive, or <c>null</c> for all messages.
    /// </summary>
    public SessionMessageType? MessageType { get; }

    public Action<IOutboundWebSocketMessage> Handler { get; }

    public bool IsDisposed => Volatile.Read(ref _disposed) == 1;

    /// <summary>
    /// Whether the subscription receives a message type. Subscriptions to all messages skip keep alive messages.
    /// </summary>
    /// <param name="messageType">The message type.</param>
    /// <returns><c>true</c> when the handler should be called.</returns>
    public bool Receives(SessionMessageType messageType)
        => !IsDisposed
           && (MessageType is null
               ? messageType is not (SessionMessageType.KeepAlive or SessionMessageType.ForceKeepAlive)
               : MessageType == messageType);

    /// <summary>
    /// Notify the subscription that no more messages will arrive because the client was disposed.
    /// </summary>
    public void Complete() => _completed?.Invoke();

    public void Dispose()
    {
        if (Interlocked.Exchange(ref _disposed, 1) == 0)
        {
            _client.RemoveSubscription(this);
        }
    }
}
