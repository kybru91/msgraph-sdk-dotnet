using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ChatMessagePolicyViolationPolicyTip : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The URL a user can visit to read about the data loss prevention policies for the organization. (ie, policies about what users shouldn&apos;t say in chats)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ComplianceUrl {
            get { return BackingStore?.Get<string?>("complianceUrl"); }
            set { BackingStore?.Set("complianceUrl", value); }
        }
#nullable restore
#else
        public string ComplianceUrl {
            get { return BackingStore?.Get<string>("complianceUrl"); }
            set { BackingStore?.Set("complianceUrl", value); }
        }
#endif
        /// <summary>Explanatory text shown to the sender of the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GeneralText {
            get { return BackingStore?.Get<string?>("generalText"); }
            set { BackingStore?.Set("generalText", value); }
        }
#nullable restore
#else
        public string GeneralText {
            get { return BackingStore?.Get<string>("generalText"); }
            set { BackingStore?.Set("generalText", value); }
        }
#endif
        /// <summary>The list of improper data in the message that was detected by the data loss prevention app. Each DLP app defines its own conditions, examples include &apos;Credit Card Number&apos; and &apos;Social Security Number&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MatchedConditionDescriptions {
            get { return BackingStore?.Get<List<string>?>("matchedConditionDescriptions"); }
            set { BackingStore?.Set("matchedConditionDescriptions", value); }
        }
#nullable restore
#else
        public List<string> MatchedConditionDescriptions {
            get { return BackingStore?.Get<List<string>>("matchedConditionDescriptions"); }
            set { BackingStore?.Set("matchedConditionDescriptions", value); }
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
        /// <summary>
        /// Instantiates a new chatMessagePolicyViolationPolicyTip and sets the default values.
        /// </summary>
        public ChatMessagePolicyViolationPolicyTip() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ChatMessagePolicyViolationPolicyTip CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessagePolicyViolationPolicyTip();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"complianceUrl", n => { ComplianceUrl = n.GetStringValue(); } },
                {"generalText", n => { GeneralText = n.GetStringValue(); } },
                {"matchedConditionDescriptions", n => { MatchedConditionDescriptions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("complianceUrl", ComplianceUrl);
            writer.WriteStringValue("generalText", GeneralText);
            writer.WriteCollectionOfPrimitiveValues<string>("matchedConditionDescriptions", MatchedConditionDescriptions);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
