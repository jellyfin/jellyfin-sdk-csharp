// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \Items\{itemId}\Images\{imageType}\{imageIndex}\{tag}\{format}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithFormatItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Items.item.Images.item.item.item.item.item collection</summary>
        /// <param name="position">The maximum image width to return.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.WithMaxWidthItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.WithMaxWidthItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("maxWidth", position);
                return new global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.WithMaxWidthItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.WithFormatItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFormatItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}/{format}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.WithFormatItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFormatItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}/{format}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
