// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Ingestion.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Region.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Region
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "EastAsia")]
        EastAsia,
        [EnumMember(Value = "EastUS2")]
        EastUS2,
        [EnumMember(Value = "NorthCentralUS")]
        NorthCentralUS,
        [EnumMember(Value = "NorthEurope")]
        NorthEurope,
        [EnumMember(Value = "WestUS2")]
        WestUS2,
        [EnumMember(Value = "SoutheastAsia")]
        SoutheastAsia,
        [EnumMember(Value = "AustraliaEast")]
        AustraliaEast,
        [EnumMember(Value = "AustraliaSoutheast")]
        AustraliaSoutheast,
        [EnumMember(Value = "AustraliaCentral")]
        AustraliaCentral,
        [EnumMember(Value = "AustraliaCentral2")]
        AustraliaCentral2,
        [EnumMember(Value = "BrazilSouth")]
        BrazilSouth,
        [EnumMember(Value = "CanadaCentral")]
        CanadaCentral,
        [EnumMember(Value = "CanadaEast")]
        CanadaEast,
        [EnumMember(Value = "ChinaNorth")]
        ChinaNorth,
        [EnumMember(Value = "ChinaEast")]
        ChinaEast,
        [EnumMember(Value = "ChinaNorth2")]
        ChinaNorth2,
        [EnumMember(Value = "ChinaEast2")]
        ChinaEast2,
        [EnumMember(Value = "WestEurope")]
        WestEurope,
        [EnumMember(Value = "FranceCentral")]
        FranceCentral,
        [EnumMember(Value = "FranceSouth")]
        FranceSouth,
        [EnumMember(Value = "GermanyCentral")]
        GermanyCentral,
        [EnumMember(Value = "GermanyNortheast")]
        GermanyNortheast,
        [EnumMember(Value = "CentralIndia")]
        CentralIndia,
        [EnumMember(Value = "WestIndia")]
        WestIndia,
        [EnumMember(Value = "SouthIndia")]
        SouthIndia,
        [EnumMember(Value = "JapanEast")]
        JapanEast,
        [EnumMember(Value = "JapanWest")]
        JapanWest,
        [EnumMember(Value = "KoreaCentral")]
        KoreaCentral,
        [EnumMember(Value = "KoreaSouth")]
        KoreaSouth,
        [EnumMember(Value = "EastUS")]
        EastUS,
        [EnumMember(Value = "WestUS")]
        WestUS,
        [EnumMember(Value = "CentralUS")]
        CentralUS,
        [EnumMember(Value = "SouthCentralUS")]
        SouthCentralUS,
        [EnumMember(Value = "WestCentralUS")]
        WestCentralUS,
        [EnumMember(Value = "SouthAfricaNorth")]
        SouthAfricaNorth,
        [EnumMember(Value = "SouthAfricaWest")]
        SouthAfricaWest,
        [EnumMember(Value = "UKWest")]
        UKWest,
        [EnumMember(Value = "UKSouth")]
        UKSouth,
        [EnumMember(Value = "UAENorth")]
        UAENorth,
        [EnumMember(Value = "UAECentral")]
        UAECentral
    }
    internal static class RegionEnumExtension
    {
        internal static string ToSerializedValue(this Region? value)
        {
            return value == null ? null : ((Region)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Region value)
        {
            switch( value )
            {
                case Region.Unknown:
                    return "Unknown";
                case Region.EastAsia:
                    return "EastAsia";
                case Region.EastUS2:
                    return "EastUS2";
                case Region.NorthCentralUS:
                    return "NorthCentralUS";
                case Region.NorthEurope:
                    return "NorthEurope";
                case Region.WestUS2:
                    return "WestUS2";
                case Region.SoutheastAsia:
                    return "SoutheastAsia";
                case Region.AustraliaEast:
                    return "AustraliaEast";
                case Region.AustraliaSoutheast:
                    return "AustraliaSoutheast";
                case Region.AustraliaCentral:
                    return "AustraliaCentral";
                case Region.AustraliaCentral2:
                    return "AustraliaCentral2";
                case Region.BrazilSouth:
                    return "BrazilSouth";
                case Region.CanadaCentral:
                    return "CanadaCentral";
                case Region.CanadaEast:
                    return "CanadaEast";
                case Region.ChinaNorth:
                    return "ChinaNorth";
                case Region.ChinaEast:
                    return "ChinaEast";
                case Region.ChinaNorth2:
                    return "ChinaNorth2";
                case Region.ChinaEast2:
                    return "ChinaEast2";
                case Region.WestEurope:
                    return "WestEurope";
                case Region.FranceCentral:
                    return "FranceCentral";
                case Region.FranceSouth:
                    return "FranceSouth";
                case Region.GermanyCentral:
                    return "GermanyCentral";
                case Region.GermanyNortheast:
                    return "GermanyNortheast";
                case Region.CentralIndia:
                    return "CentralIndia";
                case Region.WestIndia:
                    return "WestIndia";
                case Region.SouthIndia:
                    return "SouthIndia";
                case Region.JapanEast:
                    return "JapanEast";
                case Region.JapanWest:
                    return "JapanWest";
                case Region.KoreaCentral:
                    return "KoreaCentral";
                case Region.KoreaSouth:
                    return "KoreaSouth";
                case Region.EastUS:
                    return "EastUS";
                case Region.WestUS:
                    return "WestUS";
                case Region.CentralUS:
                    return "CentralUS";
                case Region.SouthCentralUS:
                    return "SouthCentralUS";
                case Region.WestCentralUS:
                    return "WestCentralUS";
                case Region.SouthAfricaNorth:
                    return "SouthAfricaNorth";
                case Region.SouthAfricaWest:
                    return "SouthAfricaWest";
                case Region.UKWest:
                    return "UKWest";
                case Region.UKSouth:
                    return "UKSouth";
                case Region.UAENorth:
                    return "UAENorth";
                case Region.UAECentral:
                    return "UAECentral";
            }
            return null;
        }

        internal static Region? ParseRegion(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return Region.Unknown;
                case "EastAsia":
                    return Region.EastAsia;
                case "EastUS2":
                    return Region.EastUS2;
                case "NorthCentralUS":
                    return Region.NorthCentralUS;
                case "NorthEurope":
                    return Region.NorthEurope;
                case "WestUS2":
                    return Region.WestUS2;
                case "SoutheastAsia":
                    return Region.SoutheastAsia;
                case "AustraliaEast":
                    return Region.AustraliaEast;
                case "AustraliaSoutheast":
                    return Region.AustraliaSoutheast;
                case "AustraliaCentral":
                    return Region.AustraliaCentral;
                case "AustraliaCentral2":
                    return Region.AustraliaCentral2;
                case "BrazilSouth":
                    return Region.BrazilSouth;
                case "CanadaCentral":
                    return Region.CanadaCentral;
                case "CanadaEast":
                    return Region.CanadaEast;
                case "ChinaNorth":
                    return Region.ChinaNorth;
                case "ChinaEast":
                    return Region.ChinaEast;
                case "ChinaNorth2":
                    return Region.ChinaNorth2;
                case "ChinaEast2":
                    return Region.ChinaEast2;
                case "WestEurope":
                    return Region.WestEurope;
                case "FranceCentral":
                    return Region.FranceCentral;
                case "FranceSouth":
                    return Region.FranceSouth;
                case "GermanyCentral":
                    return Region.GermanyCentral;
                case "GermanyNortheast":
                    return Region.GermanyNortheast;
                case "CentralIndia":
                    return Region.CentralIndia;
                case "WestIndia":
                    return Region.WestIndia;
                case "SouthIndia":
                    return Region.SouthIndia;
                case "JapanEast":
                    return Region.JapanEast;
                case "JapanWest":
                    return Region.JapanWest;
                case "KoreaCentral":
                    return Region.KoreaCentral;
                case "KoreaSouth":
                    return Region.KoreaSouth;
                case "EastUS":
                    return Region.EastUS;
                case "WestUS":
                    return Region.WestUS;
                case "CentralUS":
                    return Region.CentralUS;
                case "SouthCentralUS":
                    return Region.SouthCentralUS;
                case "WestCentralUS":
                    return Region.WestCentralUS;
                case "SouthAfricaNorth":
                    return Region.SouthAfricaNorth;
                case "SouthAfricaWest":
                    return Region.SouthAfricaWest;
                case "UKWest":
                    return Region.UKWest;
                case "UKSouth":
                    return Region.UKSouth;
                case "UAENorth":
                    return Region.UAENorth;
                case "UAECentral":
                    return Region.UAECentral;
            }
            return null;
        }
    }
}
