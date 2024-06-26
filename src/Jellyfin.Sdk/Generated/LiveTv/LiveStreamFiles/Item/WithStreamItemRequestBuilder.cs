// <auto-generated/>
using Jellyfin.Sdk.Generated.LiveTv.LiveStreamFiles.Item.StreamWithContainer;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.LiveTv.LiveStreamFiles.Item {
    /// <summary>
    /// Builds and executes requests for operations under \LiveTv\LiveStreamFiles\{streamId}
    /// </summary>
    public class WithStreamItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="WithStreamItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStreamItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/LiveStreamFiles/{streamId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithStreamItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStreamItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/LiveStreamFiles/{streamId}", rawUrl)
        {
        }
        /// <summary>
        /// Builds and executes requests for operations under \LiveTv\LiveStreamFiles\{streamId}\stream.{container}
        /// </summary>
        /// <returns>A <see cref="StreamWithContainerRequestBuilder"/></returns>
        /// <param name="container">Container type.</param>
        public StreamWithContainerRequestBuilder StreamWithContainer(string container)
        {
            if(string.IsNullOrEmpty(container)) throw new ArgumentNullException(nameof(container));
            return new StreamWithContainerRequestBuilder(PathParameters, RequestAdapter, container);
        }
    }
}
