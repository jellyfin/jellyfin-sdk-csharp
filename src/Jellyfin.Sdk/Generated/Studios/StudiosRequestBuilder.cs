// <auto-generated/>
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.Studios.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Studios {
    /// <summary>
    /// Builds and executes requests for operations under \Studios
    /// </summary>
    public class StudiosRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Studios.item collection</summary>
        /// <param name="position">Studio name.</param>
        /// <returns>A <see cref="WithNameItemRequestBuilder"/></returns>
        public WithNameItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("name", position);
            return new WithNameItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="StudiosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StudiosRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Studios{?enableImageTypes*,enableImages*,enableTotalRecordCount*,enableUserData*,excludeItemTypes*,fields*,imageTypeLimit*,includeItemTypes*,isFavorite*,limit*,nameLessThan*,nameStartsWith*,nameStartsWithOrGreater*,parentId*,searchTerm*,startIndex*,userId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="StudiosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StudiosRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Studios{?enableImageTypes*,enableImages*,enableTotalRecordCount*,enableUserData*,excludeItemTypes*,fields*,imageTypeLimit*,includeItemTypes*,isFavorite*,limit*,nameLessThan*,nameStartsWith*,nameStartsWithOrGreater*,parentId*,searchTerm*,startIndex*,userId*}", rawUrl) {
        }
        /// <summary>
        /// Gets all studios from a given item, folder, or the entire library.
        /// </summary>
        /// <returns>A <see cref="BaseItemDtoQueryResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<StudiosRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<StudiosRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BaseItemDtoQueryResult>(requestInfo, BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets all studios from a given item, folder, or the entire library.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StudiosRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StudiosRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="StudiosRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public StudiosRequestBuilder WithUrl(string rawUrl) {
            return new StudiosRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets all studios from a given item, folder, or the entire library.
        /// </summary>
        public class StudiosRequestBuilderGetQueryParameters {
            /// <summary>Optional, include image information in output.</summary>
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
            /// <summary>Total record count.</summary>
            [QueryParameter("enableTotalRecordCount")]
            public bool? EnableTotalRecordCount { get; set; }
            /// <summary>Optional, include user data.</summary>
            [QueryParameter("enableUserData")]
            public bool? EnableUserData { get; set; }
            /// <summary>Optional. If specified, results will be filtered out based on item type. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("excludeItemTypes")]
            public BaseItemKind[]? ExcludeItemTypes { get; set; }
#nullable restore
#else
            [QueryParameter("excludeItemTypes")]
            public BaseItemKind[] ExcludeItemTypes { get; set; }
#endif
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
            /// <summary>Optional, the max number of images to return, per image type.</summary>
            [QueryParameter("imageTypeLimit")]
            public int? ImageTypeLimit { get; set; }
            /// <summary>Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("includeItemTypes")]
            public BaseItemKind[]? IncludeItemTypes { get; set; }
#nullable restore
#else
            [QueryParameter("includeItemTypes")]
            public BaseItemKind[] IncludeItemTypes { get; set; }
#endif
            /// <summary>Optional filter by items that are marked as favorite, or not.</summary>
            [QueryParameter("isFavorite")]
            public bool? IsFavorite { get; set; }
            /// <summary>Optional. The maximum number of records to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Optional filter by items whose name is equally or lesser than a given input string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("nameLessThan")]
            public string? NameLessThan { get; set; }
#nullable restore
#else
            [QueryParameter("nameLessThan")]
            public string NameLessThan { get; set; }
#endif
            /// <summary>Optional filter by items whose name is sorted equally than a given input string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("nameStartsWith")]
            public string? NameStartsWith { get; set; }
#nullable restore
#else
            [QueryParameter("nameStartsWith")]
            public string NameStartsWith { get; set; }
#endif
            /// <summary>Optional filter by items whose name is sorted equally or greater than a given input string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("nameStartsWithOrGreater")]
            public string? NameStartsWithOrGreater { get; set; }
#nullable restore
#else
            [QueryParameter("nameStartsWithOrGreater")]
            public string NameStartsWithOrGreater { get; set; }
#endif
            /// <summary>Specify this to localize the search to a specific item or folder. Omit to use the root.</summary>
            [QueryParameter("parentId")]
            public Guid? ParentId { get; set; }
            /// <summary>Optional. Search term.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("searchTerm")]
            public string? SearchTerm { get; set; }
#nullable restore
#else
            [QueryParameter("searchTerm")]
            public string SearchTerm { get; set; }
#endif
            /// <summary>Optional. The record index to start at. All items with a lower index will be dropped from the results.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
            /// <summary>User id.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
