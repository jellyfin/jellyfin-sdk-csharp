// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Videos.Item.Item.Subtitles.Item.StreamWithRouteFormat {
    /// <summary>
    /// Builds and executes requests for operations under \Videos\{routeItemId}\{routeMediaSourceId}\Subtitles\{Subtitles-id}\Stream.{routeFormat}
    /// </summary>
    public class StreamWithRouteFormatRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new StreamWithRouteFormatRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="routeFormat">The (route) format of the returned subtitle.</param>
        public StreamWithRouteFormatRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string routeFormat = "") : base(requestAdapter, "{+baseurl}/Videos/{routeItemId}/{routeMediaSourceId}/Subtitles/{Subtitles%2Did}/Stream.{routeFormat}{?addVttTimeMap*,copyTimestamps*,endPositionTicks*,format*,index*,itemId*,mediaSourceId*,startPositionTicks*}", pathParameters) {
            if (!string.IsNullOrWhiteSpace(routeFormat)) PathParameters.Add("routeFormat", routeFormat);
        }
        /// <summary>
        /// Instantiates a new StreamWithRouteFormatRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StreamWithRouteFormatRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Videos/{routeItemId}/{routeMediaSourceId}/Subtitles/{Subtitles%2Did}/Stream.{routeFormat}{?addVttTimeMap*,copyTimestamps*,endPositionTicks*,format*,index*,itemId*,mediaSourceId*,startPositionTicks*}", rawUrl) {
        }
        /// <summary>
        /// Gets subtitles in a specified format.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<StreamWithRouteFormatRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<StreamWithRouteFormatRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets subtitles in a specified format.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StreamWithRouteFormatRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StreamWithRouteFormatRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "text/*");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public StreamWithRouteFormatRequestBuilder WithUrl(string rawUrl) {
            return new StreamWithRouteFormatRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets subtitles in a specified format.
        /// </summary>
        public class StreamWithRouteFormatRequestBuilderGetQueryParameters {
            /// <summary>Optional. Whether to add a VTT time map.</summary>
            [QueryParameter("addVttTimeMap")]
            public bool? AddVttTimeMap { get; set; }
            /// <summary>Optional. Whether to copy the timestamps.</summary>
            [QueryParameter("copyTimestamps")]
            public bool? CopyTimestamps { get; set; }
            /// <summary>Optional. The end position of the subtitle in ticks.</summary>
            [QueryParameter("endPositionTicks")]
            public long? EndPositionTicks { get; set; }
            /// <summary>The format of the returned subtitle.</summary>
            [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("format")]
            public string? Format { get; set; }
#nullable restore
#else
            [QueryParameter("format")]
            public string Format { get; set; }
#endif
            /// <summary>The subtitle stream index.</summary>
            [Obsolete("")]
            [QueryParameter("index")]
            public int? Index { get; set; }
            /// <summary>The item id.</summary>
            [Obsolete("")]
            [QueryParameter("itemId")]
            public Guid? ItemId { get; set; }
            /// <summary>The media source id.</summary>
            [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("mediaSourceId")]
            public string? MediaSourceId { get; set; }
#nullable restore
#else
            [QueryParameter("mediaSourceId")]
            public string MediaSourceId { get; set; }
#endif
            /// <summary>The start position of the subtitle in ticks.</summary>
            [QueryParameter("startPositionTicks")]
            public long? StartPositionTicks { get; set; }
        }
    }
}
