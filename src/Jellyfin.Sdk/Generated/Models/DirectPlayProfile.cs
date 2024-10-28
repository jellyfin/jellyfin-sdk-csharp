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
    /// Defines the MediaBrowser.Model.Dlna.DirectPlayProfile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DirectPlayProfile : IParsable
    {
        /// <summary>Gets or sets the audio codec.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AudioCodec { get; set; }
#nullable restore
#else
        public string AudioCodec { get; set; }
#endif
        /// <summary>Gets or sets the container.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Container { get; set; }
#nullable restore
#else
        public string Container { get; set; }
#endif
        /// <summary>Gets or sets the Dlna profile type.</summary>
        public global::Jellyfin.Sdk.Generated.Models.DirectPlayProfile_Type? Type { get; set; }
        /// <summary>Gets or sets the video codec.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoCodec { get; set; }
#nullable restore
#else
        public string VideoCodec { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.DirectPlayProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.DirectPlayProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.DirectPlayProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AudioCodec", n => { AudioCodec = n.GetStringValue(); } },
                { "Container", n => { Container = n.GetStringValue(); } },
                { "Type", n => { Type = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.DirectPlayProfile_Type>(); } },
                { "VideoCodec", n => { VideoCodec = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AudioCodec", AudioCodec);
            writer.WriteStringValue("Container", Container);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.DirectPlayProfile_Type>("Type", Type);
            writer.WriteStringValue("VideoCodec", VideoCodec);
        }
    }
}
#pragma warning restore CS0618
