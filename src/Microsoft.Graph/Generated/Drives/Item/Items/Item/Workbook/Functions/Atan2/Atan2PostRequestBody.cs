using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Atan2 {
    public class Atan2PostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The xNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? XNum {
            get { return BackingStore?.Get<Json?>("xNum"); }
            set { BackingStore?.Set("xNum", value); }
        }
#nullable restore
#else
        public Json XNum {
            get { return BackingStore?.Get<Json>("xNum"); }
            set { BackingStore?.Set("xNum", value); }
        }
#endif
        /// <summary>The yNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? YNum {
            get { return BackingStore?.Get<Json?>("yNum"); }
            set { BackingStore?.Set("yNum", value); }
        }
#nullable restore
#else
        public Json YNum {
            get { return BackingStore?.Get<Json>("yNum"); }
            set { BackingStore?.Set("yNum", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new atan2PostRequestBody and sets the default values.
        /// </summary>
        public Atan2PostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Atan2PostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Atan2PostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"xNum", n => { XNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"yNum", n => { YNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("xNum", XNum);
            writer.WriteObjectValue<Json>("yNum", YNum);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
