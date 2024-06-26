// <auto-generated/>
using Jellyfin.Sdk.Generated.Library.Series.Added;
using Jellyfin.Sdk.Generated.Library.Series.Updated;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Library.Series {
    /// <summary>
    /// Builds and executes requests for operations under \Library\Series
    /// </summary>
    public class SeriesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The Added property</summary>
        public AddedRequestBuilder Added
        {
            get => new AddedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Updated property</summary>
        public UpdatedRequestBuilder Updated
        {
            get => new UpdatedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SeriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SeriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Library/Series", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SeriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SeriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Library/Series", rawUrl)
        {
        }
    }
}
