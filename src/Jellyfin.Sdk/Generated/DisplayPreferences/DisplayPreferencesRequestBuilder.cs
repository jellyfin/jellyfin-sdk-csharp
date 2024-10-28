// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.DisplayPreferences.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.DisplayPreferences
{
    /// <summary>
    /// Builds and executes requests for operations under \DisplayPreferences
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DisplayPreferencesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.DisplayPreferences.item collection</summary>
        /// <param name="position">Display preferences id.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.DisplayPreferences.Item.WithDisplayPreferencesItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.DisplayPreferences.Item.WithDisplayPreferencesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("displayPreferencesId", position);
                return new global::Jellyfin.Sdk.Generated.DisplayPreferences.Item.WithDisplayPreferencesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.DisplayPreferences.DisplayPreferencesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DisplayPreferencesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/DisplayPreferences", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.DisplayPreferences.DisplayPreferencesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DisplayPreferencesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/DisplayPreferences", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
