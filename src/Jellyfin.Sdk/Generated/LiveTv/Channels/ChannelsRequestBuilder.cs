// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.LiveTv.Channels.Item;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.LiveTv.Channels
{
    /// <summary>
    /// Builds and executes requests for operations under \LiveTv\Channels
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ChannelsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.LiveTv.Channels.item collection</summary>
        /// <param name="position">Channel id.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.LiveTv.Channels.Item.WithChannelItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.LiveTv.Channels.Item.WithChannelItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("channelId", position);
                return new global::Jellyfin.Sdk.Generated.LiveTv.Channels.Item.WithChannelItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChannelsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/Channels{?addCurrentProgram*,enableFavoriteSorting*,enableImageTypes*,enableImages*,enableUserData*,fields*,imageTypeLimit*,isDisliked*,isFavorite*,isKids*,isLiked*,isMovie*,isNews*,isSeries*,isSports*,limit*,sortBy*,sortOrder*,startIndex*,type*,userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChannelsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/Channels{?addCurrentProgram*,enableFavoriteSorting*,enableImageTypes*,enableImages*,enableUserData*,fields*,imageTypeLimit*,isDisliked*,isFavorite*,isKids*,isLiked*,isMovie*,isNews*,isSeries*,isSports*,limit*,sortBy*,sortOrder*,startIndex*,type*,userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets available live tv channels.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelsRequestBuilder.ChannelsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelsRequestBuilder.ChannelsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult>(requestInfo, global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets available live tv channels.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelsRequestBuilder.ChannelsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelsRequestBuilder.ChannelsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets available live tv channels.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ChannelsRequestBuilderGetQueryParameters 
        {
            /// <summary>Optional. Adds current program info to each channel.</summary>
            [QueryParameter("addCurrentProgram")]
            public bool? AddCurrentProgram { get; set; }
            /// <summary>Optional. Incorporate favorite and like status into channel sorting.</summary>
            [QueryParameter("enableFavoriteSorting")]
            public bool? EnableFavoriteSorting { get; set; }
            /// <summary>Optional. Include image information in output.</summary>
            [QueryParameter("enableImages")]
            public bool? EnableImages { get; set; }
            /// <summary>&quot;Optional. The image types to include in the output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("enableImageTypes")]
            public global::Jellyfin.Sdk.Generated.Models.ImageType[]? EnableImageTypes { get; set; }
#nullable restore
#else
            [QueryParameter("enableImageTypes")]
            public global::Jellyfin.Sdk.Generated.Models.ImageType[] EnableImageTypes { get; set; }
#endif
            /// <summary>Optional. Include user data.</summary>
            [QueryParameter("enableUserData")]
            public bool? EnableUserData { get; set; }
            /// <summary>Optional. Specify additional fields of information to return in the output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public global::Jellyfin.Sdk.Generated.Models.ItemFields[]? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public global::Jellyfin.Sdk.Generated.Models.ItemFields[] Fields { get; set; }
#endif
            /// <summary>Optional. The max number of images to return, per image type.</summary>
            [QueryParameter("imageTypeLimit")]
            public int? ImageTypeLimit { get; set; }
            /// <summary>Optional. Filter by channels that are disliked, or not.</summary>
            [QueryParameter("isDisliked")]
            public bool? IsDisliked { get; set; }
            /// <summary>Optional. Filter by channels that are favorites, or not.</summary>
            [QueryParameter("isFavorite")]
            public bool? IsFavorite { get; set; }
            /// <summary>Optional. Filter for kids.</summary>
            [QueryParameter("isKids")]
            public bool? IsKids { get; set; }
            /// <summary>Optional. Filter by channels that are liked, or not.</summary>
            [QueryParameter("isLiked")]
            public bool? IsLiked { get; set; }
            /// <summary>Optional. Filter for movies.</summary>
            [QueryParameter("isMovie")]
            public bool? IsMovie { get; set; }
            /// <summary>Optional. Filter for news.</summary>
            [QueryParameter("isNews")]
            public bool? IsNews { get; set; }
            /// <summary>Optional. Filter for series.</summary>
            [QueryParameter("isSeries")]
            public bool? IsSeries { get; set; }
            /// <summary>Optional. Filter for sports.</summary>
            [QueryParameter("isSports")]
            public bool? IsSports { get; set; }
            /// <summary>Optional. The maximum number of records to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Optional. Key to sort by.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortBy")]
            public global::Jellyfin.Sdk.Generated.Models.ItemSortBy[]? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sortBy")]
            public global::Jellyfin.Sdk.Generated.Models.ItemSortBy[] SortBy { get; set; }
#endif
            /// <summary>Optional. Sort order.</summary>
            [QueryParameter("sortOrder")]
            public global::Jellyfin.Sdk.Generated.LiveTv.Channels.SortOrder? SortOrder { get; set; }
            /// <summary>Optional. The record index to start at. All items with a lower index will be dropped from the results.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
            /// <summary>Optional. Filter by channel type.</summary>
            [QueryParameter("type")]
            public global::Jellyfin.Sdk.Generated.LiveTv.Channels.ChannelType? Type { get; set; }
            /// <summary>Optional. Filter by user and attach user data.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
#pragma warning restore CS0618
