// <auto-generated/>
using Jellyfin.Sdk.Generated.EnvironmentNamespace.DefaultDirectoryBrowser;
using Jellyfin.Sdk.Generated.EnvironmentNamespace.DirectoryContents;
using Jellyfin.Sdk.Generated.EnvironmentNamespace.Drives;
using Jellyfin.Sdk.Generated.EnvironmentNamespace.NetworkShares;
using Jellyfin.Sdk.Generated.EnvironmentNamespace.ParentPath;
using Jellyfin.Sdk.Generated.EnvironmentNamespace.ValidatePath;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.EnvironmentNamespace {
    /// <summary>
    /// Builds and executes requests for operations under \Environment
    /// </summary>
    public class EnvironmentRequestBuilder : BaseRequestBuilder {
        /// <summary>The DefaultDirectoryBrowser property</summary>
        public DefaultDirectoryBrowserRequestBuilder DefaultDirectoryBrowser { get =>
            new DefaultDirectoryBrowserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The DirectoryContents property</summary>
        public DirectoryContentsRequestBuilder DirectoryContents { get =>
            new DirectoryContentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Drives property</summary>
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The NetworkShares property</summary>
        public NetworkSharesRequestBuilder NetworkShares { get =>
            new NetworkSharesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ParentPath property</summary>
        public ParentPathRequestBuilder ParentPath { get =>
            new ParentPathRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ValidatePath property</summary>
        public ValidatePathRequestBuilder ValidatePath { get =>
            new ValidatePathRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="EnvironmentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EnvironmentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Environment", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="EnvironmentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EnvironmentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Environment", rawUrl) {
        }
    }
}
