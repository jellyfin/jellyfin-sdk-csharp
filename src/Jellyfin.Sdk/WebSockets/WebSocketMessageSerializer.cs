using System;
using System.IO;
using System.Text.Json;
using Jellyfin.Sdk.Generated;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Serialization.Json;

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// Reads and writes WebSocket messages.
/// </summary>
internal static class WebSocketMessageSerializer
{
    private const string MessageTypeProperty = "MessageType";
    private const string DataProperty = "Data";

    /// <summary>
    /// Deserialize a message sent by the server.
    /// </summary>
    /// <param name="payload">The UTF-8 encoded JSON message.</param>
    /// <param name="filter">Returns whether a message type should be read, so skipped messages are not deserialized.</param>
    /// <returns>The message, or <c>null</c> when the message type is unknown or skipped.</returns>
    public static IOutboundWebSocketMessage? Deserialize(ReadOnlyMemory<byte> payload, Func<SessionMessageType, bool>? filter = null)
    {
        using var document = JsonDocument.Parse(payload);
        var messageType = new JsonParseNode(document.RootElement, JellyfinRequestAdapter.SerializationContext)
            .GetChildNode(MessageTypeProperty)?.GetEnumValue<SessionMessageType>();
        if (messageType is null || (filter is not null && !filter(messageType.Value)))
        {
            return null;
        }

        var factory = OutboundWebSocketMessageFactory.Get(messageType.Value);
        if (factory is null)
        {
            return null;
        }

        // Kiota reads untyped arrays in additional data lazily, so the message keeps a copy that outlives the document.
        return new JsonParseNode(document.RootElement.Clone(), JellyfinRequestAdapter.SerializationContext).GetObjectValue(factory);
    }

    /// <summary>
    /// Serialize a message to send to the server.
    /// </summary>
    /// <param name="messageType">The message type.</param>
    /// <param name="data">The optional message data.</param>
    /// <returns>The UTF-8 encoded JSON message.</returns>
    public static byte[] Serialize(string messageType, string? data = null)
    {
        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream))
        {
            writer.WriteStartObject();
            writer.WriteString(MessageTypeProperty, messageType);
            if (data is not null)
            {
                writer.WriteString(DataProperty, data);
            }

            writer.WriteEndObject();
        }

        return stream.ToArray();
    }
}
