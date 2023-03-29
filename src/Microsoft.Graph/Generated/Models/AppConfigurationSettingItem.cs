using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Contains properties for App configuration setting item.
    /// </summary>
    public class AppConfigurationSettingItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>app configuration key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppConfigKey {
            get { return BackingStore?.Get<string?>("appConfigKey"); }
            set { BackingStore?.Set("appConfigKey", value); }
        }
#nullable restore
#else
        public string AppConfigKey {
            get { return BackingStore?.Get<string>("appConfigKey"); }
            set { BackingStore?.Set("appConfigKey", value); }
        }
#endif
        /// <summary>App configuration key types.</summary>
        public MdmAppConfigKeyType? AppConfigKeyType {
            get { return BackingStore?.Get<MdmAppConfigKeyType?>("appConfigKeyType"); }
            set { BackingStore?.Set("appConfigKeyType", value); }
        }
        /// <summary>app configuration key value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppConfigKeyValue {
            get { return BackingStore?.Get<string?>("appConfigKeyValue"); }
            set { BackingStore?.Set("appConfigKeyValue", value); }
        }
#nullable restore
#else
        public string AppConfigKeyValue {
            get { return BackingStore?.Get<string>("appConfigKeyValue"); }
            set { BackingStore?.Set("appConfigKeyValue", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// Instantiates a new appConfigurationSettingItem and sets the default values.
        /// </summary>
        public AppConfigurationSettingItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AppConfigurationSettingItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppConfigurationSettingItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appConfigKey", n => { AppConfigKey = n.GetStringValue(); } },
                {"appConfigKeyType", n => { AppConfigKeyType = n.GetEnumValue<MdmAppConfigKeyType>(); } },
                {"appConfigKeyValue", n => { AppConfigKeyValue = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appConfigKey", AppConfigKey);
            writer.WriteEnumValue<MdmAppConfigKeyType>("appConfigKeyType", AppConfigKeyType);
            writer.WriteStringValue("appConfigKeyValue", AppConfigKeyValue);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}