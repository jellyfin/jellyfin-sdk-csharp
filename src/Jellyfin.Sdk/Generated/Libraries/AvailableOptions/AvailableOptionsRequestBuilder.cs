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
namespace Jellyfin.Sdk.Generated.Libraries.AvailableOptions
{
    /// <summary>
    /// Builds and executes requests for operations under \Libraries\AvailableOptions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AvailableOptionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.AvailableOptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AvailableOptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Libraries/AvailableOptions{?isNewLibrary*,libraryContentType*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.AvailableOptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AvailableOptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Libraries/AvailableOptions{?isNewLibrary*,libraryContentType*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets the library options info.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.LibraryOptionsResultDto"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Jellyfin.Sdk.Generated.Models.LibraryOptionsResultDto?> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.AvailableOptionsRequestBuilder.AvailableOptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Jellyfin.Sdk.Generated.Models.LibraryOptionsResultDto> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.AvailableOptionsRequestBuilder.AvailableOptionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Jellyfin.Sdk.Generated.Models.LibraryOptionsResultDto>(requestInfo, global::Jellyfin.Sdk.Generated.Models.LibraryOptionsResultDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets the library options info.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.AvailableOptionsRequestBuilder.AvailableOptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.AvailableOptionsRequestBuilder.AvailableOptionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.AvailableOptionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.AvailableOptionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.AvailableOptionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets the library options info.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AvailableOptionsRequestBuilderGetQueryParameters 
        {
            /// <summary>Whether this is a new library.</summary>
            [QueryParameter("isNewLibrary")]
            public bool? IsNewLibrary { get; set; }
            /// <summary>Library content type.</summary>
            [QueryParameter("libraryContentType")]
            public global::Jellyfin.Sdk.Generated.Libraries.AvailableOptions.CollectionType? LibraryContentType { get; set; }
        }
    }
}
#pragma warning restore CS0618
