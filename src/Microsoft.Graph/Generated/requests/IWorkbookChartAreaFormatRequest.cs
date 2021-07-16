// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWorkbookChartAreaFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartAreaFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartAreaFormat using POST.
        /// </summary>
        /// <param name="workbookChartAreaFormatToCreate">The WorkbookChartAreaFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAreaFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAreaFormat> CreateAsync(WorkbookChartAreaFormat workbookChartAreaFormatToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookChartAreaFormat using POST and returns a <see cref="GraphResponse{WorkbookChartAreaFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartAreaFormatToCreate">The WorkbookChartAreaFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAreaFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAreaFormat>> CreateResponseAsync(WorkbookChartAreaFormat workbookChartAreaFormatToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookChartAreaFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookChartAreaFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookChartAreaFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAreaFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAreaFormat> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookChartAreaFormat and returns a <see cref="GraphResponse{WorkbookChartAreaFormat}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAreaFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAreaFormat>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookChartAreaFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartAreaFormatToUpdate">The WorkbookChartAreaFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartAreaFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAreaFormat> UpdateAsync(WorkbookChartAreaFormat workbookChartAreaFormatToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookChartAreaFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartAreaFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartAreaFormatToUpdate">The WorkbookChartAreaFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAreaFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAreaFormat>> UpdateResponseAsync(WorkbookChartAreaFormat workbookChartAreaFormatToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookChartAreaFormat using PUT.
        /// </summary>
        /// <param name="workbookChartAreaFormatToUpdate">The WorkbookChartAreaFormat object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookChartAreaFormat> PutAsync(WorkbookChartAreaFormat workbookChartAreaFormatToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookChartAreaFormat using PUT and returns a <see cref="GraphResponse{WorkbookChartAreaFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartAreaFormatToUpdate">The WorkbookChartAreaFormat object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookChartAreaFormat}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAreaFormat>> PutResponseAsync(WorkbookChartAreaFormat workbookChartAreaFormatToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAreaFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAreaFormatRequest Expand(Expression<Func<WorkbookChartAreaFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAreaFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAreaFormatRequest Select(Expression<Func<WorkbookChartAreaFormat, object>> selectExpression);

    }
}
