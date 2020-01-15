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
    /// Defines a geographical box to match the results that lie within it.
    /// </summary>
    public partial class GeoBoundingBox : GeoBoundaryBase
    {
        /// <summary>
        /// Initializes a new instance of the GeoBoundingBox class.
        /// </summary>
        public GeoBoundingBox()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoBoundingBox class.
        /// </summary>
        /// <param name="topLeft">The top-left corner geo-location of the
        /// box.</param>
        /// <param name="bottomRight">The bottom-right corner geo-location of
        /// the box.</param>
        public GeoBoundingBox(GeoPoint topLeft = default(GeoPoint), GeoPoint bottomRight = default(GeoPoint))
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the top-left corner geo-location of the box.
        /// </summary>
        [JsonProperty(PropertyName = "topLeft")]
        public GeoPoint TopLeft { get; set; }

        /// <summary>
        /// Gets or sets the bottom-right corner geo-location of the box.
        /// </summary>
        [JsonProperty(PropertyName = "bottomRight")]
        public GeoPoint BottomRight { get; set; }

    }
}
