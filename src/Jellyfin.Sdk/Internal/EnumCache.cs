using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.Serialization;
using Microsoft.Kiota.Abstractions.Helpers;

namespace Jellyfin.Sdk.Internal;

/// <summary>
/// Parses enum values from their JSON names with lookup tables built once per enum type.
/// </summary>
/// <remarks>
/// Same lookup order as Kiota's EnumHelpers: an exact <see cref="EnumMemberAttribute"/> value, then the field name ignoring case.
/// </remarks>
/// <typeparam name="T">The enum type.</typeparam>
internal static class EnumCache<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>
    where T : struct, Enum
{
    private static readonly Dictionary<string, T> _memberValues = new(StringComparer.Ordinal);
    private static readonly Dictionary<string, T> _names = new(StringComparer.OrdinalIgnoreCase);

#pragma warning disable CA1810 // Both tables are filled from one pass over the fields.
    static EnumCache()
#pragma warning restore CA1810
    {
        foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var value = (T)field.GetValue(null)!;
            if (field.GetCustomAttribute<EnumMemberAttribute>()?.Value is { } memberValue)
            {
                AddIfMissing(_memberValues, memberValue, value);
            }

            AddIfMissing(_names, field.Name, value);
        }
    }

    /// <summary>
    /// Parse a JSON value.
    /// </summary>
    /// <param name="rawValue">The JSON string value.</param>
    /// <returns>The enum value, or <c>null</c> when the value is empty or unknown.</returns>
    public static T? Parse(string? rawValue)
    {
        if (string.IsNullOrEmpty(rawValue))
        {
            return null;
        }

        if (_memberValues.TryGetValue(rawValue!, out var value) || _names.TryGetValue(rawValue!, out value))
        {
            return value;
        }

        // Enum.TryParse, under EnumHelpers, only accepts something the tables miss when it is padded, numeric, or a list.
        var first = rawValue![0];
        return char.IsWhiteSpace(first) || char.IsWhiteSpace(rawValue[rawValue.Length - 1])
            || (first >= '0' && first <= '9') || first is '-' or '+'
            || IsList(rawValue)
                ? EnumHelpers.GetEnumValue<T>(rawValue)
                : null;
    }

    private static bool IsList(string value)
    {
#if NETSTANDARD2_0
        return value.IndexOf(',') >= 0;
#else
        return value.Contains(',', StringComparison.Ordinal);
#endif
    }

    private static void AddIfMissing(Dictionary<string, T> dictionary, string key, T value)
    {
#if NETSTANDARD2_0
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, value);
        }
#else
        dictionary.TryAdd(key, value);
#endif
    }
}
