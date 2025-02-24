using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class EntitlementManagement : Entity, IParsable {
        /// <summary>Approval stages for decisions associated with access package assignment requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Approval>? AccessPackageAssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>?>("accessPackageAssignmentApprovals"); }
            set { BackingStore?.Set("accessPackageAssignmentApprovals", value); }
        }
#nullable restore
#else
        public List<Approval> AccessPackageAssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>>("accessPackageAssignmentApprovals"); }
            set { BackingStore?.Set("accessPackageAssignmentApprovals", value); }
        }
#endif
        /// <summary>Access packages define the collection of resource roles and the policies for which subjects can request or be assigned access to those resources.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackage>? AccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>?>("accessPackages"); }
            set { BackingStore?.Set("accessPackages", value); }
        }
#nullable restore
#else
        public List<AccessPackage> AccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>>("accessPackages"); }
            set { BackingStore?.Set("accessPackages", value); }
        }
#endif
        /// <summary>Access package assignment policies govern which subjects can request or be assigned an access package via an access package assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignmentPolicy>? AssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>?>("assignmentPolicies"); }
            set { BackingStore?.Set("assignmentPolicies", value); }
        }
#nullable restore
#else
        public List<AccessPackageAssignmentPolicy> AssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>>("assignmentPolicies"); }
            set { BackingStore?.Set("assignmentPolicies", value); }
        }
#endif
        /// <summary>Access package assignment requests created by or on behalf of a subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignmentRequest>? AssignmentRequests {
            get { return BackingStore?.Get<List<AccessPackageAssignmentRequest>?>("assignmentRequests"); }
            set { BackingStore?.Set("assignmentRequests", value); }
        }
#nullable restore
#else
        public List<AccessPackageAssignmentRequest> AssignmentRequests {
            get { return BackingStore?.Get<List<AccessPackageAssignmentRequest>>("assignmentRequests"); }
            set { BackingStore?.Set("assignmentRequests", value); }
        }
#endif
        /// <summary>The assignment of an access package to a subject for a period of time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignment>? Assignments {
            get { return BackingStore?.Get<List<AccessPackageAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<AccessPackageAssignment> Assignments {
            get { return BackingStore?.Get<List<AccessPackageAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>A container for access packages.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageCatalog>? Catalogs {
            get { return BackingStore?.Get<List<AccessPackageCatalog>?>("catalogs"); }
            set { BackingStore?.Set("catalogs", value); }
        }
#nullable restore
#else
        public List<AccessPackageCatalog> Catalogs {
            get { return BackingStore?.Get<List<AccessPackageCatalog>>("catalogs"); }
            set { BackingStore?.Set("catalogs", value); }
        }
#endif
        /// <summary>References to a directory or domain of another organization whose users can request access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConnectedOrganization>? ConnectedOrganizations {
            get { return BackingStore?.Get<List<ConnectedOrganization>?>("connectedOrganizations"); }
            set { BackingStore?.Set("connectedOrganizations", value); }
        }
#nullable restore
#else
        public List<ConnectedOrganization> ConnectedOrganizations {
            get { return BackingStore?.Get<List<ConnectedOrganization>>("connectedOrganizations"); }
            set { BackingStore?.Set("connectedOrganizations", value); }
        }
#endif
        /// <summary>The settings that control the behavior of Azure AD entitlement management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EntitlementManagementSettings? Settings {
            get { return BackingStore?.Get<EntitlementManagementSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public EntitlementManagementSettings Settings {
            get { return BackingStore?.Get<EntitlementManagementSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EntitlementManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageAssignmentApprovals", n => { AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackages", n => { AccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentPolicies", n => { AssignmentPolicies = n.GetCollectionOfObjectValues<AccessPackageAssignmentPolicy>(AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentRequests", n => { AssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>(AccessPackageAssignmentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<AccessPackageAssignment>(AccessPackageAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"catalogs", n => { Catalogs = n.GetCollectionOfObjectValues<AccessPackageCatalog>(AccessPackageCatalog.CreateFromDiscriminatorValue)?.ToList(); } },
                {"connectedOrganizations", n => { ConnectedOrganizations = n.GetCollectionOfObjectValues<ConnectedOrganization>(ConnectedOrganization.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<EntitlementManagementSettings>(EntitlementManagementSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Approval>("accessPackageAssignmentApprovals", AccessPackageAssignmentApprovals);
            writer.WriteCollectionOfObjectValues<AccessPackage>("accessPackages", AccessPackages);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentPolicy>("assignmentPolicies", AssignmentPolicies);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequest>("assignmentRequests", AssignmentRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<AccessPackageCatalog>("catalogs", Catalogs);
            writer.WriteCollectionOfObjectValues<ConnectedOrganization>("connectedOrganizations", ConnectedOrganizations);
            writer.WriteObjectValue<EntitlementManagementSettings>("settings", Settings);
        }
    }
}
