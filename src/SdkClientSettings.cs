using System.Text;

namespace Jellyfin.Sdk;

/// <summary>
/// The sdk client settings.
/// </summary>
public class SdkClientSettings
{
    /// <summary>
    /// Gets or sets the Jellyfin server's base url.
    /// </summary>
    /// <example>
    /// https://demo.jellyfin.org/stable.
    /// </example>
    public string BaseUrl { get; set; }

    /// <summary>
    /// Gets or sets the user's access token.
    /// </summary>
    public string AccessToken { get; set; }

    /// <summary>
    /// Gets or sets the client name.
    /// </summary>
    public string ClientName { get; set; }

    /// <summary>
    /// Gets or sets the client version.
    /// </summary>
    public string ClientVersion { get; set; }

    /// <summary>
    /// Gets or sets the device name.
    /// </summary>
    public string DeviceName { get; set; }

    /// <summary>
    /// Gets or sets the device id.
    /// </summary>
    public string DeviceId { get; set; }

    /// <summary>
    /// Get the default authorization header.
    /// </summary>
    /// <remarks>
    /// This is used when the access token is not set.
    /// </remarks>
    /// <returns>The default authorization header.</returns>
    public string GetAuthorizationHeader()
    {
        var builder = new StringBuilder();
        if (!string.IsNullOrEmpty(ClientName))
        {
            builder.Append(" Client=\"")
                .Append(ClientName)
                .Append("\",");
        }

        if (!string.IsNullOrEmpty(ClientVersion))
        {
            builder.Append(" Version=\"")
                .Append(ClientVersion)
                .Append("\",");
        }

        if (!string.IsNullOrEmpty(DeviceName))
        {
            builder.Append(" Device=\"")
                .Append(DeviceName)
                .Append("\",");
        }

        if (!string.IsNullOrEmpty(DeviceId))
        {
            builder.Append(" DeviceId=\"")
                .Append(DeviceId)
                .Append("\",");
        }

        if (!string.IsNullOrEmpty(AccessToken))
        {
            builder.Append(" Token=\"")
                .Append(AccessToken)
                .Append("\",");
        }

        // Trim trailing comma.
        if (builder.Length > 0)
        {
            builder.Length--;
        }

        return builder.ToString();
    }

    /// <summary>
    /// Initializes the client settings.
    /// </summary>
    /// <param name="clientName">The client name.</param>
    /// <param name="clientVersion">The client version.</param>
    /// <param name="deviceName">The device name.</param>
    /// <param name="deviceId">The device id.</param>
    public void InitializeClientSettings(
        string clientName,
        string clientVersion,
        string deviceName,
        string deviceId)
    {
        ClientName = clientName;
        ClientVersion = clientVersion;
        DeviceName = deviceName;
        DeviceId = deviceId;
    }
}
