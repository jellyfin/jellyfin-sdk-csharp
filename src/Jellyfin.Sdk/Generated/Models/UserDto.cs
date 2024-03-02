// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class UserDto.
    /// </summary>
    public class UserDto : IParsable {
        /// <summary>Gets or sets the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserConfiguration? Configuration { get; set; }
#nullable restore
#else
        public UserConfiguration Configuration { get; set; }
#endif
        /// <summary>Gets or sets whether async login is enabled or not.</summary>
        public bool? EnableAutoLogin { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance has configured easy password.</summary>
        public bool? HasConfiguredEasyPassword { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance has configured password.</summary>
        public bool? HasConfiguredPassword { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance has password.</summary>
        public bool? HasPassword { get; set; }
        /// <summary>Gets or sets the id.</summary>
        public Guid? Id { get; set; }
        /// <summary>Gets or sets the last activity date.</summary>
        public DateTimeOffset? LastActivityDate { get; set; }
        /// <summary>Gets or sets the last login date.</summary>
        public DateTimeOffset? LastLoginDate { get; set; }
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserPolicy? Policy { get; set; }
#nullable restore
#else
        public UserPolicy Policy { get; set; }
#endif
        /// <summary>Gets or sets the primary image aspect ratio.</summary>
        public double? PrimaryImageAspectRatio { get; set; }
        /// <summary>Gets or sets the primary image tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryImageTag { get; set; }
#nullable restore
#else
        public string PrimaryImageTag { get; set; }
#endif
        /// <summary>Gets or sets the server identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerId { get; set; }
#nullable restore
#else
        public string ServerId { get; set; }
#endif
        /// <summary>Gets or sets the name of the server.This is not used by the server and is for client-side usage only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerName { get; set; }
#nullable restore
#else
        public string ServerName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Configuration", n => { Configuration = n.GetObjectValue<UserConfiguration>(UserConfiguration.CreateFromDiscriminatorValue); } },
                {"EnableAutoLogin", n => { EnableAutoLogin = n.GetBoolValue(); } },
                {"HasConfiguredEasyPassword", n => { HasConfiguredEasyPassword = n.GetBoolValue(); } },
                {"HasConfiguredPassword", n => { HasConfiguredPassword = n.GetBoolValue(); } },
                {"HasPassword", n => { HasPassword = n.GetBoolValue(); } },
                {"Id", n => { Id = n.GetGuidValue(); } },
                {"LastActivityDate", n => { LastActivityDate = n.GetDateTimeOffsetValue(); } },
                {"LastLoginDate", n => { LastLoginDate = n.GetDateTimeOffsetValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Policy", n => { Policy = n.GetObjectValue<UserPolicy>(UserPolicy.CreateFromDiscriminatorValue); } },
                {"PrimaryImageAspectRatio", n => { PrimaryImageAspectRatio = n.GetDoubleValue(); } },
                {"PrimaryImageTag", n => { PrimaryImageTag = n.GetStringValue(); } },
                {"ServerId", n => { ServerId = n.GetStringValue(); } },
                {"ServerName", n => { ServerName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UserConfiguration>("Configuration", Configuration);
            writer.WriteBoolValue("EnableAutoLogin", EnableAutoLogin);
            writer.WriteBoolValue("HasConfiguredEasyPassword", HasConfiguredEasyPassword);
            writer.WriteBoolValue("HasConfiguredPassword", HasConfiguredPassword);
            writer.WriteBoolValue("HasPassword", HasPassword);
            writer.WriteGuidValue("Id", Id);
            writer.WriteDateTimeOffsetValue("LastActivityDate", LastActivityDate);
            writer.WriteDateTimeOffsetValue("LastLoginDate", LastLoginDate);
            writer.WriteStringValue("Name", Name);
            writer.WriteObjectValue<UserPolicy>("Policy", Policy);
            writer.WriteDoubleValue("PrimaryImageAspectRatio", PrimaryImageAspectRatio);
            writer.WriteStringValue("PrimaryImageTag", PrimaryImageTag);
            writer.WriteStringValue("ServerId", ServerId);
            writer.WriteStringValue("ServerName", ServerName);
        }
    }
}
