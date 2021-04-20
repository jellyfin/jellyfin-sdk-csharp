namespace Jellyfin.Sdk
{
    /// <summary>
    /// The sdk client settings.
    /// </summary>
    public class SdkClientSettings
    {
        /// <summary>
        /// Gets or sets the Jellyfin server's base url.
        /// </summary>
        /// <example>
        /// https://demo.jellyfin.org/stable
        /// </example>
        public string BaseUrl { get; set; }
        
        /// <summary>
        /// Gets or sets the user's access token.
        /// </summary>
        public string AccessToken { get; set; }
        
        /// <summary>
        /// Get or sets the default authorization header.
        /// </summary>
        /// <remarks>
        /// This is used when the access token is not set.
        /// </remarks>
        public string DefaultAuthorizationHeader { get; set; }
    }
}