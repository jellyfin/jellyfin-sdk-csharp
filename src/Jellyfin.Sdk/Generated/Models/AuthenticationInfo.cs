// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    public class AuthenticationInfo : IParsable {
        /// <summary>Gets or sets the access token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessToken { get; set; }
#nullable restore
#else
        public string AccessToken { get; set; }
#endif
        /// <summary>Gets or sets the name of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppName { get; set; }
#nullable restore
#else
        public string AppName { get; set; }
#endif
        /// <summary>Gets or sets the application version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppVersion { get; set; }
#nullable restore
#else
        public string AppVersion { get; set; }
#endif
        /// <summary>Gets or sets the date created.</summary>
        public DateTimeOffset? DateCreated { get; set; }
        /// <summary>The DateLastActivity property</summary>
        public DateTimeOffset? DateLastActivity { get; set; }
        /// <summary>Gets or sets the date revoked.</summary>
        public DateTimeOffset? DateRevoked { get; set; }
        /// <summary>Gets or sets the device identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>Gets or sets the name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>Gets or sets the identifier.</summary>
        public long? Id { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance is active.</summary>
        public bool? IsActive { get; set; }
        /// <summary>Gets or sets the user identifier.</summary>
        public Guid? UserId { get; set; }
        /// <summary>The UserName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AuthenticationInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccessToken", n => { AccessToken = n.GetStringValue(); } },
                {"AppName", n => { AppName = n.GetStringValue(); } },
                {"AppVersion", n => { AppVersion = n.GetStringValue(); } },
                {"DateCreated", n => { DateCreated = n.GetDateTimeOffsetValue(); } },
                {"DateLastActivity", n => { DateLastActivity = n.GetDateTimeOffsetValue(); } },
                {"DateRevoked", n => { DateRevoked = n.GetDateTimeOffsetValue(); } },
                {"DeviceId", n => { DeviceId = n.GetStringValue(); } },
                {"DeviceName", n => { DeviceName = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetLongValue(); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"UserId", n => { UserId = n.GetGuidValue(); } },
                {"UserName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AccessToken", AccessToken);
            writer.WriteStringValue("AppName", AppName);
            writer.WriteStringValue("AppVersion", AppVersion);
            writer.WriteDateTimeOffsetValue("DateCreated", DateCreated);
            writer.WriteDateTimeOffsetValue("DateLastActivity", DateLastActivity);
            writer.WriteDateTimeOffsetValue("DateRevoked", DateRevoked);
            writer.WriteStringValue("DeviceId", DeviceId);
            writer.WriteStringValue("DeviceName", DeviceName);
            writer.WriteLongValue("Id", Id);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteGuidValue("UserId", UserId);
            writer.WriteStringValue("UserName", UserName);
        }
    }
}
