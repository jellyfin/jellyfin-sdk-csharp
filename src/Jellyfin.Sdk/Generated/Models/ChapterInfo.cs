// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class ChapterInfo.
    /// </summary>
    public class ChapterInfo : IParsable {
        /// <summary>The ImageDateModified property</summary>
        public DateTimeOffset? ImageDateModified { get; set; }
        /// <summary>Gets or sets the image path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImagePath { get; set; }
#nullable restore
#else
        public string ImagePath { get; set; }
#endif
        /// <summary>The ImageTag property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageTag { get; set; }
#nullable restore
#else
        public string ImageTag { get; set; }
#endif
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the start position ticks.</summary>
        public long? StartPositionTicks { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ChapterInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ChapterInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChapterInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ImageDateModified", n => { ImageDateModified = n.GetDateTimeOffsetValue(); } },
                {"ImagePath", n => { ImagePath = n.GetStringValue(); } },
                {"ImageTag", n => { ImageTag = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"StartPositionTicks", n => { StartPositionTicks = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("ImageDateModified", ImageDateModified);
            writer.WriteStringValue("ImagePath", ImagePath);
            writer.WriteStringValue("ImageTag", ImageTag);
            writer.WriteStringValue("Name", Name);
            writer.WriteLongValue("StartPositionTicks", StartPositionTicks);
        }
    }
}
