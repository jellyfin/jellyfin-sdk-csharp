// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class CountryInfo.
    /// </summary>
    public class CountryInfo : IParsable {
        /// <summary>Gets or sets the display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the name of the three letter ISO region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreeLetterISORegionName { get; set; }
#nullable restore
#else
        public string ThreeLetterISORegionName { get; set; }
#endif
        /// <summary>Gets or sets the name of the two letter ISO region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TwoLetterISORegionName { get; set; }
#nullable restore
#else
        public string TwoLetterISORegionName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CountryInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CountryInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DisplayName", n => { DisplayName = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"ThreeLetterISORegionName", n => { ThreeLetterISORegionName = n.GetStringValue(); } },
                {"TwoLetterISORegionName", n => { TwoLetterISORegionName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("DisplayName", DisplayName);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("ThreeLetterISORegionName", ThreeLetterISORegionName);
            writer.WriteStringValue("TwoLetterISORegionName", TwoLetterISORegionName);
        }
    }
}