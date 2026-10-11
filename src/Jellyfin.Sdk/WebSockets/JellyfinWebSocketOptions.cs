using System;
using System.Net.WebSockets;
using System.Threading;

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// Options for <see cref="JellyfinWebSocketClient"/>.
/// </summary>
public sealed class JellyfinWebSocketOptions
{
    // The longest due time System.Threading.Timer accepts.
    private static readonly TimeSpan _maxIdleTimeout = TimeSpan.FromMilliseconds(uint.MaxValue - 1);

    private IWebSocketReconnectPolicy _reconnectPolicy = new ExponentialReconnectPolicy();
    private TimeSpan _periodicMessageInterval = TimeSpan.FromSeconds(1);
    private TimeSpan _idleTimeout = TimeSpan.FromSeconds(5);
#if NET8_0_OR_GREATER
    private int _streamBufferCapacity = 1000;
#endif

    /// <summary>
    /// Gets or sets the policy used to reconnect after the connection drops.
    /// </summary>
    public IWebSocketReconnectPolicy ReconnectPolicy
    {
        get => _reconnectPolicy;
        set => _reconnectPolicy = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>
    /// Gets or sets the shortest interval between periodic messages (sessions, activity log entries and scheduled tasks).
    /// The server sends them when the data changes, at most once per interval. Must be positive.
    /// </summary>
    public TimeSpan PeriodicMessageInterval
    {
        get => _periodicMessageInterval;
        set
        {
            if (value <= TimeSpan.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "The periodic message interval must be positive.");
            }

            _periodicMessageInterval = value;
        }
    }

    /// <summary>
    /// Gets or sets how long the connection stays open after the last subscription is disposed.
    /// <see cref="TimeSpan.Zero"/> closes it immediately and <see cref="Timeout.InfiniteTimeSpan"/> keeps it open.
    /// </summary>
    public TimeSpan IdleTimeout
    {
        get => _idleTimeout;
        set
        {
            if (value != Timeout.InfiniteTimeSpan && (value < TimeSpan.Zero || value > _maxIdleTimeout))
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "The idle timeout must be zero, positive and at most 49 days, or infinite.");
            }

            _idleTimeout = value;
        }
    }

#if NET8_0_OR_GREATER
    /// <summary>
    /// Gets or sets how many unread messages an async stream from
    /// <see cref="JellyfinWebSocketClient.SubscribeAsync{TMessage}"/> or <see cref="JellyfinWebSocketClient.SubscribeAllAsync"/>
    /// buffers. When the buffer is full the oldest message is dropped.
    /// </summary>
    public int StreamBufferCapacity
    {
        get => _streamBufferCapacity;
        set
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "The stream buffer capacity must be at least 1.");
            }

            _streamBufferCapacity = value;
        }
    }
#endif

    /// <summary>
    /// Gets or sets a callback to configure the underlying <see cref="ClientWebSocket"/>,
    /// for example to set a proxy, client certificates or extra headers.
    /// </summary>
    public Action<ClientWebSocketOptions>? ConfigureWebSocket { get; set; }
}
