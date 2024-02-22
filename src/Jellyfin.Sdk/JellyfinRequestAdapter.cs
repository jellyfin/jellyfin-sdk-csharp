using System.Net.Http;
using Jellyfin.Sdk.Internal;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Jellyfin.Sdk;

/// <summary>
/// Jellyfin request adapter.
/// </summary>
public class JellyfinRequestAdapter : HttpClientRequestAdapter
{
    private static JellyfinParseNodeFactory _jellyfinParseNodeFactory = new();

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
            parseNodeFactory: _jellyfinParseNodeFactory,
            httpClient: httpClient)
    {
        BaseUrl = jellyfinSdkSettings.ServerUrl;
    }
}
