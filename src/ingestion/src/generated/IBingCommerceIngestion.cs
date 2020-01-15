// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Ingestion
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IBingCommerceIngestion : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Create an index.
        /// </summary>
        /// <remarks>
        /// Creates a definition of the tenant's index.
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='body'>
        /// An Index object that describes the index definition to add.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IndexResponse>> CreateIndexWithHttpMessagesAsync(string tenantid, string subscriptionId = default(string), Index body = default(Index), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get list of index definitions.
        /// </summary>
        /// <remarks>
        /// Get list of index definitions that you defined for a tenant.
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IndexResponse>> GetAllIndexesWithHttpMessagesAsync(string tenantid, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete an index.
        /// </summary>
        /// <remarks>
        /// Delete an index definition along with all the catalog.
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IndexResponse>> DeleteIndexWithHttpMessagesAsync(string tenantid, string indexid, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates an index with id.
        /// </summary>
        /// <remarks>
        /// Update the definition for your index.
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='body'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IndexResponse>> UpdateIndexWithHttpMessagesAsync(string tenantid, string indexid, string subscriptionId = default(string), Index body = default(Index), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get index definition by id.
        /// </summary>
        /// <remarks>
        /// Get a specific index definition for a tenant.
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IndexResponse>> GetIndexWithHttpMessagesAsync(string tenantid, string indexid, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete documents from your catalog.
        /// </summary>
        /// <remarks>
        /// Delete documents from your index's catalog.
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='body'>
        /// The set of document ids to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<DeleteDocumentsResponse>> DeleteDocumentsWithHttpMessagesAsync(string tenantid, string indexid, string subscriptionId = default(string), RequestsStringSet body = default(RequestsStringSet), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get index status by id.
        /// </summary>
        /// <remarks>
        /// Get the detailed status of your index in each supported region.
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IndexStatusResponse>> GetIndexStatusWithHttpMessagesAsync(string tenantid, string indexid, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Push catalog data.
        /// </summary>
        /// <remarks>
        /// This method pushes updates to your your index data to Bing. This is
        /// an asynchronous process. To upload your index data to Bing, you'll
        /// send a push request that contains your index data.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='notransform'>
        /// This disables transformation config processing if the config was
        /// uploaded for some index. It's useful when the data is already
        /// transformed and is matching the index definition. Default is
        /// `false`
        /// </param>
        /// <param name='updateid'>
        /// An id to uniquely identify the push update request in order to be
        /// able to track it down later.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PushDataUpdateResponse>> PushDataUpdateWithHttpMessagesAsync(string body, string tenantid, string indexid, string subscriptionId = default(string), bool? notransform = default(bool?), string updateid = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// .
        /// </summary>
        /// <remarks>
        /// .
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='updateid'>
        /// An id to uniquely identify the push update request in order to be
        /// able to track it down later.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PushUpdateStatusResponse>> PushDataStatusWithHttpMessagesAsync(string tenantid, string indexid, string updateid, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete your index's transformation config.
        /// </summary>
        /// <remarks>
        /// Delete the transformation config that currently aplies to data you
        /// push to your index.
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TransformationConfigResponse>> DeleteTransformationConfigWithHttpMessagesAsync(string tenantid, string indexid, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve your current index's transformation config.
        /// </summary>
        /// <remarks>
        /// Retrieve the transformation config that currently applies to data
        /// you push to your index.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TransformationConfigResponse>> CreateOrUpdateTransformationConfigWithHttpMessagesAsync(string body, string tenantid, string indexid, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get ingestion status.
        /// </summary>
        /// <remarks>
        /// Track your ingestion by querying the status.
        /// </remarks>
        /// <param name='tenantid'>
        /// The ID that uniquely identifies the tenant that the index belongs
        /// to.
        /// </param>
        /// <param name='indexid'>
        /// The ID that uniquely identifies the index definition to manage.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TransformationConfigResponse>> GetTransformationConfigWithHttpMessagesAsync(string tenantid, string indexid, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a transformation config.
        /// </summary>
        /// <remarks>
        /// Upload a new transformation config and set it as the transformation
        /// config that applies to data you push to your index.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TransformationConfigResponse>> UploadTryOutConfigWithHttpMessagesAsync(string body, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Upload a trytout config.
        /// </summary>
        /// <remarks>
        /// Upload a transformation config that you can use to test data
        /// transformation on the cloud.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='tryoutid'>
        /// The transformation tryout config id.
        /// </param>
        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TransformationTryoutResponse>> ExecuteTryOutConfigWithHttpMessagesAsync(string body, string tryoutid, string subscriptionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='subscriptionId'>
        /// Bing developer subcription id
        /// </param>
        /// <param name='format'>
        /// The push data update document format. Possible values include:
        /// 'Unknown', 'LDJson', 'CSV', 'TSV', 'JsonArray'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SchemaDetectionResponse>> DetectSchemaWithHttpMessagesAsync(string subscriptionId = default(string), string format = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
