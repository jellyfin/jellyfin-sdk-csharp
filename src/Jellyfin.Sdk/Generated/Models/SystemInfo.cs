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
    /// Class SystemInfo.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SystemInfo : IParsable
    {
        /// <summary>Gets or sets the cache path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CachePath { get; set; }
#nullable restore
#else
        public string CachePath { get; set; }
#endif
        /// <summary>The CanLaunchWebBrowser property</summary>
        [Obsolete("")]
        public bool? CanLaunchWebBrowser { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance can self restart.</summary>
        [Obsolete("")]
        public bool? CanSelfRestart { get; set; }
        /// <summary>Gets or sets the list of cast receiver applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.CastReceiverApplication>? CastReceiverApplications { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.CastReceiverApplication> CastReceiverApplications { get; set; }
#endif
        /// <summary>Gets or sets the completed installations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.InstallationInfo>? CompletedInstallations { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.InstallationInfo> CompletedInstallations { get; set; }
#endif
        /// <summary>The EncoderLocation property</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncoderLocation { get; set; }
#nullable restore
#else
        public string EncoderLocation { get; set; }
#endif
        /// <summary>Gets or sets a value indicating whether this instance has pending restart.</summary>
        public bool? HasPendingRestart { get; set; }
        /// <summary>Gets or sets a value indicating whether this instance has update available.</summary>
        [Obsolete("")]
        public bool? HasUpdateAvailable { get; set; }
        /// <summary>Gets or sets the id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Gets or sets the internal metadata path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalMetadataPath { get; set; }
#nullable restore
#else
        public string InternalMetadataPath { get; set; }
#endif
        /// <summary>The IsShuttingDown property</summary>
        public bool? IsShuttingDown { get; set; }
        /// <summary>Gets or sets the items by name path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemsByNamePath { get; set; }
#nullable restore
#else
        public string ItemsByNamePath { get; set; }
#endif
        /// <summary>Gets or sets the local address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalAddress { get; set; }
#nullable restore
#else
        public string LocalAddress { get; set; }
#endif
        /// <summary>Gets or sets the log path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogPath { get; set; }
#nullable restore
#else
        public string LogPath { get; set; }
#endif
        /// <summary>Gets or sets the operating system.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem { get; set; }
#nullable restore
#else
        public string OperatingSystem { get; set; }
#endif
        /// <summary>Gets or sets the display name of the operating system.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystemDisplayName { get; set; }
#nullable restore
#else
        public string OperatingSystemDisplayName { get; set; }
#endif
        /// <summary>Gets or sets the package name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageName { get; set; }
#nullable restore
#else
        public string PackageName { get; set; }
#endif
        /// <summary>Gets or sets the product name. This is the AssemblyProduct name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName { get; set; }
#nullable restore
#else
        public string ProductName { get; set; }
#endif
        /// <summary>Gets or sets the program data path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProgramDataPath { get; set; }
#nullable restore
#else
        public string ProgramDataPath { get; set; }
#endif
        /// <summary>Gets or sets the name of the server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerName { get; set; }
#nullable restore
#else
        public string ServerName { get; set; }
#endif
        /// <summary>Gets or sets a value indicating whether the startup wizard is completed.</summary>
        public bool? StartupWizardCompleted { get; set; }
        /// <summary>Gets or sets a value indicating whether [supports library monitor].</summary>
        public bool? SupportsLibraryMonitor { get; set; }
        /// <summary>The SystemArchitecture property</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SystemArchitecture { get; set; }
#nullable restore
#else
        public string SystemArchitecture { get; set; }
#endif
        /// <summary>Gets or sets the transcode path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TranscodingTempPath { get; set; }
#nullable restore
#else
        public string TranscodingTempPath { get; set; }
#endif
        /// <summary>Gets or sets the server version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>Gets or sets the web UI resources path.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebPath { get; set; }
#nullable restore
#else
        public string WebPath { get; set; }
#endif
        /// <summary>Gets or sets the web socket port number.</summary>
        public int? WebSocketPortNumber { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Models.SystemInfo"/> and sets the default values.
        /// </summary>
        public SystemInfo()
        {
            EncoderLocation = "System";
            SystemArchitecture = "X64";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.SystemInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.SystemInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.SystemInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "CachePath", n => { CachePath = n.GetStringValue(); } },
                { "CanLaunchWebBrowser", n => { CanLaunchWebBrowser = n.GetBoolValue(); } },
                { "CanSelfRestart", n => { CanSelfRestart = n.GetBoolValue(); } },
                { "CastReceiverApplications", n => { CastReceiverApplications = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.CastReceiverApplication>(global::Jellyfin.Sdk.Generated.Models.CastReceiverApplication.CreateFromDiscriminatorValue)?.AsList(); } },
                { "CompletedInstallations", n => { CompletedInstallations = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.InstallationInfo>(global::Jellyfin.Sdk.Generated.Models.InstallationInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "EncoderLocation", n => { EncoderLocation = n.GetStringValue(); } },
                { "HasPendingRestart", n => { HasPendingRestart = n.GetBoolValue(); } },
                { "HasUpdateAvailable", n => { HasUpdateAvailable = n.GetBoolValue(); } },
                { "Id", n => { Id = n.GetStringValue(); } },
                { "InternalMetadataPath", n => { InternalMetadataPath = n.GetStringValue(); } },
                { "IsShuttingDown", n => { IsShuttingDown = n.GetBoolValue(); } },
                { "ItemsByNamePath", n => { ItemsByNamePath = n.GetStringValue(); } },
                { "LocalAddress", n => { LocalAddress = n.GetStringValue(); } },
                { "LogPath", n => { LogPath = n.GetStringValue(); } },
                { "OperatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                { "OperatingSystemDisplayName", n => { OperatingSystemDisplayName = n.GetStringValue(); } },
                { "PackageName", n => { PackageName = n.GetStringValue(); } },
                { "ProductName", n => { ProductName = n.GetStringValue(); } },
                { "ProgramDataPath", n => { ProgramDataPath = n.GetStringValue(); } },
                { "ServerName", n => { ServerName = n.GetStringValue(); } },
                { "StartupWizardCompleted", n => { StartupWizardCompleted = n.GetBoolValue(); } },
                { "SupportsLibraryMonitor", n => { SupportsLibraryMonitor = n.GetBoolValue(); } },
                { "SystemArchitecture", n => { SystemArchitecture = n.GetStringValue(); } },
                { "TranscodingTempPath", n => { TranscodingTempPath = n.GetStringValue(); } },
                { "Version", n => { Version = n.GetStringValue(); } },
                { "WebPath", n => { WebPath = n.GetStringValue(); } },
                { "WebSocketPortNumber", n => { WebSocketPortNumber = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("CachePath", CachePath);
            writer.WriteBoolValue("CanLaunchWebBrowser", CanLaunchWebBrowser);
            writer.WriteBoolValue("CanSelfRestart", CanSelfRestart);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.CastReceiverApplication>("CastReceiverApplications", CastReceiverApplications);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.InstallationInfo>("CompletedInstallations", CompletedInstallations);
            writer.WriteStringValue("EncoderLocation", EncoderLocation);
            writer.WriteBoolValue("HasPendingRestart", HasPendingRestart);
            writer.WriteBoolValue("HasUpdateAvailable", HasUpdateAvailable);
            writer.WriteStringValue("Id", Id);
            writer.WriteStringValue("InternalMetadataPath", InternalMetadataPath);
            writer.WriteBoolValue("IsShuttingDown", IsShuttingDown);
            writer.WriteStringValue("ItemsByNamePath", ItemsByNamePath);
            writer.WriteStringValue("LocalAddress", LocalAddress);
            writer.WriteStringValue("LogPath", LogPath);
            writer.WriteStringValue("OperatingSystem", OperatingSystem);
            writer.WriteStringValue("OperatingSystemDisplayName", OperatingSystemDisplayName);
            writer.WriteStringValue("PackageName", PackageName);
            writer.WriteStringValue("ProductName", ProductName);
            writer.WriteStringValue("ProgramDataPath", ProgramDataPath);
            writer.WriteStringValue("ServerName", ServerName);
            writer.WriteBoolValue("StartupWizardCompleted", StartupWizardCompleted);
            writer.WriteBoolValue("SupportsLibraryMonitor", SupportsLibraryMonitor);
            writer.WriteStringValue("SystemArchitecture", SystemArchitecture);
            writer.WriteStringValue("TranscodingTempPath", TranscodingTempPath);
            writer.WriteStringValue("Version", Version);
            writer.WriteStringValue("WebPath", WebPath);
            writer.WriteIntValue("WebSocketPortNumber", WebSocketPortNumber);
        }
    }
}
#pragma warning restore CS0618
