// <auto-generated/>
using Jellyfin.Sdk.Generated.Library.Media.Updated;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Library.Media {
    /// <summary>
    /// Builds and executes requests for operations under \Library\Media
    /// </summary>
    public class MediaRequestBuilder : BaseRequestBuilder {
        /// <summary>The Updated property</summary>
        public UpdatedRequestBuilder Updated { get =>
            new UpdatedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="MediaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MediaRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Library/Media", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="MediaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MediaRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Library/Media", rawUrl) {
        }
    }
}
