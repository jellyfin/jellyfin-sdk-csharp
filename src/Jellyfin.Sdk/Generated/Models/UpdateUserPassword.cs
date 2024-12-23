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
    /// The update user password request body.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UpdateUserPassword : IParsable
    {
        /// <summary>Gets or sets the current sha1-hashed password.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentPassword { get; set; }
#nullable restore
#else
        public string CurrentPassword { get; set; }
#endif
        /// <summary>Gets or sets the current plain text password.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentPw { get; set; }
#nullable restore
#else
        public string CurrentPw { get; set; }
#endif
        /// <summary>Gets or sets the new plain text password.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewPw { get; set; }
#nullable restore
#else
        public string NewPw { get; set; }
#endif
        /// <summary>Gets or sets a value indicating whether to reset the password.</summary>
        public bool? ResetPassword { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.UpdateUserPassword"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.UpdateUserPassword CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.UpdateUserPassword();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "CurrentPassword", n => { CurrentPassword = n.GetStringValue(); } },
                { "CurrentPw", n => { CurrentPw = n.GetStringValue(); } },
                { "NewPw", n => { NewPw = n.GetStringValue(); } },
                { "ResetPassword", n => { ResetPassword = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("CurrentPassword", CurrentPassword);
            writer.WriteStringValue("CurrentPw", CurrentPw);
            writer.WriteStringValue("NewPw", NewPw);
            writer.WriteBoolValue("ResetPassword", ResetPassword);
        }
    }
}
#pragma warning restore CS0618
