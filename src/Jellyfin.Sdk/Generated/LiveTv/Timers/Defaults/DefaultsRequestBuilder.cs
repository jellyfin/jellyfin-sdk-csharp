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
namespace Jellyfin.Sdk.Generated.LiveTv.Timers.Defaults {
    /// <summary>
    /// Builds and executes requests for operations under \LiveTv\Timers\Defaults
    /// </summary>
    public class DefaultsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new DefaultsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefaultsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/Timers/Defaults{?programId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DefaultsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefaultsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/Timers/Defaults{?programId*}", rawUrl) {
        }
        /// <summary>
        /// Gets the default values for a new timer.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SeriesTimerInfoDto?> GetAsync(Action<RequestConfiguration<DefaultsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SeriesTimerInfoDto> GetAsync(Action<RequestConfiguration<DefaultsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<SeriesTimerInfoDto>(requestInfo, SeriesTimerInfoDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets the default values for a new timer.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public DefaultsRequestBuilder WithUrl(string rawUrl) {
            return new DefaultsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets the default values for a new timer.
        /// </summary>
        public class DefaultsRequestBuilderGetQueryParameters {
            /// <summary>Optional. To attach default values based on a program.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("programId")]
            public string? ProgramId { get; set; }
#nullable restore
#else
            [QueryParameter("programId")]
            public string ProgramId { get; set; }
#endif
        }
    }
}
