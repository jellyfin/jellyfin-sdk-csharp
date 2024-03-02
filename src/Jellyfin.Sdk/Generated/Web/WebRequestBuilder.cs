// <auto-generated/>
using Jellyfin.Sdk.Generated.Web.ConfigurationPage;
using Jellyfin.Sdk.Generated.Web.ConfigurationPages;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Web {
    /// <summary>
    /// Builds and executes requests for operations under \web
    /// </summary>
    public class WebRequestBuilder : BaseRequestBuilder {
        /// <summary>The ConfigurationPage property</summary>
        public ConfigurationPageRequestBuilder ConfigurationPage { get =>
            new ConfigurationPageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ConfigurationPages property</summary>
        public ConfigurationPagesRequestBuilder ConfigurationPages { get =>
            new ConfigurationPagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WebRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/web", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WebRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/web", rawUrl) {
        }
    }
}
