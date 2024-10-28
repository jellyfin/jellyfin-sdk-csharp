// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.UserItems.Item;
using Jellyfin.Sdk.Generated.UserItems.Resume;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.UserItems
{
    /// <summary>
    /// Builds and executes requests for operations under \UserItems
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserItemsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Resume property</summary>
        public global::Jellyfin.Sdk.Generated.UserItems.Resume.ResumeRequestBuilder Resume
        {
            get => new global::Jellyfin.Sdk.Generated.UserItems.Resume.ResumeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.UserItems.item collection</summary>
        /// <param name="position">The item id.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.UserItems.Item.WithItemItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.UserItems.Item.WithItemItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("itemId", position);
                return new global::Jellyfin.Sdk.Generated.UserItems.Item.WithItemItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.UserItems.UserItemsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/UserItems", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.UserItems.UserItemsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/UserItems", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
