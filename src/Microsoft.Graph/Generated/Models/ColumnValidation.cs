using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ColumnValidation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Default BCP 47 language tag for the description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultLanguage {
            get { return BackingStore?.Get<string?>("defaultLanguage"); }
            set { BackingStore?.Set("defaultLanguage", value); }
        }
#nullable restore
#else
        public string DefaultLanguage {
            get { return BackingStore?.Get<string>("defaultLanguage"); }
            set { BackingStore?.Set("defaultLanguage", value); }
        }
#endif
        /// <summary>Localized messages that explain what is needed for this column&apos;s value to be considered valid. User will be prompted with this message if validation fails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DisplayNameLocalization>? Descriptions {
            get { return BackingStore?.Get<List<DisplayNameLocalization>?>("descriptions"); }
            set { BackingStore?.Set("descriptions", value); }
        }
#nullable restore
#else
        public List<DisplayNameLocalization> Descriptions {
            get { return BackingStore?.Get<List<DisplayNameLocalization>>("descriptions"); }
            set { BackingStore?.Set("descriptions", value); }
        }
#endif
        /// <summary>The formula to validate column value. For examples, see Examples of common formulas in lists.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Formula {
            get { return BackingStore?.Get<string?>("formula"); }
            set { BackingStore?.Set("formula", value); }
        }
#nullable restore
#else
        public string Formula {
            get { return BackingStore?.Get<string>("formula"); }
            set { BackingStore?.Set("formula", value); }
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
        /// Instantiates a new columnValidation and sets the default values.
        /// </summary>
        public ColumnValidation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ColumnValidation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ColumnValidation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultLanguage", n => { DefaultLanguage = n.GetStringValue(); } },
                {"descriptions", n => { Descriptions = n.GetCollectionOfObjectValues<DisplayNameLocalization>(DisplayNameLocalization.CreateFromDiscriminatorValue)?.ToList(); } },
                {"formula", n => { Formula = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultLanguage", DefaultLanguage);
            writer.WriteCollectionOfObjectValues<DisplayNameLocalization>("descriptions", Descriptions);
            writer.WriteStringValue("formula", Formula);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
