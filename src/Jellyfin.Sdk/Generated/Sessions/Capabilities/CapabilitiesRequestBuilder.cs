// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.Sessions.Capabilities.Full;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Sessions.Capabilities
{
    /// <summary>
    /// Builds and executes requests for operations under \Sessions\Capabilities
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CapabilitiesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Full property</summary>
        public global::Jellyfin.Sdk.Generated.Sessions.Capabilities.Full.FullRequestBuilder Full
        {
            get => new global::Jellyfin.Sdk.Generated.Sessions.Capabilities.Full.FullRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Sessions.Capabilities.CapabilitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CapabilitiesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sessions/Capabilities{?id*,playableMediaTypes*,supportedCommands*,supportsMediaControl*,supportsPersistentIdentifier*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Sessions.Capabilities.CapabilitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CapabilitiesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sessions/Capabilities{?id*,playableMediaTypes*,supportedCommands*,supportsMediaControl*,supportsPersistentIdentifier*}", rawUrl)
        {
        }
        /// <summary>
        /// Updates capabilities for a device.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Sessions.Capabilities.CapabilitiesRequestBuilder.CapabilitiesRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Sessions.Capabilities.CapabilitiesRequestBuilder.CapabilitiesRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates capabilities for a device.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Sessions.Capabilities.CapabilitiesRequestBuilder.CapabilitiesRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.Sessions.Capabilities.CapabilitiesRequestBuilder.CapabilitiesRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Sessions.Capabilities.CapabilitiesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.Sessions.Capabilities.CapabilitiesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.Sessions.Capabilities.CapabilitiesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Updates capabilities for a device.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CapabilitiesRequestBuilderPostQueryParameters 
        {
            /// <summary>The session id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("id")]
            public string? Id { get; set; }
#nullable restore
#else
            [QueryParameter("id")]
            public string Id { get; set; }
#endif
            /// <summary>A list of playable media types, comma delimited. Audio, Video, Book, Photo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("playableMediaTypes")]
            public global::Jellyfin.Sdk.Generated.Models.MediaType[]? PlayableMediaTypes { get; set; }
#nullable restore
#else
            [QueryParameter("playableMediaTypes")]
            public global::Jellyfin.Sdk.Generated.Models.MediaType[] PlayableMediaTypes { get; set; }
#endif
            /// <summary>A list of supported remote control commands, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("supportedCommands")]
            public global::Jellyfin.Sdk.Generated.Models.GeneralCommandType[]? SupportedCommands { get; set; }
#nullable restore
#else
            [QueryParameter("supportedCommands")]
            public global::Jellyfin.Sdk.Generated.Models.GeneralCommandType[] SupportedCommands { get; set; }
#endif
            /// <summary>Determines whether media can be played remotely..</summary>
            [QueryParameter("supportsMediaControl")]
            public bool? SupportsMediaControl { get; set; }
            /// <summary>Determines whether the device supports a unique identifier.</summary>
            [QueryParameter("supportsPersistentIdentifier")]
            public bool? SupportsPersistentIdentifier { get; set; }
        }
    }
}
#pragma warning restore CS0618
