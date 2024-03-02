// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// The notification DTO.
    /// </summary>
    public class NotificationDto : IParsable {
        /// <summary>Gets or sets the notification date.</summary>
        public DateTimeOffset? Date { get; set; }
        /// <summary>Gets or sets the notification&apos;s description. Defaults to an empty string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Gets or sets the notification ID. Defaults to an empty string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Gets or sets a value indicating whether the notification has been read. Defaults to false.</summary>
        public bool? IsRead { get; set; }
        /// <summary>Gets or sets the notification level.</summary>
        public NotificationLevel? Level { get; set; }
        /// <summary>Gets or sets the notification&apos;s name. Defaults to an empty string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the notification&apos;s URL. Defaults to an empty string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>Gets or sets the notification&apos;s user ID. Defaults to an empty string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="NotificationDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NotificationDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NotificationDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Date", n => { Date = n.GetDateTimeOffsetValue(); } },
                {"Description", n => { Description = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetStringValue(); } },
                {"IsRead", n => { IsRead = n.GetBoolValue(); } },
                {"Level", n => { Level = n.GetEnumValue<NotificationLevel>(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Url", n => { Url = n.GetStringValue(); } },
                {"UserId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("Date", Date);
            writer.WriteStringValue("Description", Description);
            writer.WriteStringValue("Id", Id);
            writer.WriteBoolValue("IsRead", IsRead);
            writer.WriteEnumValue<NotificationLevel>("Level", Level);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("Url", Url);
            writer.WriteStringValue("UserId", UserId);
        }
    }
}
