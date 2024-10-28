// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles
{
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{item-id}\{mediaSource-id}\Subtitles
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SubtitlesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Videos.item.item.Subtitles.item collection</summary>
        /// <param name="position">The subtitle stream index.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.IndexItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.IndexItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("index%2Did", position);
                return new global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.IndexItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.SubtitlesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/{mediaSource%2Did}/Subtitles", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.SubtitlesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/{mediaSource%2Did}/Subtitles", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
