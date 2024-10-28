// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.Users.AuthenticateByName;
using Jellyfin.Sdk.Generated.Users.AuthenticateWithQuickConnect;
using Jellyfin.Sdk.Generated.Users.Configuration;
using Jellyfin.Sdk.Generated.Users.ForgotPassword;
using Jellyfin.Sdk.Generated.Users.Item;
using Jellyfin.Sdk.Generated.Users.Me;
using Jellyfin.Sdk.Generated.Users.New;
using Jellyfin.Sdk.Generated.Users.Password;
using Jellyfin.Sdk.Generated.Users.Public;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Users
{
    /// <summary>
    /// Builds and executes requests for operations under \Users
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UsersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The AuthenticateByName property</summary>
        public global::Jellyfin.Sdk.Generated.Users.AuthenticateByName.AuthenticateByNameRequestBuilder AuthenticateByName
        {
            get => new global::Jellyfin.Sdk.Generated.Users.AuthenticateByName.AuthenticateByNameRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The AuthenticateWithQuickConnect property</summary>
        public global::Jellyfin.Sdk.Generated.Users.AuthenticateWithQuickConnect.AuthenticateWithQuickConnectRequestBuilder AuthenticateWithQuickConnect
        {
            get => new global::Jellyfin.Sdk.Generated.Users.AuthenticateWithQuickConnect.AuthenticateWithQuickConnectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Configuration property</summary>
        public global::Jellyfin.Sdk.Generated.Users.Configuration.ConfigurationRequestBuilder Configuration
        {
            get => new global::Jellyfin.Sdk.Generated.Users.Configuration.ConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ForgotPassword property</summary>
        public global::Jellyfin.Sdk.Generated.Users.ForgotPassword.ForgotPasswordRequestBuilder ForgotPassword
        {
            get => new global::Jellyfin.Sdk.Generated.Users.ForgotPassword.ForgotPasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Me property</summary>
        public global::Jellyfin.Sdk.Generated.Users.Me.MeRequestBuilder Me
        {
            get => new global::Jellyfin.Sdk.Generated.Users.Me.MeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The New property</summary>
        public global::Jellyfin.Sdk.Generated.Users.New.NewRequestBuilder New
        {
            get => new global::Jellyfin.Sdk.Generated.Users.New.NewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Password property</summary>
        public global::Jellyfin.Sdk.Generated.Users.Password.PasswordRequestBuilder Password
        {
            get => new global::Jellyfin.Sdk.Generated.Users.Password.PasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Public property</summary>
        public global::Jellyfin.Sdk.Generated.Users.Public.PublicRequestBuilder Public
        {
            get => new global::Jellyfin.Sdk.Generated.Users.Public.PublicRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Users.item collection</summary>
        /// <param name="position">The user id.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Users.Item.WithUserItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.Users.Item.WithUserItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("userId", position);
                return new global::Jellyfin.Sdk.Generated.Users.Item.WithUserItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users{?isDisabled*,isHidden*,userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users{?isDisabled*,isHidden*,userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets a list of users.
        /// </summary>
        /// <returns>A List&lt;global::Jellyfin.Sdk.Generated.Models.UserDto&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Jellyfin.Sdk.Generated.Models.UserDto>?> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Jellyfin.Sdk.Generated.Models.UserDto>> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Jellyfin.Sdk.Generated.Models.UserDto>(requestInfo, global::Jellyfin.Sdk.Generated.Models.UserDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Updates a user.
        /// </summary>
        /// <param name="body">Class UserDto.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Jellyfin.Sdk.Generated.Models.ProblemDetails">When receiving a 400 status code</exception>
        /// <exception cref="global::Jellyfin.Sdk.Generated.Models.ProblemDetails">When receiving a 403 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::Jellyfin.Sdk.Generated.Models.UserDto body, Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder.UsersRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::Jellyfin.Sdk.Generated.Models.UserDto body, Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder.UsersRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Jellyfin.Sdk.Generated.Models.ProblemDetails.CreateFromDiscriminatorValue },
                { "403", global::Jellyfin.Sdk.Generated.Models.ProblemDetails.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a list of users.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Updates a user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Class UserDto.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Jellyfin.Sdk.Generated.Models.UserDto body, Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder.UsersRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Jellyfin.Sdk.Generated.Models.UserDto body, Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder.UsersRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Users.UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets a list of users.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UsersRequestBuilderGetQueryParameters 
        {
            /// <summary>Optional filter by IsDisabled=true or false.</summary>
            [QueryParameter("isDisabled")]
            public bool? IsDisabled { get; set; }
            /// <summary>Optional filter by IsHidden=true or false.</summary>
            [QueryParameter("isHidden")]
            public bool? IsHidden { get; set; }
        }
        /// <summary>
        /// Updates a user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UsersRequestBuilderPostQueryParameters 
        {
            /// <summary>The user id.</summary>
            [QueryParameter("userId")]
            public Guid? UserId { get; set; }
        }
    }
}
#pragma warning restore CS0618
