// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class ThemeMediaResult.
    /// </summary>
    public class ThemeMediaResult : IParsable {
        /// <summary>Gets or sets the items.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BaseItemDto>? Items { get; set; }
#nullable restore
#else
        public List<BaseItemDto> Items { get; set; }
#endif
        /// <summary>Gets or sets the owner id.</summary>
        public Guid? OwnerId { get; set; }
        /// <summary>Gets or sets the index of the first record in Items.</summary>
        public int? StartIndex { get; set; }
        /// <summary>Gets or sets the total number of records available.</summary>
        public int? TotalRecordCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ThemeMediaResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ThemeMediaResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Items", n => { Items = n.GetCollectionOfObjectValues<BaseItemDto>(BaseItemDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"OwnerId", n => { OwnerId = n.GetGuidValue(); } },
                {"StartIndex", n => { StartIndex = n.GetIntValue(); } },
                {"TotalRecordCount", n => { TotalRecordCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<BaseItemDto>("Items", Items);
            writer.WriteGuidValue("OwnerId", OwnerId);
            writer.WriteIntValue("StartIndex", StartIndex);
            writer.WriteIntValue("TotalRecordCount", TotalRecordCount);
        }
    }
}