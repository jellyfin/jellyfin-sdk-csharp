// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class UtcTimeResponse.
    /// </summary>
    public class UtcTimeResponse : IParsable 
    {
        /// <summary>Gets the UTC time when request has been received.</summary>
        public DateTimeOffset? RequestReceptionTime { get; set; }
        /// <summary>Gets the UTC time when response has been sent.</summary>
        public DateTimeOffset? ResponseTransmissionTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UtcTimeResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UtcTimeResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UtcTimeResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"RequestReceptionTime", n => { RequestReceptionTime = n.GetDateTimeOffsetValue(); } },
                {"ResponseTransmissionTime", n => { ResponseTransmissionTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("RequestReceptionTime", RequestReceptionTime);
            writer.WriteDateTimeOffsetValue("ResponseTransmissionTime", ResponseTransmissionTime);
        }
    }
}
