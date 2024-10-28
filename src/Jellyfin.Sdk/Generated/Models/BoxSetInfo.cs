// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Jellyfin.Sdk.Generated.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class BoxSetInfo : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The IndexNumber property</summary>
        public int? IndexNumber { get; set; }
        /// <summary>The IsAutomated property</summary>
        public bool? IsAutomated { get; set; }
        /// <summary>Gets or sets the metadata country code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MetadataCountryCode { get; set; }
#nullable restore
#else
        public string MetadataCountryCode { get; set; }
#endif
        /// <summary>Gets or sets the metadata language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MetadataLanguage { get; set; }
#nullable restore
#else
        public string MetadataLanguage { get; set; }
#endif
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the original title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalTitle { get; set; }
#nullable restore
#else
        public string OriginalTitle { get; set; }
#endif
        /// <summary>The ParentIndexNumber property</summary>
        public int? ParentIndexNumber { get; set; }
        /// <summary>Gets or sets the path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The PremiereDate property</summary>
        public DateTimeOffset? PremiereDate { get; set; }
        /// <summary>Gets or sets the provider ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BoxSetInfo_ProviderIds? ProviderIds { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BoxSetInfo_ProviderIds ProviderIds { get; set; }
#endif
        /// <summary>Gets or sets the year.</summary>
        public int? Year { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.BoxSetInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.BoxSetInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.BoxSetInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "IndexNumber", n => { IndexNumber = n.GetIntValue(); } },
                { "IsAutomated", n => { IsAutomated = n.GetBoolValue(); } },
                { "MetadataCountryCode", n => { MetadataCountryCode = n.GetStringValue(); } },
                { "MetadataLanguage", n => { MetadataLanguage = n.GetStringValue(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "OriginalTitle", n => { OriginalTitle = n.GetStringValue(); } },
                { "ParentIndexNumber", n => { ParentIndexNumber = n.GetIntValue(); } },
                { "Path", n => { Path = n.GetStringValue(); } },
                { "PremiereDate", n => { PremiereDate = n.GetDateTimeOffsetValue(); } },
                { "ProviderIds", n => { ProviderIds = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BoxSetInfo_ProviderIds>(global::Jellyfin.Sdk.Generated.Models.BoxSetInfo_ProviderIds.CreateFromDiscriminatorValue); } },
                { "Year", n => { Year = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("IndexNumber", IndexNumber);
            writer.WriteBoolValue("IsAutomated", IsAutomated);
            writer.WriteStringValue("MetadataCountryCode", MetadataCountryCode);
            writer.WriteStringValue("MetadataLanguage", MetadataLanguage);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("OriginalTitle", OriginalTitle);
            writer.WriteIntValue("ParentIndexNumber", ParentIndexNumber);
            writer.WriteStringValue("Path", Path);
            writer.WriteDateTimeOffsetValue("PremiereDate", PremiereDate);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BoxSetInfo_ProviderIds>("ProviderIds", ProviderIds);
            writer.WriteIntValue("Year", Year);
        }
    }
}
#pragma warning restore CS0618
