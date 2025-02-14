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
    /// The remote lyric info dto.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RemoteLyricInfoDto : IParsable
    {
        /// <summary>Gets or sets the id for the lyric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Gets the lyrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.LyricDto? Lyrics { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.LyricDto Lyrics { get; set; }
#endif
        /// <summary>Gets the provider name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderName { get; set; }
#nullable restore
#else
        public string ProviderName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.RemoteLyricInfoDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.RemoteLyricInfoDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.RemoteLyricInfoDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Id", n => { Id = n.GetStringValue(); } },
                { "Lyrics", n => { Lyrics = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.LyricDto>(global::Jellyfin.Sdk.Generated.Models.LyricDto.CreateFromDiscriminatorValue); } },
                { "ProviderName", n => { ProviderName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Id", Id);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.LyricDto>("Lyrics", Lyrics);
            writer.WriteStringValue("ProviderName", ProviderName);
        }
    }
}
#pragma warning restore CS0618
