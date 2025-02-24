using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.Security {
    public class HuntingQueryResults : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
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
        /// <summary>The results of the hunting query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HuntingRowResult>? Results {
            get { return BackingStore?.Get<List<HuntingRowResult>?>("results"); }
            set { BackingStore?.Set("results", value); }
        }
#nullable restore
#else
        public List<HuntingRowResult> Results {
            get { return BackingStore?.Get<List<HuntingRowResult>>("results"); }
            set { BackingStore?.Set("results", value); }
        }
#endif
        /// <summary>The schema for the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SinglePropertySchema>? Schema {
            get { return BackingStore?.Get<List<SinglePropertySchema>?>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#nullable restore
#else
        public List<SinglePropertySchema> Schema {
            get { return BackingStore?.Get<List<SinglePropertySchema>>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new huntingQueryResults and sets the default values.
        /// </summary>
        public HuntingQueryResults() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HuntingQueryResults CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HuntingQueryResults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"results", n => { Results = n.GetCollectionOfObjectValues<HuntingRowResult>(HuntingRowResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schema", n => { Schema = n.GetCollectionOfObjectValues<SinglePropertySchema>(SinglePropertySchema.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<HuntingRowResult>("results", Results);
            writer.WriteCollectionOfObjectValues<SinglePropertySchema>("schema", Schema);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
