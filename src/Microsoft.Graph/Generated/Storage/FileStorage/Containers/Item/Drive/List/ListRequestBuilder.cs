// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Columns;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ContentTypes;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.CreatedByUser;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Drive;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.LastModifiedByUser;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Operations;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Subscriptions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List
{
    /// <summary>
    /// Provides operations to manage the list property of the microsoft.graph.drive entity.
    /// </summary>
    public class ListRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.list entity.</summary>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Columns.ColumnsRequestBuilder Columns
        {
            get => new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentTypes property of the microsoft.graph.list entity.</summary>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ContentTypes.ContentTypesRequestBuilder ContentTypes
        {
            get => new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ContentTypes.ContentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.</summary>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.CreatedByUser.CreatedByUserRequestBuilder CreatedByUser
        {
            get => new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.CreatedByUser.CreatedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.list entity.</summary>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Drive.DriveRequestBuilder Drive
        {
            get => new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the items property of the microsoft.graph.list entity.</summary>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.ItemsRequestBuilder Items
        {
            get => new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.</summary>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.LastModifiedByUser.LastModifiedByUserRequestBuilder LastModifiedByUser
        {
            get => new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.LastModifiedByUser.LastModifiedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.list entity.</summary>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Operations.OperationsRequestBuilder Operations
        {
            get => new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subscriptions property of the microsoft.graph.list entity.</summary>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Subscriptions.SubscriptionsRequestBuilder Subscriptions
        {
            get => new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Subscriptions.SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/list{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/list{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property list for storage
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// For drives in SharePoint, the underlying document library list. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.List"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.List?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder.ListRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.List> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder.ListRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.List>(requestInfo, Microsoft.Graph.Models.List.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property list in storage
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.List"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.List?> PatchAsync(Microsoft.Graph.Models.List body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.List> PatchAsync(Microsoft.Graph.Models.List body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.List>(requestInfo, Microsoft.Graph.Models.List.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property list for storage
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// For drives in SharePoint, the underlying document library list. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder.ListRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder.ListRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property list in storage
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.List body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.List body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ListRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// For drives in SharePoint, the underlying document library list. Read-only. Nullable.
        /// </summary>
        public class ListRequestBuilderGetQueryParameters 
        {
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ListRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder.ListRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ListRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
