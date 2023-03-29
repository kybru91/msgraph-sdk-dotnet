using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class OnPremisesProvisioningError : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category {
            get { return BackingStore?.Get<string?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public string Category {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>The date and time at which the error occurred.</summary>
        public DateTimeOffset? OccurredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("occurredDateTime"); }
            set { BackingStore?.Set("occurredDateTime", value); }
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
        /// <summary>Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PropertyCausingError {
            get { return BackingStore?.Get<string?>("propertyCausingError"); }
            set { BackingStore?.Set("propertyCausingError", value); }
        }
#nullable restore
#else
        public string PropertyCausingError {
            get { return BackingStore?.Get<string>("propertyCausingError"); }
            set { BackingStore?.Set("propertyCausingError", value); }
        }
#endif
        /// <summary>Value of the property causing the error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value {
            get { return BackingStore?.Get<string?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public string Value {
            get { return BackingStore?.Get<string>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new onPremisesProvisioningError and sets the default values.
        /// </summary>
        public OnPremisesProvisioningError() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesProvisioningError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesProvisioningError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"category", n => { Category = n.GetStringValue(); } },
                {"occurredDateTime", n => { OccurredDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"propertyCausingError", n => { PropertyCausingError = n.GetStringValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("category", Category);
            writer.WriteDateTimeOffsetValue("occurredDateTime", OccurredDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("propertyCausingError", PropertyCausingError);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}