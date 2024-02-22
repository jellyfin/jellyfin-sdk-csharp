// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    public class CodecProfile : IParsable {
        /// <summary>The ApplyConditions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProfileCondition>? ApplyConditions { get; set; }
#nullable restore
#else
        public List<ProfileCondition> ApplyConditions { get; set; }
#endif
        /// <summary>The Codec property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Codec { get; set; }
#nullable restore
#else
        public string Codec { get; set; }
#endif
        /// <summary>The Conditions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProfileCondition>? Conditions { get; set; }
#nullable restore
#else
        public List<ProfileCondition> Conditions { get; set; }
#endif
        /// <summary>The Container property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Container { get; set; }
#nullable restore
#else
        public string Container { get; set; }
#endif
        /// <summary>The Type property</summary>
        public CodecType? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CodecProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CodecProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ApplyConditions", n => { ApplyConditions = n.GetCollectionOfObjectValues<ProfileCondition>(ProfileCondition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Codec", n => { Codec = n.GetStringValue(); } },
                {"Conditions", n => { Conditions = n.GetCollectionOfObjectValues<ProfileCondition>(ProfileCondition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Container", n => { Container = n.GetStringValue(); } },
                {"Type", n => { Type = n.GetEnumValue<CodecType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ProfileCondition>("ApplyConditions", ApplyConditions);
            writer.WriteStringValue("Codec", Codec);
            writer.WriteCollectionOfObjectValues<ProfileCondition>("Conditions", Conditions);
            writer.WriteStringValue("Container", Container);
            writer.WriteEnumValue<CodecType>("Type", Type);
        }
    }
}