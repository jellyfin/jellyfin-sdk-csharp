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
    /// Class TaskInfo.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TaskInfo : IParsable
    {
        /// <summary>Gets or sets the category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; set; }
#nullable restore
#else
        public string Category { get; set; }
#endif
        /// <summary>Gets or sets the progress.</summary>
        public double? CurrentProgressPercentage { get; set; }
        /// <summary>Gets or sets the description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Gets or sets the id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Gets or sets a value indicating whether this instance is hidden.</summary>
        public bool? IsHidden { get; set; }
        /// <summary>Gets or sets the key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>Gets or sets the last execution result.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Jellyfin.Sdk.Generated.Models.TaskResult? LastExecutionResult { get; set; }
#nullable restore
#else
        public global::Jellyfin.Sdk.Generated.Models.TaskResult LastExecutionResult { get; set; }
#endif
        /// <summary>Gets or sets the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Gets or sets the state of the task.</summary>
        public global::Jellyfin.Sdk.Generated.Models.TaskInfo_State? State { get; set; }
        /// <summary>Gets or sets the triggers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Jellyfin.Sdk.Generated.Models.TaskTriggerInfo>? Triggers { get; set; }
#nullable restore
#else
        public List<global::Jellyfin.Sdk.Generated.Models.TaskTriggerInfo> Triggers { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Jellyfin.Sdk.Generated.Models.TaskInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Jellyfin.Sdk.Generated.Models.TaskInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Jellyfin.Sdk.Generated.Models.TaskInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Category", n => { Category = n.GetStringValue(); } },
                { "CurrentProgressPercentage", n => { CurrentProgressPercentage = n.GetDoubleValue(); } },
                { "Description", n => { Description = n.GetStringValue(); } },
                { "Id", n => { Id = n.GetStringValue(); } },
                { "IsHidden", n => { IsHidden = n.GetBoolValue(); } },
                { "Key", n => { Key = n.GetStringValue(); } },
                { "LastExecutionResult", n => { LastExecutionResult = n.GetObjectValue<global::Jellyfin.Sdk.Generated.Models.TaskResult>(global::Jellyfin.Sdk.Generated.Models.TaskResult.CreateFromDiscriminatorValue); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "State", n => { State = n.GetEnumValue<global::Jellyfin.Sdk.Generated.Models.TaskInfo_State>(); } },
                { "Triggers", n => { Triggers = n.GetCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.TaskTriggerInfo>(global::Jellyfin.Sdk.Generated.Models.TaskTriggerInfo.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Category", Category);
            writer.WriteDoubleValue("CurrentProgressPercentage", CurrentProgressPercentage);
            writer.WriteStringValue("Description", Description);
            writer.WriteStringValue("Id", Id);
            writer.WriteBoolValue("IsHidden", IsHidden);
            writer.WriteStringValue("Key", Key);
            writer.WriteObjectValue<global::Jellyfin.Sdk.Generated.Models.TaskResult>("LastExecutionResult", LastExecutionResult);
            writer.WriteStringValue("Name", Name);
            writer.WriteEnumValue<global::Jellyfin.Sdk.Generated.Models.TaskInfo_State>("State", State);
            writer.WriteCollectionOfObjectValues<global::Jellyfin.Sdk.Generated.Models.TaskTriggerInfo>("Triggers", Triggers);
        }
    }
}
#pragma warning restore CS0618
