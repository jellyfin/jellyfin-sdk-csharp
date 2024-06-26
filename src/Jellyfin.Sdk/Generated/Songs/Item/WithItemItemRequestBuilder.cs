// <auto-generated/>
using Jellyfin.Sdk.Generated.Songs.Item.InstantMix;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Songs.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Songs\{itemId}
    /// </summary>
    public class WithItemItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The InstantMix property</summary>
        public InstantMixRequestBuilder InstantMix
        {
            get => new InstantMixRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Songs/{itemId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithItemItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Songs/{itemId}", rawUrl)
        {
        }
    }
}
