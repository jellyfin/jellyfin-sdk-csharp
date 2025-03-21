// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.LiveTv.LiveRecordings.Item.StreamNamespace;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.LiveTv.LiveRecordings.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \LiveTv\LiveRecordings\{recordingId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithRecordingItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The stream property</summary>
        public global::Jellyfin.Sdk.Generated.LiveTv.LiveRecordings.Item.StreamNamespace.StreamRequestBuilder Stream
        {
            get => new global::Jellyfin.Sdk.Generated.LiveTv.LiveRecordings.Item.StreamNamespace.StreamRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.LiveTv.LiveRecordings.Item.WithRecordingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRecordingItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/LiveRecordings/{recordingId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.LiveTv.LiveRecordings.Item.WithRecordingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRecordingItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/LiveRecordings/{recordingId}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
