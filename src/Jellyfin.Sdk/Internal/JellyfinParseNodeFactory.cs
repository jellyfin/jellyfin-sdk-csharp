using System;
using System.IO;
using System.Text.Json;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Jellyfin.Sdk.Internal;

/// <summary>
/// Jellyfin parse node factory.
/// </summary>
internal sealed class JellyfinParseNodeFactory : IParseNodeFactory
{
    /// <inheritdoc />
    public string ValidContentType => "application/json";

    /// <inheritdoc />
    public IParseNode GetRootParseNode(string contentType, Stream? content)
    {
#if NET8_0_OR_GREATER
        ArgumentException.ThrowIfNullOrEmpty(contentType);
        ArgumentNullException.ThrowIfNull(content);
#else
        if (string.IsNullOrEmpty(contentType))
        {
            throw new ArgumentNullException(nameof(contentType));
        }

        if (content is null)
        {
            throw new ArgumentNullException(nameof(content));
        }
#endif

        if (!string.Equals(ValidContentType, contentType, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentOutOfRangeException($"expected a {ValidContentType} content type");
        }

        using var jsonDocument = JsonDocument.Parse(content);
        return new JellyfinJsonParseNode(jsonDocument.RootElement.Clone());
    }
}
