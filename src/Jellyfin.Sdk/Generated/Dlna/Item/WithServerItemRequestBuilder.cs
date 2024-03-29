// <auto-generated/>
using Jellyfin.Sdk.Generated.Dlna.Item.ConnectionManager;
using Jellyfin.Sdk.Generated.Dlna.Item.ContentDirectory;
using Jellyfin.Sdk.Generated.Dlna.Item.Description;
using Jellyfin.Sdk.Generated.Dlna.Item.DescriptionXml;
using Jellyfin.Sdk.Generated.Dlna.Item.Icons;
using Jellyfin.Sdk.Generated.Dlna.Item.MediaReceiverRegistrar;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Dlna.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Dlna\{serverId}
    /// </summary>
    public class WithServerItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The ConnectionManager property</summary>
        public ConnectionManagerRequestBuilder ConnectionManager { get =>
            new ConnectionManagerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ContentDirectory property</summary>
        public ContentDirectoryRequestBuilder ContentDirectory { get =>
            new ContentDirectoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The description property</summary>
        public DescriptionRequestBuilder Description { get =>
            new DescriptionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The descriptionXml property</summary>
        public DescriptionXmlRequestBuilder DescriptionXml { get =>
            new DescriptionXmlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The icons property</summary>
        public IconsRequestBuilder Icons { get =>
            new IconsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MediaReceiverRegistrar property</summary>
        public MediaReceiverRegistrarRequestBuilder MediaReceiverRegistrar { get =>
            new MediaReceiverRegistrarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithServerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithServerItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Dlna/{serverId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithServerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithServerItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Dlna/{serverId}", rawUrl) {
        }
    }
}
