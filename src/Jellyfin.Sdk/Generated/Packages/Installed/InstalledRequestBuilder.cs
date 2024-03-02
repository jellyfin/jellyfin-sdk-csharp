// <auto-generated/>
using Jellyfin.Sdk.Generated.Packages.Installed.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Packages.Installed {
    /// <summary>
    /// Builds and executes requests for operations under \Packages\Installed
    /// </summary>
    public class InstalledRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Packages.Installed.item collection</summary>
        /// <param name="position">Package name.</param>
        /// <returns>A <see cref="WithNameItemRequestBuilder"/></returns>
        public WithNameItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("name", position);
            return new WithNameItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="InstalledRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstalledRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Packages/Installed", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="InstalledRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstalledRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Packages/Installed", rawUrl) {
        }
    }
}
