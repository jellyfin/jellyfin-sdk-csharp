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
    /// Api model for MediaSegment&apos;s.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MediaSegmentDto : IParsable
    {
        /// <summary>Gets or sets the end of the segment.</summary>
        public long? EndTicks { get; set; }
        /// <summary>Gets or sets the id of the media segment.</summary>
        public Guid? Id { get; set; }
        /// <summary>Gets or sets the id of the associated item.</summary>
        public Guid? ItemId { get; set; }
        /// <summary>Gets or sets the start of the segment.</summary>
        public long? StartTicks { get; set; }
        /// <summary>Defines the types of content an individual Jellyfin.Data.Entities.MediaSegment represents.</summary>
        public global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto_Type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "EndTicks", n => { EndTicks = n.GetLongValue(); } },
                { "Id", n => { Id = n.GetGuidValue(); } },
                { "ItemId", n => { ItemId = n.GetGuidValue(); } },
                { "StartTicks", n => { StartTicks = n.GetLongValue(); } },
                { "Type", n => { Type = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto_Type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("EndTicks", EndTicks);
            writer.WriteGuidValue("Id", Id);
            writer.WriteGuidValue("ItemId", ItemId);
            writer.WriteLongValue("StartTicks", StartTicks);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto_Type>("Type", Type);
        }
    }
}
#pragma warning restore CS0618
