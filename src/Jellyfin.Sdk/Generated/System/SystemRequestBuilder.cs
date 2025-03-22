// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.System.ActivityLog;
using Jellyfin.Sdk.Generated.System.Configuration;
using Jellyfin.Sdk.Generated.System.Endpoint;
using Jellyfin.Sdk.Generated.System.Info;
using Jellyfin.Sdk.Generated.System.Logs;
using Jellyfin.Sdk.Generated.System.Ping;
using Jellyfin.Sdk.Generated.System.Restart;
using Jellyfin.Sdk.Generated.System.Shutdown;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.System
{
    /// <summary>
    /// Builds and executes requests for operations under \System
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SystemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ActivityLog property</summary>
        public global::Jellyfin.Sdk.Generated.System.ActivityLog.ActivityLogRequestBuilder ActivityLog
        {
            get => new global::Jellyfin.Sdk.Generated.System.ActivityLog.ActivityLogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Configuration property</summary>
        public global::Jellyfin.Sdk.Generated.System.Configuration.ConfigurationRequestBuilder Configuration
        {
            get => new global::Jellyfin.Sdk.Generated.System.Configuration.ConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Endpoint property</summary>
        public global::Jellyfin.Sdk.Generated.System.Endpoint.EndpointRequestBuilder Endpoint
        {
            get => new global::Jellyfin.Sdk.Generated.System.Endpoint.EndpointRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Info property</summary>
        public global::Jellyfin.Sdk.Generated.System.Info.InfoRequestBuilder Info
        {
            get => new global::Jellyfin.Sdk.Generated.System.Info.InfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Logs property</summary>
        public global::Jellyfin.Sdk.Generated.System.Logs.LogsRequestBuilder Logs
        {
            get => new global::Jellyfin.Sdk.Generated.System.Logs.LogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Ping property</summary>
        public global::Jellyfin.Sdk.Generated.System.Ping.PingRequestBuilder Ping
        {
            get => new global::Jellyfin.Sdk.Generated.System.Ping.PingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Restart property</summary>
        public global::Jellyfin.Sdk.Generated.System.Restart.RestartRequestBuilder Restart
        {
            get => new global::Jellyfin.Sdk.Generated.System.Restart.RestartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Shutdown property</summary>
        public global::Jellyfin.Sdk.Generated.System.Shutdown.ShutdownRequestBuilder Shutdown
        {
            get => new global::Jellyfin.Sdk.Generated.System.Shutdown.ShutdownRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.System.SystemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SystemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/System", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.System.SystemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SystemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/System", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
