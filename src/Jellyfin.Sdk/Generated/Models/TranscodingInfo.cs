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
    /// Class holding information on a runnning transcode.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TranscodingInfo : IParsable
    {
        /// <summary>Gets or sets the audio channels.</summary>
        public int? AudioChannels { get; set; }
        /// <summary>Gets or sets the thread count used for encoding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AudioCodec { get; set; }
#nullable restore
#else
        public string AudioCodec { get; set; }
#endif
        /// <summary>Gets or sets the bitrate.</summary>
        public int? Bitrate { get; set; }
        /// <summary>Gets or sets the completion percentage.</summary>
        public double? CompletionPercentage { get; set; }
        /// <summary>Gets or sets the thread count used for encoding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Container { get; set; }
#nullable restore
#else
        public string Container { get; set; }
#endif
        /// <summary>Gets or sets the framerate.</summary>
        public float? Framerate { get; set; }
        /// <summary>Gets or sets the hardware acceleration type.</summary>
        public global::Jellyfin.Sdk.Generated.Models.TranscodingInfo_HardwareAccelerationType? HardwareAccelerationType { get; set; }
        /// <summary>Gets or sets the video height.</summary>
        public int? Height { get; set; }
        /// <summary>Gets or sets a value indicating whether the audio is passed through.</summary>
        public bool? IsAudioDirect { get; set; }
        /// <summary>Gets or sets a value indicating whether the video is passed through.</summary>
        public bool? IsVideoDirect { get; set; }
        /// <summary>Gets or sets the transcode reasons.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.TranscodeReason?>? TranscodeReasons { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.TranscodeReason?> TranscodeReasons { get; set; }
#endif
        /// <summary>Gets or sets the thread count used for encoding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoCodec { get; set; }
#nullable restore
#else
        public string VideoCodec { get; set; }
#endif
        /// <summary>Gets or sets the video width.</summary>
        public int? Width { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.TranscodingInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.TranscodingInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.TranscodingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AudioChannels", n => { AudioChannels = n.GetIntValue(); } },
                { "AudioCodec", n => { AudioCodec = n.GetStringValue(); } },
                { "Bitrate", n => { Bitrate = n.GetIntValue(); } },
                { "CompletionPercentage", n => { CompletionPercentage = n.GetDoubleValue(); } },
                { "Container", n => { Container = n.GetStringValue(); } },
                { "Framerate", n => { Framerate = n.GetFloatValue(); } },
                { "HardwareAccelerationType", n => { HardwareAccelerationType = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.TranscodingInfo_HardwareAccelerationType>(); } },
                { "Height", n => { Height = n.GetIntValue(); } },
                { "IsAudioDirect", n => { IsAudioDirect = n.GetBoolValue(); } },
                { "IsVideoDirect", n => { IsVideoDirect = n.GetBoolValue(); } },
                { "TranscodeReasons", n => { TranscodeReasons = n.GetCollectionOfEnumValues<global::Jellyfin.Sdk.Generated.Models.TranscodeReason>()?.AsList(); } },
                { "VideoCodec", n => { VideoCodec = n.GetStringValue(); } },
                { "Width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AudioChannels", AudioChannels);
            writer.WriteStringValue("AudioCodec", AudioCodec);
            writer.WriteIntValue("Bitrate", Bitrate);
            writer.WriteDoubleValue("CompletionPercentage", CompletionPercentage);
            writer.WriteStringValue("Container", Container);
            writer.WriteFloatValue("Framerate", Framerate);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.TranscodingInfo_HardwareAccelerationType>("HardwareAccelerationType", HardwareAccelerationType);
            writer.WriteIntValue("Height", Height);
            writer.WriteBoolValue("IsAudioDirect", IsAudioDirect);
            writer.WriteBoolValue("IsVideoDirect", IsVideoDirect);
            writer.WriteCollectionOfEnumValues<global::Jellyfin.Sdk.Generated.Models.TranscodeReason>("TranscodeReasons", TranscodeReasons);
            writer.WriteStringValue("VideoCodec", VideoCodec);
            writer.WriteIntValue("Width", Width);
        }
    }
}
#pragma warning restore CS0618
