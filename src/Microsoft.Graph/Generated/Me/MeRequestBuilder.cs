// <auto-generated/>
using Microsoft.Graph.Me.Activities;
using Microsoft.Graph.Me.AgreementAcceptances;
using Microsoft.Graph.Me.AppRoleAssignments;
using Microsoft.Graph.Me.AssignLicense;
using Microsoft.Graph.Me.Authentication;
using Microsoft.Graph.Me.Calendar;
using Microsoft.Graph.Me.CalendarGroups;
using Microsoft.Graph.Me.CalendarView;
using Microsoft.Graph.Me.Calendars;
using Microsoft.Graph.Me.ChangePassword;
using Microsoft.Graph.Me.Chats;
using Microsoft.Graph.Me.CheckMemberGroups;
using Microsoft.Graph.Me.CheckMemberObjects;
using Microsoft.Graph.Me.CloudClipboard;
using Microsoft.Graph.Me.ContactFolders;
using Microsoft.Graph.Me.Contacts;
using Microsoft.Graph.Me.CreatedObjects;
using Microsoft.Graph.Me.DeviceManagementTroubleshootingEvents;
using Microsoft.Graph.Me.DirectReports;
using Microsoft.Graph.Me.Drive;
using Microsoft.Graph.Me.Drives;
using Microsoft.Graph.Me.EmployeeExperience;
using Microsoft.Graph.Me.Events;
using Microsoft.Graph.Me.ExportDeviceAndAppManagementData;
using Microsoft.Graph.Me.ExportDeviceAndAppManagementDataWithSkipWithTop;
using Microsoft.Graph.Me.ExportPersonalData;
using Microsoft.Graph.Me.Extensions;
using Microsoft.Graph.Me.FindMeetingTimes;
using Microsoft.Graph.Me.FollowedSites;
using Microsoft.Graph.Me.GetMailTips;
using Microsoft.Graph.Me.GetManagedAppDiagnosticStatuses;
using Microsoft.Graph.Me.GetManagedAppPolicies;
using Microsoft.Graph.Me.GetManagedDevicesWithAppFailures;
using Microsoft.Graph.Me.GetMemberGroups;
using Microsoft.Graph.Me.GetMemberObjects;
using Microsoft.Graph.Me.InferenceClassification;
using Microsoft.Graph.Me.Insights;
using Microsoft.Graph.Me.JoinedTeams;
using Microsoft.Graph.Me.LicenseDetails;
using Microsoft.Graph.Me.MailFolders;
using Microsoft.Graph.Me.MailboxSettings;
using Microsoft.Graph.Me.ManagedAppRegistrations;
using Microsoft.Graph.Me.ManagedDevices;
using Microsoft.Graph.Me.Manager;
using Microsoft.Graph.Me.MemberOf;
using Microsoft.Graph.Me.Messages;
using Microsoft.Graph.Me.Oauth2PermissionGrants;
using Microsoft.Graph.Me.Onenote;
using Microsoft.Graph.Me.OnlineMeetings;
using Microsoft.Graph.Me.Outlook;
using Microsoft.Graph.Me.OwnedDevices;
using Microsoft.Graph.Me.OwnedObjects;
using Microsoft.Graph.Me.People;
using Microsoft.Graph.Me.PermissionGrants;
using Microsoft.Graph.Me.Photo;
using Microsoft.Graph.Me.Photos;
using Microsoft.Graph.Me.Planner;
using Microsoft.Graph.Me.Presence;
using Microsoft.Graph.Me.RegisteredDevices;
using Microsoft.Graph.Me.ReminderViewWithStartDateTimeWithEndDateTime;
using Microsoft.Graph.Me.RemoveAllDevicesFromManagement;
using Microsoft.Graph.Me.ReprocessLicenseAssignment;
using Microsoft.Graph.Me.Restore;
using Microsoft.Graph.Me.RetryServiceProvisioning;
using Microsoft.Graph.Me.RevokeSignInSessions;
using Microsoft.Graph.Me.ScopedRoleMemberOf;
using Microsoft.Graph.Me.SendMail;
using Microsoft.Graph.Me.ServiceProvisioningErrors;
using Microsoft.Graph.Me.Settings;
using Microsoft.Graph.Me.Sponsors;
using Microsoft.Graph.Me.Teamwork;
using Microsoft.Graph.Me.Todo;
using Microsoft.Graph.Me.TransitiveMemberOf;
using Microsoft.Graph.Me.TranslateExchangeIds;
using Microsoft.Graph.Me.WipeManagedAppRegistrationsByDeviceTag;
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
namespace Microsoft.Graph.Me {
    /// <summary>
    /// Provides operations to manage the user singleton.
    /// </summary>
    public class MeRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to manage the activities property of the microsoft.graph.user entity.</summary>
        public ActivitiesRequestBuilder Activities
        {
            get => new ActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the agreementAcceptances property of the microsoft.graph.user entity.</summary>
        public AgreementAcceptancesRequestBuilder AgreementAcceptances
        {
            get => new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appRoleAssignments property of the microsoft.graph.user entity.</summary>
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments
        {
            get => new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the assignLicense method.</summary>
        public AssignLicenseRequestBuilder AssignLicense
        {
            get => new AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authentication property of the microsoft.graph.user entity.</summary>
        public AuthenticationRequestBuilder Authentication
        {
            get => new AuthenticationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendar property of the microsoft.graph.user entity.</summary>
        public CalendarRequestBuilder Calendar
        {
            get => new CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendarGroups property of the microsoft.graph.user entity.</summary>
        public CalendarGroupsRequestBuilder CalendarGroups
        {
            get => new CalendarGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendars property of the microsoft.graph.user entity.</summary>
        public CalendarsRequestBuilder Calendars
        {
            get => new CalendarsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendarView property of the microsoft.graph.user entity.</summary>
        public CalendarViewRequestBuilder CalendarView
        {
            get => new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the changePassword method.</summary>
        public ChangePasswordRequestBuilder ChangePassword
        {
            get => new ChangePasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the chats property of the microsoft.graph.user entity.</summary>
        public ChatsRequestBuilder Chats
        {
            get => new ChatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberGroups method.</summary>
        public CheckMemberGroupsRequestBuilder CheckMemberGroups
        {
            get => new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberObjects method.</summary>
        public CheckMemberObjectsRequestBuilder CheckMemberObjects
        {
            get => new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudClipboard property of the microsoft.graph.user entity.</summary>
        public CloudClipboardRequestBuilder CloudClipboard
        {
            get => new CloudClipboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contactFolders property of the microsoft.graph.user entity.</summary>
        public ContactFoldersRequestBuilder ContactFolders
        {
            get => new ContactFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contacts property of the microsoft.graph.user entity.</summary>
        public ContactsRequestBuilder Contacts
        {
            get => new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdObjects property of the microsoft.graph.user entity.</summary>
        public CreatedObjectsRequestBuilder CreatedObjects
        {
            get => new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceManagementTroubleshootingEvents property of the microsoft.graph.user entity.</summary>
        public DeviceManagementTroubleshootingEventsRequestBuilder DeviceManagementTroubleshootingEvents
        {
            get => new DeviceManagementTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the directReports property of the microsoft.graph.user entity.</summary>
        public DirectReportsRequestBuilder DirectReports
        {
            get => new DirectReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.user entity.</summary>
        public DriveRequestBuilder Drive
        {
            get => new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drives property of the microsoft.graph.user entity.</summary>
        public DrivesRequestBuilder Drives
        {
            get => new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the employeeExperience property of the microsoft.graph.user entity.</summary>
        public EmployeeExperienceRequestBuilder EmployeeExperience
        {
            get => new EmployeeExperienceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the events property of the microsoft.graph.user entity.</summary>
        public EventsRequestBuilder Events
        {
            get => new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the exportDeviceAndAppManagementData method.</summary>
        public ExportDeviceAndAppManagementDataRequestBuilder ExportDeviceAndAppManagementData
        {
            get => new ExportDeviceAndAppManagementDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the exportPersonalData method.</summary>
        public ExportPersonalDataRequestBuilder ExportPersonalData
        {
            get => new ExportPersonalDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensions property of the microsoft.graph.user entity.</summary>
        public ExtensionsRequestBuilder Extensions
        {
            get => new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the findMeetingTimes method.</summary>
        public FindMeetingTimesRequestBuilder FindMeetingTimes
        {
            get => new FindMeetingTimesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the followedSites property of the microsoft.graph.user entity.</summary>
        public FollowedSitesRequestBuilder FollowedSites
        {
            get => new FollowedSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMailTips method.</summary>
        public GetMailTipsRequestBuilder GetMailTips
        {
            get => new GetMailTipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getManagedAppDiagnosticStatuses method.</summary>
        public GetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses
        {
            get => new GetManagedAppDiagnosticStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getManagedAppPolicies method.</summary>
        public GetManagedAppPoliciesRequestBuilder GetManagedAppPolicies
        {
            get => new GetManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getManagedDevicesWithAppFailures method.</summary>
        public GetManagedDevicesWithAppFailuresRequestBuilder GetManagedDevicesWithAppFailures
        {
            get => new GetManagedDevicesWithAppFailuresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberGroups method.</summary>
        public GetMemberGroupsRequestBuilder GetMemberGroups
        {
            get => new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberObjects method.</summary>
        public GetMemberObjectsRequestBuilder GetMemberObjects
        {
            get => new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the inferenceClassification property of the microsoft.graph.user entity.</summary>
        public InferenceClassificationRequestBuilder InferenceClassification
        {
            get => new InferenceClassificationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the insights property of the microsoft.graph.user entity.</summary>
        public InsightsRequestBuilder Insights
        {
            get => new InsightsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the joinedTeams property of the microsoft.graph.user entity.</summary>
        public JoinedTeamsRequestBuilder JoinedTeams
        {
            get => new JoinedTeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the licenseDetails property of the microsoft.graph.user entity.</summary>
        public LicenseDetailsRequestBuilder LicenseDetails
        {
            get => new LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mailboxSettings property</summary>
        public MailboxSettingsRequestBuilder MailboxSettings
        {
            get => new MailboxSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mailFolders property of the microsoft.graph.user entity.</summary>
        public MailFoldersRequestBuilder MailFolders
        {
            get => new MailFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedAppRegistrations property of the microsoft.graph.user entity.</summary>
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations
        {
            get => new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDevices property of the microsoft.graph.user entity.</summary>
        public ManagedDevicesRequestBuilder ManagedDevices
        {
            get => new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the manager property of the microsoft.graph.user entity.</summary>
        public ManagerRequestBuilder Manager
        {
            get => new ManagerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the memberOf property of the microsoft.graph.user entity.</summary>
        public MemberOfRequestBuilder MemberOf
        {
            get => new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the messages property of the microsoft.graph.user entity.</summary>
        public MessagesRequestBuilder Messages
        {
            get => new MessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.user entity.</summary>
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants
        {
            get => new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onenote property of the microsoft.graph.user entity.</summary>
        public OnenoteRequestBuilder Onenote
        {
            get => new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onlineMeetings property of the microsoft.graph.user entity.</summary>
        public OnlineMeetingsRequestBuilder OnlineMeetings
        {
            get => new OnlineMeetingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the outlook property of the microsoft.graph.user entity.</summary>
        public OutlookRequestBuilder Outlook
        {
            get => new OutlookRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the ownedDevices property of the microsoft.graph.user entity.</summary>
        public OwnedDevicesRequestBuilder OwnedDevices
        {
            get => new OwnedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the ownedObjects property of the microsoft.graph.user entity.</summary>
        public OwnedObjectsRequestBuilder OwnedObjects
        {
            get => new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the people property of the microsoft.graph.user entity.</summary>
        public PeopleRequestBuilder People
        {
            get => new PeopleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissionGrants property of the microsoft.graph.user entity.</summary>
        public PermissionGrantsRequestBuilder PermissionGrants
        {
            get => new PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the photo property of the microsoft.graph.user entity.</summary>
        public PhotoRequestBuilder Photo
        {
            get => new PhotoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the photos property of the microsoft.graph.user entity.</summary>
        public PhotosRequestBuilder Photos
        {
            get => new PhotosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the planner property of the microsoft.graph.user entity.</summary>
        public PlannerRequestBuilder Planner
        {
            get => new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the presence property of the microsoft.graph.user entity.</summary>
        public PresenceRequestBuilder Presence
        {
            get => new PresenceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the registeredDevices property of the microsoft.graph.user entity.</summary>
        public RegisteredDevicesRequestBuilder RegisteredDevices
        {
            get => new RegisteredDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeAllDevicesFromManagement method.</summary>
        public RemoveAllDevicesFromManagementRequestBuilder RemoveAllDevicesFromManagement
        {
            get => new RemoveAllDevicesFromManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reprocessLicenseAssignment method.</summary>
        public ReprocessLicenseAssignmentRequestBuilder ReprocessLicenseAssignment
        {
            get => new ReprocessLicenseAssignmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public RestoreRequestBuilder Restore
        {
            get => new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retryServiceProvisioning method.</summary>
        public RetryServiceProvisioningRequestBuilder RetryServiceProvisioning
        {
            get => new RetryServiceProvisioningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the revokeSignInSessions method.</summary>
        public RevokeSignInSessionsRequestBuilder RevokeSignInSessions
        {
            get => new RevokeSignInSessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the scopedRoleMemberOf property of the microsoft.graph.user entity.</summary>
        public ScopedRoleMemberOfRequestBuilder ScopedRoleMemberOf
        {
            get => new ScopedRoleMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendMail method.</summary>
        public SendMailRequestBuilder SendMail
        {
            get => new SendMailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The serviceProvisioningErrors property</summary>
        public ServiceProvisioningErrorsRequestBuilder ServiceProvisioningErrors
        {
            get => new ServiceProvisioningErrorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the settings property of the microsoft.graph.user entity.</summary>
        public SettingsRequestBuilder Settings
        {
            get => new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sponsors property of the microsoft.graph.user entity.</summary>
        public SponsorsRequestBuilder Sponsors
        {
            get => new SponsorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the teamwork property of the microsoft.graph.user entity.</summary>
        public TeamworkRequestBuilder Teamwork
        {
            get => new TeamworkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the todo property of the microsoft.graph.user entity.</summary>
        public TodoRequestBuilder Todo
        {
            get => new TodoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMemberOf property of the microsoft.graph.user entity.</summary>
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf
        {
            get => new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the translateExchangeIds method.</summary>
        public TranslateExchangeIdsRequestBuilder TranslateExchangeIds
        {
            get => new TranslateExchangeIdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the wipeManagedAppRegistrationsByDeviceTag method.</summary>
        public WipeManagedAppRegistrationsByDeviceTagRequestBuilder WipeManagedAppRegistrationsByDeviceTag
        {
            get => new WipeManagedAppRegistrationsByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="MeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Provides operations to call the exportDeviceAndAppManagementData method.
        /// </summary>
        /// <returns>A <see cref="ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder"/></returns>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="top">Usage: top={top}</param>
        public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder ExportDeviceAndAppManagementDataWithSkipWithTop(int? skip, int? top)
        {
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(PathParameters, RequestAdapter, skip, top);
        }
        /// <summary>
        /// Retrieve the properties and relationships of user object. This operation returns by default only a subset of the more commonly used properties for each user. These default properties are noted in the Properties section. To get properties that are not returned by default, do a GET operation for the user and specify the properties in a $select OData query option. Because the user resource supports extensions, you can also use the GET operation to get custom properties and extension data in a user instance. Customers through Microsoft Entra ID for customers can also use this API operation to retrieve their details.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.User"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.User?> GetAsync(Action<RequestConfiguration<MeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.User> GetAsync(Action<RequestConfiguration<MeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.User>(requestInfo, Microsoft.Graph.Models.User.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of a user object. Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles. Compare member and guest default permissions to see properties they can manage. Customers through Microsoft Entra ID for customers can also use this API operation to update their details. See Default user permissions in customer tenants for the list of properties they can update.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.User"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.User?> PatchAsync(Microsoft.Graph.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.User> PatchAsync(Microsoft.Graph.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.User>(requestInfo, Microsoft.Graph.Models.User.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the reminderView method.
        /// </summary>
        /// <returns>A <see cref="ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder"/></returns>
        /// <param name="endDateTime">Usage: EndDateTime=&apos;{EndDateTime}&apos;</param>
        /// <param name="startDateTime">Usage: StartDateTime=&apos;{StartDateTime}&apos;</param>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder ReminderViewWithStartDateTimeWithEndDateTime(string endDateTime, string startDateTime)
        {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, startDateTime);
        }
        /// <summary>
        /// Retrieve the properties and relationships of user object. This operation returns by default only a subset of the more commonly used properties for each user. These default properties are noted in the Properties section. To get properties that are not returned by default, do a GET operation for the user and specify the properties in a $select OData query option. Because the user resource supports extensions, you can also use the GET operation to get custom properties and extension data in a user instance. Customers through Microsoft Entra ID for customers can also use this API operation to retrieve their details.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MeRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a user object. Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles. Compare member and guest default permissions to see properties they can manage. Customers through Microsoft Entra ID for customers can also use this API operation to update their details. See Default user permissions in customer tenants for the list of properties they can update.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="MeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MeRequestBuilder WithUrl(string rawUrl)
        {
            return new MeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve the properties and relationships of user object. This operation returns by default only a subset of the more commonly used properties for each user. These default properties are noted in the Properties section. To get properties that are not returned by default, do a GET operation for the user and specify the properties in a $select OData query option. Because the user resource supports extensions, you can also use the GET operation to get custom properties and extension data in a user instance. Customers through Microsoft Entra ID for customers can also use this API operation to retrieve their details.
        /// </summary>
        public class MeRequestBuilderGetQueryParameters 
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
        public class MeRequestBuilderGetRequestConfiguration : RequestConfiguration<MeRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MeRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
