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
    public partial class UserPolicy : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The AccessSchedules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.AccessSchedule>? AccessSchedules { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.AccessSchedule> AccessSchedules { get; set; }
#endif
        /// <summary>The AllowedTags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedTags { get; set; }
#nullable restore
#else
        public List<string> AllowedTags { get; set; }
#endif
        /// <summary>The AuthenticationProviderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationProviderId { get; set; }
#nullable restore
#else
        public string AuthenticationProviderId { get; set; }
#endif
        /// <summary>The BlockedChannels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? BlockedChannels { get; set; }
#nullable restore
#else
        public List<Guid?> BlockedChannels { get; set; }
#endif
        /// <summary>The BlockedMediaFolders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? BlockedMediaFolders { get; set; }
#nullable restore
#else
        public List<Guid?> BlockedMediaFolders { get; set; }
#endif
        /// <summary>The BlockedTags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BlockedTags { get; set; }
#nullable restore
#else
        public List<string> BlockedTags { get; set; }
#endif
        /// <summary>The BlockUnratedItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.UnratedItem?>? BlockUnratedItems { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.UnratedItem?> BlockUnratedItems { get; set; }
#endif
        /// <summary>The EnableAllChannels property</summary>
        public bool? EnableAllChannels { get; set; }
        /// <summary>The EnableAllDevices property</summary>
        public bool? EnableAllDevices { get; set; }
        /// <summary>The EnableAllFolders property</summary>
        public bool? EnableAllFolders { get; set; }
        /// <summary>The EnableAudioPlaybackTranscoding property</summary>
        public bool? EnableAudioPlaybackTranscoding { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance can manage collections.</summary>
        public bool? EnableCollectionManagement { get; set; }
        /// <summary>The EnableContentDeletion property</summary>
        public bool? EnableContentDeletion { get; set; }
        /// <summary>The EnableContentDeletionFromFolders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnableContentDeletionFromFolders { get; set; }
#nullable restore
#else
        public List<string> EnableContentDeletionFromFolders { get; set; }
#endif
        /// <summary>The EnableContentDownloading property</summary>
        public bool? EnableContentDownloading { get; set; }
        /// <summary>The EnabledChannels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? EnabledChannels { get; set; }
#nullable restore
#else
        public List<Guid?> EnabledChannels { get; set; }
#endif
        /// <summary>The EnabledDevices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledDevices { get; set; }
#nullable restore
#else
        public List<string> EnabledDevices { get; set; }
#endif
        /// <summary>The EnabledFolders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? EnabledFolders { get; set; }
#nullable restore
#else
        public List<Guid?> EnabledFolders { get; set; }
#endif
        /// <summary>The EnableLiveTvAccess property</summary>
        public bool? EnableLiveTvAccess { get; set; }
        /// <summary>The EnableLiveTvManagement property</summary>
        public bool? EnableLiveTvManagement { get; set; }
        /// <summary>Gets or sets a value indicating whether this user can manage lyrics.</summary>
        public bool? EnableLyricManagement { get; set; }
        /// <summary>The EnableMediaConversion property</summary>
        public bool? EnableMediaConversion { get; set; }
        /// <summary>The EnableMediaPlayback property</summary>
        public bool? EnableMediaPlayback { get; set; }
        /// <summary>The EnablePlaybackRemuxing property</summary>
        public bool? EnablePlaybackRemuxing { get; set; }
        /// <summary>The EnablePublicSharing property</summary>
        public bool? EnablePublicSharing { get; set; }
        /// <summary>The EnableRemoteAccess property</summary>
        public bool? EnableRemoteAccess { get; set; }
        /// <summary>The EnableRemoteControlOfOtherUsers property</summary>
        public bool? EnableRemoteControlOfOtherUsers { get; set; }
        /// <summary>The EnableSharedDeviceControl property</summary>
        public bool? EnableSharedDeviceControl { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance can manage subtitles.</summary>
        public bool? EnableSubtitleManagement { get; set; }
        /// <summary>Gets or sets a value indicating whether [enable synchronize].</summary>
        public bool? EnableSyncTranscoding { get; set; }
        /// <summary>The EnableUserPreferenceAccess property</summary>
        public bool? EnableUserPreferenceAccess { get; set; }
        /// <summary>The EnableVideoPlaybackTranscoding property</summary>
        public bool? EnableVideoPlaybackTranscoding { get; set; }
        /// <summary>The ForceRemoteSourceTranscoding property</summary>
        public bool? ForceRemoteSourceTranscoding { get; set; }
        /// <summary>The InvalidLoginAttemptCount property</summary>
        public int? InvalidLoginAttemptCount { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance is administrator.</summary>
        public bool? IsAdministrator { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance is disabled.</summary>
        public bool? IsDisabled { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance is hidden.</summary>
        public bool? IsHidden { get; set; }
        /// <summary>The LoginAttemptsBeforeLockout property</summary>
        public int? LoginAttemptsBeforeLockout { get; set; }
        /// <summary>The MaxActiveSessions property</summary>
        public int? MaxActiveSessions { get; set; }
        /// <summary>Gets or sets the max parental rating.</summary>
        public int? MaxParentalRating { get; set; }
        /// <summary>The PasswordResetProviderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PasswordResetProviderId { get; set; }
#nullable restore
#else
        public string PasswordResetProviderId { get; set; }
#endif
        /// <summary>The RemoteClientBitrateLimit property</summary>
        public int? RemoteClientBitrateLimit { get; set; }
        /// <summary>Gets or sets a value indicating what SyncPlay features the user can access.</summary>
        public global::Jellyfin.Sdk.Generated.Models.UserPolicy_SyncPlayAccess? SyncPlayAccess { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.UserPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.UserPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.UserPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AccessSchedules", n => { AccessSchedules = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.AccessSchedule>(global::Jellyfin.Sdk.Generated.Models.AccessSchedule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "AllowedTags", n => { AllowedTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "AuthenticationProviderId", n => { AuthenticationProviderId = n.GetStringValue(); } },
                { "BlockUnratedItems", n => { BlockUnratedItems = n.GetCollectionOfEnumValues<global::Jellyfin.Sdk.Generated.Models.UnratedItem>()?.AsList(); } },
                { "BlockedChannels", n => { BlockedChannels = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "BlockedMediaFolders", n => { BlockedMediaFolders = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "BlockedTags", n => { BlockedTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "EnableAllChannels", n => { EnableAllChannels = n.GetBoolValue(); } },
                { "EnableAllDevices", n => { EnableAllDevices = n.GetBoolValue(); } },
                { "EnableAllFolders", n => { EnableAllFolders = n.GetBoolValue(); } },
                { "EnableAudioPlaybackTranscoding", n => { EnableAudioPlaybackTranscoding = n.GetBoolValue(); } },
                { "EnableCollectionManagement", n => { EnableCollectionManagement = n.GetBoolValue(); } },
                { "EnableContentDeletion", n => { EnableContentDeletion = n.GetBoolValue(); } },
                { "EnableContentDeletionFromFolders", n => { EnableContentDeletionFromFolders = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "EnableContentDownloading", n => { EnableContentDownloading = n.GetBoolValue(); } },
                { "EnableLiveTvAccess", n => { EnableLiveTvAccess = n.GetBoolValue(); } },
                { "EnableLiveTvManagement", n => { EnableLiveTvManagement = n.GetBoolValue(); } },
                { "EnableLyricManagement", n => { EnableLyricManagement = n.GetBoolValue(); } },
                { "EnableMediaConversion", n => { EnableMediaConversion = n.GetBoolValue(); } },
                { "EnableMediaPlayback", n => { EnableMediaPlayback = n.GetBoolValue(); } },
                { "EnablePlaybackRemuxing", n => { EnablePlaybackRemuxing = n.GetBoolValue(); } },
                { "EnablePublicSharing", n => { EnablePublicSharing = n.GetBoolValue(); } },
                { "EnableRemoteAccess", n => { EnableRemoteAccess = n.GetBoolValue(); } },
                { "EnableRemoteControlOfOtherUsers", n => { EnableRemoteControlOfOtherUsers = n.GetBoolValue(); } },
                { "EnableSharedDeviceControl", n => { EnableSharedDeviceControl = n.GetBoolValue(); } },
                { "EnableSubtitleManagement", n => { EnableSubtitleManagement = n.GetBoolValue(); } },
                { "EnableSyncTranscoding", n => { EnableSyncTranscoding = n.GetBoolValue(); } },
                { "EnableUserPreferenceAccess", n => { EnableUserPreferenceAccess = n.GetBoolValue(); } },
                { "EnableVideoPlaybackTranscoding", n => { EnableVideoPlaybackTranscoding = n.GetBoolValue(); } },
                { "EnabledChannels", n => { EnabledChannels = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "EnabledDevices", n => { EnabledDevices = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "EnabledFolders", n => { EnabledFolders = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "ForceRemoteSourceTranscoding", n => { ForceRemoteSourceTranscoding = n.GetBoolValue(); } },
                { "InvalidLoginAttemptCount", n => { InvalidLoginAttemptCount = n.GetIntValue(); } },
                { "IsAdministrator", n => { IsAdministrator = n.GetBoolValue(); } },
                { "IsDisabled", n => { IsDisabled = n.GetBoolValue(); } },
                { "IsHidden", n => { IsHidden = n.GetBoolValue(); } },
                { "LoginAttemptsBeforeLockout", n => { LoginAttemptsBeforeLockout = n.GetIntValue(); } },
                { "MaxActiveSessions", n => { MaxActiveSessions = n.GetIntValue(); } },
                { "MaxParentalRating", n => { MaxParentalRating = n.GetIntValue(); } },
                { "PasswordResetProviderId", n => { PasswordResetProviderId = n.GetStringValue(); } },
                { "RemoteClientBitrateLimit", n => { RemoteClientBitrateLimit = n.GetIntValue(); } },
                { "SyncPlayAccess", n => { SyncPlayAccess = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.UserPolicy_SyncPlayAccess>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.AccessSchedule>("AccessSchedules", AccessSchedules);
            writer.WriteCollectionOfPrimitiveValues<string>("AllowedTags", AllowedTags);
            writer.WriteStringValue("AuthenticationProviderId", AuthenticationProviderId);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("BlockedChannels", BlockedChannels);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("BlockedMediaFolders", BlockedMediaFolders);
            writer.WriteCollectionOfPrimitiveValues<string>("BlockedTags", BlockedTags);
            writer.WriteCollectionOfEnumValues<global::Jellyfin.Sdk.Generated.Models.UnratedItem>("BlockUnratedItems", BlockUnratedItems);
            writer.WriteBoolValue("EnableAllChannels", EnableAllChannels);
            writer.WriteBoolValue("EnableAllDevices", EnableAllDevices);
            writer.WriteBoolValue("EnableAllFolders", EnableAllFolders);
            writer.WriteBoolValue("EnableAudioPlaybackTranscoding", EnableAudioPlaybackTranscoding);
            writer.WriteBoolValue("EnableCollectionManagement", EnableCollectionManagement);
            writer.WriteBoolValue("EnableContentDeletion", EnableContentDeletion);
            writer.WriteCollectionOfPrimitiveValues<string>("EnableContentDeletionFromFolders", EnableContentDeletionFromFolders);
            writer.WriteBoolValue("EnableContentDownloading", EnableContentDownloading);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("EnabledChannels", EnabledChannels);
            writer.WriteCollectionOfPrimitiveValues<string>("EnabledDevices", EnabledDevices);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("EnabledFolders", EnabledFolders);
            writer.WriteBoolValue("EnableLiveTvAccess", EnableLiveTvAccess);
            writer.WriteBoolValue("EnableLiveTvManagement", EnableLiveTvManagement);
            writer.WriteBoolValue("EnableLyricManagement", EnableLyricManagement);
            writer.WriteBoolValue("EnableMediaConversion", EnableMediaConversion);
            writer.WriteBoolValue("EnableMediaPlayback", EnableMediaPlayback);
            writer.WriteBoolValue("EnablePlaybackRemuxing", EnablePlaybackRemuxing);
            writer.WriteBoolValue("EnablePublicSharing", EnablePublicSharing);
            writer.WriteBoolValue("EnableRemoteAccess", EnableRemoteAccess);
            writer.WriteBoolValue("EnableRemoteControlOfOtherUsers", EnableRemoteControlOfOtherUsers);
            writer.WriteBoolValue("EnableSharedDeviceControl", EnableSharedDeviceControl);
            writer.WriteBoolValue("EnableSubtitleManagement", EnableSubtitleManagement);
            writer.WriteBoolValue("EnableSyncTranscoding", EnableSyncTranscoding);
            writer.WriteBoolValue("EnableUserPreferenceAccess", EnableUserPreferenceAccess);
            writer.WriteBoolValue("EnableVideoPlaybackTranscoding", EnableVideoPlaybackTranscoding);
            writer.WriteBoolValue("ForceRemoteSourceTranscoding", ForceRemoteSourceTranscoding);
            writer.WriteIntValue("InvalidLoginAttemptCount", InvalidLoginAttemptCount);
            writer.WriteBoolValue("IsAdministrator", IsAdministrator);
            writer.WriteBoolValue("IsDisabled", IsDisabled);
            writer.WriteBoolValue("IsHidden", IsHidden);
            writer.WriteIntValue("LoginAttemptsBeforeLockout", LoginAttemptsBeforeLockout);
            writer.WriteIntValue("MaxActiveSessions", MaxActiveSessions);
            writer.WriteIntValue("MaxParentalRating", MaxParentalRating);
            writer.WriteStringValue("PasswordResetProviderId", PasswordResetProviderId);
            writer.WriteIntValue("RemoteClientBitrateLimit", RemoteClientBitrateLimit);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.UserPolicy_SyncPlayAccess>("SyncPlayAccess", SyncPlayAccess);
        }
    }
}
#pragma warning restore CS0618
