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
namespace Jellyfin.Sdk.Generated.Items.Item.Intros
{
    /// <summary>
    /// Builds and executes requests for operations under \Items\{itemId}\Intros
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IntrosRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.Item.Intros.IntrosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IntrosRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Intros{?userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.Item.Intros.IntrosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IntrosRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Intros{?userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets intros to play before the main media item plays.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Items.Item.Intros.IntrosRequestBuilder.IntrosRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Items.Item.Intros.IntrosRequestBuilder.IntrosRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult>(requestInfo, global::Jellyfin.Sdk.Generated.Models.BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets intros to play before the main media item plays.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Items.Item.Intros.IntrosRequestBuilder.IntrosRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Items.Item.Intros.IntrosRequestBuilder.IntrosRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Items.Item.Intros.IntrosRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Items.Item.Intros.IntrosRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Items.Item.Intros.IntrosRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets intros to play before the main media item plays.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IntrosRequestBuilderGetQueryParameters 
        {
            /// <summary>User id.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
#pragma warning restore CS0618
