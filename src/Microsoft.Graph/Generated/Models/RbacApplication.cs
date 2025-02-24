using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class RbacApplication : Entity, IParsable {
        /// <summary>Resource to grant access to users or groups.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleAssignment>? RoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>?>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#endif
        /// <summary>Instances for active role assignments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleAssignmentScheduleInstance>? RoleAssignmentScheduleInstances {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentScheduleInstance>?>("roleAssignmentScheduleInstances"); }
            set { BackingStore?.Set("roleAssignmentScheduleInstances", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleAssignmentScheduleInstance> RoleAssignmentScheduleInstances {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentScheduleInstance>>("roleAssignmentScheduleInstances"); }
            set { BackingStore?.Set("roleAssignmentScheduleInstances", value); }
        }
#endif
        /// <summary>Requests for active role assignments to principals through PIM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleAssignmentScheduleRequest>? RoleAssignmentScheduleRequests {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentScheduleRequest>?>("roleAssignmentScheduleRequests"); }
            set { BackingStore?.Set("roleAssignmentScheduleRequests", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleAssignmentScheduleRequest> RoleAssignmentScheduleRequests {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentScheduleRequest>>("roleAssignmentScheduleRequests"); }
            set { BackingStore?.Set("roleAssignmentScheduleRequests", value); }
        }
#endif
        /// <summary>Schedules for active role assignment operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleAssignmentSchedule>? RoleAssignmentSchedules {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentSchedule>?>("roleAssignmentSchedules"); }
            set { BackingStore?.Set("roleAssignmentSchedules", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleAssignmentSchedule> RoleAssignmentSchedules {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentSchedule>>("roleAssignmentSchedules"); }
            set { BackingStore?.Set("roleAssignmentSchedules", value); }
        }
#endif
        /// <summary>Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleDefinition>? RoleDefinitions {
            get { return BackingStore?.Get<List<UnifiedRoleDefinition>?>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<UnifiedRoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#endif
        /// <summary>Instances for role eligibility requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleEligibilityScheduleInstance>? RoleEligibilityScheduleInstances {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilityScheduleInstance>?>("roleEligibilityScheduleInstances"); }
            set { BackingStore?.Set("roleEligibilityScheduleInstances", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleEligibilityScheduleInstance> RoleEligibilityScheduleInstances {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilityScheduleInstance>>("roleEligibilityScheduleInstances"); }
            set { BackingStore?.Set("roleEligibilityScheduleInstances", value); }
        }
#endif
        /// <summary>Requests for role eligibilities for principals through PIM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleEligibilityScheduleRequest>? RoleEligibilityScheduleRequests {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilityScheduleRequest>?>("roleEligibilityScheduleRequests"); }
            set { BackingStore?.Set("roleEligibilityScheduleRequests", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleEligibilityScheduleRequest> RoleEligibilityScheduleRequests {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilityScheduleRequest>>("roleEligibilityScheduleRequests"); }
            set { BackingStore?.Set("roleEligibilityScheduleRequests", value); }
        }
#endif
        /// <summary>Schedules for role eligibility operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleEligibilitySchedule>? RoleEligibilitySchedules {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilitySchedule>?>("roleEligibilitySchedules"); }
            set { BackingStore?.Set("roleEligibilitySchedules", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleEligibilitySchedule> RoleEligibilitySchedules {
            get { return BackingStore?.Get<List<UnifiedRoleEligibilitySchedule>>("roleEligibilitySchedules"); }
            set { BackingStore?.Set("roleEligibilitySchedules", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RbacApplication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RbacApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>(UnifiedRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignmentScheduleInstances", n => { RoleAssignmentScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleInstance>(UnifiedRoleAssignmentScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignmentScheduleRequests", n => { RoleAssignmentScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentScheduleRequest>(UnifiedRoleAssignmentScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignmentSchedules", n => { RoleAssignmentSchedules = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentSchedule>(UnifiedRoleAssignmentSchedule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleEligibilityScheduleInstances", n => { RoleEligibilityScheduleInstances = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleInstance>(UnifiedRoleEligibilityScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleEligibilityScheduleRequests", n => { RoleEligibilityScheduleRequests = n.GetCollectionOfObjectValues<UnifiedRoleEligibilityScheduleRequest>(UnifiedRoleEligibilityScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleEligibilitySchedules", n => { RoleEligibilitySchedules = n.GetCollectionOfObjectValues<UnifiedRoleEligibilitySchedule>(UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignmentScheduleInstance>("roleAssignmentScheduleInstances", RoleAssignmentScheduleInstances);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignmentScheduleRequest>("roleAssignmentScheduleRequests", RoleAssignmentScheduleRequests);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignmentSchedule>("roleAssignmentSchedules", RoleAssignmentSchedules);
            writer.WriteCollectionOfObjectValues<UnifiedRoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<UnifiedRoleEligibilityScheduleInstance>("roleEligibilityScheduleInstances", RoleEligibilityScheduleInstances);
            writer.WriteCollectionOfObjectValues<UnifiedRoleEligibilityScheduleRequest>("roleEligibilityScheduleRequests", RoleEligibilityScheduleRequests);
            writer.WriteCollectionOfObjectValues<UnifiedRoleEligibilitySchedule>("roleEligibilitySchedules", RoleEligibilitySchedules);
        }
    }
}
