using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AccessPackageAssignmentRequestRequirements : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Indicates whether the requestor is allowed to set a custom schedule.</summary>
        public bool? AllowCustomAssignmentSchedule {
            get { return BackingStore?.Get<bool?>("allowCustomAssignmentSchedule"); }
            set { BackingStore?.Set("allowCustomAssignmentSchedule", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether a request to add must be approved by an approver.</summary>
        public bool? IsApprovalRequiredForAdd {
            get { return BackingStore?.Get<bool?>("isApprovalRequiredForAdd"); }
            set { BackingStore?.Set("isApprovalRequiredForAdd", value); }
        }
        /// <summary>Indicates whether a request to update must be approved by an approver.</summary>
        public bool? IsApprovalRequiredForUpdate {
            get { return BackingStore?.Get<bool?>("isApprovalRequiredForUpdate"); }
            set { BackingStore?.Set("isApprovalRequiredForUpdate", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The description of the policy that the user is trying to request access using.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyDescription {
            get { return BackingStore?.Get<string?>("policyDescription"); }
            set { BackingStore?.Set("policyDescription", value); }
        }
#nullable restore
#else
        public string PolicyDescription {
            get { return BackingStore?.Get<string>("policyDescription"); }
            set { BackingStore?.Set("policyDescription", value); }
        }
#endif
        /// <summary>The display name of the policy that the user is trying to request access using.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyDisplayName {
            get { return BackingStore?.Get<string?>("policyDisplayName"); }
            set { BackingStore?.Set("policyDisplayName", value); }
        }
#nullable restore
#else
        public string PolicyDisplayName {
            get { return BackingStore?.Get<string>("policyDisplayName"); }
            set { BackingStore?.Set("policyDisplayName", value); }
        }
#endif
        /// <summary>The identifier of the policy that these requirements are associated with. This identifier can be used when creating a new assignment request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId {
            get { return BackingStore?.Get<string?>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#nullable restore
#else
        public string PolicyId {
            get { return BackingStore?.Get<string>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#endif
        /// <summary>The questions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageQuestion>? Questions {
            get { return BackingStore?.Get<List<AccessPackageQuestion>?>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#nullable restore
#else
        public List<AccessPackageQuestion> Questions {
            get { return BackingStore?.Get<List<AccessPackageQuestion>>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#endif
        /// <summary>Schedule restrictions enforced, if any.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EntitlementManagementSchedule? Schedule {
            get { return BackingStore?.Get<EntitlementManagementSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public EntitlementManagementSchedule Schedule {
            get { return BackingStore?.Get<EntitlementManagementSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new accessPackageAssignmentRequestRequirements and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestRequirements() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessPackageAssignmentRequestRequirements CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequestRequirements();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowCustomAssignmentSchedule", n => { AllowCustomAssignmentSchedule = n.GetBoolValue(); } },
                {"isApprovalRequiredForAdd", n => { IsApprovalRequiredForAdd = n.GetBoolValue(); } },
                {"isApprovalRequiredForUpdate", n => { IsApprovalRequiredForUpdate = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"policyDescription", n => { PolicyDescription = n.GetStringValue(); } },
                {"policyDisplayName", n => { PolicyDisplayName = n.GetStringValue(); } },
                {"policyId", n => { PolicyId = n.GetStringValue(); } },
                {"questions", n => { Questions = n.GetCollectionOfObjectValues<AccessPackageQuestion>(AccessPackageQuestion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<EntitlementManagementSchedule>(EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowCustomAssignmentSchedule", AllowCustomAssignmentSchedule);
            writer.WriteBoolValue("isApprovalRequiredForAdd", IsApprovalRequiredForAdd);
            writer.WriteBoolValue("isApprovalRequiredForUpdate", IsApprovalRequiredForUpdate);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("policyDescription", PolicyDescription);
            writer.WriteStringValue("policyDisplayName", PolicyDisplayName);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteCollectionOfObjectValues<AccessPackageQuestion>("questions", Questions);
            writer.WriteObjectValue<EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
