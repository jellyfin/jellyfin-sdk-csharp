// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class MetadataOptions.
    /// </summary>
    public class MetadataOptions : IParsable {
        /// <summary>The DisabledImageFetchers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisabledImageFetchers { get; set; }
#nullable restore
#else
        public List<string> DisabledImageFetchers { get; set; }
#endif
        /// <summary>The DisabledMetadataFetchers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisabledMetadataFetchers { get; set; }
#nullable restore
#else
        public List<string> DisabledMetadataFetchers { get; set; }
#endif
        /// <summary>The DisabledMetadataSavers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisabledMetadataSavers { get; set; }
#nullable restore
#else
        public List<string> DisabledMetadataSavers { get; set; }
#endif
        /// <summary>The ImageFetcherOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ImageFetcherOrder { get; set; }
#nullable restore
#else
        public List<string> ImageFetcherOrder { get; set; }
#endif
        /// <summary>The ItemType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemType { get; set; }
#nullable restore
#else
        public string ItemType { get; set; }
#endif
        /// <summary>The LocalMetadataReaderOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LocalMetadataReaderOrder { get; set; }
#nullable restore
#else
        public List<string> LocalMetadataReaderOrder { get; set; }
#endif
        /// <summary>The MetadataFetcherOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MetadataFetcherOrder { get; set; }
#nullable restore
#else
        public List<string> MetadataFetcherOrder { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MetadataOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MetadataOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DisabledImageFetchers", n => { DisabledImageFetchers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"DisabledMetadataFetchers", n => { DisabledMetadataFetchers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"DisabledMetadataSavers", n => { DisabledMetadataSavers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"ImageFetcherOrder", n => { ImageFetcherOrder = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"ItemType", n => { ItemType = n.GetStringValue(); } },
                {"LocalMetadataReaderOrder", n => { LocalMetadataReaderOrder = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"MetadataFetcherOrder", n => { MetadataFetcherOrder = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("DisabledImageFetchers", DisabledImageFetchers);
            writer.WriteCollectionOfPrimitiveValues<string>("DisabledMetadataFetchers", DisabledMetadataFetchers);
            writer.WriteCollectionOfPrimitiveValues<string>("DisabledMetadataSavers", DisabledMetadataSavers);
            writer.WriteCollectionOfPrimitiveValues<string>("ImageFetcherOrder", ImageFetcherOrder);
            writer.WriteStringValue("ItemType", ItemType);
            writer.WriteCollectionOfPrimitiveValues<string>("LocalMetadataReaderOrder", LocalMetadataReaderOrder);
            writer.WriteCollectionOfPrimitiveValues<string>("MetadataFetcherOrder", MetadataFetcherOrder);
        }
    }
}