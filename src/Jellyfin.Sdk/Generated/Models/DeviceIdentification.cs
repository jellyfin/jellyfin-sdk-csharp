// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    public class DeviceIdentification : IParsable {
        /// <summary>Gets or sets the name of the friendly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FriendlyName { get; set; }
#nullable restore
#else
        public string FriendlyName { get; set; }
#endif
        /// <summary>Gets or sets the headers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HttpHeaderInfo>? Headers { get; set; }
#nullable restore
#else
        public List<HttpHeaderInfo> Headers { get; set; }
#endif
        /// <summary>Gets or sets the manufacturer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer { get; set; }
#nullable restore
#else
        public string Manufacturer { get; set; }
#endif
        /// <summary>Gets or sets the manufacturer URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManufacturerUrl { get; set; }
#nullable restore
#else
        public string ManufacturerUrl { get; set; }
#endif
        /// <summary>Gets or sets the model description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModelDescription { get; set; }
#nullable restore
#else
        public string ModelDescription { get; set; }
#endif
        /// <summary>Gets or sets the name of the model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModelName { get; set; }
#nullable restore
#else
        public string ModelName { get; set; }
#endif
        /// <summary>Gets or sets the model number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModelNumber { get; set; }
#nullable restore
#else
        public string ModelNumber { get; set; }
#endif
        /// <summary>Gets or sets the model URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModelUrl { get; set; }
#nullable restore
#else
        public string ModelUrl { get; set; }
#endif
        /// <summary>Gets or sets the serial number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; set; }
#nullable restore
#else
        public string SerialNumber { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceIdentification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceIdentification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceIdentification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"FriendlyName", n => { FriendlyName = n.GetStringValue(); } },
                {"Headers", n => { Headers = n.GetCollectionOfObjectValues<HttpHeaderInfo>(HttpHeaderInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"ManufacturerUrl", n => { ManufacturerUrl = n.GetStringValue(); } },
                {"ModelDescription", n => { ModelDescription = n.GetStringValue(); } },
                {"ModelName", n => { ModelName = n.GetStringValue(); } },
                {"ModelNumber", n => { ModelNumber = n.GetStringValue(); } },
                {"ModelUrl", n => { ModelUrl = n.GetStringValue(); } },
                {"SerialNumber", n => { SerialNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("FriendlyName", FriendlyName);
            writer.WriteCollectionOfObjectValues<HttpHeaderInfo>("Headers", Headers);
            writer.WriteStringValue("Manufacturer", Manufacturer);
            writer.WriteStringValue("ManufacturerUrl", ManufacturerUrl);
            writer.WriteStringValue("ModelDescription", ModelDescription);
            writer.WriteStringValue("ModelName", ModelName);
            writer.WriteStringValue("ModelNumber", ModelNumber);
            writer.WriteStringValue("ModelUrl", ModelUrl);
            writer.WriteStringValue("SerialNumber", SerialNumber);
        }
    }
}
