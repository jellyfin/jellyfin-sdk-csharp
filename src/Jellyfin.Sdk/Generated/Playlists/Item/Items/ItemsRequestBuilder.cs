// <auto-generated/>
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.Playlists.Item.Items.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Playlists.Item.Items {
    /// <summary>
    /// Builds and executes requests for operations under \Playlists\{id-id}\Items
    /// </summary>
    public class ItemsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Playlists.item.Items.item collection</summary>
        /// <param name="position">The item id.</param>
        /// <returns>A <see cref="WithItemItemRequestBuilder"/></returns>
        public WithItemItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("itemId", position);
            return new WithItemItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="ItemsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Playlists/{id%2Did}/Items?userId={userId}{&enableImageTypes*,enableImages*,enableUserData*,fields*,imageTypeLimit*,limit*,startIndex*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ItemsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Playlists/{id%2Did}/Items?userId={userId}{&enableImageTypes*,enableImages*,enableUserData*,fields*,imageTypeLimit*,limit*,startIndex*}", rawUrl) {
        }
        /// <summary>
        /// Removes items from a playlist.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<ItemsRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<ItemsRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets the original items of a playlist.
        /// </summary>
        /// <returns>A <see cref="BaseItemDtoQueryResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<ItemsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<ItemsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BaseItemDtoQueryResult>(requestInfo, BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Adds items to a playlist.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(Action<RequestConfiguration<ItemsRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(Action<RequestConfiguration<ItemsRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Removes items from a playlist.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<ItemsRequestBuilderDeleteQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<ItemsRequestBuilderDeleteQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/Playlists/{id%2Did}/Items{?entryIds*}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Gets the original items of a playlist.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ItemsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ItemsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Adds items to a playlist.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<ItemsRequestBuilderPostQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<ItemsRequestBuilderPostQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/Playlists/{id%2Did}/Items{?ids*,userId*}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ItemsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ItemsRequestBuilder WithUrl(string rawUrl) {
            return new ItemsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Removes items from a playlist.
        /// </summary>
        public class ItemsRequestBuilderDeleteQueryParameters {
            /// <summary>The item ids, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("entryIds")]
            public string[]? EntryIds { get; set; }
#nullable restore
#else
            [QueryParameter("entryIds")]
            public string[] EntryIds { get; set; }
#endif
        }
        /// <summary>
        /// Gets the original items of a playlist.
        /// </summary>
        public class ItemsRequestBuilderGetQueryParameters {
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
            /// <summary>Optional. The record index to start at. All items with a lower index will be dropped from the results.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
            /// <summary>User id.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
        /// <summary>
        /// Adds items to a playlist.
        /// </summary>
        public class ItemsRequestBuilderPostQueryParameters {
            /// <summary>Item id, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ids")]
            public Guid?[]? Ids { get; set; }
#nullable restore
#else
            [QueryParameter("ids")]
            public Guid?[] Ids { get; set; }
#endif
            /// <summary>The userId.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
