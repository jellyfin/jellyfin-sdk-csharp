using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;

namespace Jellyfin.Sdk.Benchmarks;

internal static class Fixture
{
    /// <summary>
    /// Gets Fixtures/*.json, plus the *.json files in JELLYFIN_SDK_FIXTURES when set, such as responses captured from a real server.
    /// </summary>
    public static IEnumerable<string> Files
    {
        get
        {
            var builtIn = Directory.EnumerateFiles(Path.Combine(AppContext.BaseDirectory, "Fixtures"), "*.json");
            var extra = Environment.GetEnvironmentVariable("JELLYFIN_SDK_FIXTURES") is { Length: > 0 } dir
                ? Directory.EnumerateFiles(dir, "*.json")
                : [];
            return builtIn.Concat(extra).Order(StringComparer.Ordinal);
        }
    }

    /// <summary>
    /// Parse item-*.json as a BaseItemDto and any other file as a BaseItemDtoQueryResult.
    /// </summary>
    public static async Task<IParsable> ParseAsync(IParseNodeFactory factory, string path, byte[] content)
    {
        using var stream = new MemoryStream(content, writable: false);
        var node = await factory.GetRootParseNodeAsync("application/json", stream).ConfigureAwait(false);
        return Path.GetFileName(path).StartsWith("item-", StringComparison.Ordinal)
            ? node.GetObjectValue(BaseItemDto.CreateFromDiscriminatorValue)
            : node.GetObjectValue(BaseItemDtoQueryResult.CreateFromDiscriminatorValue);
    }

    /// <summary>
    /// Serialize a model back to JSON with Kiota's writer, to compare two parses.
    /// </summary>
    public static string Serialize(IParsable model)
    {
        using var writer = new JsonSerializationWriter();
        writer.WriteObjectValue(null, model);
        using var reader = new StreamReader(writer.GetSerializedContent());
        return reader.ReadToEnd();
    }
}
