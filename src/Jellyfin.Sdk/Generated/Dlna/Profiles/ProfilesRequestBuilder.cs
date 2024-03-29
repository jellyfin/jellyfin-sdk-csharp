// <auto-generated/>
using Jellyfin.Sdk.Generated.Dlna.Profiles.Default;
using Jellyfin.Sdk.Generated.Dlna.Profiles.Item;
using Jellyfin.Sdk.Generated.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Dlna.Profiles {
    /// <summary>
    /// Builds and executes requests for operations under \Dlna\Profiles
    /// </summary>
    public class ProfilesRequestBuilder : BaseRequestBuilder {
        /// <summary>The Default property</summary>
        public DefaultRequestBuilder Default { get =>
            new DefaultRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Dlna.Profiles.item collection</summary>
        /// <param name="position">Profile Id.</param>
        /// <returns>A <see cref="WithProfileItemRequestBuilder"/></returns>
        public WithProfileItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("profileId", position);
            return new WithProfileItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="ProfilesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfilesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Dlna/Profiles", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ProfilesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfilesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Dlna/Profiles", rawUrl) {
        }
        /// <summary>
        /// Creates a profile.
        /// </summary>
        /// <param name="body">A MediaBrowser.Model.Dlna.DeviceProfile represents a set of metadata which determines which content a certain device is able to play.&lt;br /&gt;Specifically, it defines the supported &lt;see cref=&quot;P:MediaBrowser.Model.Dlna.DeviceProfile.ContainerProfiles&quot;&gt;containers&lt;/see&gt; and&lt;see cref=&quot;P:MediaBrowser.Model.Dlna.DeviceProfile.CodecProfiles&quot;&gt;codecs&lt;/see&gt; (video and/or audio, including codec profiles and levels)the device is able to direct play (without transcoding or remuxing),as well as which &lt;see cref=&quot;P:MediaBrowser.Model.Dlna.DeviceProfile.TranscodingProfiles&quot;&gt;containers/codecs to transcode to&lt;/see&gt; in case it isn&apos;t.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(DeviceProfile body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(DeviceProfile body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a profile.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">A MediaBrowser.Model.Dlna.DeviceProfile represents a set of metadata which determines which content a certain device is able to play.&lt;br /&gt;Specifically, it defines the supported &lt;see cref=&quot;P:MediaBrowser.Model.Dlna.DeviceProfile.ContainerProfiles&quot;&gt;containers&lt;/see&gt; and&lt;see cref=&quot;P:MediaBrowser.Model.Dlna.DeviceProfile.CodecProfiles&quot;&gt;codecs&lt;/see&gt; (video and/or audio, including codec profiles and levels)the device is able to direct play (without transcoding or remuxing),as well as which &lt;see cref=&quot;P:MediaBrowser.Model.Dlna.DeviceProfile.TranscodingProfiles&quot;&gt;containers/codecs to transcode to&lt;/see&gt; in case it isn&apos;t.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(DeviceProfile body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(DeviceProfile body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// <returns>A <see cref="ProfilesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ProfilesRequestBuilder WithUrl(string rawUrl) {
            return new ProfilesRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
