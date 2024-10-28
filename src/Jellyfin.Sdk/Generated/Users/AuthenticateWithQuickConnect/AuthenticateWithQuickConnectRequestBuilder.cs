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
namespace Jellyfin.Sdk.Generated.Users.AuthenticateWithQuickConnect
{
    /// <summary>
    /// Builds and executes requests for operations under \Users\AuthenticateWithQuickConnect
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AuthenticateWithQuickConnectRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Users.AuthenticateWithQuickConnect.AuthenticateWithQuickConnectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticateWithQuickConnectRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/AuthenticateWithQuickConnect", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Users.AuthenticateWithQuickConnect.AuthenticateWithQuickConnectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticateWithQuickConnectRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/AuthenticateWithQuickConnect", rawUrl)
        {
        }
        /// <summary>
        /// Authenticates a user with quick connect.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.AuthenticationResult"/></returns>
        /// <param name="body">The quick connect request body.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Jellyfin.Sdk.Generated.Models.AuthenticationResult?> PostAsync(global::Jellyfin.Sdk.Generated.Models.QuickConnectDto body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Jellyfin.Sdk.Generated.Models.AuthenticationResult> PostAsync(global::Jellyfin.Sdk.Generated.Models.QuickConnectDto body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Jellyfin.Sdk.Generated.Models.AuthenticationResult>(requestInfo, global::Jellyfin.Sdk.Generated.Models.AuthenticationResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Authenticates a user with quick connect.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The quick connect request body.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Jellyfin.Sdk.Generated.Models.QuickConnectDto body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Jellyfin.Sdk.Generated.Models.QuickConnectDto body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
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
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Users.AuthenticateWithQuickConnect.AuthenticateWithQuickConnectRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Users.AuthenticateWithQuickConnect.AuthenticateWithQuickConnectRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Users.AuthenticateWithQuickConnect.AuthenticateWithQuickConnectRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
