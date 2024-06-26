// <auto-generated/>
using Jellyfin.Sdk.Generated.LiveTv.ListingProviders.SchedulesDirect.Countries;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.LiveTv.ListingProviders.SchedulesDirect {
    /// <summary>
    /// Builds and executes requests for operations under \LiveTv\ListingProviders\SchedulesDirect
    /// </summary>
    public class SchedulesDirectRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The Countries property</summary>
        public CountriesRequestBuilder Countries
        {
            get => new CountriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SchedulesDirectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SchedulesDirectRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/ListingProviders/SchedulesDirect", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SchedulesDirectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SchedulesDirectRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/LiveTv/ListingProviders/SchedulesDirect", rawUrl)
        {
        }
    }
}
