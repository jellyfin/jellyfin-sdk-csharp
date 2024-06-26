// <auto-generated/>
using Jellyfin.Sdk.Generated.Providers.Lyrics.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Providers.Lyrics {
    /// <summary>
    /// Builds and executes requests for operations under \Providers\Lyrics
    /// </summary>
    public class LyricsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Providers.Lyrics.item collection</summary>
        /// <param name="position">The remote provider item id.</param>
        /// <returns>A <see cref="WithLyricItemRequestBuilder"/></returns>
        public WithLyricItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("lyricId", position);
                return new WithLyricItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="LyricsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LyricsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Providers/Lyrics", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="LyricsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LyricsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Providers/Lyrics", rawUrl)
        {
        }
    }
}
