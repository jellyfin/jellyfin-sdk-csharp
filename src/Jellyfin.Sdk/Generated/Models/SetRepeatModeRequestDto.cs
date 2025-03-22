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
    /// Class SetRepeatModeRequestDto.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SetRepeatModeRequestDto : IParsable
    {
        /// <summary>Enum GroupRepeatMode.</summary>
        public global::Jellyfin.Sdk.Generated.Models.SetRepeatModeRequestDto_Mode? Mode { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.SetRepeatModeRequestDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.SetRepeatModeRequestDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.SetRepeatModeRequestDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Mode", n => { Mode = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.SetRepeatModeRequestDto_Mode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.SetRepeatModeRequestDto_Mode>("Mode", Mode);
        }
    }
}
#pragma warning restore CS0618
