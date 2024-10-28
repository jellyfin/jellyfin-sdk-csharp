// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Artists.Item.Images;
using Jellyfin.Sdk.Generated.Artists.Item.InstantMix;
using Jellyfin.Sdk.Generated.Artists.Item.Similar;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Artists.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \Artists\{item-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ItemItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Images property</summary>
        public global::Jellyfin.Sdk.Generated.Artists.Item.Images.ImagesRequestBuilder Images
        {
            get => new global::Jellyfin.Sdk.Generated.Artists.Item.Images.ImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The InstantMix property</summary>
        public global::Jellyfin.Sdk.Generated.Artists.Item.InstantMix.InstantMixRequestBuilder InstantMix
        {
            get => new global::Jellyfin.Sdk.Generated.Artists.Item.InstantMix.InstantMixRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Similar property</summary>
        public global::Jellyfin.Sdk.Generated.Artists.Item.Similar.SimilarRequestBuilder Similar
        {
            get => new global::Jellyfin.Sdk.Generated.Artists.Item.Similar.SimilarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Artists.Item.ItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Artists/{item%2Did}{?userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Artists.Item.ItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Artists/{item%2Did}{?userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets an artist by name.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.BaseItemDto"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Jellyfin.Sdk.Generated.Models.BaseItemDto?> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Artists.Item.ItemItemRequestBuilder.ItemItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Jellyfin.Sdk.Generated.Models.BaseItemDto> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Artists.Item.ItemItemRequestBuilder.ItemItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Jellyfin.Sdk.Generated.Models.BaseItemDto>(requestInfo, global::Jellyfin.Sdk.Generated.Models.BaseItemDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets an artist by name.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Artists.Item.ItemItemRequestBuilder.ItemItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Artists.Item.ItemItemRequestBuilder.ItemItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Artists.Item.ItemItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Artists.Item.ItemItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Artists.Item.ItemItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets an artist by name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ItemItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Optional. Filter by user id, and attach user data.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
#pragma warning restore CS0618
