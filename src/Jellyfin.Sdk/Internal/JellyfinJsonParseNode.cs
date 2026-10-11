using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;

namespace Jellyfin.Sdk.Internal;

/// <summary>
/// Kiota's JsonParseNode with a generated field switch, cached enum lookups, direct primitive reads and reused child nodes.
/// Anything else is read by Kiota's node.
/// </summary>
/// <remarks>
/// The direct reads of string, bool, int, long, float, double, Guid and DateTimeOffset bypass custom converters in the context.
/// </remarks>
internal sealed class JellyfinJsonParseNode : IParseNode
{
    private static readonly System.Reflection.Assembly _sdkAssembly = typeof(JellyfinJsonParseNode).Assembly;

    private readonly KiotaJsonSerializationContext _context;
    private JsonElement _jsonNode;

    public JellyfinJsonParseNode(JsonElement node, KiotaJsonSerializationContext context)
    {
        _jsonNode = node;
        _context = context;
    }

    /// <inheritdoc />
    public Action<IParsable>? OnBeforeAssignFieldValues { get; set; }

    /// <inheritdoc />
    public Action<IParsable>? OnAfterAssignFieldValues { get; set; }

    /// <inheritdoc />
    public string? GetStringValue() => GetStringValue(_jsonNode);

    /// <inheritdoc />
    public bool? GetBoolValue()
        => _jsonNode.ValueKind is JsonValueKind.True or JsonValueKind.False
            ? _jsonNode.GetBoolean()
            : Kiota(_jsonNode).GetBoolValue();

    /// <inheritdoc />
    public byte? GetByteValue() => Kiota(_jsonNode).GetByteValue();

    /// <inheritdoc />
    public sbyte? GetSbyteValue() => Kiota(_jsonNode).GetSbyteValue();

    /// <inheritdoc />
    public int? GetIntValue() => GetIntValue(_jsonNode);

    /// <inheritdoc />
    public float? GetFloatValue()
        => _jsonNode.ValueKind == JsonValueKind.Number && _jsonNode.TryGetSingle(out var value)
            ? value
            : Kiota(_jsonNode).GetFloatValue();

    /// <inheritdoc />
    public long? GetLongValue()
        => _jsonNode.ValueKind == JsonValueKind.Number && _jsonNode.TryGetInt64(out var value)
            ? value
            : Kiota(_jsonNode).GetLongValue();

    /// <inheritdoc />
    public double? GetDoubleValue()
        => _jsonNode.ValueKind == JsonValueKind.Number && _jsonNode.TryGetDouble(out var value)
            ? value
            : Kiota(_jsonNode).GetDoubleValue();

    /// <inheritdoc />
    public decimal? GetDecimalValue() => Kiota(_jsonNode).GetDecimalValue();

    /// <inheritdoc />
    public Guid? GetGuidValue() => GetGuidValue(_jsonNode);

    /// <inheritdoc />
    public DateTimeOffset? GetDateTimeOffsetValue()
        => _jsonNode.ValueKind == JsonValueKind.String && _jsonNode.TryGetDateTimeOffset(out var value)
            ? value
            : Kiota(_jsonNode).GetDateTimeOffsetValue();

    /// <inheritdoc />
    public TimeSpan? GetTimeSpanValue() => Kiota(_jsonNode).GetTimeSpanValue();

    /// <inheritdoc />
    public Date? GetDateValue() => Kiota(_jsonNode).GetDateValue();

    /// <inheritdoc />
    public Time? GetTimeValue() => Kiota(_jsonNode).GetTimeValue();

    /// <inheritdoc />
    public T? GetEnumValue<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>()
        where T : struct, Enum
        => GetEnumValue<T>(_jsonNode);

    /// <inheritdoc />
    public IEnumerable<T> GetCollectionOfObjectValues<T>(ParsableFactory<T> factory)
        where T : IParsable
        // The element is read now: this node may be reused for another property before the result is enumerated.
        => _jsonNode.ValueKind == JsonValueKind.Array ? GetObjectValues(_jsonNode, factory) : [];

    /// <inheritdoc />
    public IEnumerable<T?> GetCollectionOfEnumValues<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>()
        where T : struct, Enum
        => _jsonNode.ValueKind == JsonValueKind.Array ? GetEnumValues<T>(_jsonNode) : [];

    /// <inheritdoc />
    public IEnumerable<T> GetCollectionOfPrimitiveValues<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>()
        => _jsonNode.ValueKind == JsonValueKind.Array && (typeof(T) == typeof(string) || typeof(T) == typeof(Guid?) || typeof(T) == typeof(int?))
            ? GetPrimitiveValues<T>(_jsonNode)
            : Kiota(_jsonNode).GetCollectionOfPrimitiveValues<T>();

    /// <inheritdoc />
    public byte[]? GetByteArrayValue() => Kiota(_jsonNode).GetByteArrayValue();

    /// <inheritdoc />
    public T GetObjectValue<T>(ParsableFactory<T> factory)
        where T : IParsable
    {
        _ = factory ?? throw new ArgumentNullException(nameof(factory));

        if (typeof(T) == typeof(UntypedNode))
        {
            return Kiota(_jsonNode).GetObjectValue(factory);
        }

        var item = factory(this);
        OnBeforeAssignFieldValues?.Invoke(item);
        AssignFieldValues(item);
        OnAfterAssignFieldValues?.Invoke(item);
        return item;
    }

    /// <inheritdoc />
    public IParseNode? GetChildNode(string identifier)
    {
        _ = identifier ?? throw new ArgumentNullException(nameof(identifier));

        return _jsonNode.ValueKind == JsonValueKind.Object && _jsonNode.TryGetProperty(identifier, out var value)
            ? CreateChild(value)
            : null;
    }

    private static bool IsKnownField(IFieldAssignable? assignable, IDictionary<string, Action<IParseNode>>? deserializers, string name)
        => assignable is null
            ? deserializers!.ContainsKey(name)
            : assignable.HasField(name);

    private static void TryAdd(IDictionary<string, object> dictionary, string key, object? value)
    {
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, value!);
        }
    }

    private JsonParseNode Kiota(JsonElement element) => new(element, _context);

    private T? GetEnumValue<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>(JsonElement element)
        where T : struct, Enum
        => element.ValueKind == JsonValueKind.String
            ? EnumCache<T>.Parse(element.GetString())
            : Kiota(element).GetEnumValue<T>();

    private JellyfinJsonParseNode CreateChild(JsonElement element)
        => new(element, _context)
        {
            OnBeforeAssignFieldValues = OnBeforeAssignFieldValues,
            OnAfterAssignFieldValues = OnAfterAssignFieldValues,
        };

    private IEnumerable<T> GetObjectValues<T>(JsonElement array, ParsableFactory<T> factory)
        where T : IParsable
    {
        JellyfinJsonParseNode? node = null;
        foreach (var element in array.EnumerateArray())
        {
            node ??= CreateChild(element);
            node._jsonNode = element;
            yield return node.GetObjectValue(factory);
        }
    }

    private IEnumerable<T?> GetEnumValues<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>(JsonElement array)
        where T : struct, Enum
    {
        foreach (var element in array.EnumerateArray())
        {
            yield return GetEnumValue<T>(element);
        }
    }

    private IEnumerable<T> GetPrimitiveValues<T>(JsonElement array)
    {
        foreach (var element in array.EnumerateArray())
        {
            if (typeof(T) == typeof(string))
            {
                yield return (T)(object)GetStringValue(element)!;
            }
            else if (typeof(T) == typeof(Guid?))
            {
                yield return (T)(object)GetGuidValue(element)!;
            }
            else
            {
                yield return (T)(object)GetIntValue(element)!;
            }
        }
    }

    private string? GetStringValue(JsonElement element)
        => element.ValueKind == JsonValueKind.String
            ? element.GetString()
            : Kiota(element).GetStringValue();

    private int? GetIntValue(JsonElement element)
        => element.ValueKind == JsonValueKind.Number && element.TryGetInt32(out var value)
            ? value
            : Kiota(element).GetIntValue();

    // Valid values parse the same as the SDK's JsonGuidConverter (Guid.Parse); anything else goes to Kiota's node.
    private Guid? GetGuidValue(JsonElement element)
        => element.ValueKind == JsonValueKind.String && Guid.TryParse(element.GetString(), out var value)
            ? value
            : Kiota(element).GetGuidValue();

    private void AssignFieldValues<T>(T item)
        where T : IParsable
    {
        if (_jsonNode.ValueKind != JsonValueKind.Object)
        {
            return;
        }

        IDictionary<string, object>? additionalData = null;
        if (item is IAdditionalDataHolder holder)
        {
            additionalData = holder.AdditionalData ??= new Dictionary<string, object>();
        }

        // Subclasses outside the SDK may override GetFieldDeserializers, so only SDK types take the switch.
        var assignable = ReferenceEquals(item.GetType().Assembly, _sdkAssembly) ? item as IFieldAssignable : null;
        var deserializers = assignable is null ? item.GetFieldDeserializers() : null;
        JellyfinJsonParseNode? child = null;

        foreach (var property in _jsonNode.EnumerateObject())
        {
            var name = property.Name;
            if (property.Value.ValueKind == JsonValueKind.Null)
            {
                // Kiota skips null values of known fields and stores them for unknown ones.
                if (!IsKnownField(assignable, deserializers, name) && additionalData is not null)
                {
                    TryAdd(additionalData, name, null);
                }

                continue;
            }

            child ??= CreateChild(property.Value);
            child._jsonNode = property.Value;

            bool assigned;
            if (assignable is not null)
            {
                assigned = assignable.TryAssignField(name, child);
            }
            else if (deserializers!.TryGetValue(name, out var deserializer))
            {
                deserializer(child);
                assigned = true;
            }
            else
            {
                assigned = false;
            }

            if (!assigned && additionalData is not null)
            {
                TryAdd(additionalData, name, TryGetAnything(property.Value));
            }
        }
    }

    // Copied from Kiota's private JsonParseNode.TryGetAnything.
    private object? TryGetAnything(JsonElement element)
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Number:
                if (element.TryGetDecimal(out var decimalValue))
                {
                    return decimalValue;
                }

                if (element.TryGetDouble(out var doubleValue))
                {
                    return doubleValue;
                }

                throw new InvalidOperationException("unexpected additional value type during number deserialization");
            case JsonValueKind.String:
                if (element.TryGetDateTime(out var dateTime))
                {
                    return dateTime;
                }

                if (element.TryGetDateTimeOffset(out var dateTimeOffset))
                {
                    return dateTimeOffset;
                }

                if (element.TryGetGuid(out var guid))
                {
                    return guid;
                }

                return element.GetString();
            case JsonValueKind.Object:
            case JsonValueKind.Array:
                return Kiota(element).GetObjectValue(UntypedNode.CreateFromDiscriminatorValue);
            case JsonValueKind.True:
                return true;
            case JsonValueKind.False:
                return false;
            case JsonValueKind.Undefined:
            case JsonValueKind.Null:
                return null;
            default:
                throw new InvalidOperationException($"unexpected additional value type during deserialization json kind : {element.ValueKind}");
        }
    }
}
