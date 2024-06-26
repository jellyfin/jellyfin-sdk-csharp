// <auto-generated/>
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Shows.NextUp {
    /// <summary>
    /// Builds and executes requests for operations under \Shows\NextUp
    /// </summary>
    public class NextUpRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="NextUpRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NextUpRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Shows/NextUp{?disableFirstEpisode*,enableImageTypes*,enableImages*,enableResumable*,enableRewatching*,enableTotalRecordCount*,enableUserData*,fields*,imageTypeLimit*,limit*,nextUpDateCutoff*,parentId*,seriesId*,startIndex*,userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="NextUpRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NextUpRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Shows/NextUp{?disableFirstEpisode*,enableImageTypes*,enableImages*,enableResumable*,enableRewatching*,enableTotalRecordCount*,enableUserData*,fields*,imageTypeLimit*,limit*,nextUpDateCutoff*,parentId*,seriesId*,startIndex*,userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets a list of next up episodes.
        /// </summary>
        /// <returns>A <see cref="BaseItemDtoQueryResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<NextUpRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<NextUpRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BaseItemDtoQueryResult>(requestInfo, BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a list of next up episodes.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<NextUpRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<NextUpRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="NextUpRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public NextUpRequestBuilder WithUrl(string rawUrl)
        {
            return new NextUpRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets a list of next up episodes.
        /// </summary>
        public class NextUpRequestBuilderGetQueryParameters 
        {
            /// <summary>Whether to disable sending the first episode in a series as next up.</summary>
            [QueryParameter("disableFirstEpisode")]
            public bool? DisableFirstEpisode { get; set; }
            /// <summary>Optional. Include image information in output.</summary>
            [QueryParameter("enableImages")]
            public bool? EnableImages { get; set; }
            /// <summary>Optional. The image types to include in the output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("enableImageTypes")]
            public ImageType[]? EnableImageTypes { get; set; }
#nullable restore
#else
            [QueryParameter("enableImageTypes")]
            public ImageType[] EnableImageTypes { get; set; }
#endif
            /// <summary>Whether to include resumable episodes in next up results.</summary>
            [QueryParameter("enableResumable")]
            public bool? EnableResumable { get; set; }
            /// <summary>Whether to include watched episodes in next up results.</summary>
            [QueryParameter("enableRewatching")]
            public bool? EnableRewatching { get; set; }
            /// <summary>Whether to enable the total records count. Defaults to true.</summary>
            [QueryParameter("enableTotalRecordCount")]
            public bool? EnableTotalRecordCount { get; set; }
            /// <summary>Optional. Include user data.</summary>
            [QueryParameter("enableUserData")]
            public bool? EnableUserData { get; set; }
            /// <summary>Optional. Specify additional fields of information to return in the output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public ItemFields[]? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public ItemFields[] Fields { get; set; }
#endif
            /// <summary>Optional. The max number of images to return, per image type.</summary>
            [QueryParameter("imageTypeLimit")]
            public int? ImageTypeLimit { get; set; }
            /// <summary>Optional. The maximum number of records to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Optional. Starting date of shows to show in Next Up section.</summary>
            [QueryParameter("nextUpDateCutoff")]
            public DateTimeOffset? NextUpDateCutoff { get; set; }
            /// <summary>Optional. Specify this to localize the search to a specific item or folder. Omit to use the root.</summary>
            [QueryParameter("parentId")]
            public Guid? ParentId { get; set; }
            /// <summary>Optional. Filter by series id.</summary>
            [QueryParameter("seriesId")]
            public Guid? SeriesId { get; set; }
            /// <summary>Optional. The record index to start at. All items with a lower index will be dropped from the results.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
            /// <summary>The user id of the user to get the next up episodes for.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
