// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Sessions.Item.User.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Sessions.Item.User
{
    /// <summary>
    /// Builds and executes requests for operations under \Sessions\{sessionId}\User
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Sessions.item.User.item collection</summary>
        /// <param name="position">The user id.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Sessions.Item.User.Item.WithUserItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.Sessions.Item.User.Item.WithUserItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("userId", position);
                return new global::Jellyfin.Sdk.Generated.Sessions.Item.User.Item.WithUserItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Sessions.Item.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sessions/{sessionId}/User", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Sessions.Item.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sessions/{sessionId}/User", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
