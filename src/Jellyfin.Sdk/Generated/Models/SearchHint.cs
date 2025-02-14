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
    /// Class SearchHintResult.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SearchHint : IParsable
    {
        /// <summary>Gets or sets the album.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Album { get; set; }
#nullable restore
#else
        public string Album { get; set; }
#endif
        /// <summary>Gets or sets the album artist.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlbumArtist { get; set; }
#nullable restore
#else
        public string AlbumArtist { get; set; }
#endif
        /// <summary>Gets or sets the album id.</summary>
        public Guid? AlbumId { get; set; }
        /// <summary>Gets or sets the artists.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Artists { get; set; }
#nullable restore
#else
        public List<string> Artists { get; set; }
#endif
        /// <summary>Gets or sets the backdrop image item identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BackdropImageItemId { get; set; }
#nullable restore
#else
        public string BackdropImageItemId { get; set; }
#endif
        /// <summary>Gets or sets the backdrop image tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BackdropImageTag { get; set; }
#nullable restore
#else
        public string BackdropImageTag { get; set; }
#endif
        /// <summary>Gets or sets the channel identifier.</summary>
        public Guid? ChannelId { get; set; }
        /// <summary>Gets or sets the name of the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChannelName { get; set; }
#nullable restore
#else
        public string ChannelName { get; set; }
#endif
        /// <summary>Gets or sets the end date.</summary>
        public DateTimeOffset? EndDate { get; set; }
        /// <summary>Gets or sets the episode count.</summary>
        public int? EpisodeCount { get; set; }
        /// <summary>Gets or sets the item id.</summary>
        public Guid? Id { get; set; }
        /// <summary>Gets or sets the index number.</summary>
        public int? IndexNumber { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance is folder.</summary>
        public bool? IsFolder { get; set; }
        /// <summary>Gets or sets the item id.</summary>
        [Obsolete("")]
        public Guid? ItemId { get; set; }
        /// <summary>Gets or sets the matched term.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MatchedTerm { get; set; }
#nullable restore
#else
        public string MatchedTerm { get; set; }
#endif
        /// <summary>Media types.</summary>
        public global::Jellyfin.Sdk.Generated.Models.SearchHint_MediaType? MediaType { get; set; }
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the parent index number.</summary>
        public int? ParentIndexNumber { get; set; }
        /// <summary>Gets or sets the primary image aspect ratio.</summary>
        public double? PrimaryImageAspectRatio { get; set; }
        /// <summary>Gets or sets the image tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryImageTag { get; set; }
#nullable restore
#else
        public string PrimaryImageTag { get; set; }
#endif
        /// <summary>Gets or sets the production year.</summary>
        public int? ProductionYear { get; set; }
        /// <summary>Gets or sets the run time ticks.</summary>
        public long? RunTimeTicks { get; set; }
        /// <summary>Gets or sets the series.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Series { get; set; }
#nullable restore
#else
        public string Series { get; set; }
#endif
        /// <summary>Gets or sets the song count.</summary>
        public int? SongCount { get; set; }
        /// <summary>Gets or sets the start date.</summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary>Gets or sets the status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>Gets or sets the thumb image item identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbImageItemId { get; set; }
#nullable restore
#else
        public string ThumbImageItemId { get; set; }
#endif
        /// <summary>Gets or sets the thumb image tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbImageTag { get; set; }
#nullable restore
#else
        public string ThumbImageTag { get; set; }
#endif
        /// <summary>The base item kind.</summary>
        public global::Jellyfin.Sdk.Generated.Models.SearchHint_Type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.SearchHint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.SearchHint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.SearchHint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Album", n => { Album = n.GetStringValue(); } },
                { "AlbumArtist", n => { AlbumArtist = n.GetStringValue(); } },
                { "AlbumId", n => { AlbumId = n.GetGuidValue(); } },
                { "Artists", n => { Artists = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "BackdropImageItemId", n => { BackdropImageItemId = n.GetStringValue(); } },
                { "BackdropImageTag", n => { BackdropImageTag = n.GetStringValue(); } },
                { "ChannelId", n => { ChannelId = n.GetGuidValue(); } },
                { "ChannelName", n => { ChannelName = n.GetStringValue(); } },
                { "EndDate", n => { EndDate = n.GetDateTimeOffsetValue(); } },
                { "EpisodeCount", n => { EpisodeCount = n.GetIntValue(); } },
                { "Id", n => { Id = n.GetGuidValue(); } },
                { "IndexNumber", n => { IndexNumber = n.GetIntValue(); } },
                { "IsFolder", n => { IsFolder = n.GetBoolValue(); } },
                { "ItemId", n => { ItemId = n.GetGuidValue(); } },
                { "MatchedTerm", n => { MatchedTerm = n.GetStringValue(); } },
                { "MediaType", n => { MediaType = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.SearchHint_MediaType>(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "ParentIndexNumber", n => { ParentIndexNumber = n.GetIntValue(); } },
                { "PrimaryImageAspectRatio", n => { PrimaryImageAspectRatio = n.GetDoubleValue(); } },
                { "PrimaryImageTag", n => { PrimaryImageTag = n.GetStringValue(); } },
                { "ProductionYear", n => { ProductionYear = n.GetIntValue(); } },
                { "RunTimeTicks", n => { RunTimeTicks = n.GetLongValue(); } },
                { "Series", n => { Series = n.GetStringValue(); } },
                { "SongCount", n => { SongCount = n.GetIntValue(); } },
                { "StartDate", n => { StartDate = n.GetDateTimeOffsetValue(); } },
                { "Status", n => { Status = n.GetStringValue(); } },
                { "ThumbImageItemId", n => { ThumbImageItemId = n.GetStringValue(); } },
                { "ThumbImageTag", n => { ThumbImageTag = n.GetStringValue(); } },
                { "Type", n => { Type = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.SearchHint_Type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Album", Album);
            writer.WriteStringValue("AlbumArtist", AlbumArtist);
            writer.WriteGuidValue("AlbumId", AlbumId);
            writer.WriteCollectionOfPrimitiveValues<string>("Artists", Artists);
            writer.WriteStringValue("BackdropImageItemId", BackdropImageItemId);
            writer.WriteStringValue("BackdropImageTag", BackdropImageTag);
            writer.WriteGuidValue("ChannelId", ChannelId);
            writer.WriteStringValue("ChannelName", ChannelName);
            writer.WriteDateTimeOffsetValue("EndDate", EndDate);
            writer.WriteIntValue("EpisodeCount", EpisodeCount);
            writer.WriteGuidValue("Id", Id);
            writer.WriteIntValue("IndexNumber", IndexNumber);
            writer.WriteBoolValue("IsFolder", IsFolder);
            writer.WriteGuidValue("ItemId", ItemId);
            writer.WriteStringValue("MatchedTerm", MatchedTerm);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.SearchHint_MediaType>("MediaType", MediaType);
            writer.WriteStringValue("Name", Name);
            writer.WriteIntValue("ParentIndexNumber", ParentIndexNumber);
            writer.WriteDoubleValue("PrimaryImageAspectRatio", PrimaryImageAspectRatio);
            writer.WriteStringValue("PrimaryImageTag", PrimaryImageTag);
            writer.WriteIntValue("ProductionYear", ProductionYear);
            writer.WriteLongValue("RunTimeTicks", RunTimeTicks);
            writer.WriteStringValue("Series", Series);
            writer.WriteIntValue("SongCount", SongCount);
            writer.WriteDateTimeOffsetValue("StartDate", StartDate);
            writer.WriteStringValue("Status", Status);
            writer.WriteStringValue("ThumbImageItemId", ThumbImageItemId);
            writer.WriteStringValue("ThumbImageTag", ThumbImageTag);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.SearchHint_Type>("Type", Type);
        }
    }
}
#pragma warning restore CS0618
