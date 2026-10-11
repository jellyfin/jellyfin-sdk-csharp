using System;

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// Grows the reconnect delay exponentially from <see cref="MinDelay"/> up to <see cref="MaxDelay"/>.
/// </summary>
public sealed class ExponentialReconnectPolicy : IWebSocketReconnectPolicy
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExponentialReconnectPolicy"/> class.
    /// </summary>
    /// <param name="minDelay">The first delay. Defaults to 1 second.</param>
    /// <param name="maxDelay">The maximum delay. Defaults to 5 minutes.</param>
    /// <param name="factor">The growth factor per attempt. Defaults to 1.5.</param>
    public ExponentialReconnectPolicy(TimeSpan? minDelay = null, TimeSpan? maxDelay = null, double factor = 1.5)
    {
        MinDelay = minDelay ?? TimeSpan.FromSeconds(1);
        MaxDelay = maxDelay ?? TimeSpan.FromMinutes(5);
        Factor = factor;

        if (MinDelay < TimeSpan.Zero)
        {
            throw new ArgumentOutOfRangeException(nameof(minDelay), "The minimum delay must not be negative.");
        }

        if (MaxDelay < MinDelay)
        {
            throw new ArgumentOutOfRangeException(nameof(maxDelay), "The maximum delay must not be less than the minimum delay.");
        }
    }

    /// <summary>
    /// Gets the first delay.
    /// </summary>
    public TimeSpan MinDelay { get; }

    /// <summary>
    /// Gets the longest delay, returned for every attempt once the growth passes it.
    /// </summary>
    public TimeSpan MaxDelay { get; }

    /// <summary>
    /// Gets the growth factor per attempt.
    /// </summary>
    public double Factor { get; }

    /// <inheritdoc />
    public TimeSpan? GetReconnectDelay(int attempt)
    {
        var ticks = MinDelay.Ticks * Math.Pow(Factor, Math.Max(attempt - 1, 0));
        return ticks >= MaxDelay.Ticks
            ? MaxDelay
            : TimeSpan.FromTicks(Math.Max((long)ticks, MinDelay.Ticks));
    }
}
