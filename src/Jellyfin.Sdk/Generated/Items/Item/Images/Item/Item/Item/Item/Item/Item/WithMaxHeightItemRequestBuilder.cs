// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.Item.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \Items\{itemId}\Images\{imageType}\{imageIndex}\{tag}\{format}\{maxWidth}\{maxHeight}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithMaxHeightItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Items.item.Images.item.item.item.item.item.item.item collection</summary>
        /// <param name="position">Optional. Percent to render for the percent played overlay.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.Item.Item.WithPercentPlayedItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.Item.Item.WithPercentPlayedItemRequestBuilder this[double position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("percentPlayed", position);
                return new global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.Item.Item.WithPercentPlayedItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.Item.WithMaxHeightItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMaxHeightItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}/{format}/{maxWidth}/{maxHeight}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.Item.Images.Item.Item.Item.Item.Item.Item.WithMaxHeightItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMaxHeightItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/{itemId}/Images/{imageType}/{imageIndex}/{tag}/{format}/{maxWidth}/{maxHeight}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
