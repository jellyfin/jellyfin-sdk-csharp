using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

namespace Jellyfin.Sdk;

/// <summary>
/// Jellyfin authentication provider.
/// </summary>
public class JellyfinAuthenticationProvider : IAuthenticationProvider
{
    private const string HeaderName = "Authorization";
    private readonly JellyfinSdkSettings _sdkSettings;

    /// <summary>
    /// Initializes a new instance of the <see cref="JellyfinAuthenticationProvider"/> class.
    /// </summary>
    /// <param name="sdkSettings">The Jellyfin sdk settings.</param>
    public JellyfinAuthenticationProvider(JellyfinSdkSettings sdkSettings)
    {
        _sdkSettings = sdkSettings;
    }

    /// <inheritdoc />
    public Task AuthenticateRequestAsync(
        RequestInformation request,
        Dictionary<string, object>? additionalAuthenticationContext = null,
        CancellationToken cancellationToken = default)
    {
        request.Headers.Add(HeaderName, _sdkSettings.GetAuthorizationHeader());
        return Task.CompletedTask;
    }
}
