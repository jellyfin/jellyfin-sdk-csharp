// <auto-generated/>
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.Users.ForgotPassword.Pin;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Users.ForgotPassword {
    /// <summary>
    /// Builds and executes requests for operations under \Users\ForgotPassword
    /// </summary>
    public class ForgotPasswordRequestBuilder : BaseRequestBuilder {
        /// <summary>The Pin property</summary>
        public PinRequestBuilder Pin { get =>
            new PinRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ForgotPasswordRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ForgotPasswordRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/ForgotPassword", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ForgotPasswordRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ForgotPasswordRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/ForgotPassword", rawUrl) {
        }
        /// <summary>
        /// Initiates the forgot password process for a local user.
        /// </summary>
        /// <param name="body">Forgot Password request body DTO.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ForgotPasswordResult?> PostAsync(ForgotPasswordDto body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ForgotPasswordResult> PostAsync(ForgotPasswordDto body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ForgotPasswordResult>(requestInfo, ForgotPasswordResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Initiates the forgot password process for a local user.
        /// </summary>
        /// <param name="body">Forgot Password request body DTO.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ForgotPasswordDto body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ForgotPasswordDto body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ForgotPasswordRequestBuilder WithUrl(string rawUrl) {
            return new ForgotPasswordRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
