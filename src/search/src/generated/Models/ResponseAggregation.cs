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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines an aggregation result.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Aggregation")]
    public partial class ResponseAggregation : ResponseTask
    {
        /// <summary>
        /// Initializes a new instance of the ResponseAggregation class.
        /// </summary>
        public ResponseAggregation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResponseAggregation class.
        /// </summary>
        /// <param name="errors">A list of errors that happened to the task, if
        /// any.</param>
        /// <param name="name">The aggregation name as defined in the
        /// requset.</param>
        /// <param name="estimatedCount">An estimated count of items in this
        /// aggregation.</param>
        /// <param name="aggregations">The list of child aggregations, if
        /// any.</param>
        public ResponseAggregation(IList<ResponseError> errors = default(IList<ResponseError>), IList<ResponseDebugInfo> debug = default(IList<ResponseDebugInfo>), string name = default(string), long? estimatedCount = default(long?), IList<ResponseAggregation> aggregations = default(IList<ResponseAggregation>))
            : base(errors, debug)
        {
            Name = name;
            EstimatedCount = estimatedCount;
            Aggregations = aggregations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the aggregation name as defined in the requset.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an estimated count of items in this aggregation.
        /// </summary>
        [JsonProperty(PropertyName = "estimatedCount")]
        public long? EstimatedCount { get; set; }

        /// <summary>
        /// Gets or sets the list of child aggregations, if any.
        /// </summary>
        [JsonProperty(PropertyName = "aggregations")]
        public IList<ResponseAggregation> Aggregations { get; set; }

    }
}
