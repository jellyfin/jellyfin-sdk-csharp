// <auto-generated/>
using Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles {
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{Videos-id}\{ItemId-id}\Subtitles
    /// </summary>
    public class SubtitlesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Videos.item.item.Subtitles.item collection</summary>
        /// <param name="position">The subtitle stream index.</param>
        public SubtitlesItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("Subtitles%2Did", position);
            return new SubtitlesItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Videos.item.item.Subtitles.item collection</summary>
        /// <param name="position">The subtitle stream index.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public SubtitlesItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("Subtitles%2Did", position);
            return new SubtitlesItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new SubtitlesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{Videos%2Did}/{ItemId%2Did}/Subtitles", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SubtitlesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{Videos%2Did}/{ItemId%2Did}/Subtitles", rawUrl) {
        }
    }
}