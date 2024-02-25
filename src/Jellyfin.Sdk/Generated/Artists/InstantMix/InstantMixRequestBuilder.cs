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
namespace Jellyfin.Sdk.Generated.Artists.InstantMix {
    /// <summary>
    /// Builds and executes requests for operations under \Artists\InstantMix
    /// </summary>
    public class InstantMixRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new InstantMixRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstantMixRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Artists/InstantMix?id={id}{&enableImages*,enableImageTypes*,enableUserData*,fields*,imageTypeLimit*,limit*,userId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new InstantMixRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstantMixRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Artists/InstantMix?id={id}{&enableImages*,enableImageTypes*,enableUserData*,fields*,imageTypeLimit*,limit*,userId*}", rawUrl) {
        }
        /// <summary>
        /// Creates an instant playlist based on a given artist.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<InstantMixRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<InstantMixRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BaseItemDtoQueryResult>(requestInfo, BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates an instant playlist based on a given artist.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<InstantMixRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<InstantMixRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        [Obsolete("")]
        public InstantMixRequestBuilder WithUrl(string rawUrl) {
            return new InstantMixRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Creates an instant playlist based on a given artist.
        /// </summary>
        public class InstantMixRequestBuilderGetQueryParameters {
            /// <summary>Optional. Include image information in output.</summary>
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
            /// <summary>Optional. Specify additional fields of information to return in the output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string[]? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string[] Fields { get; set; }
#endif
            /// <summary>The item id.</summary>
            [QueryParameter("id")]
            public Guid? Id { get; set; }
            /// <summary>Optional. The max number of images to return, per image type.</summary>
            [QueryParameter("imageTypeLimit")]
            public int? ImageTypeLimit { get; set; }
            /// <summary>Optional. The maximum number of records to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Optional. Filter by user id, and attach user data.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
