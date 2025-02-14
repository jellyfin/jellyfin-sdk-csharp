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
    /// Query result container.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MediaSegmentDtoQueryResult : IParsable
    {
        /// <summary>Gets or sets the items.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto>? Items { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto> Items { get; set; }
#endif
        /// <summary>Gets or sets the index of the first record in Items.</summary>
        public int? StartIndex { get; set; }
        /// <summary>Gets or sets the total number of records available.</summary>
        public int? TotalRecordCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.MediaSegmentDtoQueryResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.MediaSegmentDtoQueryResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.MediaSegmentDtoQueryResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Items", n => { Items = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto>(global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto.CreateFromDiscriminatorValue)?.AsList(); } },
                { "StartIndex", n => { StartIndex = n.GetIntValue(); } },
                { "TotalRecordCount", n => { TotalRecordCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.MediaSegmentDto>("Items", Items);
            writer.WriteIntValue("StartIndex", StartIndex);
            writer.WriteIntValue("TotalRecordCount", TotalRecordCount);
        }
    }
}
#pragma warning restore CS0618
