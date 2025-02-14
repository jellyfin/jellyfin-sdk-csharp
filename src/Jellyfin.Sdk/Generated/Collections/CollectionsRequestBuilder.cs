// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Collections.Item;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Collections
{
    /// <summary>
    /// Builds and executes requests for operations under \Collections
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CollectionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Collections.item collection</summary>
        /// <param name="position">The collection id.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Collections.Item.WithCollectionItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.Collections.Item.WithCollectionItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("collectionId", position);
                return new global::Jellyfin.Sdk.Generated.Collections.Item.WithCollectionItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Collections.CollectionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CollectionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Collections{?ids*,isLocked*,name*,parentId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Collections.CollectionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CollectionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Collections{?ids*,isLocked*,name*,parentId*}", rawUrl)
        {
        }
        /// <summary>
        /// Creates a new collection.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.CollectionCreationResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Jellyfin.Sdk.Generated.Models.CollectionCreationResult?> PostAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Jellyfin.Sdk.Generated.Models.CollectionCreationResult> PostAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Jellyfin.Sdk.Generated.Models.CollectionCreationResult>(requestInfo, global::Jellyfin.Sdk.Generated.Models.CollectionCreationResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new collection.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Collections.CollectionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Collections.CollectionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Collections.CollectionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Creates a new collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CollectionsRequestBuilderPostQueryParameters 
        {
            /// <summary>Item Ids to add to the collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ids")]
            public string[]? Ids { get; set; }
#nullable restore
#else
            [QueryParameter("ids")]
            public string[] Ids { get; set; }
#endif
            /// <summary>Whether or not to lock the new collection.</summary>
            [QueryParameter("isLocked")]
            public bool? IsLocked { get; set; }
            /// <summary>The name of the collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
#endif
            /// <summary>Optional. Create the collection within a specific folder.</summary>
            [QueryParameter("parentId")]
            public Guid? ParentId { get; set; }
        }
    }
}
#pragma warning restore CS0618
