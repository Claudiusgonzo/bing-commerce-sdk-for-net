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
    using System.Linq;

    /// <summary>
    /// Defines a geo-location based on lattitude and longitude.
    /// </summary>
    public partial class GeoPoint
    {
        /// <summary>
        /// Initializes a new instance of the GeoPoint class.
        /// </summary>
        public GeoPoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoPoint class.
        /// </summary>
        /// <param name="lat">The lattitude of the location.</param>
        /// <param name="lon">The longitude of the location.</param>
        public GeoPoint(double? lat = default(double?), double? lon = default(double?))
        {
            Lat = lat;
            Lon = lon;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the lattitude of the location.
        /// </summary>
        [JsonProperty(PropertyName = "lat")]
        public double? Lat { get; set; }

        /// <summary>
        /// Gets or sets the longitude of the location.
        /// </summary>
        [JsonProperty(PropertyName = "lon")]
        public double? Lon { get; set; }

    }
}
