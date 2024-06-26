// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class TrickplayOptions.
    /// </summary>
    public class TrickplayOptions : IParsable 
    {
        /// <summary>Gets or sets a value indicating whether or not to use HW acceleration.</summary>
        public bool? EnableHwAcceleration { get; set; }
        /// <summary>Gets or sets a value indicating whether or not to use HW accelerated MJPEG encoding.</summary>
        public bool? EnableHwEncoding { get; set; }
        /// <summary>Gets or sets the interval, in ms, between each new trickplay image.</summary>
        public int? Interval { get; set; }
        /// <summary>Gets or sets the jpeg quality to use for image tiles.</summary>
        public int? JpegQuality { get; set; }
        /// <summary>Gets or sets the process priority for the ffmpeg process.</summary>
        public TrickplayOptions_ProcessPriority? ProcessPriority { get; set; }
        /// <summary>Gets or sets the number of threads to be used by ffmpeg.</summary>
        public int? ProcessThreads { get; set; }
        /// <summary>Gets or sets the ffmpeg output quality level.</summary>
        public int? Qscale { get; set; }
        /// <summary>Gets or sets the behavior used by trickplay provider on library scan/update.</summary>
        public TrickplayOptions_ScanBehavior? ScanBehavior { get; set; }
        /// <summary>Gets or sets number of tile images to allow in Y dimension.</summary>
        public int? TileHeight { get; set; }
        /// <summary>Gets or sets number of tile images to allow in X dimension.</summary>
        public int? TileWidth { get; set; }
        /// <summary>Gets or sets the target width resolutions, in px, to generates preview images for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? WidthResolutions { get; set; }
#nullable restore
#else
        public List<int?> WidthResolutions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TrickplayOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TrickplayOptions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrickplayOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"EnableHwAcceleration", n => { EnableHwAcceleration = n.GetBoolValue(); } },
                {"EnableHwEncoding", n => { EnableHwEncoding = n.GetBoolValue(); } },
                {"Interval", n => { Interval = n.GetIntValue(); } },
                {"JpegQuality", n => { JpegQuality = n.GetIntValue(); } },
                {"ProcessPriority", n => { ProcessPriority = n.GetEnumValue<TrickplayOptions_ProcessPriority>(); } },
                {"ProcessThreads", n => { ProcessThreads = n.GetIntValue(); } },
                {"Qscale", n => { Qscale = n.GetIntValue(); } },
                {"ScanBehavior", n => { ScanBehavior = n.GetEnumValue<TrickplayOptions_ScanBehavior>(); } },
                {"TileHeight", n => { TileHeight = n.GetIntValue(); } },
                {"TileWidth", n => { TileWidth = n.GetIntValue(); } },
                {"WidthResolutions", n => { WidthResolutions = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("EnableHwAcceleration", EnableHwAcceleration);
            writer.WriteBoolValue("EnableHwEncoding", EnableHwEncoding);
            writer.WriteIntValue("Interval", Interval);
            writer.WriteIntValue("JpegQuality", JpegQuality);
            writer.WriteEnumValue<TrickplayOptions_ProcessPriority>("ProcessPriority", ProcessPriority);
            writer.WriteIntValue("ProcessThreads", ProcessThreads);
            writer.WriteIntValue("Qscale", Qscale);
            writer.WriteEnumValue<TrickplayOptions_ScanBehavior>("ScanBehavior", ScanBehavior);
            writer.WriteIntValue("TileHeight", TileHeight);
            writer.WriteIntValue("TileWidth", TileWidth);
            writer.WriteCollectionOfPrimitiveValues<int?>("WidthResolutions", WidthResolutions);
        }
    }
}
