// <auto-generated/>
using Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.Item;
using Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.StreamWithRouteFormat;
using Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{item-id}\{mediaSource-id}\Subtitles\{index-id}
    /// </summary>
    public class IndexItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The subtitlesM3u8 property</summary>
        public SubtitlesM3u8RequestBuilder SubtitlesM3u8
        {
            get => new SubtitlesM3u8RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Videos.item.item.Subtitles.item.item collection</summary>
        /// <param name="position">The (route) start position of the subtitle in ticks.</param>
        /// <returns>A <see cref="WithRouteStartPositionTicksItemRequestBuilder"/></returns>
        public WithRouteStartPositionTicksItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("routeStartPositionTicks", position);
                return new WithRouteStartPositionTicksItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="IndexItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IndexItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/{mediaSource%2Did}/Subtitles/{index%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="IndexItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IndexItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/{mediaSource%2Did}/Subtitles/{index%2Did}", rawUrl)
        {
        }
        /// <summary>
        /// Builds and executes requests for operations under \Videos\{item-id}\{mediaSource-id}\Subtitles\{index-id}\Stream.{routeFormat}
        /// </summary>
        /// <returns>A <see cref="StreamWithRouteFormatRequestBuilder"/></returns>
        /// <param name="routeFormat">The (route) format of the returned subtitle.</param>
        public StreamWithRouteFormatRequestBuilder StreamWithRouteFormat(string routeFormat)
        {
            if(string.IsNullOrEmpty(routeFormat)) throw new ArgumentNullException(nameof(routeFormat));
            return new StreamWithRouteFormatRequestBuilder(PathParameters, RequestAdapter, routeFormat);
        }
    }
}
