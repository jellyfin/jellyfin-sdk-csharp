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
namespace Jellyfin.Sdk.Generated.LiveTv.ChannelMappingOptions {
    /// <summary>
    /// Builds and executes requests for operations under \LiveTv\ChannelMappingOptions
    /// </summary>
    public class ChannelMappingOptionsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="ChannelMappingOptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChannelMappingOptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/ChannelMappingOptions{?providerId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ChannelMappingOptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChannelMappingOptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/ChannelMappingOptions{?providerId*}", rawUrl) {
        }
        /// <summary>
        /// Get channel mapping options.
        /// </summary>
        /// <returns>A <see cref="ChannelMappingOptionsDto"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ChannelMappingOptionsDto?> GetAsync(Action<RequestConfiguration<ChannelMappingOptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ChannelMappingOptionsDto> GetAsync(Action<RequestConfiguration<ChannelMappingOptionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ChannelMappingOptionsDto>(requestInfo, ChannelMappingOptionsDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get channel mapping options.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ChannelMappingOptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ChannelMappingOptionsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ChannelMappingOptionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ChannelMappingOptionsRequestBuilder WithUrl(string rawUrl) {
            return new ChannelMappingOptionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get channel mapping options.
        /// </summary>
        public class ChannelMappingOptionsRequestBuilderGetQueryParameters {
            /// <summary>Provider id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("providerId")]
            public string? ProviderId { get; set; }
#nullable restore
#else
            [QueryParameter("providerId")]
            public string ProviderId { get; set; }
#endif
        }
    }
}
