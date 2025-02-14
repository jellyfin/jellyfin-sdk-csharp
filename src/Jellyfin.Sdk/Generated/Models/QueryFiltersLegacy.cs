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
    public partial class QueryFiltersLegacy : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Genres property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Genres { get; set; }
#nullable restore
#else
        public List<string> Genres { get; set; }
#endif
        /// <summary>The OfficialRatings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OfficialRatings { get; set; }
#nullable restore
#else
        public List<string> OfficialRatings { get; set; }
#endif
        /// <summary>The Tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The Years property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Years { get; set; }
#nullable restore
#else
        public List<int?> Years { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.QueryFiltersLegacy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.QueryFiltersLegacy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.QueryFiltersLegacy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Genres", n => { Genres = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "OfficialRatings", n => { OfficialRatings = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "Tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "Years", n => { Years = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("Genres", Genres);
            writer.WriteCollectionOfPrimitiveValues<string>("OfficialRatings", OfficialRatings);
            writer.WriteCollectionOfPrimitiveValues<string>("Tags", Tags);
            writer.WriteCollectionOfPrimitiveValues<int?>("Years", Years);
        }
    }
}
#pragma warning restore CS0618
