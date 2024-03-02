// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    public class ForgotPasswordResult : IParsable {
        /// <summary>Gets or sets the action.</summary>
        public ForgotPasswordAction? Action { get; set; }
        /// <summary>Gets or sets the pin expiration date.</summary>
        public DateTimeOffset? PinExpirationDate { get; set; }
        /// <summary>Gets or sets the pin file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PinFile { get; set; }
#nullable restore
#else
        public string PinFile { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ForgotPasswordResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ForgotPasswordResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ForgotPasswordResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Action", n => { Action = n.GetEnumValue<ForgotPasswordAction>(); } },
                {"PinExpirationDate", n => { PinExpirationDate = n.GetDateTimeOffsetValue(); } },
                {"PinFile", n => { PinFile = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ForgotPasswordAction>("Action", Action);
            writer.WriteDateTimeOffsetValue("PinExpirationDate", PinExpirationDate);
            writer.WriteStringValue("PinFile", PinFile);
        }
    }
}
