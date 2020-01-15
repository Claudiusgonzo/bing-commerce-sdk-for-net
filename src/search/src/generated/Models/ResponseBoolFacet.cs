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
    /// Defines a facet on a Boolean field.
    /// </summary>
    [Newtonsoft.Json.JsonObject("BoolFacet")]
    public partial class ResponseBoolFacet : ResponseFacetBase
    {
        /// <summary>
        /// Initializes a new instance of the ResponseBoolFacet class.
        /// </summary>
        public ResponseBoolFacet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResponseBoolFacet class.
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
        /// <param name="label">The facet label, that you can use to render
        /// your UI.</param>
        public ResponseBoolFacet(IList<ResponseError> errors = default(IList<ResponseError>), IList<ResponseDebugInfo> debug = default(IList<ResponseDebugInfo>), string name = default(string), long? estimatedCount = default(long?), IList<ResponseAggregation> aggregations = default(IList<ResponseAggregation>), string field = default(string), string label = default(string), IList<ResponseBoolRefinement> refinements = default(IList<ResponseBoolRefinement>))
            : base(errors, debug, name, estimatedCount, aggregations, field, label)
        {
            Refinements = refinements;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "refinements")]
        public IList<ResponseBoolRefinement> Refinements { get; set; }

    }
}
