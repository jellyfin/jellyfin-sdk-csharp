// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicArtist
{
    /// <summary>
    /// Builds and executes requests for operations under \Items\RemoteSearch\MusicArtist
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MusicArtistRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicArtist.MusicArtistRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MusicArtistRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/RemoteSearch/MusicArtist", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicArtist.MusicArtistRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MusicArtistRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/RemoteSearch/MusicArtist", rawUrl)
        {
        }
        /// <summary>
        /// Get music artist remote search.
        /// </summary>
        /// <returns>A List&lt;global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult&gt;</returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult>?> PostAsync(global::Jellyfin.Sdk.Generated.Models.ArtistInfoRemoteSearchQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult>> PostAsync(global::Jellyfin.Sdk.Generated.Models.ArtistInfoRemoteSearchQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult>(requestInfo, global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Get music artist remote search.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Jellyfin.Sdk.Generated.Models.ArtistInfoRemoteSearchQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Jellyfin.Sdk.Generated.Models.ArtistInfoRemoteSearchQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicArtist.MusicArtistRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicArtist.MusicArtistRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicArtist.MusicArtistRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
