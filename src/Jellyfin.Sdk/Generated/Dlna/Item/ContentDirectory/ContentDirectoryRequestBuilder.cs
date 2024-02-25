// <auto-generated/>
using Jellyfin.Sdk.Generated.Dlna.Item.ContentDirectory.ContentDirectoryXml;
using Jellyfin.Sdk.Generated.Dlna.Item.ContentDirectory.Control;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Dlna.Item.ContentDirectory {
    /// <summary>
    /// Builds and executes requests for operations under \Dlna\{serverId}\ContentDirectory
    /// </summary>
    public class ContentDirectoryRequestBuilder : BaseRequestBuilder {
        /// <summary>The ContentDirectory property</summary>
        public ContentDirectoryRequestBuilder ContentDirectory { get =>
            new ContentDirectoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ContentDirectoryXml property</summary>
        public ContentDirectoryXmlRequestBuilder ContentDirectoryXml { get =>
            new ContentDirectoryXmlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Control property</summary>
        public ControlRequestBuilder Control { get =>
            new ControlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ContentDirectoryRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContentDirectoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Dlna/{serverId}/ContentDirectory", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ContentDirectoryRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContentDirectoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Dlna/{serverId}/ContentDirectory", rawUrl) {
        }
        /// <summary>
        /// Gets Dlna content directory xml.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets Dlna content directory xml.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "text/xml");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ContentDirectoryRequestBuilder WithUrl(string rawUrl) {
            return new ContentDirectoryRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
