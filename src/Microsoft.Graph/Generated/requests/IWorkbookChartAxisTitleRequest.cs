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
    /// The interface IWorkbookChartAxisTitleRequest.
    /// </summary>
    public partial interface IWorkbookChartAxisTitleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartAxisTitle using POST.
        /// </summary>
        /// <param name="workbookChartAxisTitleToCreate">The WorkbookChartAxisTitle to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAxisTitle.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitle> CreateAsync(WorkbookChartAxisTitle workbookChartAxisTitleToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookChartAxisTitle using POST and returns a <see cref="GraphResponse{WorkbookChartAxisTitle}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisTitleToCreate">The WorkbookChartAxisTitle to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxisTitle}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisTitle>> CreateResponseAsync(WorkbookChartAxisTitle workbookChartAxisTitleToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookChartAxisTitle.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookChartAxisTitle and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookChartAxisTitle.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAxisTitle.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitle> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookChartAxisTitle and returns a <see cref="GraphResponse{WorkbookChartAxisTitle}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxisTitle}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisTitle>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookChartAxisTitle using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisTitleToUpdate">The WorkbookChartAxisTitle to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartAxisTitle.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitle> UpdateAsync(WorkbookChartAxisTitle workbookChartAxisTitleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookChartAxisTitle using PATCH and returns a <see cref="GraphResponse{WorkbookChartAxisTitle}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisTitleToUpdate">The WorkbookChartAxisTitle to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxisTitle}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisTitle>> UpdateResponseAsync(WorkbookChartAxisTitle workbookChartAxisTitleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookChartAxisTitle using PUT.
        /// </summary>
        /// <param name="workbookChartAxisTitleToUpdate">The WorkbookChartAxisTitle object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitle> PutAsync(WorkbookChartAxisTitle workbookChartAxisTitleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookChartAxisTitle using PUT and returns a <see cref="GraphResponse{WorkbookChartAxisTitle}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisTitleToUpdate">The WorkbookChartAxisTitle object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookChartAxisTitle}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisTitle>> PutResponseAsync(WorkbookChartAxisTitle workbookChartAxisTitleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisTitleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisTitleRequest Expand(Expression<Func<WorkbookChartAxisTitle, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisTitleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisTitleRequest Select(Expression<Func<WorkbookChartAxisTitle, object>> selectExpression);

    }
}
