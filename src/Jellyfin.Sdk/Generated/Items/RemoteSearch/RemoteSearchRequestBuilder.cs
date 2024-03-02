// <auto-generated/>
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
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.Items.RemoteSearch {
    /// <summary>
    /// Builds and executes requests for operations under \Items\RemoteSearch
    /// </summary>
    public class RemoteSearchRequestBuilder : BaseRequestBuilder {
        /// <summary>The Apply property</summary>
        public ApplyRequestBuilder Apply { get =>
            new ApplyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Book property</summary>
        public BookRequestBuilder Book { get =>
            new BookRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The BoxSet property</summary>
        public BoxSetRequestBuilder BoxSet { get =>
            new BoxSetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Movie property</summary>
        public MovieRequestBuilder Movie { get =>
            new MovieRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MusicAlbum property</summary>
        public MusicAlbumRequestBuilder MusicAlbum { get =>
            new MusicAlbumRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MusicArtist property</summary>
        public MusicArtistRequestBuilder MusicArtist { get =>
            new MusicArtistRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MusicVideo property</summary>
        public MusicVideoRequestBuilder MusicVideo { get =>
            new MusicVideoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Person property</summary>
        public PersonRequestBuilder Person { get =>
            new PersonRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Series property</summary>
        public SeriesRequestBuilder Series { get =>
            new SeriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Trailer property</summary>
        public TrailerRequestBuilder Trailer { get =>
            new TrailerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="RemoteSearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RemoteSearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/RemoteSearch", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="RemoteSearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RemoteSearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Items/RemoteSearch", rawUrl) {
        }
    }
}
