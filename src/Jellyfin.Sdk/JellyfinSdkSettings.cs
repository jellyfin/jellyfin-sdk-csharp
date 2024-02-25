using System;
using System.Text;
using System.Text.Encodings.Web;

namespace Jellyfin.Sdk;

/// <summary>
/// The sdk client settings.
/// </summary>
public class JellyfinSdkSettings
{
    private const string AuthScheme = "MediaBrowser";

    private string? _authHeader;
    private string? _authTokenHeader;

    /// <summary>
    /// The event that fires when the server url is updated.
    /// </summary>
    public event EventHandler<TypedEventArgs<string?>>? ServerUrlUpdated;

    /// <summary>
    /// Gets the Jellyfin server's base url.
    /// </summary>
    /// <example>
    /// https://demo.jellyfin.org/stable.
    /// </example>
    public string? ServerUrl { get; private set; }

    /// <summary>
    /// Gets the user's access token.
    /// </summary>
    public string? AccessToken { get; private set; }

    /// <summary>
    /// Get the authorization header.
    /// </summary>
    /// <returns>The authorization header.</returns>
    /// <exception cref="InvalidOperationException">Setting not initialized.</exception>
    public string GetAuthorizationHeader()
    {
        if (!string.IsNullOrEmpty(_authTokenHeader))
        {
            return _authTokenHeader!;
        }

        if (!string.IsNullOrEmpty(_authHeader))
        {
            return _authHeader!;
        }

        throw new InvalidOperationException("Settings not initialized");
    }

    /// <summary>
    /// Initializes the client settings.
    /// </summary>
    /// <param name="clientName">The client name.</param>
    /// <param name="clientVersion">The client version.</param>
    /// <param name="deviceName">The device name.</param>
    /// <param name="deviceId">The device id.</param>
    public void Initialize(
        string clientName,
        string clientVersion,
        string deviceName,
        string deviceId)
    {
        var builder = new StringBuilder();

        builder.Append(AuthScheme);

        if (!string.IsNullOrEmpty(clientName))
        {
            builder.Append(" Client=\"")
                .Append(UrlEncoder.Default.Encode(clientName))
                .Append("\",");
        }

        if (!string.IsNullOrEmpty(clientVersion))
        {
            builder.Append(" Version=\"")
                .Append(UrlEncoder.Default.Encode(clientVersion))
                .Append("\",");
        }

        if (!string.IsNullOrEmpty(deviceName))
        {
            builder.Append(" Device=\"")
                .Append(UrlEncoder.Default.Encode(deviceName))
                .Append("\",");
        }

        if (!string.IsNullOrEmpty(deviceId))
        {
            builder.Append(" DeviceId=\"")
                .Append(UrlEncoder.Default.Encode(deviceId))
                .Append("\",");
        }

        // Trim trailing comma.
        if (builder.Length > AuthScheme.Length)
        {
            builder.Length--;
        }

        _authHeader = builder.ToString();
    }

    /// <summary>
    /// Set the server url.
    /// </summary>
    /// <param name="serverUrl">The server url.</param>
    public void SetServerUrl(string? serverUrl)
    {
        ServerUrl = serverUrl;
        ServerUrlUpdated?.Invoke(this, new TypedEventArgs<string?>(serverUrl));
    }

    /// <summary>
    /// Set the access token.
    /// </summary>
    /// <param name="accessToken">The access token.</param>
    public void SetAccessToken(string? accessToken)
    {
        AccessToken = accessToken;

        _authTokenHeader = string.IsNullOrEmpty(accessToken)
            ? null
            : $"{AuthScheme} Token=\"{accessToken}\"";
    }
}
