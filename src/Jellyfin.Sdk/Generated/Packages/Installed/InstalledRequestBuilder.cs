// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Packages.Installed.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Packages.Installed
{
    /// <summary>
    /// Builds and executes requests for operations under \Packages\Installed
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class InstalledRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Packages.Installed.item collection</summary>
        /// <param name="position">Package name.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Packages.Installed.Item.WithNameItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.Packages.Installed.Item.WithNameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("name", position);
                return new global::Jellyfin.Sdk.Generated.Packages.Installed.Item.WithNameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Packages.Installed.InstalledRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstalledRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Packages/Installed", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Packages.Installed.InstalledRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstalledRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Packages/Installed", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
