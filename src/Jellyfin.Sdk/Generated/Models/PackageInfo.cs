// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class PackageInfo.
    /// </summary>
    public class PackageInfo : IParsable {
        /// <summary>Gets or sets the category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; set; }
#nullable restore
#else
        public string Category { get; set; }
#endif
        /// <summary>Gets or sets a long description of the plugin containing features or helpful explanations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Gets or sets the guid of the assembly associated with this plugin.This is used to identify the proper item for automatic updates.</summary>
        public Guid? Guid { get; set; }
        /// <summary>Gets or sets the image url for the package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageUrl { get; set; }
#nullable restore
#else
        public string ImageUrl { get; set; }
#endif
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets a short overview of what the plugin does.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Overview { get; set; }
#nullable restore
#else
        public string Overview { get; set; }
#endif
        /// <summary>Gets or sets the owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner { get; set; }
#nullable restore
#else
        public string Owner { get; set; }
#endif
        /// <summary>Gets or sets the versions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VersionInfo>? Versions { get; set; }
#nullable restore
#else
        public List<VersionInfo> Versions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PackageInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PackageInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PackageInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"category", n => { Category = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"guid", n => { Guid = n.GetGuidValue(); } },
                {"imageUrl", n => { ImageUrl = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"overview", n => { Overview = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<VersionInfo>(VersionInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("description", Description);
            writer.WriteGuidValue("guid", Guid);
            writer.WriteStringValue("imageUrl", ImageUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("overview", Overview);
            writer.WriteStringValue("owner", Owner);
            writer.WriteCollectionOfObjectValues<VersionInfo>("versions", Versions);
        }
    }
}
