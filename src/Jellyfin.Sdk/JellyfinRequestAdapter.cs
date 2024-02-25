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
    private static readonly JellyfinParseNodeFactory _jellyfinParseNodeFactory = new();

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
            parseNodeFactory: _jellyfinParseNodeFactory,
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
