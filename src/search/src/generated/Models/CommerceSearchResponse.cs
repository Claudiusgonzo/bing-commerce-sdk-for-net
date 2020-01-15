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
    /// The response to a Bing Commerce Search Query.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SearchResponse")]
    public partial class CommerceSearchResponse : ResponseTask
    {
        /// <summary>
        /// Initializes a new instance of the CommerceSearchResponse class.
        /// </summary>
        public CommerceSearchResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CommerceSearchResponse class.
        /// </summary>
        /// <param name="errors">A list of errors that happened to the task, if
        /// any.</param>
        /// <param name="impressionId">A random GUID to uniquely track the
        /// search response.</param>
        /// <param name="queryContext">The query alteration result.</param>
        /// <param name="items">The item results</param>
        /// <param name="aggregations">The aggregations result.</param>
        /// <param name="redirectUrl">The redirect url for this the current
        /// query from the request search instance.</param>
        /// <param name="customization">The user defined customizations applied
        /// the search query.</param>
        public CommerceSearchResponse(IList<ResponseError> errors = default(IList<ResponseError>), IList<ResponseDebugInfo> debug = default(IList<ResponseDebugInfo>), string impressionId = default(string), ResponseQueryContext queryContext = default(ResponseQueryContext), ResponseItemsBase items = default(ResponseItemsBase), IList<ResponseAggregation> aggregations = default(IList<ResponseAggregation>), string redirectUrl = default(string), ResponseCustomization customization = default(ResponseCustomization))
            : base(errors, debug)
        {
            ImpressionId = impressionId;
            QueryContext = queryContext;
            Items = items;
            Aggregations = aggregations;
            RedirectUrl = redirectUrl;
            Customization = customization;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a random GUID to uniquely track the search response.
        /// </summary>
        [JsonProperty(PropertyName = "impressionId")]
        public string ImpressionId { get; set; }

        /// <summary>
        /// Gets or sets the query alteration result.
        /// </summary>
        [JsonProperty(PropertyName = "queryContext")]
        public ResponseQueryContext QueryContext { get; set; }

        /// <summary>
        /// Gets or sets the item results
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public ResponseItemsBase Items { get; set; }

        /// <summary>
        /// Gets or sets the aggregations result.
        /// </summary>
        [JsonProperty(PropertyName = "aggregations")]
        public IList<ResponseAggregation> Aggregations { get; set; }

        /// <summary>
        /// Gets or sets the redirect url for this the current query from the
        /// request search instance.
        /// </summary>
        [JsonProperty(PropertyName = "redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets the user defined customizations applied the search
        /// query.
        /// </summary>
        [JsonProperty(PropertyName = "customization")]
        public ResponseCustomization Customization { get; set; }

    }
}
