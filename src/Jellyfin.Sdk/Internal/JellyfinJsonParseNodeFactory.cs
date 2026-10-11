using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;

namespace Jellyfin.Sdk.Internal;

internal sealed class JellyfinJsonParseNodeFactory : IParseNodeFactory
{
    public JellyfinJsonParseNodeFactory(KiotaJsonSerializationContext context)
    {
        Context = context;
    }

    public KiotaJsonSerializationContext Context { get; }

    /// <inheritdoc />
    public string ValidContentType => "application/json";

    /// <inheritdoc />
    public async Task<IParseNode> GetRootParseNodeAsync(string contentType, Stream content, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(contentType))
        {
            throw new ArgumentNullException(nameof(contentType));
        }

        if (!ValidContentType.Equals(contentType, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentOutOfRangeException(nameof(contentType), $"expected a {ValidContentType} content type");
        }

        _ = content ?? throw new ArgumentNullException(nameof(content));

        // Same as Kiota: parse into pooled buffers, then copy the root out so the document can be returned to the pool.
        using var document = await JsonDocument.ParseAsync(content, default, cancellationToken).ConfigureAwait(false);
        return new JellyfinJsonParseNode(document.RootElement.Clone(), Context);
    }
}
