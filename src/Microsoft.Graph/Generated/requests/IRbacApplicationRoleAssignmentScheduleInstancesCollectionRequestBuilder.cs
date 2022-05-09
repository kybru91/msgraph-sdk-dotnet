// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequestBuilder.
    /// </summary>
    public partial interface IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUnifiedRoleAssignmentScheduleInstanceRequestBuilder"/> for the specified UnifiedRoleAssignmentScheduleInstance.
        /// </summary>
        /// <param name="id">The ID for the UnifiedRoleAssignmentScheduleInstance.</param>
        /// <returns>The <see cref="IUnifiedRoleAssignmentScheduleInstanceRequestBuilder"/>.</returns>
        IUnifiedRoleAssignmentScheduleInstanceRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for UnifiedRoleAssignmentScheduleInstanceFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IUnifiedRoleAssignmentScheduleInstanceFilterByCurrentUserRequestBuilder"/>.</returns>
        IUnifiedRoleAssignmentScheduleInstanceFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            RoleAssignmentScheduleInstanceFilterByCurrentUserOptions on);
    }
}