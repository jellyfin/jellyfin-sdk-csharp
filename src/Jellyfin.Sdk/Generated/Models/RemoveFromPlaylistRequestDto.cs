// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class RemoveFromPlaylistRequestDto.
    /// </summary>
    public class RemoveFromPlaylistRequestDto : IParsable {
        /// <summary>Gets or sets a value indicating whether the playing item should be removed as well. Used only when clearing the playlist.</summary>
        public bool? ClearPlayingItem { get; set; }
        /// <summary>Gets or sets a value indicating whether the entire playlist should be cleared.</summary>
        public bool? ClearPlaylist { get; set; }
        /// <summary>Gets or sets the playlist identifiers ot the items. Ignored when clearing the playlist.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? PlaylistItemIds { get; set; }
#nullable restore
#else
        public List<Guid?> PlaylistItemIds { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RemoveFromPlaylistRequestDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RemoveFromPlaylistRequestDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoveFromPlaylistRequestDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ClearPlayingItem", n => { ClearPlayingItem = n.GetBoolValue(); } },
                {"ClearPlaylist", n => { ClearPlaylist = n.GetBoolValue(); } },
                {"PlaylistItemIds", n => { PlaylistItemIds = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("ClearPlayingItem", ClearPlayingItem);
            writer.WriteBoolValue("ClearPlaylist", ClearPlaylist);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("PlaylistItemIds", PlaylistItemIds);
        }
    }
}
