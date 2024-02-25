using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;

#if NET5_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;
#endif

namespace Jellyfin.Sdk.Internal;

/// <summary>
/// Json node parser with specific property overrides.
/// </summary>
internal sealed class JellyfinJsonParseNode : IParseNode
{
    private static readonly Type _booleanType = typeof(bool?);
    private static readonly Type _byteType = typeof(byte?);
    private static readonly Type _sbyteType = typeof(sbyte?);
    private static readonly Type _stringType = typeof(string);
    private static readonly Type _intType = typeof(int?);
    private static readonly Type _floatType = typeof(float?);
    private static readonly Type _longType = typeof(long?);
    private static readonly Type _doubleType = typeof(double?);
    private static readonly Type _guidType = typeof(Guid?);
    private static readonly Type _dateTimeOffsetType = typeof(DateTimeOffset?);
    private static readonly Type _timeSpanType = typeof(TimeSpan?);
    private static readonly Type _dateType = typeof(Date?);
    private static readonly Type _timeType = typeof(Time?);

    private readonly JsonParseNode _jsonParseNode;
    private readonly JsonElement _jsonNode;

    /// <summary>
    /// Initializes a new instance of the <see cref="JellyfinJsonParseNode"/> class.
    /// </summary>
    /// <param name="node">The JsonElement to parse.</param>
    public JellyfinJsonParseNode(JsonElement node)
    {
        _jsonParseNode = new JsonParseNode(node);
        _jsonNode = node;
    }

    /// <inheritdoc />
    public Action<IParsable>? OnBeforeAssignFieldValues
    {
        get => _jsonParseNode.OnBeforeAssignFieldValues;
        set => _jsonParseNode.OnBeforeAssignFieldValues = value;
    }

    /// <inheritdoc />
    public Action<IParsable>? OnAfterAssignFieldValues
    {
        get => _jsonParseNode.OnAfterAssignFieldValues;
        set => _jsonParseNode.OnBeforeAssignFieldValues = value;
    }

    /// <inheritdoc />
    public Guid? GetGuidValue()
        => Guid.TryParse(GetStringValue(), out var guid) ? guid : null;

    /// <inheritdoc />
    public string? GetStringValue()
        => _jsonParseNode.GetStringValue();

    /// <inheritdoc />
    public IParseNode? GetChildNode(string identifier)
    {
        if (_jsonNode.ValueKind == JsonValueKind.Object && _jsonNode.TryGetProperty(identifier ?? throw new ArgumentNullException(nameof(identifier)), out var jsonElement))
        {
            return new JellyfinJsonParseNode(jsonElement)
            {
                OnBeforeAssignFieldValues = OnBeforeAssignFieldValues,
                OnAfterAssignFieldValues = OnAfterAssignFieldValues
            };
        }

        return default;
    }

    /// <inheritdoc />
    public bool? GetBoolValue()
        => _jsonParseNode.GetBoolValue();

    /// <inheritdoc />
    public byte? GetByteValue()
        => _jsonParseNode.GetByteValue();

    /// <inheritdoc />
    public sbyte? GetSbyteValue()
        => _jsonParseNode.GetSbyteValue();

    /// <inheritdoc />
    public int? GetIntValue()
        => _jsonParseNode.GetIntValue();

    /// <inheritdoc />
    public float? GetFloatValue()
        => _jsonParseNode.GetFloatValue();

    /// <inheritdoc />
    public long? GetLongValue()
        => _jsonParseNode.GetLongValue();

    /// <inheritdoc />
    public double? GetDoubleValue()
        => _jsonParseNode.GetDoubleValue();

    /// <inheritdoc />
    public decimal? GetDecimalValue()
        => _jsonParseNode.GetDecimalValue();

    /// <inheritdoc />
    public DateTimeOffset? GetDateTimeOffsetValue()
        => _jsonParseNode.GetDateTimeOffsetValue();

    /// <inheritdoc />
    public TimeSpan? GetTimeSpanValue()
        => _jsonParseNode.GetTimeSpanValue();

    /// <inheritdoc />
    public Date? GetDateValue()
        => _jsonParseNode.GetDateValue();

    /// <inheritdoc />
    public Time? GetTimeValue()
        => _jsonParseNode.GetTimeValue();

    /// <inheritdoc />
    public IEnumerable<T> GetCollectionOfPrimitiveValues<T>()
    {
        if (_jsonNode.ValueKind == JsonValueKind.Array)
        {
            var genericType = typeof(T);
            foreach (var collectionValue in _jsonNode.EnumerateArray())
            {
                var currentParseNode = new JellyfinJsonParseNode(collectionValue) { OnBeforeAssignFieldValues = OnBeforeAssignFieldValues, OnAfterAssignFieldValues = OnAfterAssignFieldValues };
                if (genericType == _booleanType)
                {
                    yield return (T)(object)currentParseNode.GetBoolValue()!;
                }
                else if (genericType == _byteType)
                {
                    yield return (T)(object)currentParseNode.GetByteValue()!;
                }
                else if (genericType == _sbyteType)
                {
                    yield return (T)(object)currentParseNode.GetSbyteValue()!;
                }
                else if (genericType == _stringType)
                {
                    yield return (T)(object)currentParseNode.GetStringValue()!;
                }
                else if (genericType == _intType)
                {
                    yield return (T)(object)currentParseNode.GetIntValue()!;
                }
                else if (genericType == _floatType)
                {
                    yield return (T)(object)currentParseNode.GetFloatValue()!;
                }
                else if (genericType == _longType)
                {
                    yield return (T)(object)currentParseNode.GetLongValue()!;
                }
                else if (genericType == _doubleType)
                {
                    yield return (T)(object)currentParseNode.GetDoubleValue()!;
                }
                else if (genericType == _guidType)
                {
                    yield return (T)(object)currentParseNode.GetGuidValue()!;
                }
                else if (genericType == _dateTimeOffsetType)
                {
                    yield return (T)(object)currentParseNode.GetDateTimeOffsetValue()!;
                }
                else if (genericType == _timeSpanType)
                {
                    yield return (T)(object)currentParseNode.GetTimeSpanValue()!;
                }
                else if (genericType == _dateType)
                {
                    yield return (T)(object)currentParseNode.GetDateValue()!;
                }
                else if (genericType == _timeType)
                {
                    yield return (T)(object)currentParseNode.GetTimeValue()!;
                }
                else
                {
                    throw new InvalidOperationException($"unknown type for deserialization {genericType.FullName}");
                }
            }
        }
    }

    /// <inheritdoc />
#if NET5_0_OR_GREATER
    public IEnumerable<T?> GetCollectionOfEnumValues<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>()
        where T : struct, Enum
#else
    public IEnumerable<T?> GetCollectionOfEnumValues<T>()
        where T : struct, Enum
#endif
    {
        if (_jsonNode.ValueKind == JsonValueKind.Array)
        {
            var enumerator = _jsonNode.EnumerateArray();
            while (enumerator.MoveNext())
            {
                var currentParseNode = new JellyfinJsonParseNode(enumerator.Current)
                {
                    OnAfterAssignFieldValues = OnAfterAssignFieldValues,
                    OnBeforeAssignFieldValues = OnBeforeAssignFieldValues
                };
                yield return currentParseNode.GetEnumValue<T>();
            }
        }
    }

    /// <inheritdoc />
    public IEnumerable<T> GetCollectionOfObjectValues<T>(ParsableFactory<T> factory)
        where T : IParsable
    {
        if (_jsonNode.ValueKind == JsonValueKind.Array)
        {
            var enumerator = _jsonNode.EnumerateArray();
            while (enumerator.MoveNext())
            {
                var currentParseNode = new JellyfinJsonParseNode(enumerator.Current)
                {
                    OnAfterAssignFieldValues = OnAfterAssignFieldValues,
                    OnBeforeAssignFieldValues = OnBeforeAssignFieldValues
                };

                yield return currentParseNode.GetObjectValue(factory);
            }
        }
    }

    /// <inheritdoc />
#if NET5_0_OR_GREATER
    public T? GetEnumValue<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>()
        where T : struct, Enum
#else
    public T? GetEnumValue<T>()
        where T : struct, Enum
#endif
        => _jsonParseNode.GetEnumValue<T>();

    /// <inheritdoc />
    public T GetObjectValue<T>(ParsableFactory<T> factory)
        where T : IParsable
    {
        var item = factory(this);
        OnBeforeAssignFieldValues?.Invoke(item);
        AssignFieldValues(item);
        OnAfterAssignFieldValues?.Invoke(item);
        return item;
    }

    /// <inheritdoc />
    public byte[]? GetByteArrayValue()
        => _jsonParseNode.GetByteArrayValue();

    private static object? TryGetAnything(JsonElement element)
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Number:
                if (element.TryGetDecimal(out var dec))
                {
                    return dec;
                }

                if (element.TryGetDouble(out var db))
                {
                    return db;
                }

                if (element.TryGetInt16(out var s))
                {
                    return s;
                }

                if (element.TryGetInt32(out var i))
                {
                    return i;
                }

                if (element.TryGetInt64(out var l))
                {
                    return l;
                }

                if (element.TryGetSingle(out var f))
                {
                    return f;
                }

                if (element.TryGetUInt16(out var us))
                {
                    return us;
                }

                if (element.TryGetUInt32(out var ui))
                {
                    return ui;
                }

                if (element.TryGetUInt64(out var ul))
                {
                    return ul;
                }

                throw new InvalidOperationException("unexpected additional value type during number deserialization");

            case JsonValueKind.String:
                if (element.TryGetDateTime(out var dt))
                {
                    return dt;
                }

                if (element.TryGetDateTimeOffset(out var dto))
                {
                    return dto;
                }

                if (element.TryGetGuid(out var g))
                {
                    return g;
                }

                return element.GetString();

            case JsonValueKind.Array:
            case JsonValueKind.Object:
                return element;
            case JsonValueKind.True:
                return true;
            case JsonValueKind.False:
                return false;
            case JsonValueKind.Null:
            case JsonValueKind.Undefined:
                return null;
            default:
                throw new InvalidOperationException($"unexpected additional value type during deserialization json kind : {element.ValueKind}");
        }
    }

    private void AssignFieldValues<T>(T item)
        where T : IParsable
    {
        if (_jsonNode.ValueKind != JsonValueKind.Object)
        {
            return;
        }

        IDictionary<string, object>? itemAdditionalData = null;
        if (item is IAdditionalDataHolder holder)
        {
            itemAdditionalData = holder.AdditionalData;
        }

        var fieldDeserializers = item.GetFieldDeserializers();

        foreach (var fieldValue in _jsonNode.EnumerateObject())
        {
            if (fieldDeserializers.TryGetValue(fieldValue.Name, out var fieldDeserializer))
            {
                if (fieldValue.Value.ValueKind == JsonValueKind.Null)
                {
                    // If the property is already null just continue. As calling functions like GetDouble,GetBoolValue do not process JsonValueKind.Null.
                    continue;
                }

                fieldDeserializer.Invoke(new JellyfinJsonParseNode(fieldValue.Value)
                {
                    OnBeforeAssignFieldValues = OnBeforeAssignFieldValues,
                    OnAfterAssignFieldValues = OnAfterAssignFieldValues
                });
            }
            else if (itemAdditionalData != null)
            {
                IDictionaryExtensions.TryAdd(itemAdditionalData, fieldValue.Name, TryGetAnything(fieldValue.Value)!);
            }
            else
            {
                Debug.WriteLine($"found additional property {fieldValue.Name} to deserialize but the model doesn't support additional data");
            }
        }
    }
}
