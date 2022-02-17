// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type RiskyUserHistoryCollectionRequestBuilder.
    /// </summary>
    public partial class RiskyUserHistoryCollectionRequestBuilder : BaseRequestBuilder, IRiskyUserHistoryCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new RiskyUserHistoryCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RiskyUserHistoryCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IRiskyUserHistoryCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IRiskyUserHistoryCollectionRequest Request(IEnumerable<Option> options)
        {
            return new RiskyUserHistoryCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IRiskyUserHistoryItemRequestBuilder"/> for the specified RiskyUserRiskyUserHistoryItem.
        /// </summary>
        /// <param name="id">The ID for the RiskyUserRiskyUserHistoryItem.</param>
        /// <returns>The <see cref="IRiskyUserHistoryItemRequestBuilder"/>.</returns>
        public IRiskyUserHistoryItemRequestBuilder this[string id]
        {
            get
            {
                return new RiskyUserHistoryItemRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}