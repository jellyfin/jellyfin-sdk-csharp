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
namespace Jellyfin.Sdk.Generated.Movies.Recommendations {
    /// <summary>
    /// Builds and executes requests for operations under \Movies\Recommendations
    /// </summary>
    public class RecommendationsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="RecommendationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecommendationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Movies/Recommendations{?categoryLimit*,fields*,itemLimit*,parentId*,userId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="RecommendationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecommendationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Movies/Recommendations{?categoryLimit*,fields*,itemLimit*,parentId*,userId*}", rawUrl) {
        }
        /// <summary>
        /// Gets movie recommendations.
        /// </summary>
        /// <returns>A List&lt;RecommendationDto&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<RecommendationDto>?> GetAsync(Action<RequestConfiguration<RecommendationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<RecommendationDto>> GetAsync(Action<RequestConfiguration<RecommendationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<RecommendationDto>(requestInfo, RecommendationDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Gets movie recommendations.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RecommendationsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RecommendationsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="RecommendationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RecommendationsRequestBuilder WithUrl(string rawUrl) {
            return new RecommendationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets movie recommendations.
        /// </summary>
        public class RecommendationsRequestBuilderGetQueryParameters {
            /// <summary>The max number of categories to return.</summary>
            [QueryParameter("categoryLimit")]
            public int? CategoryLimit { get; set; }
            /// <summary>Optional. The fields to return.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public ItemFields[]? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public ItemFields[] Fields { get; set; }
#endif
            /// <summary>The max number of items to return per category.</summary>
            [QueryParameter("itemLimit")]
            public int? ItemLimit { get; set; }
            /// <summary>Specify this to localize the search to a specific item or folder. Omit to use the root.</summary>
            [QueryParameter("parentId")]
            public Guid? ParentId { get; set; }
            /// <summary>Optional. Filter by user id, and attach user data.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
