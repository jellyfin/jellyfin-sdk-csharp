// <auto-generated/>
#pragma warning disable CS0618
using Jellyfin.Sdk.Generated.SyncPlay.Buffering;
using Jellyfin.Sdk.Generated.SyncPlay.Join;
using Jellyfin.Sdk.Generated.SyncPlay.Leave;
using Jellyfin.Sdk.Generated.SyncPlay.List;
using Jellyfin.Sdk.Generated.SyncPlay.MovePlaylistItem;
using Jellyfin.Sdk.Generated.SyncPlay.New;
using Jellyfin.Sdk.Generated.SyncPlay.NextItem;
using Jellyfin.Sdk.Generated.SyncPlay.Pause;
using Jellyfin.Sdk.Generated.SyncPlay.Ping;
using Jellyfin.Sdk.Generated.SyncPlay.PreviousItem;
using Jellyfin.Sdk.Generated.SyncPlay.Queue;
using Jellyfin.Sdk.Generated.SyncPlay.Ready;
using Jellyfin.Sdk.Generated.SyncPlay.RemoveFromPlaylist;
using Jellyfin.Sdk.Generated.SyncPlay.Seek;
using Jellyfin.Sdk.Generated.SyncPlay.SetIgnoreWait;
using Jellyfin.Sdk.Generated.SyncPlay.SetNewQueue;
using Jellyfin.Sdk.Generated.SyncPlay.SetPlaylistItem;
using Jellyfin.Sdk.Generated.SyncPlay.SetRepeatMode;
using Jellyfin.Sdk.Generated.SyncPlay.SetShuffleMode;
using Jellyfin.Sdk.Generated.SyncPlay.Stop;
using Jellyfin.Sdk.Generated.SyncPlay.Unpause;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Jellyfin.Sdk.Generated.SyncPlay
{
    /// <summary>
    /// Builds and executes requests for operations under \SyncPlay
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SyncPlayRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Buffering property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Buffering.BufferingRequestBuilder Buffering
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Buffering.BufferingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Join property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Join.JoinRequestBuilder Join
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Join.JoinRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Leave property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Leave.LeaveRequestBuilder Leave
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Leave.LeaveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The List property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.List.ListRequestBuilder List
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.List.ListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MovePlaylistItem property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.MovePlaylistItem.MovePlaylistItemRequestBuilder MovePlaylistItem
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.MovePlaylistItem.MovePlaylistItemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The New property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.New.NewRequestBuilder New
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.New.NewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The NextItem property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.NextItem.NextItemRequestBuilder NextItem
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.NextItem.NextItemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Pause property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Pause.PauseRequestBuilder Pause
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Pause.PauseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Ping property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Ping.PingRequestBuilder Ping
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Ping.PingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The PreviousItem property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.PreviousItem.PreviousItemRequestBuilder PreviousItem
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.PreviousItem.PreviousItemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Queue property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Queue.QueueRequestBuilder Queue
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Queue.QueueRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Ready property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Ready.ReadyRequestBuilder Ready
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Ready.ReadyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The RemoveFromPlaylist property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.RemoveFromPlaylist.RemoveFromPlaylistRequestBuilder RemoveFromPlaylist
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.RemoveFromPlaylist.RemoveFromPlaylistRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Seek property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Seek.SeekRequestBuilder Seek
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Seek.SeekRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetIgnoreWait property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.SetIgnoreWait.SetIgnoreWaitRequestBuilder SetIgnoreWait
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.SetIgnoreWait.SetIgnoreWaitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetNewQueue property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.SetNewQueue.SetNewQueueRequestBuilder SetNewQueue
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.SetNewQueue.SetNewQueueRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetPlaylistItem property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.SetPlaylistItem.SetPlaylistItemRequestBuilder SetPlaylistItem
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.SetPlaylistItem.SetPlaylistItemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetRepeatMode property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.SetRepeatMode.SetRepeatModeRequestBuilder SetRepeatMode
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.SetRepeatMode.SetRepeatModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SetShuffleMode property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.SetShuffleMode.SetShuffleModeRequestBuilder SetShuffleMode
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.SetShuffleMode.SetShuffleModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Stop property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Stop.StopRequestBuilder Stop
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Stop.StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Unpause property</summary>
        public global::Jellyfin.Sdk.Generated.SyncPlay.Unpause.UnpauseRequestBuilder Unpause
        {
            get => new global::Jellyfin.Sdk.Generated.SyncPlay.Unpause.UnpauseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.SyncPlay.SyncPlayRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SyncPlayRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/SyncPlay", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.SyncPlay.SyncPlayRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SyncPlayRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/SyncPlay", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
