// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type TeamInfoRequestBuilder.
    /// </summary>
    public partial class TeamInfoRequestBuilder : EntityRequestBuilder, ITeamInfoRequestBuilder
    {

        /// <summary>
        /// Constructs a new TeamInfoRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TeamInfoRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ITeamInfoRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ITeamInfoRequest Request(IEnumerable<Option> options)
        {
            return new TeamInfoRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Team.
        /// </summary>
        /// <returns>The <see cref="ITeamWithReferenceRequestBuilder"/>.</returns>
        public ITeamWithReferenceRequestBuilder Team
        {
            get
            {
                return new TeamWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("team"), this.Client);
            }
        }
    
    }
}