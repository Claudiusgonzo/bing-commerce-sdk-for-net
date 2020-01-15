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
    /// Defines the abstract base type for conditions with a field name.
    /// </summary>
    public partial class FieldConditionBase : ConditionBase
    {
        /// <summary>
        /// Initializes a new instance of the FieldConditionBase class.
        /// </summary>
        public FieldConditionBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FieldConditionBase class.
        /// </summary>
        /// <param name="field">The name of the field.</param>
        public FieldConditionBase(string field = default(string))
        {
            Field = field;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }

    }
}
