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
namespace Jellyfin.Sdk.Generated.Items.Item.Refresh {
    /// <summary>
    /// Builds and executes requests for operations under \Items\{Items-id}\Refresh
    /// </summary>
    public class RefreshRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new RefreshRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefreshRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{Items%2Did}/Refresh{?imageRefreshMode*,metadataRefreshMode*,replaceAllImages*,replaceAllMetadata*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RefreshRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefreshRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{Items%2Did}/Refresh{?imageRefreshMode*,metadataRefreshMode*,replaceAllImages*,replaceAllMetadata*}", rawUrl) {
        }
        /// <summary>
        /// Refreshes metadata for an item.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(Action<RequestConfiguration<RefreshRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(Action<RequestConfiguration<RefreshRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", ProblemDetails.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Refreshes metadata for an item.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<RefreshRequestBuilderPostQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<RefreshRequestBuilderPostQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefreshRequestBuilder WithUrl(string rawUrl) {
            return new RefreshRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Refreshes metadata for an item.
        /// </summary>
        public class RefreshRequestBuilderPostQueryParameters {
            /// <summary>(Optional) Specifies the image refresh mode.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("imageRefreshMode")]
            public string? ImageRefreshMode { get; set; }
#nullable restore
#else
            [QueryParameter("imageRefreshMode")]
            public string ImageRefreshMode { get; set; }
#endif
            /// <summary>(Optional) Specifies the metadata refresh mode.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("metadataRefreshMode")]
            public string? MetadataRefreshMode { get; set; }
#nullable restore
#else
            [QueryParameter("metadataRefreshMode")]
            public string MetadataRefreshMode { get; set; }
#endif
            /// <summary>(Optional) Determines if images should be replaced. Only applicable if mode is FullRefresh.</summary>
            [QueryParameter("replaceAllImages")]
            public bool? ReplaceAllImages { get; set; }
            /// <summary>(Optional) Determines if metadata should be replaced. Only applicable if mode is FullRefresh.</summary>
            [QueryParameter("replaceAllMetadata")]
            public bool? ReplaceAllMetadata { get; set; }
        }
    }
}
