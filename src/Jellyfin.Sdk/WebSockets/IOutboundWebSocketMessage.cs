using System;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// A WebSocket message sent from the server to the client.
/// </summary>
public interface IOutboundWebSocketMessage : IParsable
{
    /// <summary>
    /// Gets the message type, which selects the model the message is read into.
    /// </summary>
    SessionMessageType? MessageType { get; }

    /// <summary>
    /// Gets the id the server assigns to each message, or <c>null</c> when the message has none.
    /// </summary>
    Guid? MessageId { get; }
}
