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
namespace Jellyfin.Sdk.Generated.Items.Item.ThemeVideos {
    /// <summary>
    /// Builds and executes requests for operations under \Items\{itemId}\ThemeVideos
    /// </summary>
    public class ThemeVideosRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ThemeVideosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThemeVideosRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/ThemeVideos{?inheritFromParent*,userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ThemeVideosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThemeVideosRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/ThemeVideos{?inheritFromParent*,userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Get theme videos for an item.
        /// </summary>
        /// <returns>A <see cref="ThemeMediaResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ProblemDetails">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ThemeMediaResult?> GetAsync(Action<RequestConfiguration<ThemeVideosRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ThemeMediaResult> GetAsync(Action<RequestConfiguration<ThemeVideosRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", ProblemDetails.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ThemeMediaResult>(requestInfo, ThemeMediaResult.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get theme videos for an item.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ThemeVideosRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ThemeVideosRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="ThemeVideosRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ThemeVideosRequestBuilder WithUrl(string rawUrl)
        {
            return new ThemeVideosRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get theme videos for an item.
        /// </summary>
        public class ThemeVideosRequestBuilderGetQueryParameters 
        {
            /// <summary>Optional. Determines whether or not parent items should be searched for theme media.</summary>
            [QueryParameter("inheritFromParent")]
            public bool? InheritFromParent { get; set; }
            /// <summary>Optional. Filter by user id, and attach user data.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
