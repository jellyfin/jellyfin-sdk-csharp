using System;

namespace Jellyfin.Sdk.WebSockets;

/// <summary>
/// The server address and credentials used for a WebSocket connection.
/// </summary>
internal sealed class WebSocketConnectionTarget : IEquatable<WebSocketConnectionTarget>
{
    public WebSocketConnectionTarget(Uri uri, string accessToken, string authorizationHeader)
    {
        Uri = uri;
        AccessToken = accessToken;
        AuthorizationHeader = authorizationHeader;
    }

    public Uri Uri { get; }

    public string AccessToken { get; }

    public string AuthorizationHeader { get; }

    /// <summary>
    /// Create the connection target from the sdk settings.
    /// </summary>
    /// <param name="settings">The sdk settings.</param>
    /// <returns>The target, or <c>null</c> when the server url or access token is missing.</returns>
    public static WebSocketConnectionTarget? FromSettings(JellyfinSdkSettings settings)
    {
        var serverUrl = settings.ServerUrl;
        var accessToken = settings.AccessToken;
        if (string.IsNullOrEmpty(serverUrl)
            || string.IsNullOrEmpty(accessToken)
            || !Uri.TryCreate(serverUrl!.TrimEnd('/') + "/socket", UriKind.Absolute, out var uri))
        {
            return null;
        }

        var builder = new UriBuilder(uri);
        if (string.Equals(uri.Scheme, Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase))
        {
            builder.Scheme = "wss";
        }
        else if (string.Equals(uri.Scheme, Uri.UriSchemeHttp, StringComparison.OrdinalIgnoreCase))
        {
            builder.Scheme = "ws";
        }

        return new WebSocketConnectionTarget(builder.Uri, accessToken!, settings.GetAuthorizationHeader());
    }

    public bool Equals(WebSocketConnectionTarget? other)
        => other is not null
           && Uri.Equals(other.Uri)
           && string.Equals(AccessToken, other.AccessToken, StringComparison.Ordinal)
           && string.Equals(AuthorizationHeader, other.AuthorizationHeader, StringComparison.Ordinal);

    public override bool Equals(object? obj) => Equals(obj as WebSocketConnectionTarget);

    public override int GetHashCode() => Uri.GetHashCode() ^ StringComparer.Ordinal.GetHashCode(AccessToken);
}
