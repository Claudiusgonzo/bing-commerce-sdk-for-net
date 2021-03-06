// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Search
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SearchOperations.
    /// </summary>
    public static partial class SearchOperationsExtensions
    {
            /// <summary>
            /// Bing Commerce Custom Search Query.
            /// </summary>
            /// <remarks>
            /// POST requests accept complex search request options.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='tenant'>
            /// </param>
            /// <param name='index'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CommerceSearchResponse> PostAsync(this ISearchOperations operations, CommerceSearchPostRequest body, string tenant, string index, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, tenant, index, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Bing Commerce Basic Search Query.
            /// </summary>
            /// <remarks>
            /// GET requests can search an index using only URL parameters. Only limited
            /// request options are available. GET requests will always do simple item
            /// search and support only a default facet discovery aggregation.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='q'>
            /// The query to match against all eligible fields.
            /// </param>
            /// <param name='tenant'>
            /// </param>
            /// <param name='index'>
            /// </param>
            /// <param name='mkt'>
            /// The market where the results come from. Typically, `mkt` is the country
            /// where the user is making the request from.
            /// </param>
            /// <param name='setlang'>
            /// The language to use for user interface strings. You may specify the
            /// language using either a 2-letter or 4-letter code. Using 4-letter codes is
            /// preferred.
            /// </param>
            /// <param name='select'>
            /// A comma-separated list of fields to return. unspecified or empty to select
            /// only _itemId, or `*` to select all fields.
            /// </param>
            /// <param name='orderby'>
            /// A comma-separated list of OData order syntax expressions.
            /// </param>
            /// <param name='top'>
            /// The maximum count of items to return for pagination. Default is 24.
            /// </param>
            /// <param name='skip'>
            /// The offset to the first item to return for pagination. Default is 0.
            /// </param>
            /// <param name='discoverfacets'>
            /// Default value is false. When true, requests a facet discovery aggregation.
            /// </param>
            /// <param name='alteration'>
            /// A boolean flag to enable or disable query alteration. Default is true.
            /// </param>
            /// <param name='debug'>
            /// </param>
            /// <param name='searchinstanceid'>
            /// A saved search instance configuration to apply to current request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CommerceSearchResponse> GetAsync(this ISearchOperations operations, string q, string tenant, string index, string mkt = default(string), string setlang = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? discoverfacets = false, bool? alteration = true, bool? debug = false, string searchinstanceid = "Default", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(q, tenant, index, mkt, setlang, select, orderby, top, skip, discoverfacets, alteration, debug, searchinstanceid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
