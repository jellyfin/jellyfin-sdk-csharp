// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.System.Configuration.MetadataOptions.Default;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.System.Configuration.MetadataOptions
{
    /// <summary>
    /// Builds and executes requests for operations under \System\Configuration\MetadataOptions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MetadataOptionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Default property</summary>
        public global::Jellyfin.Sdk.Generated.System.Configuration.MetadataOptions.Default.DefaultRequestBuilder Default
        {
            get => new global::Jellyfin.Sdk.Generated.System.Configuration.MetadataOptions.Default.DefaultRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.System.Configuration.MetadataOptions.MetadataOptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MetadataOptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/System/Configuration/MetadataOptions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.System.Configuration.MetadataOptions.MetadataOptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MetadataOptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/System/Configuration/MetadataOptions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
