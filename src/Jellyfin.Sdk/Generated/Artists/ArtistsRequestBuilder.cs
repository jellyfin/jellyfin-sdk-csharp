// <auto-generated/>
using Jellyfin.Sdk.Generated.Artists.AlbumArtists;
using Jellyfin.Sdk.Generated.Artists.InstantMix;
using Jellyfin.Sdk.Generated.Artists.Item;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Artists {
    /// <summary>
    /// Builds and executes requests for operations under \Artists
    /// </summary>
    public class ArtistsRequestBuilder : BaseRequestBuilder {
        /// <summary>The AlbumArtists property</summary>
        public AlbumArtistsRequestBuilder AlbumArtists { get =>
            new AlbumArtistsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The InstantMix property</summary>
        public InstantMixRequestBuilder InstantMix { get =>
            new InstantMixRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Artists.item collection</summary>
        /// <param name="position">Studio name.</param>
        /// <returns>A <see cref="IdItemRequestBuilder"/></returns>
        public IdItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("id%2Did", position);
            return new IdItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="ArtistsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArtistsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Artists{?enableImageTypes*,enableImages*,enableTotalRecordCount*,enableUserData*,excludeItemTypes*,fields*,filters*,genreIds*,genres*,imageTypeLimit*,includeItemTypes*,isFavorite*,limit*,mediaTypes*,minCommunityRating*,nameLessThan*,nameStartsWith*,nameStartsWithOrGreater*,officialRatings*,parentId*,person*,personIds*,personTypes*,searchTerm*,sortBy*,sortOrder*,startIndex*,studioIds*,studios*,tags*,userId*,years*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ArtistsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArtistsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Artists{?enableImageTypes*,enableImages*,enableTotalRecordCount*,enableUserData*,excludeItemTypes*,fields*,filters*,genreIds*,genres*,imageTypeLimit*,includeItemTypes*,isFavorite*,limit*,mediaTypes*,minCommunityRating*,nameLessThan*,nameStartsWith*,nameStartsWithOrGreater*,officialRatings*,parentId*,person*,personIds*,personTypes*,searchTerm*,sortBy*,sortOrder*,startIndex*,studioIds*,studios*,tags*,userId*,years*}", rawUrl) {
        }
        /// <summary>
        /// Gets all artists from a given item, folder, or the entire library.
        /// </summary>
        /// <returns>A <see cref="BaseItemDtoQueryResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BaseItemDtoQueryResult>(requestInfo, BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets all artists from a given item, folder, or the entire library.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ArtistsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ArtistsRequestBuilder WithUrl(string rawUrl) {
            return new ArtistsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets all artists from a given item, folder, or the entire library.
        /// </summary>
        public class ArtistsRequestBuilderGetQueryParameters {
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
            /// <summary>Optional. Specify additional filters to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filters")]
            public ItemFilter[]? Filters { get; set; }
#nullable restore
#else
            [QueryParameter("filters")]
            public ItemFilter[] Filters { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("genreIds")]
            public Guid?[]? GenreIds { get; set; }
#nullable restore
#else
            [QueryParameter("genreIds")]
            public Guid?[] GenreIds { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("genres")]
            public string[]? Genres { get; set; }
#nullable restore
#else
            [QueryParameter("genres")]
            public string[] Genres { get; set; }
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
            /// <summary>Optional filter by MediaType. Allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("mediaTypes")]
            public string[]? MediaTypes { get; set; }
#nullable restore
#else
            [QueryParameter("mediaTypes")]
            public string[] MediaTypes { get; set; }
#endif
            /// <summary>Optional filter by minimum community rating.</summary>
            [QueryParameter("minCommunityRating")]
            public double? MinCommunityRating { get; set; }
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
            /// <summary>Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("officialRatings")]
            public string[]? OfficialRatings { get; set; }
#nullable restore
#else
            [QueryParameter("officialRatings")]
            public string[] OfficialRatings { get; set; }
#endif
            /// <summary>Specify this to localize the search to a specific item or folder. Omit to use the root.</summary>
            [QueryParameter("parentId")]
            public Guid? ParentId { get; set; }
            /// <summary>Optional. If specified, results will be filtered to include only those containing the specified person.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("person")]
            public string? Person { get; set; }
#nullable restore
#else
            [QueryParameter("person")]
            public string Person { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered to include only those containing the specified person ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("personIds")]
            public Guid?[]? PersonIds { get; set; }
#nullable restore
#else
            [QueryParameter("personIds")]
            public Guid?[] PersonIds { get; set; }
#endif
            /// <summary>Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("personTypes")]
            public string[]? PersonTypes { get; set; }
#nullable restore
#else
            [QueryParameter("personTypes")]
            public string[] PersonTypes { get; set; }
#endif
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
            /// <summary>Optional. Specify one or more sort orders, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortBy")]
            public string[]? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sortBy")]
            public string[] SortBy { get; set; }
#endif
            /// <summary>Sort Order - Ascending,Descending.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortOrder")]
            public Jellyfin.Sdk.Generated.Models.SortOrder[]? SortOrder { get; set; }
#nullable restore
#else
            [QueryParameter("sortOrder")]
            public Jellyfin.Sdk.Generated.Models.SortOrder[] SortOrder { get; set; }
#endif
            /// <summary>Optional. The record index to start at. All items with a lower index will be dropped from the results.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
            /// <summary>Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("studioIds")]
            public Guid?[]? StudioIds { get; set; }
#nullable restore
#else
            [QueryParameter("studioIds")]
            public Guid?[] StudioIds { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("studios")]
            public string[]? Studios { get; set; }
#nullable restore
#else
            [QueryParameter("studios")]
            public string[] Studios { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tags")]
            public string[]? Tags { get; set; }
#nullable restore
#else
            [QueryParameter("tags")]
            public string[] Tags { get; set; }
#endif
            /// <summary>User id.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
            /// <summary>Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("years")]
            public int?[]? Years { get; set; }
#nullable restore
#else
            [QueryParameter("years")]
            public int?[] Years { get; set; }
#endif
        }
    }
}
