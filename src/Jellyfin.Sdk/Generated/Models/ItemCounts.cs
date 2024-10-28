// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Sdk.Generated.Models
{
    /// <summary>
    /// Class LibrarySummary.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ItemCounts : IParsable
    {
        /// <summary>Gets or sets the album count.</summary>
        public int? AlbumCount { get; set; }
        /// <summary>Gets or sets the artist count.</summary>
        public int? ArtistCount { get; set; }
        /// <summary>Gets or sets the book count.</summary>
        public int? BookCount { get; set; }
        /// <summary>Gets or sets the box set count.</summary>
        public int? BoxSetCount { get; set; }
        /// <summary>Gets or sets the episode count.</summary>
        public int? EpisodeCount { get; set; }
        /// <summary>Gets or sets the item count.</summary>
        public int? ItemCount { get; set; }
        /// <summary>Gets or sets the movie count.</summary>
        public int? MovieCount { get; set; }
        /// <summary>Gets or sets the music video count.</summary>
        public int? MusicVideoCount { get; set; }
        /// <summary>Gets or sets the program count.</summary>
        public int? ProgramCount { get; set; }
        /// <summary>Gets or sets the series count.</summary>
        public int? SeriesCount { get; set; }
        /// <summary>Gets or sets the song count.</summary>
        public int? SongCount { get; set; }
        /// <summary>Gets or sets the trailer count.</summary>
        public int? TrailerCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.ItemCounts"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.ItemCounts CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.ItemCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AlbumCount", n => { AlbumCount = n.GetIntValue(); } },
                { "ArtistCount", n => { ArtistCount = n.GetIntValue(); } },
                { "BookCount", n => { BookCount = n.GetIntValue(); } },
                { "BoxSetCount", n => { BoxSetCount = n.GetIntValue(); } },
                { "EpisodeCount", n => { EpisodeCount = n.GetIntValue(); } },
                { "ItemCount", n => { ItemCount = n.GetIntValue(); } },
                { "MovieCount", n => { MovieCount = n.GetIntValue(); } },
                { "MusicVideoCount", n => { MusicVideoCount = n.GetIntValue(); } },
                { "ProgramCount", n => { ProgramCount = n.GetIntValue(); } },
                { "SeriesCount", n => { SeriesCount = n.GetIntValue(); } },
                { "SongCount", n => { SongCount = n.GetIntValue(); } },
                { "TrailerCount", n => { TrailerCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AlbumCount", AlbumCount);
            writer.WriteIntValue("ArtistCount", ArtistCount);
            writer.WriteIntValue("BookCount", BookCount);
            writer.WriteIntValue("BoxSetCount", BoxSetCount);
            writer.WriteIntValue("EpisodeCount", EpisodeCount);
            writer.WriteIntValue("ItemCount", ItemCount);
            writer.WriteIntValue("MovieCount", MovieCount);
            writer.WriteIntValue("MusicVideoCount", MusicVideoCount);
            writer.WriteIntValue("ProgramCount", ProgramCount);
            writer.WriteIntValue("SeriesCount", SeriesCount);
            writer.WriteIntValue("SongCount", SongCount);
            writer.WriteIntValue("TrailerCount", TrailerCount);
        }
    }
}
#pragma warning restore CS0618
