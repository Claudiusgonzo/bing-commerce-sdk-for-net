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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ResponseIndex : Index
    {
        /// <summary>
        /// Initializes a new instance of the ResponseIndex class.
        /// </summary>
        public ResponseIndex()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResponseIndex class.
        /// </summary>
        /// <param name="name">The index's name. The name must be unique per
        /// tenant, contain only ASCII characters, and have a maximum length of
        /// 64 characters.</param>
        /// <param name="description">A description of the index. The
        /// description is for the tenant's use. The description must contain
        /// only ASCII characters and have a maximum length of 64
        /// characters.</param>
        /// <param name="regions">The array of regions where the customer data
        /// will be processed and served.</param>
        /// <param name="searchScenario">The type of search scenario that the
        /// user is using the index for, which includes Retail, Hotel, and
        /// Document. Possible values include: 'Unknown', 'Retail', 'Document',
        /// 'Hotel'</param>
        /// <param name="searchServices">The array of additional search
        /// services that the user wants to include for the index, which
        /// includes Autosuggest and VisualSearch.</param>
        /// <param name="schemaVersion">The version for the schema of the
        /// index.</param>
        /// <param name="fields">The fields that are associated with the
        /// index.</param>
        /// <param name="id">The ID that uniquely identifies the index
        /// definition that had the CRUD operation applied.</param>
        /// <param name="provisioningState">The current state of provisioning
        /// for the index definition. Possible values include: 'Unknown',
        /// 'NotStarted', 'Provisioning', 'Deprovisioning', 'Succeeded',
        /// 'Failed'</param>
        /// <param name="createdDateTime">The date and time when the index was
        /// created.</param>
        public ResponseIndex(string name = default(string), string description = default(string), IList<Region?> regions = default(IList<Region?>), string searchScenario = default(string), IList<string> searchServices = default(IList<string>), string schemaVersion = default(string), IList<IndexField> fields = default(IList<IndexField>), string id = default(string), string provisioningState = default(string), string createdDateTime = default(string))
            : base(name, description, regions, searchScenario, searchServices, schemaVersion, fields)
        {
            Id = id;
            ProvisioningState = provisioningState;
            CreatedDateTime = createdDateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID that uniquely identifies the index definition
        /// that had the CRUD operation applied.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the current state of provisioning for the index
        /// definition. Possible values include: 'Unknown', 'NotStarted',
        /// 'Provisioning', 'Deprovisioning', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the index was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
