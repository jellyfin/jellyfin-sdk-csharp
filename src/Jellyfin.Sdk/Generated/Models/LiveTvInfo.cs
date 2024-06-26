// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    #pragma warning disable CS1591
    public class LiveTvInfo : IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Gets or sets the enabled users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledUsers { get; set; }
#nullable restore
#else
        public List<string> EnabledUsers { get; set; }
#endif
        /// <summary>Gets or sets a value indicating whether this instance is enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Gets or sets the services.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LiveTvServiceInfo>? Services { get; set; }
#nullable restore
#else
        public List<LiveTvServiceInfo> Services { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="LiveTvInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LiveTvInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LiveTvInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"EnabledUsers", n => { EnabledUsers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"IsEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"Services", n => { Services = n.GetCollectionOfObjectValues<LiveTvServiceInfo>(LiveTvServiceInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("EnabledUsers", EnabledUsers);
            writer.WriteBoolValue("IsEnabled", IsEnabled);
            writer.WriteCollectionOfObjectValues<LiveTvServiceInfo>("Services", Services);
        }
    }
}
