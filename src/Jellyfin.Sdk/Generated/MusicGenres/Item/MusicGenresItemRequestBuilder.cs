// <auto-generated/>
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.MusicGenres.Item.Images;
using Jellyfin.Sdk.Generated.MusicGenres.Item.InstantMix;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.MusicGenres.Item {
    /// <summary>
    /// Builds and executes requests for operations under \MusicGenres\{MusicGenres-id}
    /// </summary>
    public class MusicGenresItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The Images property</summary>
        public ImagesRequestBuilder Images { get =>
            new ImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The InstantMix property</summary>
        public InstantMixRequestBuilder InstantMix { get =>
            new InstantMixRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new MusicGenresItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MusicGenresItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/MusicGenres/{MusicGenres%2Did}{?userId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MusicGenresItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MusicGenresItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/MusicGenres/{MusicGenres%2Did}{?userId*}", rawUrl) {
        }
        /// <summary>
        /// Gets a music genre, by name.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDto?> GetAsync(Action<RequestConfiguration<MusicGenresItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BaseItemDto> GetAsync(Action<RequestConfiguration<MusicGenresItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BaseItemDto>(requestInfo, BaseItemDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a music genre, by name.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MusicGenresItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MusicGenresItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public MusicGenresItemRequestBuilder WithUrl(string rawUrl) {
            return new MusicGenresItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets a music genre, by name.
        /// </summary>
        public class MusicGenresItemRequestBuilderGetQueryParameters {
            /// <summary>Optional. Filter by user id, and attach user data.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
