// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Videos.Item.Hls.Item.StreamM3u8;
using Jellyfin.Sdk.Generated.Videos.Item.Hls.Item.WithSegmentIdWithSegmentContainer;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Videos.Item.Hls.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{item-id}\hls\{playlistId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithPlaylistItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The streamM3u8 property</summary>
        public global::Jellyfin.Sdk.Generated.Videos.Item.Hls.Item.StreamM3u8.StreamM3u8RequestBuilder StreamM3u8
        {
            get => new global::Jellyfin.Sdk.Generated.Videos.Item.Hls.Item.StreamM3u8.StreamM3u8RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Videos.Item.Hls.Item.WithPlaylistItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPlaylistItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/hls/{playlistId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Videos.Item.Hls.Item.WithPlaylistItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPlaylistItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/hls/{playlistId}", rawUrl)
        {
        }
        /// <summary>
        /// Builds and executes requests for operations under \Videos\{item-id}\hls\{playlistId}\{segmentId}.{segmentContainer}
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Videos.Item.Hls.Item.WithSegmentIdWithSegmentContainer.WithSegmentIdWithSegmentContainerRequestBuilder"/></returns>
        /// <param name="segmentContainer">The segment container.</param>
        /// <param name="segmentId">The segment id.</param>
        public global::Jellyfin.Sdk.Generated.Videos.Item.Hls.Item.WithSegmentIdWithSegmentContainer.WithSegmentIdWithSegmentContainerRequestBuilder WithSegmentIdWithSegmentContainer(string segmentContainer, string segmentId)
        {
            if(string.IsNullOrEmpty(segmentContainer)) throw new ArgumentNullException(nameof(segmentContainer));
            if(string.IsNullOrEmpty(segmentId)) throw new ArgumentNullException(nameof(segmentId));
            return new global::Jellyfin.Sdk.Generated.Videos.Item.Hls.Item.WithSegmentIdWithSegmentContainer.WithSegmentIdWithSegmentContainerRequestBuilder(PathParameters, RequestAdapter, segmentContainer, segmentId);
        }
    }
}
#pragma warning restore CS0618
