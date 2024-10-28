// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.Update;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths
{
    /// <summary>
    /// Builds and executes requests for operations under \Library\VirtualFolders\Paths
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PathsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Update property</summary>
        public global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.Update.UpdateRequestBuilder Update
        {
            get => new global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.Update.UpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PathsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Library/VirtualFolders/Paths{?name*,path*,refreshLibrary*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PathsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Library/VirtualFolders/Paths{?name*,path*,refreshLibrary*}", rawUrl)
        {
        }
        /// <summary>
        /// Remove a media path.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder.PathsRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder.PathsRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Add a media path to a library.
        /// </summary>
        /// <param name="body">Media Path dto.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::Jellyfin.Sdk.Generated.Models.MediaPathDto body, Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder.PathsRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::Jellyfin.Sdk.Generated.Models.MediaPathDto body, Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder.PathsRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Remove a media path.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder.PathsRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder.PathsRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Add a media path to a library.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Media Path dto.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Jellyfin.Sdk.Generated.Models.MediaPathDto body, Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder.PathsRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Jellyfin.Sdk.Generated.Models.MediaPathDto body, Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder.PathsRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Library.VirtualFolders.Paths.PathsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Remove a media path.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PathsRequestBuilderDeleteQueryParameters 
        {
            /// <summary>The name of the library.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
#endif
            /// <summary>The path to remove.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("path")]
            public string? Path { get; set; }
#nullable restore
#else
            [QueryParameter("path")]
            public string Path { get; set; }
#endif
            /// <summary>Whether to refresh the library.</summary>
            [QueryParameter("refreshLibrary")]
            public bool? RefreshLibrary { get; set; }
        }
        /// <summary>
        /// Add a media path to a library.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PathsRequestBuilderPostQueryParameters 
        {
            /// <summary>Whether to refresh the library.</summary>
            [QueryParameter("refreshLibrary")]
            public bool? RefreshLibrary { get; set; }
        }
    }
}
#pragma warning restore CS0618
