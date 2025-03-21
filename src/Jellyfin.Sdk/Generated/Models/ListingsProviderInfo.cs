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
    public partial class ListingsProviderInfo : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ChannelMappings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.NameValuePair>? ChannelMappings { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.NameValuePair> ChannelMappings { get; set; }
#endif
        /// <summary>The Country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The EnableAllTuners property</summary>
        public bool? EnableAllTuners { get; set; }
        /// <summary>The EnabledTuners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledTuners { get; set; }
#nullable restore
#else
        public List<string> EnabledTuners { get; set; }
#endif
        /// <summary>The Id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The KidsCategories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? KidsCategories { get; set; }
#nullable restore
#else
        public List<string> KidsCategories { get; set; }
#endif
        /// <summary>The ListingsId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ListingsId { get; set; }
#nullable restore
#else
        public string ListingsId { get; set; }
#endif
        /// <summary>The MovieCategories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MovieCategories { get; set; }
#nullable restore
#else
        public List<string> MovieCategories { get; set; }
#endif
        /// <summary>The MoviePrefix property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MoviePrefix { get; set; }
#nullable restore
#else
        public string MoviePrefix { get; set; }
#endif
        /// <summary>The NewsCategories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NewsCategories { get; set; }
#nullable restore
#else
        public List<string> NewsCategories { get; set; }
#endif
        /// <summary>The Password property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>The Path property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The PreferredLanguage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredLanguage { get; set; }
#nullable restore
#else
        public string PreferredLanguage { get; set; }
#endif
        /// <summary>The SportsCategories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SportsCategories { get; set; }
#nullable restore
#else
        public List<string> SportsCategories { get; set; }
#endif
        /// <summary>The Type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The UserAgent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserAgent { get; set; }
#nullable restore
#else
        public string UserAgent { get; set; }
#endif
        /// <summary>The Username property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>The ZipCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ZipCode { get; set; }
#nullable restore
#else
        public string ZipCode { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.ListingsProviderInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.ListingsProviderInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.ListingsProviderInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ChannelMappings", n => { ChannelMappings = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.NameValuePair>(global::Jellyfin.Sdk.Generated.Models.NameValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "Country", n => { Country = n.GetStringValue(); } },
                { "EnableAllTuners", n => { EnableAllTuners = n.GetBoolValue(); } },
                { "EnabledTuners", n => { EnabledTuners = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "Id", n => { Id = n.GetStringValue(); } },
                { "KidsCategories", n => { KidsCategories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "ListingsId", n => { ListingsId = n.GetStringValue(); } },
                { "MovieCategories", n => { MovieCategories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "MoviePrefix", n => { MoviePrefix = n.GetStringValue(); } },
                { "NewsCategories", n => { NewsCategories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "Password", n => { Password = n.GetStringValue(); } },
                { "Path", n => { Path = n.GetStringValue(); } },
                { "PreferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                { "SportsCategories", n => { SportsCategories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "Type", n => { Type = n.GetStringValue(); } },
                { "UserAgent", n => { UserAgent = n.GetStringValue(); } },
                { "Username", n => { Username = n.GetStringValue(); } },
                { "ZipCode", n => { ZipCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.NameValuePair>("ChannelMappings", ChannelMappings);
            writer.WriteStringValue("Country", Country);
            writer.WriteBoolValue("EnableAllTuners", EnableAllTuners);
            writer.WriteCollectionOfPrimitiveValues<string>("EnabledTuners", EnabledTuners);
            writer.WriteStringValue("Id", Id);
            writer.WriteCollectionOfPrimitiveValues<string>("KidsCategories", KidsCategories);
            writer.WriteStringValue("ListingsId", ListingsId);
            writer.WriteCollectionOfPrimitiveValues<string>("MovieCategories", MovieCategories);
            writer.WriteStringValue("MoviePrefix", MoviePrefix);
            writer.WriteCollectionOfPrimitiveValues<string>("NewsCategories", NewsCategories);
            writer.WriteStringValue("Password", Password);
            writer.WriteStringValue("Path", Path);
            writer.WriteStringValue("PreferredLanguage", PreferredLanguage);
            writer.WriteCollectionOfPrimitiveValues<string>("SportsCategories", SportsCategories);
            writer.WriteStringValue("Type", Type);
            writer.WriteStringValue("UserAgent", UserAgent);
            writer.WriteStringValue("Username", Username);
            writer.WriteStringValue("ZipCode", ZipCode);
        }
    }
}
#pragma warning restore CS0618
