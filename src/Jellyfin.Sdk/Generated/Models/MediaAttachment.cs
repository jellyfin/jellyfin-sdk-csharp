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
    /// Class MediaAttachment.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MediaAttachment : IParsable
    {
        /// <summary>Gets or sets the codec.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Codec { get; set; }
#nullable restore
#else
        public string Codec { get; set; }
#endif
        /// <summary>Gets or sets the codec tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CodecTag { get; set; }
#nullable restore
#else
        public string CodecTag { get; set; }
#endif
        /// <summary>Gets or sets the comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>Gets or sets the delivery URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryUrl { get; set; }
#nullable restore
#else
        public string DeliveryUrl { get; set; }
#endif
        /// <summary>Gets or sets the filename.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>Gets or sets the index.</summary>
        public int? Index { get; set; }
        /// <summary>Gets or sets the MIME type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MimeType { get; set; }
#nullable restore
#else
        public string MimeType { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.MediaAttachment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.MediaAttachment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.MediaAttachment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Codec", n => { Codec = n.GetStringValue(); } },
                { "CodecTag", n => { CodecTag = n.GetStringValue(); } },
                { "Comment", n => { Comment = n.GetStringValue(); } },
                { "DeliveryUrl", n => { DeliveryUrl = n.GetStringValue(); } },
                { "FileName", n => { FileName = n.GetStringValue(); } },
                { "Index", n => { Index = n.GetIntValue(); } },
                { "MimeType", n => { MimeType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Codec", Codec);
            writer.WriteStringValue("CodecTag", CodecTag);
            writer.WriteStringValue("Comment", Comment);
            writer.WriteStringValue("DeliveryUrl", DeliveryUrl);
            writer.WriteStringValue("FileName", FileName);
            writer.WriteIntValue("Index", Index);
            writer.WriteStringValue("MimeType", MimeType);
        }
    }
}
#pragma warning restore CS0618
