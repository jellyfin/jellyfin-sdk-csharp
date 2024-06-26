// <auto-generated/>
using Jellyfin.Sdk.Generated.Search.Hints;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Search {
    /// <summary>
    /// Builds and executes requests for operations under \Search
    /// </summary>
    public class SearchRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The Hints property</summary>
        public HintsRequestBuilder Hints
        {
            get => new HintsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Search", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Search", rawUrl)
        {
        }
    }
}
