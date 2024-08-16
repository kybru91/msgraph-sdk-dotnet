// <auto-generated/>
using Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.Count;
using Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.Item;
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
namespace Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups
{
    /// <summary>
    /// Provides operations to manage the sectionGroups property of the microsoft.graph.sectionGroup entity.
    /// </summary>
    public class SectionGroupsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.Count.CountRequestBuilder Count
        {
            get => new Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sectionGroups property of the microsoft.graph.sectionGroup entity.</summary>
        /// <param name="position">The unique identifier of sectionGroup</param>
        /// <returns>A <see cref="Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.Item.SectionGroupItemRequestBuilder"/></returns>
        public Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.Item.SectionGroupItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("sectionGroup%2Did1", position);
                return new Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.Item.SectionGroupItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SectionGroupsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/onenote/notebooks/{notebook%2Did}/sectionGroups/{sectionGroup%2Did}/sectionGroups{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SectionGroupsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/onenote/notebooks/{notebook%2Did}/sectionGroups/{sectionGroup%2Did}/sectionGroups{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// The section groups in the section. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.SectionGroupCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.SectionGroupCollectionResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder.SectionGroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.SectionGroupCollectionResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder.SectionGroupsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.SectionGroupCollectionResponse>(requestInfo, Microsoft.Graph.Models.SectionGroupCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The section groups in the section. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder.SectionGroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder.SectionGroupsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The section groups in the section. Read-only. Nullable.
        /// </summary>
        public class SectionGroupsRequestBuilderGetQueryParameters 
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
        public class SectionGroupsRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Groups.Item.Sites.Item.Onenote.Notebooks.Item.SectionGroups.Item.SectionGroups.SectionGroupsRequestBuilder.SectionGroupsRequestBuilderGetQueryParameters>
        {
        }
    }
}
