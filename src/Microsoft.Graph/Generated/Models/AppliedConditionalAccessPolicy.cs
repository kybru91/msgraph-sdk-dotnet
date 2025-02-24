using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AppliedConditionalAccessPolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Refers to the Name of the conditional access policy (example: &apos;Require MFA for Salesforce&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Refers to the grant controls enforced by the conditional access policy (example: &apos;Require multi-factor authentication&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnforcedGrantControls {
            get { return BackingStore?.Get<List<string>?>("enforcedGrantControls"); }
            set { BackingStore?.Set("enforcedGrantControls", value); }
        }
#nullable restore
#else
        public List<string> EnforcedGrantControls {
            get { return BackingStore?.Get<List<string>>("enforcedGrantControls"); }
            set { BackingStore?.Set("enforcedGrantControls", value); }
        }
#endif
        /// <summary>Refers to the session controls enforced by the conditional access policy (example: &apos;Require app enforced controls&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnforcedSessionControls {
            get { return BackingStore?.Get<List<string>?>("enforcedSessionControls"); }
            set { BackingStore?.Set("enforcedSessionControls", value); }
        }
#nullable restore
#else
        public List<string> EnforcedSessionControls {
            get { return BackingStore?.Get<List<string>>("enforcedSessionControls"); }
            set { BackingStore?.Set("enforcedSessionControls", value); }
        }
#endif
        /// <summary>An identifier of the conditional access policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
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
        /// <summary>Indicates the result of the CA policy that was triggered. Possible values are: success, failure, notApplied (Policy isn&apos;t applied because policy conditions were not met),notEnabled (This is due to the policy in disabled state), unknown, unknownFutureValue.</summary>
        public AppliedConditionalAccessPolicyResult? Result {
            get { return BackingStore?.Get<AppliedConditionalAccessPolicyResult?>("result"); }
            set { BackingStore?.Set("result", value); }
        }
        /// <summary>
        /// Instantiates a new appliedConditionalAccessPolicy and sets the default values.
        /// </summary>
        public AppliedConditionalAccessPolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AppliedConditionalAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppliedConditionalAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enforcedGrantControls", n => { EnforcedGrantControls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"enforcedSessionControls", n => { EnforcedSessionControls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"result", n => { Result = n.GetEnumValue<AppliedConditionalAccessPolicyResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedGrantControls", EnforcedGrantControls);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedSessionControls", EnforcedSessionControls);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<AppliedConditionalAccessPolicyResult>("result", Result);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
