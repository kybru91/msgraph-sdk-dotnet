using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UnifiedRoleEligibilityScheduleRequest : Request, IParsable {
        /// <summary>Represents the type of operation on the role eligibility request. The possible values are: adminAssign, adminUpdate, adminRemove, selfActivate, selfDeactivate, adminExtend, adminRenew, selfExtend, selfRenew, unknownFutureValue. adminAssign: For administrators to assign eligible roles to principals.adminRemove: For administrators to remove eligible roles from principals. adminUpdate: For administrators to change existing role eligibilities.adminExtend: For administrators to extend expiring role eligibilities.adminRenew: For administrators to renew expired eligibilities.selfActivate: For users to activate their assignments.selfDeactivate: For users to deactivate their active assignments.selfExtend: For users to request to extend their expiring assignments.selfRenew: For users to request to renew their expired assignments.</summary>
        public UnifiedRoleScheduleRequestActions? Action {
            get { return BackingStore?.Get<UnifiedRoleScheduleRequestActions?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Read-only property with details of the app-specific scope when the role eligibility is scoped to an app. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AppScope? AppScope {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AppScope?>("appScope"); }
            set { BackingStore?.Set("appScope", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AppScope AppScope {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AppScope>("appScope"); }
            set { BackingStore?.Set("appScope", value); }
        }
#endif
        /// <summary>Identifier of the app-specific scope when the role eligibility is scoped to an app. The scope of a role eligibility determines the set of resources for which the principal is eligible to access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units. Supports $filter (eq, ne, and on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppScopeId {
            get { return BackingStore?.Get<string?>("appScopeId"); }
            set { BackingStore?.Set("appScopeId", value); }
        }
#nullable restore
#else
        public string AppScopeId {
            get { return BackingStore?.Get<string>("appScopeId"); }
            set { BackingStore?.Set("appScopeId", value); }
        }
#endif
        /// <summary>The directory object that is the scope of the role eligibility. Read-only. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? DirectoryScope {
            get { return BackingStore?.Get<DirectoryObject?>("directoryScope"); }
            set { BackingStore?.Set("directoryScope", value); }
        }
#nullable restore
#else
        public DirectoryObject DirectoryScope {
            get { return BackingStore?.Get<DirectoryObject>("directoryScope"); }
            set { BackingStore?.Set("directoryScope", value); }
        }
#endif
        /// <summary>Identifier of the directory object representing the scope of the role eligibility. The scope of a role eligibility determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only. Supports $filter (eq, ne, and on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectoryScopeId {
            get { return BackingStore?.Get<string?>("directoryScopeId"); }
            set { BackingStore?.Set("directoryScopeId", value); }
        }
#nullable restore
#else
        public string DirectoryScopeId {
            get { return BackingStore?.Get<string>("directoryScopeId"); }
            set { BackingStore?.Set("directoryScopeId", value); }
        }
#endif
        /// <summary>Determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.</summary>
        public bool? IsValidationOnly {
            get { return BackingStore?.Get<bool?>("isValidationOnly"); }
            set { BackingStore?.Set("isValidationOnly", value); }
        }
        /// <summary>A message provided by users and administrators when create they create the unifiedRoleEligibilityScheduleRequest object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification {
            get { return BackingStore?.Get<string?>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#nullable restore
#else
        public string Justification {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#endif
        /// <summary>The principal that&apos;s getting a role eligibility through the request. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Principal {
            get { return BackingStore?.Get<DirectoryObject?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#nullable restore
#else
        public DirectoryObject Principal {
            get { return BackingStore?.Get<DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>Identifier of the principal that has been granted the role eligibility. Can be a user or a role-assignable group. You can grant only active assignments service principals.Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId {
            get { return BackingStore?.Get<string?>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#nullable restore
#else
        public string PrincipalId {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#endif
        /// <summary>Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRoleDefinition? RoleDefinition {
            get { return BackingStore?.Get<UnifiedRoleDefinition?>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#nullable restore
#else
        public UnifiedRoleDefinition RoleDefinition {
            get { return BackingStore?.Get<UnifiedRoleDefinition>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#endif
        /// <summary>Identifier of the unifiedRoleDefinition object that is being assigned to the principal. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId {
            get { return BackingStore?.Get<string?>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#nullable restore
#else
        public string RoleDefinitionId {
            get { return BackingStore?.Get<string>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#endif
        /// <summary>The period of the role eligibility. Recurring schedules are currently unsupported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestSchedule? ScheduleInfo {
            get { return BackingStore?.Get<RequestSchedule?>("scheduleInfo"); }
            set { BackingStore?.Set("scheduleInfo", value); }
        }
#nullable restore
#else
        public RequestSchedule ScheduleInfo {
            get { return BackingStore?.Get<RequestSchedule>("scheduleInfo"); }
            set { BackingStore?.Set("scheduleInfo", value); }
        }
#endif
        /// <summary>The schedule for a role eligibility that is referenced through the targetScheduleId property. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRoleEligibilitySchedule? TargetSchedule {
            get { return BackingStore?.Get<UnifiedRoleEligibilitySchedule?>("targetSchedule"); }
            set { BackingStore?.Set("targetSchedule", value); }
        }
#nullable restore
#else
        public UnifiedRoleEligibilitySchedule TargetSchedule {
            get { return BackingStore?.Get<UnifiedRoleEligibilitySchedule>("targetSchedule"); }
            set { BackingStore?.Set("targetSchedule", value); }
        }
#endif
        /// <summary>Identifier of the schedule object that&apos;s linked to the eligibility request. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetScheduleId {
            get { return BackingStore?.Get<string?>("targetScheduleId"); }
            set { BackingStore?.Set("targetScheduleId", value); }
        }
#nullable restore
#else
        public string TargetScheduleId {
            get { return BackingStore?.Get<string>("targetScheduleId"); }
            set { BackingStore?.Set("targetScheduleId", value); }
        }
#endif
        /// <summary>Ticket details linked to the role eligibility request including details of the ticket number and ticket system. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.TicketInfo? TicketInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TicketInfo?>("ticketInfo"); }
            set { BackingStore?.Set("ticketInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.TicketInfo TicketInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TicketInfo>("ticketInfo"); }
            set { BackingStore?.Set("ticketInfo", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleEligibilityScheduleRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleEligibilityScheduleRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetEnumValue<UnifiedRoleScheduleRequestActions>(); } },
                {"appScope", n => { AppScope = n.GetObjectValue<Microsoft.Graph.Models.AppScope>(Microsoft.Graph.Models.AppScope.CreateFromDiscriminatorValue); } },
                {"appScopeId", n => { AppScopeId = n.GetStringValue(); } },
                {"directoryScope", n => { DirectoryScope = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"directoryScopeId", n => { DirectoryScopeId = n.GetStringValue(); } },
                {"isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"scheduleInfo", n => { ScheduleInfo = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                {"targetSchedule", n => { TargetSchedule = n.GetObjectValue<UnifiedRoleEligibilitySchedule>(UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue); } },
                {"targetScheduleId", n => { TargetScheduleId = n.GetStringValue(); } },
                {"ticketInfo", n => { TicketInfo = n.GetObjectValue<Microsoft.Graph.Models.TicketInfo>(Microsoft.Graph.Models.TicketInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<UnifiedRoleScheduleRequestActions>("action", Action);
            writer.WriteObjectValue<Microsoft.Graph.Models.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteObjectValue<DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteObjectValue<RequestSchedule>("scheduleInfo", ScheduleInfo);
            writer.WriteObjectValue<UnifiedRoleEligibilitySchedule>("targetSchedule", TargetSchedule);
            writer.WriteStringValue("targetScheduleId", TargetScheduleId);
            writer.WriteObjectValue<Microsoft.Graph.Models.TicketInfo>("ticketInfo", TicketInfo);
        }
    }
}
