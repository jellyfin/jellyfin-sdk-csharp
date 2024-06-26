// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Gets or sets the blurhashes for the image tags.Maps image type to dictionary mapping image tag to blurhash value.
    /// </summary>
    public class BaseItemDto_ImageBlurHashes : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Art property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Art? Art { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Art Art { get; set; }
#endif
        /// <summary>The Backdrop property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Backdrop? Backdrop { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Backdrop Backdrop { get; set; }
#endif
        /// <summary>The Banner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Banner? Banner { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Banner Banner { get; set; }
#endif
        /// <summary>The Box property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Box? Box { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Box Box { get; set; }
#endif
        /// <summary>The BoxRear property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_BoxRear? BoxRear { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_BoxRear BoxRear { get; set; }
#endif
        /// <summary>The Chapter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Chapter? Chapter { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Chapter Chapter { get; set; }
#endif
        /// <summary>The Disc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Disc? Disc { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Disc Disc { get; set; }
#endif
        /// <summary>The Logo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Logo? Logo { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Logo Logo { get; set; }
#endif
        /// <summary>The Menu property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Menu? Menu { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Menu Menu { get; set; }
#endif
        /// <summary>The Primary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Primary? Primary { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Primary Primary { get; set; }
#endif
        /// <summary>The Profile property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Profile? Profile { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Profile Profile { get; set; }
#endif
        /// <summary>The Screenshot property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Screenshot? Screenshot { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Screenshot Screenshot { get; set; }
#endif
        /// <summary>The Thumb property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseItemDto_ImageBlurHashes_Thumb? Thumb { get; set; }
#nullable restore
#else
        public BaseItemDto_ImageBlurHashes_Thumb Thumb { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BaseItemDto_ImageBlurHashes"/> and sets the default values.
        /// </summary>
        public BaseItemDto_ImageBlurHashes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BaseItemDto_ImageBlurHashes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BaseItemDto_ImageBlurHashes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BaseItemDto_ImageBlurHashes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"Art", n => { Art = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Art>(BaseItemDto_ImageBlurHashes_Art.CreateFromDiscriminatorValue); } },
                {"Backdrop", n => { Backdrop = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Backdrop>(BaseItemDto_ImageBlurHashes_Backdrop.CreateFromDiscriminatorValue); } },
                {"Banner", n => { Banner = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Banner>(BaseItemDto_ImageBlurHashes_Banner.CreateFromDiscriminatorValue); } },
                {"Box", n => { Box = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Box>(BaseItemDto_ImageBlurHashes_Box.CreateFromDiscriminatorValue); } },
                {"BoxRear", n => { BoxRear = n.GetObjectValue<BaseItemDto_ImageBlurHashes_BoxRear>(BaseItemDto_ImageBlurHashes_BoxRear.CreateFromDiscriminatorValue); } },
                {"Chapter", n => { Chapter = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Chapter>(BaseItemDto_ImageBlurHashes_Chapter.CreateFromDiscriminatorValue); } },
                {"Disc", n => { Disc = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Disc>(BaseItemDto_ImageBlurHashes_Disc.CreateFromDiscriminatorValue); } },
                {"Logo", n => { Logo = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Logo>(BaseItemDto_ImageBlurHashes_Logo.CreateFromDiscriminatorValue); } },
                {"Menu", n => { Menu = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Menu>(BaseItemDto_ImageBlurHashes_Menu.CreateFromDiscriminatorValue); } },
                {"Primary", n => { Primary = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Primary>(BaseItemDto_ImageBlurHashes_Primary.CreateFromDiscriminatorValue); } },
                {"Profile", n => { Profile = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Profile>(BaseItemDto_ImageBlurHashes_Profile.CreateFromDiscriminatorValue); } },
                {"Screenshot", n => { Screenshot = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Screenshot>(BaseItemDto_ImageBlurHashes_Screenshot.CreateFromDiscriminatorValue); } },
                {"Thumb", n => { Thumb = n.GetObjectValue<BaseItemDto_ImageBlurHashes_Thumb>(BaseItemDto_ImageBlurHashes_Thumb.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Art>("Art", Art);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Backdrop>("Backdrop", Backdrop);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Banner>("Banner", Banner);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Box>("Box", Box);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_BoxRear>("BoxRear", BoxRear);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Chapter>("Chapter", Chapter);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Disc>("Disc", Disc);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Logo>("Logo", Logo);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Menu>("Menu", Menu);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Primary>("Primary", Primary);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Profile>("Profile", Profile);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Screenshot>("Screenshot", Screenshot);
            writer.WriteObjectValue<BaseItemDto_ImageBlurHashes_Thumb>("Thumb", Thumb);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
