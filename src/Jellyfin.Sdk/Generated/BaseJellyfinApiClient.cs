// <auto-generated/>
using Jellyfin.Sdk.Generated.Albums;
using Jellyfin.Sdk.Generated.Artists;
using Jellyfin.Sdk.Generated.Audio;
using Jellyfin.Sdk.Generated.Auth;
using Jellyfin.Sdk.Generated.Branding;
using Jellyfin.Sdk.Generated.Channels;
using Jellyfin.Sdk.Generated.ClientLog;
using Jellyfin.Sdk.Generated.Collections;
using Jellyfin.Sdk.Generated.Devices;
using Jellyfin.Sdk.Generated.DisplayPreferences;
using Jellyfin.Sdk.Generated.Dlna;
using Jellyfin.Sdk.Generated.EnvironmentNamespace;
using Jellyfin.Sdk.Generated.FallbackFont;
using Jellyfin.Sdk.Generated.Genres;
using Jellyfin.Sdk.Generated.GetUtcTime;
using Jellyfin.Sdk.Generated.Images;
using Jellyfin.Sdk.Generated.Items;
using Jellyfin.Sdk.Generated.Libraries;
using Jellyfin.Sdk.Generated.Library;
using Jellyfin.Sdk.Generated.LiveStreams;
using Jellyfin.Sdk.Generated.LiveTv;
using Jellyfin.Sdk.Generated.Localization;
using Jellyfin.Sdk.Generated.Movies;
using Jellyfin.Sdk.Generated.MusicGenres;
using Jellyfin.Sdk.Generated.Notifications;
using Jellyfin.Sdk.Generated.Packages;
using Jellyfin.Sdk.Generated.Persons;
using Jellyfin.Sdk.Generated.Playback;
using Jellyfin.Sdk.Generated.Playlists;
using Jellyfin.Sdk.Generated.Plugins;
using Jellyfin.Sdk.Generated.Providers;
using Jellyfin.Sdk.Generated.QuickConnect;
using Jellyfin.Sdk.Generated.Repositories;
using Jellyfin.Sdk.Generated.ScheduledTasks;
using Jellyfin.Sdk.Generated.Search;
using Jellyfin.Sdk.Generated.Sessions;
using Jellyfin.Sdk.Generated.Shows;
using Jellyfin.Sdk.Generated.Songs;
using Jellyfin.Sdk.Generated.Startup;
using Jellyfin.Sdk.Generated.Studios;
using Jellyfin.Sdk.Generated.SyncPlay;
using Jellyfin.Sdk.Generated.System;
using Jellyfin.Sdk.Generated.Tmdb;
using Jellyfin.Sdk.Generated.Trailers;
using Jellyfin.Sdk.Generated.Users;
using Jellyfin.Sdk.Generated.Videos;
using Jellyfin.Sdk.Generated.Web;
using Jellyfin.Sdk.Generated.Years;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated {
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class BaseJellyfinApiClient : BaseRequestBuilder {
        /// <summary>The Albums property</summary>
        public AlbumsRequestBuilder Albums { get =>
            new AlbumsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Artists property</summary>
        public ArtistsRequestBuilder Artists { get =>
            new ArtistsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Audio property</summary>
        public AudioRequestBuilder Audio { get =>
            new AudioRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Auth property</summary>
        public AuthRequestBuilder Auth { get =>
            new AuthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Branding property</summary>
        public BrandingRequestBuilder Branding { get =>
            new BrandingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Channels property</summary>
        public ChannelsRequestBuilder Channels { get =>
            new ChannelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ClientLog property</summary>
        public ClientLogRequestBuilder ClientLog { get =>
            new ClientLogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Collections property</summary>
        public CollectionsRequestBuilder Collections { get =>
            new CollectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Devices property</summary>
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The DisplayPreferences property</summary>
        public DisplayPreferencesRequestBuilder DisplayPreferences { get =>
            new DisplayPreferencesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Dlna property</summary>
        public DlnaRequestBuilder Dlna { get =>
            new DlnaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Environment property</summary>
        public EnvironmentRequestBuilder Environment { get =>
            new EnvironmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The FallbackFont property</summary>
        public FallbackFontRequestBuilder FallbackFont { get =>
            new FallbackFontRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Genres property</summary>
        public GenresRequestBuilder Genres { get =>
            new GenresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetUtcTime property</summary>
        public GetUtcTimeRequestBuilder GetUtcTime { get =>
            new GetUtcTimeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Images property</summary>
        public ImagesRequestBuilder Images { get =>
            new ImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Items property</summary>
        public ItemsRequestBuilder Items { get =>
            new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Libraries property</summary>
        public LibrariesRequestBuilder Libraries { get =>
            new LibrariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Library property</summary>
        public LibraryRequestBuilder Library { get =>
            new LibraryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The LiveStreams property</summary>
        public LiveStreamsRequestBuilder LiveStreams { get =>
            new LiveStreamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The LiveTv property</summary>
        public LiveTvRequestBuilder LiveTv { get =>
            new LiveTvRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Localization property</summary>
        public LocalizationRequestBuilder Localization { get =>
            new LocalizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Movies property</summary>
        public MoviesRequestBuilder Movies { get =>
            new MoviesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MusicGenres property</summary>
        public MusicGenresRequestBuilder MusicGenres { get =>
            new MusicGenresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Notifications property</summary>
        public NotificationsRequestBuilder Notifications { get =>
            new NotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Packages property</summary>
        public PackagesRequestBuilder Packages { get =>
            new PackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Persons property</summary>
        public PersonsRequestBuilder Persons { get =>
            new PersonsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Playback property</summary>
        public PlaybackRequestBuilder Playback { get =>
            new PlaybackRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Playlists property</summary>
        public PlaylistsRequestBuilder Playlists { get =>
            new PlaylistsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Plugins property</summary>
        public PluginsRequestBuilder Plugins { get =>
            new PluginsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Providers property</summary>
        public ProvidersRequestBuilder Providers { get =>
            new ProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The QuickConnect property</summary>
        public QuickConnectRequestBuilder QuickConnect { get =>
            new QuickConnectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Repositories property</summary>
        public RepositoriesRequestBuilder Repositories { get =>
            new RepositoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ScheduledTasks property</summary>
        public ScheduledTasksRequestBuilder ScheduledTasks { get =>
            new ScheduledTasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Sessions property</summary>
        public SessionsRequestBuilder Sessions { get =>
            new SessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Shows property</summary>
        public ShowsRequestBuilder Shows { get =>
            new ShowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Songs property</summary>
        public SongsRequestBuilder Songs { get =>
            new SongsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Startup property</summary>
        public StartupRequestBuilder Startup { get =>
            new StartupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Studios property</summary>
        public StudiosRequestBuilder Studios { get =>
            new StudiosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SyncPlay property</summary>
        public SyncPlayRequestBuilder SyncPlay { get =>
            new SyncPlayRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The System property</summary>
        public SystemRequestBuilder System { get =>
            new SystemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Tmdb property</summary>
        public TmdbRequestBuilder Tmdb { get =>
            new TmdbRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Trailers property</summary>
        public TrailersRequestBuilder Trailers { get =>
            new TrailersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Users property</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Videos property</summary>
        public VideosRequestBuilder Videos { get =>
            new VideosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The web property</summary>
        public WebRequestBuilder Web { get =>
            new WebRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Years property</summary>
        public YearsRequestBuilder Years { get =>
            new YearsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="BaseJellyfinApiClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BaseJellyfinApiClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>()) {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl)) {
                RequestAdapter.BaseUrl = "http://localhost";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
