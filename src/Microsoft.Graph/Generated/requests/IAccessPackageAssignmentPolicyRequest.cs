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
    /// The interface IAccessPackageAssignmentPolicyRequest.
    /// </summary>
    public partial interface IAccessPackageAssignmentPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessPackageAssignmentPolicy using POST.
        /// </summary>
        /// <param name="accessPackageAssignmentPolicyToCreate">The AccessPackageAssignmentPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageAssignmentPolicy.</returns>
        System.Threading.Tasks.Task<AccessPackageAssignmentPolicy> CreateAsync(AccessPackageAssignmentPolicy accessPackageAssignmentPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AccessPackageAssignmentPolicy using POST and returns a <see cref="GraphResponse{AccessPackageAssignmentPolicy}"/> object.
        /// </summary>
        /// <param name="accessPackageAssignmentPolicyToCreate">The AccessPackageAssignmentPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignmentPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignmentPolicy>> CreateResponseAsync(AccessPackageAssignmentPolicy accessPackageAssignmentPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AccessPackageAssignmentPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AccessPackageAssignmentPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AccessPackageAssignmentPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageAssignmentPolicy.</returns>
        System.Threading.Tasks.Task<AccessPackageAssignmentPolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AccessPackageAssignmentPolicy and returns a <see cref="GraphResponse{AccessPackageAssignmentPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignmentPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignmentPolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageAssignmentPolicy using PATCH.
        /// </summary>
        /// <param name="accessPackageAssignmentPolicyToUpdate">The AccessPackageAssignmentPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageAssignmentPolicy.</returns>
        System.Threading.Tasks.Task<AccessPackageAssignmentPolicy> UpdateAsync(AccessPackageAssignmentPolicy accessPackageAssignmentPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageAssignmentPolicy using PATCH and returns a <see cref="GraphResponse{AccessPackageAssignmentPolicy}"/> object.
        /// </summary>
        /// <param name="accessPackageAssignmentPolicyToUpdate">The AccessPackageAssignmentPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignmentPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignmentPolicy>> UpdateResponseAsync(AccessPackageAssignmentPolicy accessPackageAssignmentPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageAssignmentPolicy using PUT.
        /// </summary>
        /// <param name="accessPackageAssignmentPolicyToUpdate">The AccessPackageAssignmentPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AccessPackageAssignmentPolicy> PutAsync(AccessPackageAssignmentPolicy accessPackageAssignmentPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageAssignmentPolicy using PUT and returns a <see cref="GraphResponse{AccessPackageAssignmentPolicy}"/> object.
        /// </summary>
        /// <param name="accessPackageAssignmentPolicyToUpdate">The AccessPackageAssignmentPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AccessPackageAssignmentPolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignmentPolicy>> PutResponseAsync(AccessPackageAssignmentPolicy accessPackageAssignmentPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageAssignmentPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageAssignmentPolicyRequest Expand(Expression<Func<AccessPackageAssignmentPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageAssignmentPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageAssignmentPolicyRequest Select(Expression<Func<AccessPackageAssignmentPolicy, object>> selectExpression);

    }
}