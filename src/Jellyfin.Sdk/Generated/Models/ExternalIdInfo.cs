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
    /// Represents the external id information for serialization to the client.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ExternalIdInfo : IParsable
    {
        /// <summary>Gets or sets the unique key for this id. This key should be unique across all providers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>Gets or sets the display name of the external id provider (IE: IMDB, MusicBrainz, etc).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the specific media type for this id. This is used to distinguish between the differentexternal id types for providers with multiple ids.A null value indicates there is no specific media type associated with the external id, or this is thedefault id for the external provider so there is no need to specify a type.</summary>
        public global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo_Type? Type { get; set; }
        /// <summary>Gets or sets the URL format string.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UrlFormatString { get; set; }
#nullable restore
#else
        public string UrlFormatString { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Key", n => { Key = n.GetStringValue(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "Type", n => { Type = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo_Type>(); } },
                { "UrlFormatString", n => { UrlFormatString = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Key", Key);
            writer.WriteStringValue("Name", Name);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo_Type>("Type", Type);
            writer.WriteStringValue("UrlFormatString", UrlFormatString);
        }
    }
}
#pragma warning restore CS0618
