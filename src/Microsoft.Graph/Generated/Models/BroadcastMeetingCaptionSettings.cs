using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class BroadcastMeetingCaptionSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether captions are enabled for this Teams live event.</summary>
        public bool? IsCaptionEnabled {
            get { return BackingStore?.Get<bool?>("isCaptionEnabled"); }
            set { BackingStore?.Set("isCaptionEnabled", value); }
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
        /// <summary>The spoken language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpokenLanguage {
            get { return BackingStore?.Get<string?>("spokenLanguage"); }
            set { BackingStore?.Set("spokenLanguage", value); }
        }
#nullable restore
#else
        public string SpokenLanguage {
            get { return BackingStore?.Get<string>("spokenLanguage"); }
            set { BackingStore?.Set("spokenLanguage", value); }
        }
#endif
        /// <summary>The translation languages (choose up to 6).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TranslationLanguages {
            get { return BackingStore?.Get<List<string>?>("translationLanguages"); }
            set { BackingStore?.Set("translationLanguages", value); }
        }
#nullable restore
#else
        public List<string> TranslationLanguages {
            get { return BackingStore?.Get<List<string>>("translationLanguages"); }
            set { BackingStore?.Set("translationLanguages", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new broadcastMeetingCaptionSettings and sets the default values.
        /// </summary>
        public BroadcastMeetingCaptionSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BroadcastMeetingCaptionSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BroadcastMeetingCaptionSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isCaptionEnabled", n => { IsCaptionEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"spokenLanguage", n => { SpokenLanguage = n.GetStringValue(); } },
                {"translationLanguages", n => { TranslationLanguages = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isCaptionEnabled", IsCaptionEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("spokenLanguage", SpokenLanguage);
            writer.WriteCollectionOfPrimitiveValues<string>("translationLanguages", TranslationLanguages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
