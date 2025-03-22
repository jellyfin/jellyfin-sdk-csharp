// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Jellyfin.Sdk.Generated.Models
{
    /// <summary>Gets or sets the specific media type for this id. This is used to distinguish between the differentexternal id types for providers with multiple ids.A null value indicates there is no specific media type associated with the external id, or this is thedefault id for the external provider so there is no need to specify a type.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ExternalIdInfo_Type
    {
        [EnumMember(Value = "Album")]
        #pragma warning disable CS1591
        Album,
        #pragma warning restore CS1591
        [EnumMember(Value = "AlbumArtist")]
        #pragma warning disable CS1591
        AlbumArtist,
        #pragma warning restore CS1591
        [EnumMember(Value = "Artist")]
        #pragma warning disable CS1591
        Artist,
        #pragma warning restore CS1591
        [EnumMember(Value = "BoxSet")]
        #pragma warning disable CS1591
        BoxSet,
        #pragma warning restore CS1591
        [EnumMember(Value = "Episode")]
        #pragma warning disable CS1591
        Episode,
        #pragma warning restore CS1591
        [EnumMember(Value = "Movie")]
        #pragma warning disable CS1591
        Movie,
        #pragma warning restore CS1591
        [EnumMember(Value = "OtherArtist")]
        #pragma warning disable CS1591
        OtherArtist,
        #pragma warning restore CS1591
        [EnumMember(Value = "Person")]
        #pragma warning disable CS1591
        Person,
        #pragma warning restore CS1591
        [EnumMember(Value = "ReleaseGroup")]
        #pragma warning disable CS1591
        ReleaseGroup,
        #pragma warning restore CS1591
        [EnumMember(Value = "Season")]
        #pragma warning disable CS1591
        Season,
        #pragma warning restore CS1591
        [EnumMember(Value = "Series")]
        #pragma warning disable CS1591
        Series,
        #pragma warning restore CS1591
        [EnumMember(Value = "Track")]
        #pragma warning disable CS1591
        Track,
        #pragma warning restore CS1591
        [EnumMember(Value = "Book")]
        #pragma warning disable CS1591
        Book,
        #pragma warning restore CS1591
        [EnumMember(Value = "Recording")]
        #pragma warning disable CS1591
        Recording,
        #pragma warning restore CS1591
    }
}
