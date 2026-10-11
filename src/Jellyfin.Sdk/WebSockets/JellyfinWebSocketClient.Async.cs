#if NET8_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using Jellyfin.Sdk.Generated.Models;

namespace Jellyfin.Sdk.WebSockets;

/// <content>
/// Async streams and async disposal.
/// </content>
public sealed partial class JellyfinWebSocketClient : IAsyncDisposable
{
    /// <summary>
    /// Subscribe to a message type as an async stream.
    /// </summary>
    /// <remarks>
    /// The subscription starts when enumeration starts and ends when enumeration stops.
    /// Messages are buffered until they are read, up to <see cref="JellyfinWebSocketOptions.StreamBufferCapacity"/>.
    /// The stream completes when the client is disposed.
    /// </remarks>
    /// <param name="cancellationToken">The cancellation token that stops the enumeration.</param>
    /// <typeparam name="TMessage">The message type, for example <see cref="LibraryChangedMessage"/>.</typeparam>
    /// <returns>The received messages.</returns>
    public IAsyncEnumerable<TMessage> SubscribeAsync<TMessage>(CancellationToken cancellationToken = default)
        where TMessage : class, IOutboundWebSocketMessage, new()
        => ReadMessagesAsync<TMessage>(GetMessageType<TMessage>(), cancellationToken);

    /// <summary>
    /// Subscribe to all messages, except keep alive messages, as an async stream.
    /// </summary>
    /// <remarks>
    /// The subscription starts when enumeration starts and ends when enumeration stops.
    /// Messages are buffered until they are read, up to <see cref="JellyfinWebSocketOptions.StreamBufferCapacity"/>.
    /// The stream completes when the client is disposed.
    /// </remarks>
    /// <param name="cancellationToken">The cancellation token that stops the enumeration.</param>
    /// <returns>The received messages.</returns>
    public IAsyncEnumerable<IOutboundWebSocketMessage> SubscribeAllAsync(CancellationToken cancellationToken = default)
        => ReadMessagesAsync<IOutboundWebSocketMessage>(null, cancellationToken);

    /// <summary>
    /// Close the connection and wait for it to end.
    /// </summary>
    /// <remarks>
    /// The connection is aborted when the server does not answer the close within 5 seconds.
    /// When called from a message handler or event of this client, it returns without waiting,
    /// because the connection cannot end until the handler returns.
    /// </remarks>
    /// <returns>A <see cref="ValueTask"/> that completes when the connection has ended.</returns>
    public async ValueTask DisposeAsync()
    {
        Dispose();
        if (_callbackClient != this)
        {
            await _runTask.ConfigureAwait(false);
        }
    }

    private async IAsyncEnumerable<TMessage> ReadMessagesAsync<TMessage>(
        SessionMessageType? messageType,
        [EnumeratorCancellation] CancellationToken cancellationToken)
        where TMessage : class, IOutboundWebSocketMessage
    {
        var channel = Channel.CreateBounded<IOutboundWebSocketMessage>(new BoundedChannelOptions(_options.StreamBufferCapacity)
        {
            FullMode = BoundedChannelFullMode.DropOldest,
            SingleReader = true
        });

        using var subscription = AddSubscription(new WebSocketSubscription(
            this,
            messageType,
            message => channel.Writer.TryWrite(message),
            () => channel.Writer.TryComplete()));

        await foreach (var message in channel.Reader.ReadAllAsync(cancellationToken).ConfigureAwait(false))
        {
            yield return (TMessage)message;
        }
    }
}
#endif
