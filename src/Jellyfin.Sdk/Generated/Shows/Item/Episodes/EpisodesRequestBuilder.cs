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
namespace Jellyfin.Sdk.Generated.Shows.Item.Episodes {
    /// <summary>
    /// Builds and executes requests for operations under \Shows\{Shows-id}\Episodes
    /// </summary>
    public class EpisodesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new EpisodesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EpisodesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Shows/{Shows%2Did}/Episodes{?adjacentTo*,enableImages*,enableImageTypes*,enableUserData*,fields*,imageTypeLimit*,isMissing*,limit*,season*,seasonId*,sortBy*,startIndex*,startItemId*,userId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new EpisodesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EpisodesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Shows/{Shows%2Did}/Episodes{?adjacentTo*,enableImages*,enableImageTypes*,enableUserData*,fields*,imageTypeLimit*,isMissing*,limit*,season*,seasonId*,sortBy*,startIndex*,startItemId*,userId*}", rawUrl) {
        }
        /// <summary>
        /// Gets episodes for a tv season.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<EpisodesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<EpisodesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", ProblemDetails.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<BaseItemDtoQueryResult>(requestInfo, BaseItemDtoQueryResult.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets episodes for a tv season.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EpisodesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EpisodesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EpisodesRequestBuilder WithUrl(string rawUrl) {
            return new EpisodesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets episodes for a tv season.
        /// </summary>
        public class EpisodesRequestBuilderGetQueryParameters {
            /// <summary>Optional. Return items that are siblings of a supplied item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("adjacentTo")]
            public string? AdjacentTo { get; set; }
#nullable restore
#else
            [QueryParameter("adjacentTo")]
            public string AdjacentTo { get; set; }
#endif
            /// <summary>Optional, include image information in output.</summary>
            [QueryParameter("enableImages")]
            public bool? EnableImages { get; set; }
            /// <summary>Optional. The image types to include in the output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("enableImageTypes")]
            public string[]? EnableImageTypes { get; set; }
#nullable restore
#else
            [QueryParameter("enableImageTypes")]
            public string[] EnableImageTypes { get; set; }
#endif
            /// <summary>Optional. Include user data.</summary>
            [QueryParameter("enableUserData")]
            public bool? EnableUserData { get; set; }
            /// <summary>Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines, TrailerUrls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string[]? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string[] Fields { get; set; }
#endif
            /// <summary>Optional, the max number of images to return, per image type.</summary>
            [QueryParameter("imageTypeLimit")]
            public int? ImageTypeLimit { get; set; }
            /// <summary>Optional. Filter by items that are missing episodes or not.</summary>
            [QueryParameter("isMissing")]
            public bool? IsMissing { get; set; }
            /// <summary>Optional. The maximum number of records to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Optional filter by season number.</summary>
            [QueryParameter("season")]
            public int? Season { get; set; }
            /// <summary>Optional. Filter by season id.</summary>
            [QueryParameter("seasonId")]
            public Guid? SeasonId { get; set; }
            /// <summary>Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortBy")]
            public string? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sortBy")]
            public string SortBy { get; set; }
#endif
            /// <summary>Optional. The record index to start at. All items with a lower index will be dropped from the results.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
            /// <summary>Optional. Skip through the list until a given item is found.</summary>
            [QueryParameter("startItemId")]
            public Guid? StartItemId { get; set; }
            /// <summary>The user id.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
