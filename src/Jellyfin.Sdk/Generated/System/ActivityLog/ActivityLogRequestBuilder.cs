// <auto-generated/>
using Jellyfin.Sdk.Generated.System.ActivityLog.Entries;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.System.ActivityLog {
    /// <summary>
    /// Builds and executes requests for operations under \System\ActivityLog
    /// </summary>
    public class ActivityLogRequestBuilder : BaseRequestBuilder {
        /// <summary>The Entries property</summary>
        public EntriesRequestBuilder Entries { get =>
            new EntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ActivityLogRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActivityLogRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/System/ActivityLog", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ActivityLogRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActivityLogRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/System/ActivityLog", rawUrl) {
        }
    }
}