// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.LiveTv.LiveStreamFiles.Item.StreamWithContainer;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.LiveTv.LiveStreamFiles.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \LiveTv\LiveStreamFiles\{streamId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithStreamItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.LiveTv.LiveStreamFiles.Item.WithStreamItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStreamItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/LiveStreamFiles/{streamId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.LiveTv.LiveStreamFiles.Item.WithStreamItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStreamItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/LiveStreamFiles/{streamId}", rawUrl)
        {
        }
        /// <summary>
        /// Builds and executes requests for operations under \LiveTv\LiveStreamFiles\{streamId}\stream.{container}
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.LiveTv.LiveStreamFiles.Item.StreamWithContainer.StreamWithContainerRequestBuilder"/></returns>
        /// <param name="container">Container type.</param>
        public global::Jellyfin.Sdk.Generated.LiveTv.LiveStreamFiles.Item.StreamWithContainer.StreamWithContainerRequestBuilder StreamWithContainer(string container)
        {
            if(string.IsNullOrEmpty(container)) throw new ArgumentNullException(nameof(container));
            return new global::Jellyfin.Sdk.Generated.LiveTv.LiveStreamFiles.Item.StreamWithContainer.StreamWithContainerRequestBuilder(PathParameters, RequestAdapter, container);
        }
    }
}
#pragma warning restore CS0618
