// <auto-generated/>
using Jellyfin.Sdk.Generated.QuickConnect.Authorize;
using Jellyfin.Sdk.Generated.QuickConnect.Connect;
using Jellyfin.Sdk.Generated.QuickConnect.Enabled;
using Jellyfin.Sdk.Generated.QuickConnect.Initiate;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.QuickConnect {
    /// <summary>
    /// Builds and executes requests for operations under \QuickConnect
    /// </summary>
    public class QuickConnectRequestBuilder : BaseRequestBuilder {
        /// <summary>The Authorize property</summary>
        public AuthorizeRequestBuilder Authorize { get =>
            new AuthorizeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Connect property</summary>
        public ConnectRequestBuilder Connect { get =>
            new ConnectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Enabled property</summary>
        public EnabledRequestBuilder Enabled { get =>
            new EnabledRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Initiate property</summary>
        public InitiateRequestBuilder Initiate { get =>
            new InitiateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="QuickConnectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public QuickConnectRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/QuickConnect", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="QuickConnectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public QuickConnectRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/QuickConnect", rawUrl) {
        }
    }
}
