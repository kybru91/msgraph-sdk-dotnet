using Microsoft.Graph.Me.CalendarGroups.Item.Calendars.Item.AllowedCalendarSharingRolesWithUser;
using Microsoft.Graph.Me.CalendarGroups.Item.Calendars.Item.CalendarPermissions;
using Microsoft.Graph.Me.CalendarGroups.Item.Calendars.Item.CalendarView;
using Microsoft.Graph.Me.CalendarGroups.Item.Calendars.Item.Events;
using Microsoft.Graph.Me.CalendarGroups.Item.Calendars.Item.GetSchedule;
using Microsoft.Graph.Me.CalendarGroups.Item.Calendars.Item.MultiValueExtendedProperties;
using Microsoft.Graph.Me.CalendarGroups.Item.Calendars.Item.SingleValueExtendedProperties;
using Microsoft.Graph.Models;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Me.CalendarGroups.Item.Calendars.Item {
    /// <summary>
    /// Provides operations to manage the calendars property of the microsoft.graph.calendarGroup entity.
    /// </summary>
    public class CalendarItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the calendarPermissions property of the microsoft.graph.calendar entity.</summary>
        public CalendarPermissionsRequestBuilder CalendarPermissions { get =>
            new CalendarPermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendarView property of the microsoft.graph.calendar entity.</summary>
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the events property of the microsoft.graph.calendar entity.</summary>
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getSchedule method.</summary>
        public GetScheduleRequestBuilder GetSchedule { get =>
            new GetScheduleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the multiValueExtendedProperties property of the microsoft.graph.calendar entity.</summary>
        public MultiValueExtendedPropertiesRequestBuilder MultiValueExtendedProperties { get =>
            new MultiValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the singleValueExtendedProperties property of the microsoft.graph.calendar entity.</summary>
        public SingleValueExtendedPropertiesRequestBuilder SingleValueExtendedProperties { get =>
            new SingleValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the allowedCalendarSharingRoles method.
        /// </summary>
        /// <param name="user">Usage: User=&apos;{User}&apos;</param>
        public AllowedCalendarSharingRolesWithUserRequestBuilder AllowedCalendarSharingRolesWithUser(string user) {
            if(string.IsNullOrEmpty(user)) throw new ArgumentNullException(nameof(user));
            return new AllowedCalendarSharingRolesWithUserRequestBuilder(PathParameters, RequestAdapter, user);
        }
        /// <summary>
        /// Instantiates a new CalendarItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CalendarItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/calendarGroups/{calendarGroup%2Did}/calendars/{calendar%2Did}{?%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CalendarItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CalendarItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/calendarGroups/{calendarGroup%2Did}/calendars/{calendar%2Did}{?%24select}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property calendars for me
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<CalendarItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<CalendarItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The calendars in the calendar group. Navigation property. Read-only. Nullable.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.Calendar?> GetAsync(Action<CalendarItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.Calendar> GetAsync(Action<CalendarItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.Calendar>(requestInfo, Microsoft.Graph.Models.Calendar.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property calendars in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.Calendar?> PatchAsync(Microsoft.Graph.Models.Calendar body, Action<CalendarItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.Calendar> PatchAsync(Microsoft.Graph.Models.Calendar body, Action<CalendarItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.Calendar>(requestInfo, Microsoft.Graph.Models.Calendar.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property calendars for me
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<CalendarItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<CalendarItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CalendarItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The calendars in the calendar group. Navigation property. Read-only. Nullable.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CalendarItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CalendarItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new CalendarItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property calendars in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.Calendar body, Action<CalendarItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.Calendar body, Action<CalendarItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new CalendarItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CalendarItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CalendarItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public CalendarItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The calendars in the calendar group. Navigation property. Read-only. Nullable.
        /// </summary>
        public class CalendarItemRequestBuilderGetQueryParameters {
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
        public class CalendarItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CalendarItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CalendarItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new CalendarItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CalendarItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CalendarItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new CalendarItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public CalendarItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}