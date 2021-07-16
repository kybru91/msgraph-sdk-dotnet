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
    /// The interface ITokenIssuancePolicyRequest.
    /// </summary>
    public partial interface ITokenIssuancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TokenIssuancePolicy using POST.
        /// </summary>
        /// <param name="tokenIssuancePolicyToCreate">The TokenIssuancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TokenIssuancePolicy.</returns>
        System.Threading.Tasks.Task<TokenIssuancePolicy> CreateAsync(TokenIssuancePolicy tokenIssuancePolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TokenIssuancePolicy using POST and returns a <see cref="GraphResponse{TokenIssuancePolicy}"/> object.
        /// </summary>
        /// <param name="tokenIssuancePolicyToCreate">The TokenIssuancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TokenIssuancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenIssuancePolicy>> CreateResponseAsync(TokenIssuancePolicy tokenIssuancePolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TokenIssuancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TokenIssuancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TokenIssuancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TokenIssuancePolicy.</returns>
        System.Threading.Tasks.Task<TokenIssuancePolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TokenIssuancePolicy and returns a <see cref="GraphResponse{TokenIssuancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TokenIssuancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenIssuancePolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TokenIssuancePolicy using PATCH.
        /// </summary>
        /// <param name="tokenIssuancePolicyToUpdate">The TokenIssuancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TokenIssuancePolicy.</returns>
        System.Threading.Tasks.Task<TokenIssuancePolicy> UpdateAsync(TokenIssuancePolicy tokenIssuancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TokenIssuancePolicy using PATCH and returns a <see cref="GraphResponse{TokenIssuancePolicy}"/> object.
        /// </summary>
        /// <param name="tokenIssuancePolicyToUpdate">The TokenIssuancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TokenIssuancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenIssuancePolicy>> UpdateResponseAsync(TokenIssuancePolicy tokenIssuancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TokenIssuancePolicy using PUT.
        /// </summary>
        /// <param name="tokenIssuancePolicyToUpdate">The TokenIssuancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TokenIssuancePolicy> PutAsync(TokenIssuancePolicy tokenIssuancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TokenIssuancePolicy using PUT and returns a <see cref="GraphResponse{TokenIssuancePolicy}"/> object.
        /// </summary>
        /// <param name="tokenIssuancePolicyToUpdate">The TokenIssuancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TokenIssuancePolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenIssuancePolicy>> PutResponseAsync(TokenIssuancePolicy tokenIssuancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITokenIssuancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITokenIssuancePolicyRequest Expand(Expression<Func<TokenIssuancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITokenIssuancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITokenIssuancePolicyRequest Select(Expression<Func<TokenIssuancePolicy, object>> selectExpression);

    }
}
