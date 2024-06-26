// <auto-generated/>
using Jellyfin.Sdk.Generated.LiveTv.Tuners.Discover;
using Jellyfin.Sdk.Generated.LiveTv.Tuners.Discvover;
using Jellyfin.Sdk.Generated.LiveTv.Tuners.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.LiveTv.Tuners {
    /// <summary>
    /// Builds and executes requests for operations under \LiveTv\Tuners
    /// </summary>
    public class TunersRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The Discover property</summary>
        public DiscoverRequestBuilder Discover
        {
            get => new DiscoverRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Discvover property</summary>
        public DiscvoverRequestBuilder Discvover
        {
            get => new DiscvoverRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.LiveTv.Tuners.item collection</summary>
        /// <param name="position">Tuner id.</param>
        /// <returns>A <see cref="WithTunerItemRequestBuilder"/></returns>
        public WithTunerItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("tunerId", position);
                return new WithTunerItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="TunersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TunersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/Tuners", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="TunersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TunersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/Tuners", rawUrl)
        {
        }
    }
}
