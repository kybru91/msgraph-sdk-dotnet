using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AccessPackageAssignmentReviewSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The default decision to apply if the access is not reviewed. The possible values are: keepAccess, removeAccess, acceptAccessRecommendation, unknownFutureValue.</summary>
        public AccessReviewExpirationBehavior? ExpirationBehavior {
            get { return BackingStore?.Get<AccessReviewExpirationBehavior?>("expirationBehavior"); }
            set { BackingStore?.Set("expirationBehavior", value); }
        }
        /// <summary>This collection specifies the users who will be the fallback reviewers when the primary reviewers don&apos;t respond.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubjectSet>? FallbackReviewers {
            get { return BackingStore?.Get<List<SubjectSet>?>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#nullable restore
#else
        public List<SubjectSet> FallbackReviewers {
            get { return BackingStore?.Get<List<SubjectSet>>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#endif
        /// <summary>If true, access reviews are required for assignments through this policy.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Specifies whether to display recommendations to the reviewer. The default value is true.</summary>
        public bool? IsRecommendationEnabled {
            get { return BackingStore?.Get<bool?>("isRecommendationEnabled"); }
            set { BackingStore?.Set("isRecommendationEnabled", value); }
        }
        /// <summary>Specifies whether the reviewer must provide justification for the approval. The default value is true.</summary>
        public bool? IsReviewerJustificationRequired {
            get { return BackingStore?.Get<bool?>("isReviewerJustificationRequired"); }
            set { BackingStore?.Set("isReviewerJustificationRequired", value); }
        }
        /// <summary>Specifies whether the principals can review their own assignments.</summary>
        public bool? IsSelfReview {
            get { return BackingStore?.Get<bool?>("isSelfReview"); }
            set { BackingStore?.Set("isSelfReview", value); }
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
        /// <summary>This collection specifies the users or group of users who will review the access package assignments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubjectSet>? PrimaryReviewers {
            get { return BackingStore?.Get<List<SubjectSet>?>("primaryReviewers"); }
            set { BackingStore?.Set("primaryReviewers", value); }
        }
#nullable restore
#else
        public List<SubjectSet> PrimaryReviewers {
            get { return BackingStore?.Get<List<SubjectSet>>("primaryReviewers"); }
            set { BackingStore?.Set("primaryReviewers", value); }
        }
#endif
        /// <summary>When the first review should start and how often it should recur.</summary>
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
        /// Instantiates a new accessPackageAssignmentReviewSettings and sets the default values.
        /// </summary>
        public AccessPackageAssignmentReviewSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessPackageAssignmentReviewSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentReviewSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expirationBehavior", n => { ExpirationBehavior = n.GetEnumValue<AccessReviewExpirationBehavior>(); } },
                {"fallbackReviewers", n => { FallbackReviewers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"isRecommendationEnabled", n => { IsRecommendationEnabled = n.GetBoolValue(); } },
                {"isReviewerJustificationRequired", n => { IsReviewerJustificationRequired = n.GetBoolValue(); } },
                {"isSelfReview", n => { IsSelfReview = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"primaryReviewers", n => { PrimaryReviewers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<EntitlementManagementSchedule>(EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessReviewExpirationBehavior>("expirationBehavior", ExpirationBehavior);
            writer.WriteCollectionOfObjectValues<SubjectSet>("fallbackReviewers", FallbackReviewers);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isRecommendationEnabled", IsRecommendationEnabled);
            writer.WriteBoolValue("isReviewerJustificationRequired", IsReviewerJustificationRequired);
            writer.WriteBoolValue("isSelfReview", IsSelfReview);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<SubjectSet>("primaryReviewers", PrimaryReviewers);
            writer.WriteObjectValue<EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
