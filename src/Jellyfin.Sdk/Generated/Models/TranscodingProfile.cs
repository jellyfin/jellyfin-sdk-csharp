// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    public class TranscodingProfile : IParsable {
        /// <summary>The AudioCodec property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AudioCodec { get; set; }
#nullable restore
#else
        public string AudioCodec { get; set; }
#endif
        /// <summary>The BreakOnNonKeyFrames property</summary>
        public bool? BreakOnNonKeyFrames { get; set; }
        /// <summary>The Conditions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProfileCondition>? Conditions { get; set; }
#nullable restore
#else
        public List<ProfileCondition> Conditions { get; set; }
#endif
        /// <summary>The Container property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Container { get; set; }
#nullable restore
#else
        public string Container { get; set; }
#endif
        /// <summary>The Context property</summary>
        public EncodingContext? Context { get; set; }
        /// <summary>The CopyTimestamps property</summary>
        public bool? CopyTimestamps { get; set; }
        /// <summary>The EnableMpegtsM2TsMode property</summary>
        public bool? EnableMpegtsM2TsMode { get; set; }
        /// <summary>The EnableSubtitlesInManifest property</summary>
        public bool? EnableSubtitlesInManifest { get; set; }
        /// <summary>The EstimateContentLength property</summary>
        public bool? EstimateContentLength { get; set; }
        /// <summary>The MaxAudioChannels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MaxAudioChannels { get; set; }
#nullable restore
#else
        public string MaxAudioChannels { get; set; }
#endif
        /// <summary>The MinSegments property</summary>
        public int? MinSegments { get; set; }
        /// <summary>The Protocol property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Protocol { get; set; }
#nullable restore
#else
        public string Protocol { get; set; }
#endif
        /// <summary>The SegmentLength property</summary>
        public int? SegmentLength { get; set; }
        /// <summary>The TranscodeSeekInfo property</summary>
        public Jellyfin.Sdk.Generated.Models.TranscodeSeekInfo? TranscodeSeekInfo { get; set; }
        /// <summary>The Type property</summary>
        public DlnaProfileType? Type { get; set; }
        /// <summary>The VideoCodec property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoCodec { get; set; }
#nullable restore
#else
        public string VideoCodec { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TranscodingProfile"/> and sets the default values.
        /// </summary>
        public TranscodingProfile() {
            Context = EncodingContext.Streaming;
            TranscodeSeekInfo = Jellyfin.Sdk.Generated.Models.TranscodeSeekInfo.Auto;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TranscodingProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TranscodingProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TranscodingProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AudioCodec", n => { AudioCodec = n.GetStringValue(); } },
                {"BreakOnNonKeyFrames", n => { BreakOnNonKeyFrames = n.GetBoolValue(); } },
                {"Conditions", n => { Conditions = n.GetCollectionOfObjectValues<ProfileCondition>(ProfileCondition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Container", n => { Container = n.GetStringValue(); } },
                {"Context", n => { Context = n.GetEnumValue<EncodingContext>(); } },
                {"CopyTimestamps", n => { CopyTimestamps = n.GetBoolValue(); } },
                {"EnableMpegtsM2TsMode", n => { EnableMpegtsM2TsMode = n.GetBoolValue(); } },
                {"EnableSubtitlesInManifest", n => { EnableSubtitlesInManifest = n.GetBoolValue(); } },
                {"EstimateContentLength", n => { EstimateContentLength = n.GetBoolValue(); } },
                {"MaxAudioChannels", n => { MaxAudioChannels = n.GetStringValue(); } },
                {"MinSegments", n => { MinSegments = n.GetIntValue(); } },
                {"Protocol", n => { Protocol = n.GetStringValue(); } },
                {"SegmentLength", n => { SegmentLength = n.GetIntValue(); } },
                {"TranscodeSeekInfo", n => { TranscodeSeekInfo = n.GetEnumValue<TranscodeSeekInfo>(); } },
                {"Type", n => { Type = n.GetEnumValue<DlnaProfileType>(); } },
                {"VideoCodec", n => { VideoCodec = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AudioCodec", AudioCodec);
            writer.WriteBoolValue("BreakOnNonKeyFrames", BreakOnNonKeyFrames);
            writer.WriteCollectionOfObjectValues<ProfileCondition>("Conditions", Conditions);
            writer.WriteStringValue("Container", Container);
            writer.WriteEnumValue<EncodingContext>("Context", Context);
            writer.WriteBoolValue("CopyTimestamps", CopyTimestamps);
            writer.WriteBoolValue("EnableMpegtsM2TsMode", EnableMpegtsM2TsMode);
            writer.WriteBoolValue("EnableSubtitlesInManifest", EnableSubtitlesInManifest);
            writer.WriteBoolValue("EstimateContentLength", EstimateContentLength);
            writer.WriteStringValue("MaxAudioChannels", MaxAudioChannels);
            writer.WriteIntValue("MinSegments", MinSegments);
            writer.WriteStringValue("Protocol", Protocol);
            writer.WriteIntValue("SegmentLength", SegmentLength);
            writer.WriteEnumValue<TranscodeSeekInfo>("TranscodeSeekInfo", TranscodeSeekInfo);
            writer.WriteEnumValue<DlnaProfileType>("Type", Type);
            writer.WriteStringValue("VideoCodec", VideoCodec);
        }
    }
}
