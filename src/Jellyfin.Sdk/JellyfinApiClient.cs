using Jellyfin.Sdk.Generated;
using Microsoft.Kiota.Abstractions;

namespace Jellyfin.Sdk;

/// <summary>
/// The Jellyfin api client.
/// </summary>
public class JellyfinApiClient : BaseJellyfinApiClient
{
    private readonly JellyfinSdkSettings _jellyfinSdkSettings;

    /// <summary>
    /// Initializes a new instance of the <see cref="JellyfinApiClient"/> class.
    /// </summary>
    /// <param name="requestAdapter">The request adapter.</param>
    /// <param name="jellyfinSdkSettings">The Jellyfin sdk settings.</param>
    public JellyfinApiClient(IRequestAdapter requestAdapter, JellyfinSdkSettings jellyfinSdkSettings)
        : base(requestAdapter)
    {
        _jellyfinSdkSettings = jellyfinSdkSettings;
    }

    /// <summary>
    /// Update the current api client.
    /// </summary>
    /// <remarks>
    /// Only required if changing the server address.
    /// </remarks>
    public void Update()
        => RequestAdapter.BaseUrl = _jellyfinSdkSettings.ServerUrl;
}
