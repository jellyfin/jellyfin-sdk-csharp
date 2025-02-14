// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Startup.Complete;
using Jellyfin.Sdk.Generated.Startup.Configuration;
using Jellyfin.Sdk.Generated.Startup.FirstUser;
using Jellyfin.Sdk.Generated.Startup.RemoteAccess;
using Jellyfin.Sdk.Generated.Startup.User;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Startup
{
    /// <summary>
    /// Builds and executes requests for operations under \Startup
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StartupRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Complete property</summary>
        public global::Jellyfin.Sdk.Generated.Startup.Complete.CompleteRequestBuilder Complete
        {
            get => new global::Jellyfin.Sdk.Generated.Startup.Complete.CompleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Configuration property</summary>
        public global::Jellyfin.Sdk.Generated.Startup.Configuration.ConfigurationRequestBuilder Configuration
        {
            get => new global::Jellyfin.Sdk.Generated.Startup.Configuration.ConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The FirstUser property</summary>
        public global::Jellyfin.Sdk.Generated.Startup.FirstUser.FirstUserRequestBuilder FirstUser
        {
            get => new global::Jellyfin.Sdk.Generated.Startup.FirstUser.FirstUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The RemoteAccess property</summary>
        public global::Jellyfin.Sdk.Generated.Startup.RemoteAccess.RemoteAccessRequestBuilder RemoteAccess
        {
            get => new global::Jellyfin.Sdk.Generated.Startup.RemoteAccess.RemoteAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The User property</summary>
        public global::Jellyfin.Sdk.Generated.Startup.User.UserRequestBuilder User
        {
            get => new global::Jellyfin.Sdk.Generated.Startup.User.UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Startup.StartupRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StartupRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Startup", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Startup.StartupRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StartupRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Startup", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
