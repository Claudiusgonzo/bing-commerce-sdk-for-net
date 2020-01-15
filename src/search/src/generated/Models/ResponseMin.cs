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
    /// Returns the minimum value of the field encountered within the match
    /// set.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Min")]
    public partial class ResponseMin : ResponseFieldAggregationBase
    {
        /// <summary>
        /// Initializes a new instance of the ResponseMin class.
        /// </summary>
        public ResponseMin()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResponseMin class.
        /// </summary>
        /// <param name="errors">A list of errors that happened to the task, if
        /// any.</param>
        /// <param name="name">The aggregation name as defined in the
        /// requset.</param>
        /// <param name="estimatedCount">An estimated count of items in this
        /// aggregation.</param>
        /// <param name="aggregations">The list of child aggregations, if
        /// any.</param>
        /// <param name="field">The name of the field.</param>
        /// <param name="value">The minimum value of the field for the match
        /// set.</param>
        public ResponseMin(IList<ResponseError> errors = default(IList<ResponseError>), IList<ResponseDebugInfo> debug = default(IList<ResponseDebugInfo>), string name = default(string), long? estimatedCount = default(long?), IList<ResponseAggregation> aggregations = default(IList<ResponseAggregation>), string field = default(string), double? value = default(double?))
            : base(errors, debug, name, estimatedCount, aggregations, field)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the minimum value of the field for the match set.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

    }
}
