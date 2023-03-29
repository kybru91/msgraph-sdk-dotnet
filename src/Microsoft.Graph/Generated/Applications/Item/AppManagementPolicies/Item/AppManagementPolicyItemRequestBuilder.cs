using Microsoft.Graph.Applications.Item.AppManagementPolicies.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Microsoft.Graph.Applications.Item.AppManagementPolicies.Item {
    /// <summary>
    /// Builds and executes requests for operations under \applications\{application-id}\appManagementPolicies\{appManagementPolicy-id}
    /// </summary>
    public class AppManagementPolicyItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the collection of application entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AppManagementPolicyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppManagementPolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/appManagementPolicies/{appManagementPolicy%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AppManagementPolicyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppManagementPolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/appManagementPolicies/{appManagementPolicy%2Did}", rawUrl) {
        }
    }
}