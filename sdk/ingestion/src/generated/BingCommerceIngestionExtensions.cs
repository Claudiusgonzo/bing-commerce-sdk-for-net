// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Ingestion
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BingCommerceIngestion.
    /// </summary>
    public static partial class BingCommerceIngestionExtensions
    {
            /// <summary>
            /// Create an index.
            /// </summary>
            /// <remarks>
            /// Creates a definition of the tenant's index.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='body'>
            /// An Index object that describes the index definition to add.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexResponse> CreateIndexAsync(this IBingCommerceIngestion operations, string tenantid, string subscriptionId = default(string), Index body = default(Index), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateIndexWithHttpMessagesAsync(tenantid, subscriptionId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get list of index definitions.
            /// </summary>
            /// <remarks>
            /// Get list of index definitions that you defined for a tenant.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexResponse> GetAllIndexesAsync(this IBingCommerceIngestion operations, string tenantid, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllIndexesWithHttpMessagesAsync(tenantid, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an index.
            /// </summary>
            /// <remarks>
            /// Delete an index definition along with all the catalog.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='indexid'>
            /// The ID that uniquely identifies the index definition to manage.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexResponse> DeleteIndexAsync(this IBingCommerceIngestion operations, string tenantid, string indexid, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteIndexWithHttpMessagesAsync(tenantid, indexid, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an index with id.
            /// </summary>
            /// <remarks>
            /// Update the definition for your index.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexResponse> UpdateIndexAsync(this IBingCommerceIngestion operations, string tenantid, string indexid, string subscriptionId = default(string), Index body = default(Index), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateIndexWithHttpMessagesAsync(tenantid, indexid, subscriptionId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get index definition by id.
            /// </summary>
            /// <remarks>
            /// Get a specific index definition for a tenant.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='indexid'>
            /// The ID that uniquely identifies the index definition to manage.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexResponse> GetIndexAsync(this IBingCommerceIngestion operations, string tenantid, string indexid, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetIndexWithHttpMessagesAsync(tenantid, indexid, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete documents from your catalog.
            /// </summary>
            /// <remarks>
            /// Delete documents from your index's catalog.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeleteDocumentsResponse> DeleteDocumentsAsync(this IBingCommerceIngestion operations, string tenantid, string indexid, string subscriptionId = default(string), RequestsStringSet body = default(RequestsStringSet), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteDocumentsWithHttpMessagesAsync(tenantid, indexid, subscriptionId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get index status by id.
            /// </summary>
            /// <remarks>
            /// Get the detailed status of your index in each supported region.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='indexid'>
            /// The ID that uniquely identifies the index definition to manage.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexStatusResponse> GetIndexStatusAsync(this IBingCommerceIngestion operations, string tenantid, string indexid, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetIndexStatusWithHttpMessagesAsync(tenantid, indexid, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Push catalog data.
            /// </summary>
            /// <remarks>
            /// This method pushes updates to your your index data to Bing. This is an
            /// asynchronous process. To upload your index data to Bing, you'll send a push
            /// request that contains your index data.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='indexid'>
            /// The ID that uniquely identifies the index definition to manage.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='notransform'>
            /// This disables transformation config processing if the config was uploaded
            /// for some index. It's useful when the data is already transformed and is
            /// matching the index definition. Default is `false`
            /// </param>
            /// <param name='updateid'>
            /// An id to uniquely identify the push update request in order to be able to
            /// track it down later.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PushDataUpdateResponse> PushDataUpdateAsync(this IBingCommerceIngestion operations, string body, string tenantid, string indexid, string subscriptionId = default(string), bool? notransform = default(bool?), string updateid = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PushDataUpdateWithHttpMessagesAsync(body, tenantid, indexid, subscriptionId, notransform, updateid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// .
            /// </summary>
            /// <remarks>
            /// .
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='indexid'>
            /// The ID that uniquely identifies the index definition to manage.
            /// </param>
            /// <param name='updateid'>
            /// An id to uniquely identify the push update request in order to be able to
            /// track it down later.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PushUpdateStatusResponse> PushDataStatusAsync(this IBingCommerceIngestion operations, string tenantid, string indexid, string updateid, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PushDataStatusWithHttpMessagesAsync(tenantid, indexid, updateid, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete your index's transformation config.
            /// </summary>
            /// <remarks>
            /// Delete the transformation config that currently aplies to data you push to
            /// your index.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='indexid'>
            /// The ID that uniquely identifies the index definition to manage.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransformationConfigResponse> DeleteTransformationConfigAsync(this IBingCommerceIngestion operations, string tenantid, string indexid, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteTransformationConfigWithHttpMessagesAsync(tenantid, indexid, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve your current index's transformation config.
            /// </summary>
            /// <remarks>
            /// Retrieve the transformation config that currently applies to data you push
            /// to your index.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='indexid'>
            /// The ID that uniquely identifies the index definition to manage.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransformationConfigResponse> CreateOrUpdateTransformationConfigAsync(this IBingCommerceIngestion operations, string body, string tenantid, string indexid, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateTransformationConfigWithHttpMessagesAsync(body, tenantid, indexid, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get ingestion status.
            /// </summary>
            /// <remarks>
            /// Track your ingestion by querying the status.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantid'>
            /// The ID that uniquely identifies the tenant that the index belongs to.
            /// </param>
            /// <param name='indexid'>
            /// The ID that uniquely identifies the index definition to manage.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransformationConfigResponse> GetTransformationConfigAsync(this IBingCommerceIngestion operations, string tenantid, string indexid, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTransformationConfigWithHttpMessagesAsync(tenantid, indexid, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a transformation config.
            /// </summary>
            /// <remarks>
            /// Upload a new transformation config and set it as the transformation config
            /// that applies to data you push to your index.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransformationConfigResponse> UploadTryOutConfigAsync(this IBingCommerceIngestion operations, string body, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UploadTryOutConfigWithHttpMessagesAsync(body, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upload a trytout config.
            /// </summary>
            /// <remarks>
            /// Upload a transformation config that you can use to test data transformation
            /// on the cloud.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='tryoutid'>
            /// The transformation tryout config id.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransformationTryoutResponse> ExecuteTryOutConfigAsync(this IBingCommerceIngestion operations, string body, string tryoutid, string subscriptionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExecuteTryOutConfigWithHttpMessagesAsync(body, tryoutid, subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Bing developer subcription id
            /// </param>
            /// <param name='format'>
            /// The push data update document format. Possible values include: 'Unknown',
            /// 'LDJson', 'CSV', 'TSV', 'JsonArray'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchemaDetectionResponse> DetectSchemaAsync(this IBingCommerceIngestion operations, string subscriptionId = default(string), string format = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DetectSchemaWithHttpMessagesAsync(subscriptionId, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
