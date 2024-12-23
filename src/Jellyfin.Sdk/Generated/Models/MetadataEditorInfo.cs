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
    public partial class MetadataEditorInfo : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ContentType property</summary>
        public global::Jellyfin.Sdk.Generated.Models.MetadataEditorInfo_ContentType? ContentType { get; set; }
        /// <summary>The ContentTypeOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.NameValuePair>? ContentTypeOptions { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.NameValuePair> ContentTypeOptions { get; set; }
#endif
        /// <summary>The Countries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.CountryInfo>? Countries { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.CountryInfo> Countries { get; set; }
#endif
        /// <summary>The Cultures property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.CultureDto>? Cultures { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.CultureDto> Cultures { get; set; }
#endif
        /// <summary>The ExternalIdInfos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo>? ExternalIdInfos { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo> ExternalIdInfos { get; set; }
#endif
        /// <summary>The ParentalRatingOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.ParentalRating>? ParentalRatingOptions { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.ParentalRating> ParentalRatingOptions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.MetadataEditorInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.MetadataEditorInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.MetadataEditorInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ContentType", n => { ContentType = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.MetadataEditorInfo_ContentType>(); } },
                { "ContentTypeOptions", n => { ContentTypeOptions = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.NameValuePair>(global::Jellyfin.Sdk.Generated.Models.NameValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "Countries", n => { Countries = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.CountryInfo>(global::Jellyfin.Sdk.Generated.Models.CountryInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "Cultures", n => { Cultures = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.CultureDto>(global::Jellyfin.Sdk.Generated.Models.CultureDto.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ExternalIdInfos", n => { ExternalIdInfos = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo>(global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ParentalRatingOptions", n => { ParentalRatingOptions = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.ParentalRating>(global::Jellyfin.Sdk.Generated.Models.ParentalRating.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.MetadataEditorInfo_ContentType>("ContentType", ContentType);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.NameValuePair>("ContentTypeOptions", ContentTypeOptions);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.CountryInfo>("Countries", Countries);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.CultureDto>("Cultures", Cultures);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.ExternalIdInfo>("ExternalIdInfos", ExternalIdInfos);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.ParentalRating>("ParentalRatingOptions", ParentalRatingOptions);
        }
    }
}
#pragma warning restore CS0618
