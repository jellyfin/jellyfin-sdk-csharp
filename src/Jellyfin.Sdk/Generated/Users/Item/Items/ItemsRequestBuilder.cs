// <auto-generated/>
using Jellyfin.Sdk.Generated.Models;
using Jellyfin.Sdk.Generated.Users.Item.Items.Item;
using Jellyfin.Sdk.Generated.Users.Item.Items.Latest;
using Jellyfin.Sdk.Generated.Users.Item.Items.Resume;
using Jellyfin.Sdk.Generated.Users.Item.Items.Root;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Users.Item.Items {
    /// <summary>
    /// Builds and executes requests for operations under \Users\{userId}\Items
    /// </summary>
    public class ItemsRequestBuilder : BaseRequestBuilder {
        /// <summary>The Latest property</summary>
        public LatestRequestBuilder Latest { get =>
            new LatestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Resume property</summary>
        public ResumeRequestBuilder Resume { get =>
            new ResumeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Root property</summary>
        public RootRequestBuilder Root { get =>
            new RootRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Jellyfin.Sdk.Generated.Users.item.Items.item collection</summary>
        /// <param name="position">Item id.</param>
        public WithItemItemRequestBuilder this[Guid position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("itemId", position);
            return new WithItemItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/{userId}/Items{?adjacentTo*,albumArtistIds*,albumIds*,albums*,artistIds*,artists*,collapseBoxSetItems*,contributingArtistIds*,enableImages*,enableImageTypes*,enableTotalRecordCount*,enableUserData*,excludeArtistIds*,excludeItemIds*,excludeItemTypes*,excludeLocationTypes*,fields*,filters*,genreIds*,genres*,hasImdbId*,hasOfficialRating*,hasOverview*,hasParentalRating*,hasSpecialFeature*,hasSubtitles*,hasThemeSong*,hasThemeVideo*,hasTmdbId*,hasTrailer*,hasTvdbId*,ids*,imageTypeLimit*,imageTypes*,includeItemTypes*,is3D*,is4K*,isFavorite*,isHd*,isKids*,isLocked*,isMissing*,isMovie*,isNews*,isPlaceHolder*,isPlayed*,isSeries*,isSports*,isUnaired*,limit*,locationTypes*,maxHeight*,maxOfficialRating*,maxPremiereDate*,maxWidth*,mediaTypes*,minCommunityRating*,minCriticRating*,minDateLastSaved*,minDateLastSavedForUser*,minHeight*,minOfficialRating*,minPremiereDate*,minWidth*,nameLessThan*,nameStartsWith*,nameStartsWithOrGreater*,officialRatings*,parentId*,parentIndexNumber*,person*,personIds*,personTypes*,recursive*,searchTerm*,seriesStatus*,sortBy*,sortOrder*,startIndex*,studioIds*,studios*,tags*,videoTypes*,years*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Users/{userId}/Items{?adjacentTo*,albumArtistIds*,albumIds*,albums*,artistIds*,artists*,collapseBoxSetItems*,contributingArtistIds*,enableImages*,enableImageTypes*,enableTotalRecordCount*,enableUserData*,excludeArtistIds*,excludeItemIds*,excludeItemTypes*,excludeLocationTypes*,fields*,filters*,genreIds*,genres*,hasImdbId*,hasOfficialRating*,hasOverview*,hasParentalRating*,hasSpecialFeature*,hasSubtitles*,hasThemeSong*,hasThemeVideo*,hasTmdbId*,hasTrailer*,hasTvdbId*,ids*,imageTypeLimit*,imageTypes*,includeItemTypes*,is3D*,is4K*,isFavorite*,isHd*,isKids*,isLocked*,isMissing*,isMovie*,isNews*,isPlaceHolder*,isPlayed*,isSeries*,isSports*,isUnaired*,limit*,locationTypes*,maxHeight*,maxOfficialRating*,maxPremiereDate*,maxWidth*,mediaTypes*,minCommunityRating*,minCriticRating*,minDateLastSaved*,minDateLastSavedForUser*,minHeight*,minOfficialRating*,minPremiereDate*,minWidth*,nameLessThan*,nameStartsWith*,nameStartsWithOrGreater*,officialRatings*,parentId*,parentIndexNumber*,person*,personIds*,personTypes*,recursive*,searchTerm*,seriesStatus*,sortBy*,sortOrder*,startIndex*,studioIds*,studios*,tags*,videoTypes*,years*}", rawUrl) {
        }
        /// <summary>
        /// Gets items based on a query.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BaseItemDtoQueryResult?> GetAsync(Action<RequestConfiguration<ItemsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BaseItemDtoQueryResult> GetAsync(Action<RequestConfiguration<ItemsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BaseItemDtoQueryResult>(requestInfo, BaseItemDtoQueryResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets items based on a query.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ItemsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ItemsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json;profile=\"CamelCase\", application/json;profile=\"PascalCase\"");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ItemsRequestBuilder WithUrl(string rawUrl) {
            return new ItemsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets items based on a query.
        /// </summary>
        public class ItemsRequestBuilderGetQueryParameters {
            /// <summary>Optional. Return items that are siblings of a supplied item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("adjacentTo")]
            public string? AdjacentTo { get; set; }
#nullable restore
#else
            [QueryParameter("adjacentTo")]
            public string AdjacentTo { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered to include only those containing the specified album artist id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("albumArtistIds")]
            public Guid?[]? AlbumArtistIds { get; set; }
#nullable restore
#else
            [QueryParameter("albumArtistIds")]
            public Guid?[] AlbumArtistIds { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on album id. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("albumIds")]
            public Guid?[]? AlbumIds { get; set; }
#nullable restore
#else
            [QueryParameter("albumIds")]
            public Guid?[] AlbumIds { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on album. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("albums")]
            public string[]? Albums { get; set; }
#nullable restore
#else
            [QueryParameter("albums")]
            public string[] Albums { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered to include only those containing the specified artist id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("artistIds")]
            public Guid?[]? ArtistIds { get; set; }
#nullable restore
#else
            [QueryParameter("artistIds")]
            public Guid?[] ArtistIds { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on artists. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("artists")]
            public string[]? Artists { get; set; }
#nullable restore
#else
            [QueryParameter("artists")]
            public string[] Artists { get; set; }
#endif
            /// <summary>Whether or not to hide items behind their boxsets.</summary>
            [QueryParameter("collapseBoxSetItems")]
            public bool? CollapseBoxSetItems { get; set; }
            /// <summary>Optional. If specified, results will be filtered to include only those containing the specified contributing artist id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("contributingArtistIds")]
            public Guid?[]? ContributingArtistIds { get; set; }
#nullable restore
#else
            [QueryParameter("contributingArtistIds")]
            public Guid?[] ContributingArtistIds { get; set; }
#endif
            /// <summary>Optional, include image information in output.</summary>
            [QueryParameter("enableImages")]
            public bool? EnableImages { get; set; }
            /// <summary>Optional. The image types to include in the output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("enableImageTypes")]
            public string[]? EnableImageTypes { get; set; }
#nullable restore
#else
            [QueryParameter("enableImageTypes")]
            public string[] EnableImageTypes { get; set; }
#endif
            /// <summary>Optional. Enable the total record count.</summary>
            [QueryParameter("enableTotalRecordCount")]
            public bool? EnableTotalRecordCount { get; set; }
            /// <summary>Optional, include user data.</summary>
            [QueryParameter("enableUserData")]
            public bool? EnableUserData { get; set; }
            /// <summary>Optional. If specified, results will be filtered based on artist id. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("excludeArtistIds")]
            public Guid?[]? ExcludeArtistIds { get; set; }
#nullable restore
#else
            [QueryParameter("excludeArtistIds")]
            public Guid?[] ExcludeArtistIds { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered by excluding item ids. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("excludeItemIds")]
            public Guid?[]? ExcludeItemIds { get; set; }
#nullable restore
#else
            [QueryParameter("excludeItemIds")]
            public Guid?[] ExcludeItemIds { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on item type. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("excludeItemTypes")]
            public string[]? ExcludeItemTypes { get; set; }
#nullable restore
#else
            [QueryParameter("excludeItemTypes")]
            public string[] ExcludeItemTypes { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on the LocationType. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("excludeLocationTypes")]
            public string[]? ExcludeLocationTypes { get; set; }
#nullable restore
#else
            [QueryParameter("excludeLocationTypes")]
            public string[] ExcludeLocationTypes { get; set; }
#endif
            /// <summary>Optional. Specify additional fields of information to return in the output. This allows multiple, comma delimited. Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string[]? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string[] Fields { get; set; }
#endif
            /// <summary>Optional. Specify additional filters to apply. This allows multiple, comma delimited. Options: IsFolder, IsNotFolder, IsUnplayed, IsPlayed, IsFavorite, IsResumable, Likes, Dislikes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filters")]
            public string[]? Filters { get; set; }
#nullable restore
#else
            [QueryParameter("filters")]
            public string[] Filters { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on genre id. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("genreIds")]
            public Guid?[]? GenreIds { get; set; }
#nullable restore
#else
            [QueryParameter("genreIds")]
            public Guid?[] GenreIds { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on genre. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("genres")]
            public string[]? Genres { get; set; }
#nullable restore
#else
            [QueryParameter("genres")]
            public string[] Genres { get; set; }
#endif
            /// <summary>Optional filter by items that have an imdb id or not.</summary>
            [QueryParameter("hasImdbId")]
            public bool? HasImdbId { get; set; }
            /// <summary>Optional filter by items that have official ratings.</summary>
            [QueryParameter("hasOfficialRating")]
            public bool? HasOfficialRating { get; set; }
            /// <summary>Optional filter by items that have an overview or not.</summary>
            [QueryParameter("hasOverview")]
            public bool? HasOverview { get; set; }
            /// <summary>Optional filter by items that have or do not have a parental rating.</summary>
            [QueryParameter("hasParentalRating")]
            public bool? HasParentalRating { get; set; }
            /// <summary>Optional filter by items with special features.</summary>
            [QueryParameter("hasSpecialFeature")]
            public bool? HasSpecialFeature { get; set; }
            /// <summary>Optional filter by items with subtitles.</summary>
            [QueryParameter("hasSubtitles")]
            public bool? HasSubtitles { get; set; }
            /// <summary>Optional filter by items with theme songs.</summary>
            [QueryParameter("hasThemeSong")]
            public bool? HasThemeSong { get; set; }
            /// <summary>Optional filter by items with theme videos.</summary>
            [QueryParameter("hasThemeVideo")]
            public bool? HasThemeVideo { get; set; }
            /// <summary>Optional filter by items that have a tmdb id or not.</summary>
            [QueryParameter("hasTmdbId")]
            public bool? HasTmdbId { get; set; }
            /// <summary>Optional filter by items with trailers.</summary>
            [QueryParameter("hasTrailer")]
            public bool? HasTrailer { get; set; }
            /// <summary>Optional filter by items that have a tvdb id or not.</summary>
            [QueryParameter("hasTvdbId")]
            public bool? HasTvdbId { get; set; }
            /// <summary>Optional. If specific items are needed, specify a list of item id&apos;s to retrieve. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ids")]
            public Guid?[]? Ids { get; set; }
#nullable restore
#else
            [QueryParameter("ids")]
            public Guid?[] Ids { get; set; }
#endif
            /// <summary>Optional, the max number of images to return, per image type.</summary>
            [QueryParameter("imageTypeLimit")]
            public int? ImageTypeLimit { get; set; }
            /// <summary>Optional. If specified, results will be filtered based on those containing image types. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("imageTypes")]
            public string[]? ImageTypes { get; set; }
#nullable restore
#else
            [QueryParameter("imageTypes")]
            public string[] ImageTypes { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on the item type. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("includeItemTypes")]
            public string[]? IncludeItemTypes { get; set; }
#nullable restore
#else
            [QueryParameter("includeItemTypes")]
            public string[] IncludeItemTypes { get; set; }
#endif
            /// <summary>Optional filter by items that are 3D, or not.</summary>
            [QueryParameter("is3D")]
            public bool? Is3D { get; set; }
            /// <summary>Optional filter by items that are 4K or not.</summary>
            [QueryParameter("is4K")]
            public bool? Is4K { get; set; }
            /// <summary>Optional filter by items that are marked as favorite, or not.</summary>
            [QueryParameter("isFavorite")]
            public bool? IsFavorite { get; set; }
            /// <summary>Optional filter by items that are HD or not.</summary>
            [QueryParameter("isHd")]
            public bool? IsHd { get; set; }
            /// <summary>Optional filter for live tv kids.</summary>
            [QueryParameter("isKids")]
            public bool? IsKids { get; set; }
            /// <summary>Optional filter by items that are locked.</summary>
            [QueryParameter("isLocked")]
            public bool? IsLocked { get; set; }
            /// <summary>Optional filter by items that are missing episodes or not.</summary>
            [QueryParameter("isMissing")]
            public bool? IsMissing { get; set; }
            /// <summary>Optional filter for live tv movies.</summary>
            [QueryParameter("isMovie")]
            public bool? IsMovie { get; set; }
            /// <summary>Optional filter for live tv news.</summary>
            [QueryParameter("isNews")]
            public bool? IsNews { get; set; }
            /// <summary>Optional filter by items that are placeholders.</summary>
            [QueryParameter("isPlaceHolder")]
            public bool? IsPlaceHolder { get; set; }
            /// <summary>Optional filter by items that are played, or not.</summary>
            [QueryParameter("isPlayed")]
            public bool? IsPlayed { get; set; }
            /// <summary>Optional filter for live tv series.</summary>
            [QueryParameter("isSeries")]
            public bool? IsSeries { get; set; }
            /// <summary>Optional filter for live tv sports.</summary>
            [QueryParameter("isSports")]
            public bool? IsSports { get; set; }
            /// <summary>Optional filter by items that are unaired episodes or not.</summary>
            [QueryParameter("isUnaired")]
            public bool? IsUnaired { get; set; }
            /// <summary>Optional. The maximum number of records to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Optional. If specified, results will be filtered based on LocationType. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("locationTypes")]
            public string[]? LocationTypes { get; set; }
#nullable restore
#else
            [QueryParameter("locationTypes")]
            public string[] LocationTypes { get; set; }
#endif
            /// <summary>Optional. Filter by the maximum height of the item.</summary>
            [QueryParameter("maxHeight")]
            public int? MaxHeight { get; set; }
            /// <summary>Optional filter by maximum official rating (PG, PG-13, TV-MA, etc).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("maxOfficialRating")]
            public string? MaxOfficialRating { get; set; }
#nullable restore
#else
            [QueryParameter("maxOfficialRating")]
            public string MaxOfficialRating { get; set; }
#endif
            /// <summary>Optional. The maximum premiere date. Format = ISO.</summary>
            [QueryParameter("maxPremiereDate")]
            public DateTimeOffset? MaxPremiereDate { get; set; }
            /// <summary>Optional. Filter by the maximum width of the item.</summary>
            [QueryParameter("maxWidth")]
            public int? MaxWidth { get; set; }
            /// <summary>Optional filter by MediaType. Allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("mediaTypes")]
            public string[]? MediaTypes { get; set; }
#nullable restore
#else
            [QueryParameter("mediaTypes")]
            public string[] MediaTypes { get; set; }
#endif
            /// <summary>Optional filter by minimum community rating.</summary>
            [QueryParameter("minCommunityRating")]
            public double? MinCommunityRating { get; set; }
            /// <summary>Optional filter by minimum critic rating.</summary>
            [QueryParameter("minCriticRating")]
            public double? MinCriticRating { get; set; }
            /// <summary>Optional. The minimum last saved date. Format = ISO.</summary>
            [QueryParameter("minDateLastSaved")]
            public DateTimeOffset? MinDateLastSaved { get; set; }
            /// <summary>Optional. The minimum last saved date for the current user. Format = ISO.</summary>
            [QueryParameter("minDateLastSavedForUser")]
            public DateTimeOffset? MinDateLastSavedForUser { get; set; }
            /// <summary>Optional. Filter by the minimum height of the item.</summary>
            [QueryParameter("minHeight")]
            public int? MinHeight { get; set; }
            /// <summary>Optional filter by minimum official rating (PG, PG-13, TV-MA, etc).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("minOfficialRating")]
            public string? MinOfficialRating { get; set; }
#nullable restore
#else
            [QueryParameter("minOfficialRating")]
            public string MinOfficialRating { get; set; }
#endif
            /// <summary>Optional. The minimum premiere date. Format = ISO.</summary>
            [QueryParameter("minPremiereDate")]
            public DateTimeOffset? MinPremiereDate { get; set; }
            /// <summary>Optional. Filter by the minimum width of the item.</summary>
            [QueryParameter("minWidth")]
            public int? MinWidth { get; set; }
            /// <summary>Optional filter by items whose name is equally or lesser than a given input string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("nameLessThan")]
            public string? NameLessThan { get; set; }
#nullable restore
#else
            [QueryParameter("nameLessThan")]
            public string NameLessThan { get; set; }
#endif
            /// <summary>Optional filter by items whose name is sorted equally than a given input string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("nameStartsWith")]
            public string? NameStartsWith { get; set; }
#nullable restore
#else
            [QueryParameter("nameStartsWith")]
            public string NameStartsWith { get; set; }
#endif
            /// <summary>Optional filter by items whose name is sorted equally or greater than a given input string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("nameStartsWithOrGreater")]
            public string? NameStartsWithOrGreater { get; set; }
#nullable restore
#else
            [QueryParameter("nameStartsWithOrGreater")]
            public string NameStartsWithOrGreater { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on OfficialRating. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("officialRatings")]
            public string[]? OfficialRatings { get; set; }
#nullable restore
#else
            [QueryParameter("officialRatings")]
            public string[] OfficialRatings { get; set; }
#endif
            /// <summary>Specify this to localize the search to a specific item or folder. Omit to use the root.</summary>
            [QueryParameter("parentId")]
            public Guid? ParentId { get; set; }
            /// <summary>Optional filter by parent index number.</summary>
            [QueryParameter("parentIndexNumber")]
            public int? ParentIndexNumber { get; set; }
            /// <summary>Optional. If specified, results will be filtered to include only those containing the specified person.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("person")]
            public string? Person { get; set; }
#nullable restore
#else
            [QueryParameter("person")]
            public string Person { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered to include only those containing the specified person id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("personIds")]
            public Guid?[]? PersonIds { get; set; }
#nullable restore
#else
            [QueryParameter("personIds")]
            public Guid?[] PersonIds { get; set; }
#endif
            /// <summary>Optional. If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType. Allows multiple, comma-delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("personTypes")]
            public string[]? PersonTypes { get; set; }
#nullable restore
#else
            [QueryParameter("personTypes")]
            public string[] PersonTypes { get; set; }
#endif
            /// <summary>When searching within folders, this determines whether or not the search will be recursive. true/false.</summary>
            [QueryParameter("recursive")]
            public bool? Recursive { get; set; }
            /// <summary>Optional. Filter based on a search term.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("searchTerm")]
            public string? SearchTerm { get; set; }
#nullable restore
#else
            [QueryParameter("searchTerm")]
            public string SearchTerm { get; set; }
#endif
            /// <summary>Optional filter by Series Status. Allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("seriesStatus")]
            public string[]? SeriesStatus { get; set; }
#nullable restore
#else
            [QueryParameter("seriesStatus")]
            public string[] SeriesStatus { get; set; }
#endif
            /// <summary>Optional. Specify one or more sort orders, comma delimited. Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortBy")]
            public string[]? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sortBy")]
            public string[] SortBy { get; set; }
#endif
            /// <summary>Sort Order - Ascending,Descending.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortOrder")]
            public string[]? SortOrder { get; set; }
#nullable restore
#else
            [QueryParameter("sortOrder")]
            public string[] SortOrder { get; set; }
#endif
            /// <summary>Optional. The record index to start at. All items with a lower index will be dropped from the results.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
            /// <summary>Optional. If specified, results will be filtered based on studio id. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("studioIds")]
            public Guid?[]? StudioIds { get; set; }
#nullable restore
#else
            [QueryParameter("studioIds")]
            public Guid?[] StudioIds { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on studio. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("studios")]
            public string[]? Studios { get; set; }
#nullable restore
#else
            [QueryParameter("studios")]
            public string[] Studios { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on tag. This allows multiple, pipe delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tags")]
            public string[]? Tags { get; set; }
#nullable restore
#else
            [QueryParameter("tags")]
            public string[] Tags { get; set; }
#endif
            /// <summary>Optional filter by VideoType (videofile, dvd, bluray, iso). Allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("videoTypes")]
            public string[]? VideoTypes { get; set; }
#nullable restore
#else
            [QueryParameter("videoTypes")]
            public string[] VideoTypes { get; set; }
#endif
            /// <summary>Optional. If specified, results will be filtered based on production year. This allows multiple, comma delimited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("years")]
            public int?[]? Years { get; set; }
#nullable restore
#else
            [QueryParameter("years")]
            public int?[] Years { get; set; }
#endif
        }
    }
}
