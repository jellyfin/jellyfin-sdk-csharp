// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.Items.RemoteSearch.Apply;
using Jellyfin.Sdk.Generated.Items.RemoteSearch.Book;
using Jellyfin.Sdk.Generated.Items.RemoteSearch.BoxSet;
using Jellyfin.Sdk.Generated.Items.RemoteSearch.Movie;
using Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicAlbum;
using Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicArtist;
using Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicVideo;
using Jellyfin.Sdk.Generated.Items.RemoteSearch.Person;
using Jellyfin.Sdk.Generated.Items.RemoteSearch.Series;
using Jellyfin.Sdk.Generated.Items.RemoteSearch.Trailer;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Items.RemoteSearch
{
    /// <summary>
    /// Builds and executes requests for operations under \Items\RemoteSearch
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RemoteSearchRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Apply property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Apply.ApplyRequestBuilder Apply
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Apply.ApplyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Book property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Book.BookRequestBuilder Book
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Book.BookRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The BoxSet property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.BoxSet.BoxSetRequestBuilder BoxSet
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.BoxSet.BoxSetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Movie property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Movie.MovieRequestBuilder Movie
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Movie.MovieRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MusicAlbum property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicAlbum.MusicAlbumRequestBuilder MusicAlbum
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicAlbum.MusicAlbumRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MusicArtist property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicArtist.MusicArtistRequestBuilder MusicArtist
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicArtist.MusicArtistRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MusicVideo property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicVideo.MusicVideoRequestBuilder MusicVideo
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.MusicVideo.MusicVideoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Person property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Person.PersonRequestBuilder Person
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Person.PersonRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Series property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Series.SeriesRequestBuilder Series
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Series.SeriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Trailer property</summary>
        public global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Trailer.TrailerRequestBuilder Trailer
        {
            get => new global::Jellyfin.Sdk.Generated.Items.RemoteSearch.Trailer.TrailerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.RemoteSearch.RemoteSearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RemoteSearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/RemoteSearch", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Items.RemoteSearch.RemoteSearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RemoteSearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/RemoteSearch", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
