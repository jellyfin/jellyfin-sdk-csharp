using System.Net.Http;
using System.Text.Json;
using Jellyfin.Sdk.Internal;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Serialization.Json;

namespace Jellyfin.Sdk;

/// <summary>
/// Jellyfin request adapter.
/// </summary>
public class JellyfinRequestAdapter : HttpClientRequestAdapter
{
    private static readonly JsonParseNodeFactory _jsonParseNodeFactory = new(
        new KiotaJsonSerializationContext(
            new JsonSerializerOptions(KiotaJsonSerializationContext.Default.Options)
            {
                Converters =
                {
                    new JsonNullableGuidConverter(),
                    new JsonGuidConverter()
                }
            }));

    private readonly JellyfinSdkSettings _jellyfinSdkSettings;

    /// <summary>
    /// Initializes a new instance of the <see cref="JellyfinRequestAdapter"/> class.
    /// </summary>
    /// <param name="authenticationProvider">The authentication provider.</param>
    /// <param name="jellyfinSdkSettings">The Jellyfin sdk settings.</param>
    /// <param name="httpClient">The native HTTP client.</param>
    public JellyfinRequestAdapter(
        IAuthenticationProvider authenticationProvider,
        JellyfinSdkSettings jellyfinSdkSettings,
        HttpClient? httpClient = null)
        : base(
            authenticationProvider,
            parseNodeFactory: _jsonParseNodeFactory,
            httpClient: httpClient)
    {
        _jellyfinSdkSettings = jellyfinSdkSettings;

        BaseUrl = _jellyfinSdkSettings.ServerUrl;
        _jellyfinSdkSettings.ServerUrlUpdated += OnServerUrlUpdated;
    }

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _jellyfinSdkSettings.ServerUrlUpdated -= OnServerUrlUpdated;
        }

        base.Dispose(disposing);
    }

    private void OnServerUrlUpdated(object? sender, TypedEventArgs<string?> e)
        => BaseUrl = e.Content;
}
