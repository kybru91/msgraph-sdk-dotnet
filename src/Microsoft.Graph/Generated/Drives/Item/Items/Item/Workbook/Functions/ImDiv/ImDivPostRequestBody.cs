using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.ImDiv {
    public class ImDivPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The inumber1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Inumber1 {
            get { return BackingStore?.Get<Json?>("inumber1"); }
            set { BackingStore?.Set("inumber1", value); }
        }
#nullable restore
#else
        public Json Inumber1 {
            get { return BackingStore?.Get<Json>("inumber1"); }
            set { BackingStore?.Set("inumber1", value); }
        }
#endif
        /// <summary>The inumber2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Inumber2 {
            get { return BackingStore?.Get<Json?>("inumber2"); }
            set { BackingStore?.Set("inumber2", value); }
        }
#nullable restore
#else
        public Json Inumber2 {
            get { return BackingStore?.Get<Json>("inumber2"); }
            set { BackingStore?.Set("inumber2", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new imDivPostRequestBody and sets the default values.
        /// </summary>
        public ImDivPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ImDivPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImDivPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"inumber1", n => { Inumber1 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"inumber2", n => { Inumber2 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("inumber1", Inumber1);
            writer.WriteObjectValue<Json>("inumber2", Inumber2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
