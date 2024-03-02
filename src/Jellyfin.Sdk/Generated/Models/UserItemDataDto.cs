// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class UserItemDataDto.
    /// </summary>
    public class UserItemDataDto : IParsable {
        /// <summary>Gets or sets a value indicating whether this instance is favorite.</summary>
        public bool? IsFavorite { get; set; }
        /// <summary>Gets or sets the item identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemId { get; set; }
#nullable restore
#else
        public string ItemId { get; set; }
#endif
        /// <summary>Gets or sets the key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>Gets or sets the last played date.</summary>
        public DateTimeOffset? LastPlayedDate { get; set; }
        /// <summary>Gets or sets a value indicating whether this MediaBrowser.Model.Dto.UserItemDataDto is likes.</summary>
        public bool? Likes { get; set; }
        /// <summary>Gets or sets the playback position ticks.</summary>
        public long? PlaybackPositionTicks { get; set; }
        /// <summary>Gets or sets the play count.</summary>
        public int? PlayCount { get; set; }
        /// <summary>Gets or sets a value indicating whether this MediaBrowser.Model.Dto.UserItemDataDto is played.</summary>
        public bool? Played { get; set; }
        /// <summary>Gets or sets the played percentage.</summary>
        public double? PlayedPercentage { get; set; }
        /// <summary>Gets or sets the rating.</summary>
        public double? Rating { get; set; }
        /// <summary>Gets or sets the unplayed item count.</summary>
        public int? UnplayedItemCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserItemDataDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserItemDataDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserItemDataDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"IsFavorite", n => { IsFavorite = n.GetBoolValue(); } },
                {"ItemId", n => { ItemId = n.GetStringValue(); } },
                {"Key", n => { Key = n.GetStringValue(); } },
                {"LastPlayedDate", n => { LastPlayedDate = n.GetDateTimeOffsetValue(); } },
                {"Likes", n => { Likes = n.GetBoolValue(); } },
                {"PlayCount", n => { PlayCount = n.GetIntValue(); } },
                {"PlaybackPositionTicks", n => { PlaybackPositionTicks = n.GetLongValue(); } },
                {"Played", n => { Played = n.GetBoolValue(); } },
                {"PlayedPercentage", n => { PlayedPercentage = n.GetDoubleValue(); } },
                {"Rating", n => { Rating = n.GetDoubleValue(); } },
                {"UnplayedItemCount", n => { UnplayedItemCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("IsFavorite", IsFavorite);
            writer.WriteStringValue("ItemId", ItemId);
            writer.WriteStringValue("Key", Key);
            writer.WriteDateTimeOffsetValue("LastPlayedDate", LastPlayedDate);
            writer.WriteBoolValue("Likes", Likes);
            writer.WriteLongValue("PlaybackPositionTicks", PlaybackPositionTicks);
            writer.WriteIntValue("PlayCount", PlayCount);
            writer.WriteBoolValue("Played", Played);
            writer.WriteDoubleValue("PlayedPercentage", PlayedPercentage);
            writer.WriteDoubleValue("Rating", Rating);
            writer.WriteIntValue("UnplayedItemCount", UnplayedItemCount);
        }
    }
}
