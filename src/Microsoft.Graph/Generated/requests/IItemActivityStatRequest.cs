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
    /// The interface IItemActivityStatRequest.
    /// </summary>
    public partial interface IItemActivityStatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ItemActivityStat using POST.
        /// </summary>
        /// <param name="itemActivityStatToCreate">The ItemActivityStat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemActivityStat.</returns>
        System.Threading.Tasks.Task<ItemActivityStat> CreateAsync(ItemActivityStat itemActivityStatToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ItemActivityStat using POST and returns a <see cref="GraphResponse{ItemActivityStat}"/> object.
        /// </summary>
        /// <param name="itemActivityStatToCreate">The ItemActivityStat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemActivityStat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityStat>> CreateResponseAsync(ItemActivityStat itemActivityStatToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ItemActivityStat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ItemActivityStat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ItemActivityStat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemActivityStat.</returns>
        System.Threading.Tasks.Task<ItemActivityStat> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ItemActivityStat and returns a <see cref="GraphResponse{ItemActivityStat}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemActivityStat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityStat>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ItemActivityStat using PATCH.
        /// </summary>
        /// <param name="itemActivityStatToUpdate">The ItemActivityStat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemActivityStat.</returns>
        System.Threading.Tasks.Task<ItemActivityStat> UpdateAsync(ItemActivityStat itemActivityStatToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ItemActivityStat using PATCH and returns a <see cref="GraphResponse{ItemActivityStat}"/> object.
        /// </summary>
        /// <param name="itemActivityStatToUpdate">The ItemActivityStat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ItemActivityStat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityStat>> UpdateResponseAsync(ItemActivityStat itemActivityStatToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ItemActivityStat using PUT.
        /// </summary>
        /// <param name="itemActivityStatToUpdate">The ItemActivityStat object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ItemActivityStat> PutAsync(ItemActivityStat itemActivityStatToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ItemActivityStat using PUT and returns a <see cref="GraphResponse{ItemActivityStat}"/> object.
        /// </summary>
        /// <param name="itemActivityStatToUpdate">The ItemActivityStat object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ItemActivityStat}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivityStat>> PutResponseAsync(ItemActivityStat itemActivityStatToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityStatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityStatRequest Expand(Expression<Func<ItemActivityStat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityStatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityStatRequest Select(Expression<Func<ItemActivityStat, object>> selectExpression);

    }
}
