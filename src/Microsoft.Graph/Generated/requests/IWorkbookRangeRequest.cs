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
    /// The interface IWorkbookRangeRequest.
    /// </summary>
    public partial interface IWorkbookRangeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookRange using POST.
        /// </summary>
        /// <param name="workbookRangeToCreate">The WorkbookRange to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRange.</returns>
        System.Threading.Tasks.Task<WorkbookRange> CreateAsync(WorkbookRange workbookRangeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookRange using POST and returns a <see cref="GraphResponse{WorkbookRange}"/> object.
        /// </summary>
        /// <param name="workbookRangeToCreate">The WorkbookRange to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRange}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRange>> CreateResponseAsync(WorkbookRange workbookRangeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRange.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRange and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRange.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRange.</returns>
        System.Threading.Tasks.Task<WorkbookRange> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRange and returns a <see cref="GraphResponse{WorkbookRange}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRange}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRange>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRange using PATCH.
        /// </summary>
        /// <param name="workbookRangeToUpdate">The WorkbookRange to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRange.</returns>
        System.Threading.Tasks.Task<WorkbookRange> UpdateAsync(WorkbookRange workbookRangeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRange using PATCH and returns a <see cref="GraphResponse{WorkbookRange}"/> object.
        /// </summary>
        /// <param name="workbookRangeToUpdate">The WorkbookRange to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookRange}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRange>> UpdateResponseAsync(WorkbookRange workbookRangeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRange using PUT.
        /// </summary>
        /// <param name="workbookRangeToUpdate">The WorkbookRange object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookRange> PutAsync(WorkbookRange workbookRangeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRange using PUT and returns a <see cref="GraphResponse{WorkbookRange}"/> object.
        /// </summary>
        /// <param name="workbookRangeToUpdate">The WorkbookRange object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookRange}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRange>> PutResponseAsync(WorkbookRange workbookRangeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeRequest Expand(Expression<Func<WorkbookRange, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeRequest Select(Expression<Func<WorkbookRange, object>> selectExpression);

    }
}
