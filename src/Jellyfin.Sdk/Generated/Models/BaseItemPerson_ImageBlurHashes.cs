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
    /// Gets or sets the primary image blurhash.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BaseItemPerson_ImageBlurHashes : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Art property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Art? Art { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Art Art { get; set; }
#endif
        /// <summary>The Backdrop property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Backdrop? Backdrop { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Backdrop Backdrop { get; set; }
#endif
        /// <summary>The Banner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Banner? Banner { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Banner Banner { get; set; }
#endif
        /// <summary>The Box property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Box? Box { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Box Box { get; set; }
#endif
        /// <summary>The BoxRear property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_BoxRear? BoxRear { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_BoxRear BoxRear { get; set; }
#endif
        /// <summary>The Chapter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Chapter? Chapter { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Chapter Chapter { get; set; }
#endif
        /// <summary>The Disc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Disc? Disc { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Disc Disc { get; set; }
#endif
        /// <summary>The Logo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Logo? Logo { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Logo Logo { get; set; }
#endif
        /// <summary>The Menu property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Menu? Menu { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Menu Menu { get; set; }
#endif
        /// <summary>The Primary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Primary? Primary { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Primary Primary { get; set; }
#endif
        /// <summary>The Profile property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Profile? Profile { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Profile Profile { get; set; }
#endif
        /// <summary>The Screenshot property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Screenshot? Screenshot { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Screenshot Screenshot { get; set; }
#endif
        /// <summary>The Thumb property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Thumb? Thumb { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Thumb Thumb { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes"/> and sets the default values.
        /// </summary>
        public BaseItemPerson_ImageBlurHashes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Art", n => { Art = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Art>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Art.CreateFromDiscriminatorValue); } },
                { "Backdrop", n => { Backdrop = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Backdrop>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Backdrop.CreateFromDiscriminatorValue); } },
                { "Banner", n => { Banner = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Banner>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Banner.CreateFromDiscriminatorValue); } },
                { "Box", n => { Box = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Box>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Box.CreateFromDiscriminatorValue); } },
                { "BoxRear", n => { BoxRear = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_BoxRear>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_BoxRear.CreateFromDiscriminatorValue); } },
                { "Chapter", n => { Chapter = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Chapter>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Chapter.CreateFromDiscriminatorValue); } },
                { "Disc", n => { Disc = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Disc>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Disc.CreateFromDiscriminatorValue); } },
                { "Logo", n => { Logo = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Logo>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Logo.CreateFromDiscriminatorValue); } },
                { "Menu", n => { Menu = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Menu>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Menu.CreateFromDiscriminatorValue); } },
                { "Primary", n => { Primary = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Primary>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Primary.CreateFromDiscriminatorValue); } },
                { "Profile", n => { Profile = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Profile>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Profile.CreateFromDiscriminatorValue); } },
                { "Screenshot", n => { Screenshot = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Screenshot>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Screenshot.CreateFromDiscriminatorValue); } },
                { "Thumb", n => { Thumb = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Thumb>(global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Thumb.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Art>("Art", Art);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Backdrop>("Backdrop", Backdrop);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Banner>("Banner", Banner);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Box>("Box", Box);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_BoxRear>("BoxRear", BoxRear);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Chapter>("Chapter", Chapter);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Disc>("Disc", Disc);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Logo>("Logo", Logo);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Menu>("Menu", Menu);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Primary>("Primary", Primary);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Profile>("Profile", Profile);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Screenshot>("Screenshot", Screenshot);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.BaseItemPerson_ImageBlurHashes_Thumb>("Thumb", Thumb);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
