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
    /// Class InstallationInfo.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class InstallationInfo : IParsable
    {
        /// <summary>Gets or sets the changelog for this version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Changelog { get; set; }
#nullable restore
#else
        public string Changelog { get; set; }
#endif
        /// <summary>Gets or sets a checksum for the binary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Checksum { get; set; }
#nullable restore
#else
        public string Checksum { get; set; }
#endif
        /// <summary>Gets or sets the Id.</summary>
        public Guid? Guid { get; set; }
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets package information for the installation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.PackageInfo? PackageInfo { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.PackageInfo PackageInfo { get; set; }
#endif
        /// <summary>Gets or sets the source URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceUrl { get; set; }
#nullable restore
#else
        public string SourceUrl { get; set; }
#endif
        /// <summary>Gets or sets the version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.InstallationInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.InstallationInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.InstallationInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Changelog", n => { Changelog = n.GetStringValue(); } },
                { "Checksum", n => { Checksum = n.GetStringValue(); } },
                { "Guid", n => { Guid = n.GetGuidValue(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "PackageInfo", n => { PackageInfo = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.PackageInfo>(global::Jellyfin.Sdk.Generated.Models.PackageInfo.CreateFromDiscriminatorValue); } },
                { "SourceUrl", n => { SourceUrl = n.GetStringValue(); } },
                { "Version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Changelog", Changelog);
            writer.WriteStringValue("Checksum", Checksum);
            writer.WriteGuidValue("Guid", Guid);
            writer.WriteStringValue("Name", Name);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.PackageInfo>("PackageInfo", PackageInfo);
            writer.WriteStringValue("SourceUrl", SourceUrl);
            writer.WriteStringValue("Version", Version);
        }
    }
}
#pragma warning restore CS0618
