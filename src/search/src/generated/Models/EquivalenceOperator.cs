// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EquivalenceOperator.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EquivalenceOperator
    {
        [EnumMember(Value = "Eq")]
        Eq,
        [EnumMember(Value = "Ne")]
        Ne
    }
    internal static class EquivalenceOperatorEnumExtension
    {
        internal static string ToSerializedValue(this EquivalenceOperator? value)
        {
            return value == null ? null : ((EquivalenceOperator)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EquivalenceOperator value)
        {
            switch( value )
            {
                case EquivalenceOperator.Eq:
                    return "Eq";
                case EquivalenceOperator.Ne:
                    return "Ne";
            }
            return null;
        }

        internal static EquivalenceOperator? ParseEquivalenceOperator(this string value)
        {
            switch( value )
            {
                case "Eq":
                    return EquivalenceOperator.Eq;
                case "Ne":
                    return EquivalenceOperator.Ne;
            }
            return null;
        }
    }
}
