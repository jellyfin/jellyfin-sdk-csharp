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
    public partial class RemoteSearchResult : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The AlbumArtist property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult? AlbumArtist { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult AlbumArtist { get; set; }
#endif
        /// <summary>The Artists property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult>? Artists { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult> Artists { get; set; }
#endif
        /// <summary>The ImageUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageUrl { get; set; }
#nullable restore
#else
        public string ImageUrl { get; set; }
#endif
        /// <summary>The IndexNumber property</summary>
        public int? IndexNumber { get; set; }
        /// <summary>The IndexNumberEnd property</summary>
        public int? IndexNumberEnd { get; set; }
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Overview property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Overview { get; set; }
#nullable restore
#else
        public string Overview { get; set; }
#endif
        /// <summary>The ParentIndexNumber property</summary>
        public int? ParentIndexNumber { get; set; }
        /// <summary>The PremiereDate property</summary>
        public DateTimeOffset? PremiereDate { get; set; }
        /// <summary>Gets or sets the year.</summary>
        public int? ProductionYear { get; set; }
        /// <summary>Gets or sets the provider ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult_ProviderIds? ProviderIds { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult_ProviderIds ProviderIds { get; set; }
#endif
        /// <summary>The SearchProviderName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SearchProviderName { get; set; }
#nullable restore
#else
        public string SearchProviderName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AlbumArtist", n => { AlbumArtist = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult>(global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult.CreateFromDiscriminatorValue); } },
                { "Artists", n => { Artists = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult>(global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ImageUrl", n => { ImageUrl = n.GetStringValue(); } },
                { "IndexNumber", n => { IndexNumber = n.GetIntValue(); } },
                { "IndexNumberEnd", n => { IndexNumberEnd = n.GetIntValue(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "Overview", n => { Overview = n.GetStringValue(); } },
                { "ParentIndexNumber", n => { ParentIndexNumber = n.GetIntValue(); } },
                { "PremiereDate", n => { PremiereDate = n.GetDateTimeOffsetValue(); } },
                { "ProductionYear", n => { ProductionYear = n.GetIntValue(); } },
                { "ProviderIds", n => { ProviderIds = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult_ProviderIds>(global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult_ProviderIds.CreateFromDiscriminatorValue); } },
                { "SearchProviderName", n => { SearchProviderName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult>("AlbumArtist", AlbumArtist);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult>("Artists", Artists);
            writer.WriteStringValue("ImageUrl", ImageUrl);
            writer.WriteIntValue("IndexNumber", IndexNumber);
            writer.WriteIntValue("IndexNumberEnd", IndexNumberEnd);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("Overview", Overview);
            writer.WriteIntValue("ParentIndexNumber", ParentIndexNumber);
            writer.WriteDateTimeOffsetValue("PremiereDate", PremiereDate);
            writer.WriteIntValue("ProductionYear", ProductionYear);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.RemoteSearchResult_ProviderIds>("ProviderIds", ProviderIds);
            writer.WriteStringValue("SearchProviderName", SearchProviderName);
        }
    }
}
#pragma warning restore CS0618
