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
    public partial class LibraryOptions : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>An enum representing the options to disable embedded subs.</summary>
        public global::Jellyfin.Sdk.Generated.Models.LibraryOptions_AllowEmbeddedSubtitles? AllowEmbeddedSubtitles { get; set; }
        /// <summary>The AutomaticallyAddToCollection property</summary>
        public bool? AutomaticallyAddToCollection { get; set; }
        /// <summary>The AutomaticRefreshIntervalDays property</summary>
        public int? AutomaticRefreshIntervalDays { get; set; }
        /// <summary>The CustomTagDelimiters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CustomTagDelimiters { get; set; }
#nullable restore
#else
        public List<string> CustomTagDelimiters { get; set; }
#endif
        /// <summary>The DelimiterWhitelist property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DelimiterWhitelist { get; set; }
#nullable restore
#else
        public List<string> DelimiterWhitelist { get; set; }
#endif
        /// <summary>The DisabledLocalMetadataReaders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisabledLocalMetadataReaders { get; set; }
#nullable restore
#else
        public List<string> DisabledLocalMetadataReaders { get; set; }
#endif
        /// <summary>The DisabledLyricFetchers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisabledLyricFetchers { get; set; }
#nullable restore
#else
        public List<string> DisabledLyricFetchers { get; set; }
#endif
        /// <summary>The DisabledMediaSegmentProviders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisabledMediaSegmentProviders { get; set; }
#nullable restore
#else
        public List<string> DisabledMediaSegmentProviders { get; set; }
#endif
        /// <summary>The DisabledSubtitleFetchers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisabledSubtitleFetchers { get; set; }
#nullable restore
#else
        public List<string> DisabledSubtitleFetchers { get; set; }
#endif
        /// <summary>The EnableAutomaticSeriesGrouping property</summary>
        public bool? EnableAutomaticSeriesGrouping { get; set; }
        /// <summary>The EnableChapterImageExtraction property</summary>
        public bool? EnableChapterImageExtraction { get; set; }
        /// <summary>The Enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The EnableEmbeddedEpisodeInfos property</summary>
        public bool? EnableEmbeddedEpisodeInfos { get; set; }
        /// <summary>The EnableEmbeddedExtrasTitles property</summary>
        public bool? EnableEmbeddedExtrasTitles { get; set; }
        /// <summary>The EnableEmbeddedTitles property</summary>
        public bool? EnableEmbeddedTitles { get; set; }
        /// <summary>The EnableInternetProviders property</summary>
        [Obsolete("")]
        public bool? EnableInternetProviders { get; set; }
        /// <summary>The EnableLUFSScan property</summary>
        public bool? EnableLUFSScan { get; set; }
        /// <summary>The EnablePhotos property</summary>
        public bool? EnablePhotos { get; set; }
        /// <summary>The EnableRealtimeMonitor property</summary>
        public bool? EnableRealtimeMonitor { get; set; }
        /// <summary>The EnableTrickplayImageExtraction property</summary>
        public bool? EnableTrickplayImageExtraction { get; set; }
        /// <summary>The ExtractChapterImagesDuringLibraryScan property</summary>
        public bool? ExtractChapterImagesDuringLibraryScan { get; set; }
        /// <summary>The ExtractTrickplayImagesDuringLibraryScan property</summary>
        public bool? ExtractTrickplayImagesDuringLibraryScan { get; set; }
        /// <summary>The LocalMetadataReaderOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LocalMetadataReaderOrder { get; set; }
#nullable restore
#else
        public List<string> LocalMetadataReaderOrder { get; set; }
#endif
        /// <summary>The LyricFetcherOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LyricFetcherOrder { get; set; }
#nullable restore
#else
        public List<string> LyricFetcherOrder { get; set; }
#endif
        /// <summary>The MediaSegmentProvideOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaSegmentProvideOrder { get; set; }
#nullable restore
#else
        public List<string> MediaSegmentProvideOrder { get; set; }
#endif
        /// <summary>Gets or sets the metadata country code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MetadataCountryCode { get; set; }
#nullable restore
#else
        public string MetadataCountryCode { get; set; }
#endif
        /// <summary>The MetadataSavers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MetadataSavers { get; set; }
#nullable restore
#else
        public List<string> MetadataSavers { get; set; }
#endif
        /// <summary>The PathInfos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.MediaPathInfo>? PathInfos { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.MediaPathInfo> PathInfos { get; set; }
#endif
        /// <summary>The PreferNonstandardArtistsTag property</summary>
        public bool? PreferNonstandardArtistsTag { get; set; }
        /// <summary>Gets or sets the preferred metadata language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredMetadataLanguage { get; set; }
#nullable restore
#else
        public string PreferredMetadataLanguage { get; set; }
#endif
        /// <summary>The RequirePerfectSubtitleMatch property</summary>
        public bool? RequirePerfectSubtitleMatch { get; set; }
        /// <summary>The SaveLocalMetadata property</summary>
        public bool? SaveLocalMetadata { get; set; }
        /// <summary>The SaveLyricsWithMedia property</summary>
        public bool? SaveLyricsWithMedia { get; set; }
        /// <summary>The SaveSubtitlesWithMedia property</summary>
        public bool? SaveSubtitlesWithMedia { get; set; }
        /// <summary>The SaveTrickplayWithMedia property</summary>
        public bool? SaveTrickplayWithMedia { get; set; }
        /// <summary>The SeasonZeroDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SeasonZeroDisplayName { get; set; }
#nullable restore
#else
        public string SeasonZeroDisplayName { get; set; }
#endif
        /// <summary>The SkipSubtitlesIfAudioTrackMatches property</summary>
        public bool? SkipSubtitlesIfAudioTrackMatches { get; set; }
        /// <summary>The SkipSubtitlesIfEmbeddedSubtitlesPresent property</summary>
        public bool? SkipSubtitlesIfEmbeddedSubtitlesPresent { get; set; }
        /// <summary>The SubtitleDownloadLanguages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SubtitleDownloadLanguages { get; set; }
#nullable restore
#else
        public List<string> SubtitleDownloadLanguages { get; set; }
#endif
        /// <summary>The SubtitleFetcherOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SubtitleFetcherOrder { get; set; }
#nullable restore
#else
        public List<string> SubtitleFetcherOrder { get; set; }
#endif
        /// <summary>The TypeOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.TypeOptions>? TypeOptions { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.TypeOptions> TypeOptions { get; set; }
#endif
        /// <summary>The UseCustomTagDelimiters property</summary>
        public bool? UseCustomTagDelimiters { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.LibraryOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.LibraryOptions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.LibraryOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AllowEmbeddedSubtitles", n => { AllowEmbeddedSubtitles = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.LibraryOptions_AllowEmbeddedSubtitles>(); } },
                { "AutomaticRefreshIntervalDays", n => { AutomaticRefreshIntervalDays = n.GetIntValue(); } },
                { "AutomaticallyAddToCollection", n => { AutomaticallyAddToCollection = n.GetBoolValue(); } },
                { "CustomTagDelimiters", n => { CustomTagDelimiters = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "DelimiterWhitelist", n => { DelimiterWhitelist = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "DisabledLocalMetadataReaders", n => { DisabledLocalMetadataReaders = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "DisabledLyricFetchers", n => { DisabledLyricFetchers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "DisabledMediaSegmentProviders", n => { DisabledMediaSegmentProviders = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "DisabledSubtitleFetchers", n => { DisabledSubtitleFetchers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "EnableAutomaticSeriesGrouping", n => { EnableAutomaticSeriesGrouping = n.GetBoolValue(); } },
                { "EnableChapterImageExtraction", n => { EnableChapterImageExtraction = n.GetBoolValue(); } },
                { "EnableEmbeddedEpisodeInfos", n => { EnableEmbeddedEpisodeInfos = n.GetBoolValue(); } },
                { "EnableEmbeddedExtrasTitles", n => { EnableEmbeddedExtrasTitles = n.GetBoolValue(); } },
                { "EnableEmbeddedTitles", n => { EnableEmbeddedTitles = n.GetBoolValue(); } },
                { "EnableInternetProviders", n => { EnableInternetProviders = n.GetBoolValue(); } },
                { "EnableLUFSScan", n => { EnableLUFSScan = n.GetBoolValue(); } },
                { "EnablePhotos", n => { EnablePhotos = n.GetBoolValue(); } },
                { "EnableRealtimeMonitor", n => { EnableRealtimeMonitor = n.GetBoolValue(); } },
                { "EnableTrickplayImageExtraction", n => { EnableTrickplayImageExtraction = n.GetBoolValue(); } },
                { "Enabled", n => { Enabled = n.GetBoolValue(); } },
                { "ExtractChapterImagesDuringLibraryScan", n => { ExtractChapterImagesDuringLibraryScan = n.GetBoolValue(); } },
                { "ExtractTrickplayImagesDuringLibraryScan", n => { ExtractTrickplayImagesDuringLibraryScan = n.GetBoolValue(); } },
                { "LocalMetadataReaderOrder", n => { LocalMetadataReaderOrder = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "LyricFetcherOrder", n => { LyricFetcherOrder = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "MediaSegmentProvideOrder", n => { MediaSegmentProvideOrder = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "MetadataCountryCode", n => { MetadataCountryCode = n.GetStringValue(); } },
                { "MetadataSavers", n => { MetadataSavers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "PathInfos", n => { PathInfos = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.MediaPathInfo>(global::Jellyfin.Sdk.Generated.Models.MediaPathInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "PreferNonstandardArtistsTag", n => { PreferNonstandardArtistsTag = n.GetBoolValue(); } },
                { "PreferredMetadataLanguage", n => { PreferredMetadataLanguage = n.GetStringValue(); } },
                { "RequirePerfectSubtitleMatch", n => { RequirePerfectSubtitleMatch = n.GetBoolValue(); } },
                { "SaveLocalMetadata", n => { SaveLocalMetadata = n.GetBoolValue(); } },
                { "SaveLyricsWithMedia", n => { SaveLyricsWithMedia = n.GetBoolValue(); } },
                { "SaveSubtitlesWithMedia", n => { SaveSubtitlesWithMedia = n.GetBoolValue(); } },
                { "SaveTrickplayWithMedia", n => { SaveTrickplayWithMedia = n.GetBoolValue(); } },
                { "SeasonZeroDisplayName", n => { SeasonZeroDisplayName = n.GetStringValue(); } },
                { "SkipSubtitlesIfAudioTrackMatches", n => { SkipSubtitlesIfAudioTrackMatches = n.GetBoolValue(); } },
                { "SkipSubtitlesIfEmbeddedSubtitlesPresent", n => { SkipSubtitlesIfEmbeddedSubtitlesPresent = n.GetBoolValue(); } },
                { "SubtitleDownloadLanguages", n => { SubtitleDownloadLanguages = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "SubtitleFetcherOrder", n => { SubtitleFetcherOrder = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "TypeOptions", n => { TypeOptions = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.TypeOptions>(global::Jellyfin.Sdk.Generated.Models.TypeOptions.CreateFromDiscriminatorValue)?.AsList(); } },
                { "UseCustomTagDelimiters", n => { UseCustomTagDelimiters = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.LibraryOptions_AllowEmbeddedSubtitles>("AllowEmbeddedSubtitles", AllowEmbeddedSubtitles);
            writer.WriteBoolValue("AutomaticallyAddToCollection", AutomaticallyAddToCollection);
            writer.WriteIntValue("AutomaticRefreshIntervalDays", AutomaticRefreshIntervalDays);
            writer.WriteCollectionOfPrimitiveValues<string>("CustomTagDelimiters", CustomTagDelimiters);
            writer.WriteCollectionOfPrimitiveValues<string>("DelimiterWhitelist", DelimiterWhitelist);
            writer.WriteCollectionOfPrimitiveValues<string>("DisabledLocalMetadataReaders", DisabledLocalMetadataReaders);
            writer.WriteCollectionOfPrimitiveValues<string>("DisabledLyricFetchers", DisabledLyricFetchers);
            writer.WriteCollectionOfPrimitiveValues<string>("DisabledMediaSegmentProviders", DisabledMediaSegmentProviders);
            writer.WriteCollectionOfPrimitiveValues<string>("DisabledSubtitleFetchers", DisabledSubtitleFetchers);
            writer.WriteBoolValue("EnableAutomaticSeriesGrouping", EnableAutomaticSeriesGrouping);
            writer.WriteBoolValue("EnableChapterImageExtraction", EnableChapterImageExtraction);
            writer.WriteBoolValue("Enabled", Enabled);
            writer.WriteBoolValue("EnableEmbeddedEpisodeInfos", EnableEmbeddedEpisodeInfos);
            writer.WriteBoolValue("EnableEmbeddedExtrasTitles", EnableEmbeddedExtrasTitles);
            writer.WriteBoolValue("EnableEmbeddedTitles", EnableEmbeddedTitles);
            writer.WriteBoolValue("EnableInternetProviders", EnableInternetProviders);
            writer.WriteBoolValue("EnableLUFSScan", EnableLUFSScan);
            writer.WriteBoolValue("EnablePhotos", EnablePhotos);
            writer.WriteBoolValue("EnableRealtimeMonitor", EnableRealtimeMonitor);
            writer.WriteBoolValue("EnableTrickplayImageExtraction", EnableTrickplayImageExtraction);
            writer.WriteBoolValue("ExtractChapterImagesDuringLibraryScan", ExtractChapterImagesDuringLibraryScan);
            writer.WriteBoolValue("ExtractTrickplayImagesDuringLibraryScan", ExtractTrickplayImagesDuringLibraryScan);
            writer.WriteCollectionOfPrimitiveValues<string>("LocalMetadataReaderOrder", LocalMetadataReaderOrder);
            writer.WriteCollectionOfPrimitiveValues<string>("LyricFetcherOrder", LyricFetcherOrder);
            writer.WriteCollectionOfPrimitiveValues<string>("MediaSegmentProvideOrder", MediaSegmentProvideOrder);
            writer.WriteStringValue("MetadataCountryCode", MetadataCountryCode);
            writer.WriteCollectionOfPrimitiveValues<string>("MetadataSavers", MetadataSavers);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.MediaPathInfo>("PathInfos", PathInfos);
            writer.WriteBoolValue("PreferNonstandardArtistsTag", PreferNonstandardArtistsTag);
            writer.WriteStringValue("PreferredMetadataLanguage", PreferredMetadataLanguage);
            writer.WriteBoolValue("RequirePerfectSubtitleMatch", RequirePerfectSubtitleMatch);
            writer.WriteBoolValue("SaveLocalMetadata", SaveLocalMetadata);
            writer.WriteBoolValue("SaveLyricsWithMedia", SaveLyricsWithMedia);
            writer.WriteBoolValue("SaveSubtitlesWithMedia", SaveSubtitlesWithMedia);
            writer.WriteBoolValue("SaveTrickplayWithMedia", SaveTrickplayWithMedia);
            writer.WriteStringValue("SeasonZeroDisplayName", SeasonZeroDisplayName);
            writer.WriteBoolValue("SkipSubtitlesIfAudioTrackMatches", SkipSubtitlesIfAudioTrackMatches);
            writer.WriteBoolValue("SkipSubtitlesIfEmbeddedSubtitlesPresent", SkipSubtitlesIfEmbeddedSubtitlesPresent);
            writer.WriteCollectionOfPrimitiveValues<string>("SubtitleDownloadLanguages", SubtitleDownloadLanguages);
            writer.WriteCollectionOfPrimitiveValues<string>("SubtitleFetcherOrder", SubtitleFetcherOrder);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.TypeOptions>("TypeOptions", TypeOptions);
            writer.WriteBoolValue("UseCustomTagDelimiters", UseCustomTagDelimiters);
        }
    }
}
#pragma warning restore CS0618
