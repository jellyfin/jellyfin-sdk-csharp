// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    /// <summary>
    /// Class TaskInfo.
    /// </summary>
    public class TaskInfo : IParsable {
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
        public TaskResult? LastExecutionResult { get; set; }
#nullable restore
#else
        public TaskResult LastExecutionResult { get; set; }
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
        public TaskState? State { get; set; }
        /// <summary>Gets or sets the triggers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TaskTriggerInfo>? Triggers { get; set; }
#nullable restore
#else
        public List<TaskTriggerInfo> Triggers { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TaskInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TaskInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Category", n => { Category = n.GetStringValue(); } },
                {"CurrentProgressPercentage", n => { CurrentProgressPercentage = n.GetDoubleValue(); } },
                {"Description", n => { Description = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetStringValue(); } },
                {"IsHidden", n => { IsHidden = n.GetBoolValue(); } },
                {"Key", n => { Key = n.GetStringValue(); } },
                {"LastExecutionResult", n => { LastExecutionResult = n.GetObjectValue<TaskResult>(TaskResult.CreateFromDiscriminatorValue); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"State", n => { State = n.GetEnumValue<TaskState>(); } },
                {"Triggers", n => { Triggers = n.GetCollectionOfObjectValues<TaskTriggerInfo>(TaskTriggerInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Category", Category);
            writer.WriteDoubleValue("CurrentProgressPercentage", CurrentProgressPercentage);
            writer.WriteStringValue("Description", Description);
            writer.WriteStringValue("Id", Id);
            writer.WriteBoolValue("IsHidden", IsHidden);
            writer.WriteStringValue("Key", Key);
            writer.WriteObjectValue<TaskResult>("LastExecutionResult", LastExecutionResult);
            writer.WriteStringValue("Name", Name);
            writer.WriteEnumValue<TaskState>("State", State);
            writer.WriteCollectionOfObjectValues<TaskTriggerInfo>("Triggers", Triggers);
        }
    }
}
