// <auto-generated/>
using Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.Count;
using Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.Item;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers
{
    /// <summary>
    /// Provides operations to manage the scopedRoleMembers property of the microsoft.graph.administrativeUnit entity.
    /// </summary>
    public class ScopedRoleMembersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.Count.CountRequestBuilder Count
        {
            get => new Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the scopedRoleMembers property of the microsoft.graph.administrativeUnit entity.</summary>
        /// <param name="position">The unique identifier of scopedRoleMembership</param>
        /// <returns>A <see cref="Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.Item.ScopedRoleMembershipItemRequestBuilder"/></returns>
        public Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.Item.ScopedRoleMembershipItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("scopedRoleMembership%2Did", position);
                return new Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.Item.ScopedRoleMembershipItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScopedRoleMembersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directory/administrativeUnits/{administrativeUnit%2Did}/scopedRoleMembers{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScopedRoleMembersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directory/administrativeUnits/{administrativeUnit%2Did}/scopedRoleMembers{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List Microsoft Entra role assignments with administrative unit scope.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/administrativeunit-list-scopedrolemembers?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.ScopedRoleMembershipCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.ScopedRoleMembershipCollectionResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder.ScopedRoleMembersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.ScopedRoleMembershipCollectionResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder.ScopedRoleMembersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.ScopedRoleMembershipCollectionResponse>(requestInfo, Microsoft.Graph.Models.ScopedRoleMembershipCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Assign a Microsoft Entra role with administrative unit scope. For a list of roles that can be assigned with administrative unit scope, see Assign Microsoft Entra roles with administrative unit scope.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/administrativeunit-post-scopedrolemembers?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.ScopedRoleMembership"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.ScopedRoleMembership?> PostAsync(Microsoft.Graph.Models.ScopedRoleMembership body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.ScopedRoleMembership> PostAsync(Microsoft.Graph.Models.ScopedRoleMembership body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.ScopedRoleMembership>(requestInfo, Microsoft.Graph.Models.ScopedRoleMembership.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List Microsoft Entra role assignments with administrative unit scope.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder.ScopedRoleMembersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder.ScopedRoleMembersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Assign a Microsoft Entra role with administrative unit scope. For a list of roles that can be assigned with administrative unit scope, see Assign Microsoft Entra roles with administrative unit scope.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Models.ScopedRoleMembership body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Models.ScopedRoleMembership body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List Microsoft Entra role assignments with administrative unit scope.
        /// </summary>
        public class ScopedRoleMembersRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ScopedRoleMembersRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.DirectoryNamespace.AdministrativeUnits.Item.ScopedRoleMembers.ScopedRoleMembersRequestBuilder.ScopedRoleMembersRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ScopedRoleMembersRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
