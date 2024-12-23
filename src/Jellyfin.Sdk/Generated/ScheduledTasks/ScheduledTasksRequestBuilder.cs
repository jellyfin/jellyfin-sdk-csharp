// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.ScheduledTasks.Item;
using Jellyfin.Sdk.Generated.ScheduledTasks.Running;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.ScheduledTasks
{
    /// <summary>
    /// Builds and executes requests for operations under \ScheduledTasks
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ScheduledTasksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Running property</summary>
        public global::Jellyfin.Sdk.Generated.ScheduledTasks.Running.RunningRequestBuilder Running
        {
            get => new global::Jellyfin.Sdk.Generated.ScheduledTasks.Running.RunningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.ScheduledTasks.item collection</summary>
        /// <param name="position">Task Id.</param>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.ScheduledTasks.Item.WithTaskItemRequestBuilder"/></returns>
        public global::Jellyfin.Sdk.Generated.ScheduledTasks.Item.WithTaskItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("taskId", position);
                return new global::Jellyfin.Sdk.Generated.ScheduledTasks.Item.WithTaskItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.ScheduledTasks.ScheduledTasksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduledTasksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ScheduledTasks{?isEnabled*,isHidden*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.ScheduledTasks.ScheduledTasksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduledTasksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ScheduledTasks{?isEnabled*,isHidden*}", rawUrl)
        {
        }
        /// <summary>
        /// Get tasks.
        /// </summary>
        /// <returns>A List&lt;global::Jellyfin.Sdk.Generated.Models.TaskInfo&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Jellyfin.Sdk.Generated.Models.TaskInfo>?> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.ScheduledTasks.ScheduledTasksRequestBuilder.ScheduledTasksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Jellyfin.Sdk.Generated.Models.TaskInfo>> GetAsync(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.ScheduledTasks.ScheduledTasksRequestBuilder.ScheduledTasksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Jellyfin.Sdk.Generated.Models.TaskInfo>(requestInfo, global::Jellyfin.Sdk.Generated.Models.TaskInfo.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Get tasks.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.ScheduledTasks.ScheduledTasksRequestBuilder.ScheduledTasksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Jellyfin.Sdk.Generated.ScheduledTasks.ScheduledTasksRequestBuilder.ScheduledTasksRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.ScheduledTasks.ScheduledTasksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Jellyfin.Sdk.Generated.ScheduledTasks.ScheduledTasksRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Jellyfin.Sdk.Generated.ScheduledTasks.ScheduledTasksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get tasks.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ScheduledTasksRequestBuilderGetQueryParameters 
        {
            /// <summary>Optional filter tasks that are enabled, or not.</summary>
            [QueryParameter("isEnabled")]
            public bool? IsEnabled { get; set; }
            /// <summary>Optional filter tasks that are hidden, or not.</summary>
            [QueryParameter("isHidden")]
            public bool? IsHidden { get; set; }
        }
    }
}
#pragma warning restore CS0618
