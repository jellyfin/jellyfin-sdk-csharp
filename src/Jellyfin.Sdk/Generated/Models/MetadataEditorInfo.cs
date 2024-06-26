// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    #pragma warning disable CS1591
    public class MetadataEditorInfo : IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The ContentType property</summary>
        public MetadataEditorInfo_ContentType? ContentType { get; set; }
        /// <summary>The ContentTypeOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NameValuePair>? ContentTypeOptions { get; set; }
#nullable restore
#else
        public List<NameValuePair> ContentTypeOptions { get; set; }
#endif
        /// <summary>The Countries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CountryInfo>? Countries { get; set; }
#nullable restore
#else
        public List<CountryInfo> Countries { get; set; }
#endif
        /// <summary>The Cultures property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CultureDto>? Cultures { get; set; }
#nullable restore
#else
        public List<CultureDto> Cultures { get; set; }
#endif
        /// <summary>The ExternalIdInfos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExternalIdInfo>? ExternalIdInfos { get; set; }
#nullable restore
#else
        public List<ExternalIdInfo> ExternalIdInfos { get; set; }
#endif
        /// <summary>The ParentalRatingOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ParentalRating>? ParentalRatingOptions { get; set; }
#nullable restore
#else
        public List<ParentalRating> ParentalRatingOptions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MetadataEditorInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MetadataEditorInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MetadataEditorInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"ContentType", n => { ContentType = n.GetEnumValue<MetadataEditorInfo_ContentType>(); } },
                {"ContentTypeOptions", n => { ContentTypeOptions = n.GetCollectionOfObjectValues<NameValuePair>(NameValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Countries", n => { Countries = n.GetCollectionOfObjectValues<CountryInfo>(CountryInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Cultures", n => { Cultures = n.GetCollectionOfObjectValues<CultureDto>(CultureDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ExternalIdInfos", n => { ExternalIdInfos = n.GetCollectionOfObjectValues<ExternalIdInfo>(ExternalIdInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ParentalRatingOptions", n => { ParentalRatingOptions = n.GetCollectionOfObjectValues<ParentalRating>(ParentalRating.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MetadataEditorInfo_ContentType>("ContentType", ContentType);
            writer.WriteCollectionOfObjectValues<NameValuePair>("ContentTypeOptions", ContentTypeOptions);
            writer.WriteCollectionOfObjectValues<CountryInfo>("Countries", Countries);
            writer.WriteCollectionOfObjectValues<CultureDto>("Cultures", Cultures);
            writer.WriteCollectionOfObjectValues<ExternalIdInfo>("ExternalIdInfos", ExternalIdInfos);
            writer.WriteCollectionOfObjectValues<ParentalRating>("ParentalRatingOptions", ParentalRatingOptions);
        }
    }
}
