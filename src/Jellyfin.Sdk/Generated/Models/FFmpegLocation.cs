// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>Enum describing the location of the FFmpeg tool.</summary>
    public enum FFmpegLocation {
        [EnumMember(Value = "NotFound")]
        NotFound,
        [EnumMember(Value = "SetByArgument")]
        SetByArgument,
        [EnumMember(Value = "Custom")]
        Custom,
        [EnumMember(Value = "System")]
        System,
    }
}
