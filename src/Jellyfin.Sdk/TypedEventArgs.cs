using System;

namespace Jellyfin.Sdk;

/// <summary>
/// EventArgs with typed content.
/// </summary>
/// <typeparam name="T">The type of content.</typeparam>
public sealed class TypedEventArgs<T> : EventArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TypedEventArgs{T}"/> class.
    /// </summary>
    /// <param name="content">The content.</param>
    public TypedEventArgs(T content)
    {
        Content = content;
    }

    /// <summary>
    /// Gets the content.
    /// </summary>
    public T Content { get; }
}
