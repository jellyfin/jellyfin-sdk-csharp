// <auto-generated/>
using Jellyfin.Sdk.Generated.Videos.Item.Item.Attachments.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Videos.Item.Item.Attachments {
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{Videos-id}\{ItemId-id}\Attachments
    /// </summary>
    public class AttachmentsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Videos.item.item.Attachments.item collection</summary>
        /// <param name="position">Attachment Index.</param>
        public WithIndexItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("index", position);
            return new WithIndexItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AttachmentsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttachmentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{Videos%2Did}/{ItemId%2Did}/Attachments", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AttachmentsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttachmentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{Videos%2Did}/{ItemId%2Did}/Attachments", rawUrl) {
        }
    }
}
