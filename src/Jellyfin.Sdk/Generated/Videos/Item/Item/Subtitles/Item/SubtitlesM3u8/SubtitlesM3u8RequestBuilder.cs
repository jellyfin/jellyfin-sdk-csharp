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
namespace Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8
{
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{item-id}\{mediaSource-id}\Subtitles\{index-id}\subtitles.m3u8
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SubtitlesM3u8RequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8.SubtitlesM3u8RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesM3u8RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/{mediaSource%2Did}/Subtitles/{index%2Did}/subtitles.m3u8?segmentLength={segmentLength}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8.SubtitlesM3u8RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubtitlesM3u8RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{item%2Did}/{mediaSource%2Did}/Subtitles/{index%2Did}/subtitles.m3u8?segmentLength={segmentLength}", rawUrl)
        {
        }
        /// <summary>
        /// Gets an HLS subtitle playlist.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Jellyfin.Sdk.Generated.Models.ProblemDetails">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8.SubtitlesM3u8RequestBuilder.SubtitlesM3u8RequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8.SubtitlesM3u8RequestBuilder.SubtitlesM3u8RequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Jellyfin.Sdk.Generated.Models.ProblemDetails.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets an HLS subtitle playlist.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8.SubtitlesM3u8RequestBuilder.SubtitlesM3u8RequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8.SubtitlesM3u8RequestBuilder.SubtitlesM3u8RequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/x-mpegURL, application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8.SubtitlesM3u8RequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8.SubtitlesM3u8RequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.SubtitlesM3u8.SubtitlesM3u8RequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets an HLS subtitle playlist.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SubtitlesM3u8RequestBuilderGetQueryParameters 
        {
            /// <summary>The subtitle segment length.</summary>
            [QueryParameter("segmentLength")]
            public int? SegmentLength { get; set; }
        }
    }
}
#pragma warning restore CS0618
