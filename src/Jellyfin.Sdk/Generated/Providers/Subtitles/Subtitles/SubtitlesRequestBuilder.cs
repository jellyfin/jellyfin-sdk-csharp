// <auto-generated/>
using Jellyfin.Sdk.Generated.Providers.Subtitles.Subtitles.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Providers.Subtitles.Subtitles {
    /// <summary>
    /// Builds and executes requests for operations under \Providers\Subtitles\Subtitles
    /// </summary>
    public class SubtitlesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Providers.Subtitles.Subtitles.item collection</summary>
        /// <param name="position">The item id.</param>
        /// <returns>A <see cref="WithSubtitleItemRequestBuilder"/></returns>
        public WithSubtitleItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("subtitleId", position);
                return new WithSubtitleItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="SubtitlesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Providers/Subtitles/Subtitles", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SubtitlesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Providers/Subtitles/Subtitles", rawUrl)
        {
        }
    }
}
