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
    /// Defines the MediaBrowser.Model.Dlna.ContainerProfile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ContainerProfile : IParsable
    {
        /// <summary>Gets or sets the list of MediaBrowser.Model.Dlna.ProfileCondition which this container will be applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.ProfileCondition>? Conditions { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.ProfileCondition> Conditions { get; set; }
#endif
        /// <summary>Gets or sets the container(s) which this container must meet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Container { get; set; }
#nullable restore
#else
        public string Container { get; set; }
#endif
        /// <summary>Gets or sets the sub container(s) which this container must meet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubContainer { get; set; }
#nullable restore
#else
        public string SubContainer { get; set; }
#endif
        /// <summary>Gets or sets the MediaBrowser.Model.Dlna.DlnaProfileType which this container must meet.</summary>
        public global::Jellyfin.Sdk.Generated.Models.ContainerProfile_Type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.ContainerProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.ContainerProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.ContainerProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Conditions", n => { Conditions = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.ProfileCondition>(global::Jellyfin.Sdk.Generated.Models.ProfileCondition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "Container", n => { Container = n.GetStringValue(); } },
                { "SubContainer", n => { SubContainer = n.GetStringValue(); } },
                { "Type", n => { Type = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.ContainerProfile_Type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.ProfileCondition>("Conditions", Conditions);
            writer.WriteStringValue("Container", Container);
            writer.WriteStringValue("SubContainer", SubContainer);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.ContainerProfile_Type>("Type", Type);
        }
    }
}
#pragma warning restore CS0618
