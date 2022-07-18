// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type UnifiedGroupSourceRequest.
    /// </summary>
    public partial class UnifiedGroupSourceRequest : Microsoft.Graph.BaseRequest, IUnifiedGroupSourceRequest
    {
        /// <summary>
        /// Constructs a new UnifiedGroupSourceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnifiedGroupSourceRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnifiedGroupSource using POST.
        /// </summary>
        /// <param name="unifiedGroupSourceToCreate">The UnifiedGroupSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedGroupSource.</returns>
        public async System.Threading.Tasks.Task<UnifiedGroupSource> CreateAsync(UnifiedGroupSource unifiedGroupSourceToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UnifiedGroupSource>(unifiedGroupSourceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UnifiedGroupSource using POST and returns a <see cref="GraphResponse{UnifiedGroupSource}"/> object.
        /// </summary>
        /// <param name="unifiedGroupSourceToCreate">The UnifiedGroupSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedGroupSource}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedGroupSource>> CreateResponseAsync(UnifiedGroupSource unifiedGroupSourceToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UnifiedGroupSource>(unifiedGroupSourceToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UnifiedGroupSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UnifiedGroupSource>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UnifiedGroupSource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UnifiedGroupSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedGroupSource.</returns>
        public async System.Threading.Tasks.Task<UnifiedGroupSource> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UnifiedGroupSource>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UnifiedGroupSource and returns a <see cref="GraphResponse{UnifiedGroupSource}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedGroupSource}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedGroupSource>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UnifiedGroupSource>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnifiedGroupSource using PATCH.
        /// </summary>
        /// <param name="unifiedGroupSourceToUpdate">The UnifiedGroupSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedGroupSource.</returns>
        public async System.Threading.Tasks.Task<UnifiedGroupSource> UpdateAsync(UnifiedGroupSource unifiedGroupSourceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UnifiedGroupSource>(unifiedGroupSourceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnifiedGroupSource using PATCH and returns a <see cref="GraphResponse{UnifiedGroupSource}"/> object.
        /// </summary>
        /// <param name="unifiedGroupSourceToUpdate">The UnifiedGroupSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedGroupSource}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedGroupSource>> UpdateResponseAsync(UnifiedGroupSource unifiedGroupSourceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UnifiedGroupSource>(unifiedGroupSourceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnifiedGroupSource using PUT.
        /// </summary>
        /// <param name="unifiedGroupSourceToUpdate">The UnifiedGroupSource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UnifiedGroupSource> PutAsync(UnifiedGroupSource unifiedGroupSourceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UnifiedGroupSource>(unifiedGroupSourceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnifiedGroupSource using PUT and returns a <see cref="GraphResponse{UnifiedGroupSource}"/> object.
        /// </summary>
        /// <param name="unifiedGroupSourceToUpdate">The UnifiedGroupSource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UnifiedGroupSource}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedGroupSource>> PutResponseAsync(UnifiedGroupSource unifiedGroupSourceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UnifiedGroupSource>(unifiedGroupSourceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedGroupSourceRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedGroupSourceRequest Expand(Expression<Func<UnifiedGroupSource, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedGroupSourceRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedGroupSourceRequest Select(Expression<Func<UnifiedGroupSource, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="unifiedGroupSourceToInitialize">The <see cref="UnifiedGroupSource"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnifiedGroupSource unifiedGroupSourceToInitialize)
        {

        }
    }
}