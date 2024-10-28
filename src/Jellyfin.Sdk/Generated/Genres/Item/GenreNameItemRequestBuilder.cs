// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Genres.Item.Images;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Genres.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \Genres\{genreName-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GenreNameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Images property</summary>
        public global::Jellyfin.Sdk.Generated.Genres.Item.Images.ImagesRequestBuilder Images
        {
            get => new global::Jellyfin.Sdk.Generated.Genres.Item.Images.ImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Genres.Item.GenreNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GenreNameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Genres/{genreName%2Did}{?userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Genres.Item.GenreNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GenreNameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Genres/{genreName%2Did}{?userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets a genre, by name.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.BaseItemDto"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Jellyfin.Sdk.Generated.Models.BaseItemDto?> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Genres.Item.GenreNameItemRequestBuilder.GenreNameItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Jellyfin.Sdk.Generated.Models.BaseItemDto> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Genres.Item.GenreNameItemRequestBuilder.GenreNameItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Jellyfin.Sdk.Generated.Models.BaseItemDto>(requestInfo, global::Jellyfin.Sdk.Generated.Models.BaseItemDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a genre, by name.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Genres.Item.GenreNameItemRequestBuilder.GenreNameItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Genres.Item.GenreNameItemRequestBuilder.GenreNameItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Genres.Item.GenreNameItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Genres.Item.GenreNameItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Genres.Item.GenreNameItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets a genre, by name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class GenreNameItemRequestBuilderGetQueryParameters 
        {
            /// <summary>The user id.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
#pragma warning restore CS0618
