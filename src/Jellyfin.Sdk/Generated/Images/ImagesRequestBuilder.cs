// <auto-generated/>
using Jellyfin.Sdk.Generated.Images.General;
using Jellyfin.Sdk.Generated.Images.MediaInfo;
using Jellyfin.Sdk.Generated.Images.Ratings;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Images {
    /// <summary>
    /// Builds and executes requests for operations under \Images
    /// </summary>
    public class ImagesRequestBuilder : BaseRequestBuilder {
        /// <summary>The General property</summary>
        public GeneralRequestBuilder General { get =>
            new GeneralRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MediaInfo property</summary>
        public MediaInfoRequestBuilder MediaInfo { get =>
            new MediaInfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Ratings property</summary>
        public RatingsRequestBuilder Ratings { get =>
            new RatingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ImagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Images", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ImagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImagesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Images", rawUrl) {
        }
    }
}
