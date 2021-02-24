// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DeviceComplianceUserOverviewRequest.
    /// </summary>
    public partial class DeviceComplianceUserOverviewRequest : BaseRequest, IDeviceComplianceUserOverviewRequest
    {
        /// <summary>
        /// Constructs a new DeviceComplianceUserOverviewRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceComplianceUserOverviewRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceComplianceUserOverview using POST.
        /// </summary>
        /// <param name="deviceComplianceUserOverviewToCreate">The DeviceComplianceUserOverview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceUserOverview.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceUserOverview> CreateAsync(DeviceComplianceUserOverview deviceComplianceUserOverviewToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<DeviceComplianceUserOverview>(deviceComplianceUserOverviewToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceComplianceUserOverview using POST and returns a <see cref="GraphResponse{DeviceComplianceUserOverview}"/> object.
        /// </summary>
        /// <param name="deviceComplianceUserOverviewToCreate">The DeviceComplianceUserOverview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceUserOverview}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceUserOverview>> CreateResponseAsync(DeviceComplianceUserOverview deviceComplianceUserOverviewToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<DeviceComplianceUserOverview>(deviceComplianceUserOverviewToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceUserOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<DeviceComplianceUserOverview>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceUserOverview and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceComplianceUserOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceUserOverview.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceUserOverview> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<DeviceComplianceUserOverview>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceComplianceUserOverview and returns a <see cref="GraphResponse{DeviceComplianceUserOverview}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceUserOverview}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceUserOverview>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<DeviceComplianceUserOverview>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceComplianceUserOverview using PATCH.
        /// </summary>
        /// <param name="deviceComplianceUserOverviewToUpdate">The DeviceComplianceUserOverview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceComplianceUserOverview.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceUserOverview> UpdateAsync(DeviceComplianceUserOverview deviceComplianceUserOverviewToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<DeviceComplianceUserOverview>(deviceComplianceUserOverviewToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceComplianceUserOverview using PATCH and returns a <see cref="GraphResponse{DeviceComplianceUserOverview}"/> object.
        /// </summary>
        /// <param name="deviceComplianceUserOverviewToUpdate">The DeviceComplianceUserOverview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceUserOverview}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceUserOverview>> UpdateResponseAsync(DeviceComplianceUserOverview deviceComplianceUserOverviewToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<DeviceComplianceUserOverview>(deviceComplianceUserOverviewToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceUserOverviewRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceUserOverviewRequest Expand(Expression<Func<DeviceComplianceUserOverview, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceUserOverviewRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceUserOverviewRequest Select(Expression<Func<DeviceComplianceUserOverview, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="deviceComplianceUserOverviewToInitialize">The <see cref="DeviceComplianceUserOverview"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceComplianceUserOverview deviceComplianceUserOverviewToInitialize)
        {

        }
    }
}
