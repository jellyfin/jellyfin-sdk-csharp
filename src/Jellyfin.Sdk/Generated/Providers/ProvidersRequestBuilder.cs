// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Providers.Lyrics;
using Jellyfin.Sdk.Generated.Providers.Subtitles;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Providers
{
    /// <summary>
    /// Builds and executes requests for operations under \Providers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ProvidersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Lyrics property</summary>
        public global::Jellyfin.Sdk.Generated.Providers.Lyrics.LyricsRequestBuilder Lyrics
        {
            get => new global::Jellyfin.Sdk.Generated.Providers.Lyrics.LyricsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Subtitles property</summary>
        public global::Jellyfin.Sdk.Generated.Providers.Subtitles.SubtitlesRequestBuilder Subtitles
        {
            get => new global::Jellyfin.Sdk.Generated.Providers.Subtitles.SubtitlesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Providers.ProvidersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProvidersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Providers", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Providers.ProvidersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProvidersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Providers", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
