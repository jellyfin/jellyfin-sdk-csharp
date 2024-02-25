// <auto-generated/>
using Jellyfin.Sdk.Generated.Users.Item.PlayingItems.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Users.Item.PlayingItems {
    /// <summary>
    /// Builds and executes requests for operations under \Users\{userId}\PlayingItems
    /// </summary>
    public class PlayingItemsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Users.item.PlayingItems.item collection</summary>
        /// <param name="position">Item id.</param>
        public WithItemItemRequestBuilder this[Guid position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("itemId", position);
            return new WithItemItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new PlayingItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlayingItemsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/{userId}/PlayingItems", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PlayingItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlayingItemsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/{userId}/PlayingItems", rawUrl) {
        }
    }
}
