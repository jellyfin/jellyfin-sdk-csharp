// <auto-generated/>
using Jellyfin.Sdk.Generated.LiveTv.ListingProviders.Default;
using Jellyfin.Sdk.Generated.LiveTv.ListingProviders.Lineups;
using Jellyfin.Sdk.Generated.LiveTv.ListingProviders.SchedulesDirect;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.LiveTv.ListingProviders {
    /// <summary>
    /// Builds and executes requests for operations under \LiveTv\ListingProviders
    /// </summary>
    public class ListingProvidersRequestBuilder : BaseRequestBuilder {
        /// <summary>The Default property</summary>
        public DefaultRequestBuilder Default { get =>
            new DefaultRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Lineups property</summary>
        public LineupsRequestBuilder Lineups { get =>
            new LineupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SchedulesDirect property</summary>
        public SchedulesDirectRequestBuilder SchedulesDirect { get =>
            new SchedulesDirectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ListingProvidersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListingProvidersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/ListingProviders{?pw*,validateListings*,validateLogin*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ListingProvidersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListingProvidersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/ListingProviders{?pw*,validateListings*,validateLogin*}", rawUrl) {
        }
        /// <summary>
        /// Delete listing provider.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<ListingProvidersRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<ListingProvidersRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Adds a listings provider.
        /// </summary>
        /// <returns>A <see cref="ListingsProviderInfo"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ListingsProviderInfo?> PostAsync(ListingsProviderInfo body, Action<RequestConfiguration<ListingProvidersRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ListingsProviderInfo> PostAsync(ListingsProviderInfo body, Action<RequestConfiguration<ListingProvidersRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ListingsProviderInfo>(requestInfo, ListingsProviderInfo.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete listing provider.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<ListingProvidersRequestBuilderDeleteQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<ListingProvidersRequestBuilderDeleteQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/LiveTv/ListingProviders{?id*}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Adds a listings provider.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ListingsProviderInfo body, Action<RequestConfiguration<ListingProvidersRequestBuilderPostQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ListingsProviderInfo body, Action<RequestConfiguration<ListingProvidersRequestBuilderPostQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ListingProvidersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ListingProvidersRequestBuilder WithUrl(string rawUrl) {
            return new ListingProvidersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Delete listing provider.
        /// </summary>
        public class ListingProvidersRequestBuilderDeleteQueryParameters {
            /// <summary>Listing provider id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("id")]
            public string? Id { get; set; }
#nullable restore
#else
            [QueryParameter("id")]
            public string Id { get; set; }
#endif
        }
        /// <summary>
        /// Adds a listings provider.
        /// </summary>
        public class ListingProvidersRequestBuilderPostQueryParameters {
            /// <summary>Password.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("pw")]
            public string? Pw { get; set; }
#nullable restore
#else
            [QueryParameter("pw")]
            public string Pw { get; set; }
#endif
            /// <summary>Validate listings.</summary>
            [QueryParameter("validateListings")]
            public bool? ValidateListings { get; set; }
            /// <summary>Validate login.</summary>
            [QueryParameter("validateLogin")]
            public bool? ValidateLogin { get; set; }
        }
    }
}
