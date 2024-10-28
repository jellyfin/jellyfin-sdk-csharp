// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Items.Item.ThemeSongs
{
    /// <summary>
    /// Builds and executes requests for operations under \Items\{itemId}\ThemeSongs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ThemeSongsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.Item.ThemeSongs.ThemeSongsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThemeSongsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/ThemeSongs{?inheritFromParent*,sortBy*,sortOrder*,userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.Item.ThemeSongs.ThemeSongsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThemeSongsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/ThemeSongs{?inheritFromParent*,sortBy*,sortOrder*,userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Get theme songs for an item.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.ThemeMediaResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Jellyfin.Sdk.Generated.Models.ProblemDetails">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Jellyfin.Sdk.Generated.Models.ThemeMediaResult?> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Items.Item.ThemeSongs.ThemeSongsRequestBuilder.ThemeSongsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Jellyfin.Sdk.Generated.Models.ThemeMediaResult> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Items.Item.ThemeSongs.ThemeSongsRequestBuilder.ThemeSongsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Jellyfin.Sdk.Generated.Models.ProblemDetails.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Jellyfin.Sdk.Generated.Models.ThemeMediaResult>(requestInfo, global::Jellyfin.Sdk.Generated.Models.ThemeMediaResult.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get theme songs for an item.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Items.Item.ThemeSongs.ThemeSongsRequestBuilder.ThemeSongsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Items.Item.ThemeSongs.ThemeSongsRequestBuilder.ThemeSongsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Items.Item.ThemeSongs.ThemeSongsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Items.Item.ThemeSongs.ThemeSongsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Items.Item.ThemeSongs.ThemeSongsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get theme songs for an item.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ThemeSongsRequestBuilderGetQueryParameters 
        {
            /// <summary>Optional. Determines whether or not parent items should be searched for theme media.</summary>
            [QueryParameter("inheritFromParent")]
            public bool? InheritFromParent { get; set; }
            /// <summary>Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortBy")]
            public global::Jellyfin.Sdk.Generated.Models.ItemSortBy[]? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sortBy")]
            public global::Jellyfin.Sdk.Generated.Models.ItemSortBy[] SortBy { get; set; }
#endif
            /// <summary>Optional. Sort Order - Ascending, Descending.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortOrder")]
            public global::Jellyfin.Sdk.Generated.Models.SortOrder[]? SortOrder { get; set; }
#nullable restore
#else
            [QueryParameter("sortOrder")]
            public global::Jellyfin.Sdk.Generated.Models.SortOrder[] SortOrder { get; set; }
#endif
            /// <summary>Optional. Filter by user id, and attach user data.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
#pragma warning restore CS0618
