using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Find {
    public class FindPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The findText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? FindText {
            get { return BackingStore?.Get<Json?>("findText"); }
            set { BackingStore?.Set("findText", value); }
        }
#nullable restore
#else
        public Json FindText {
            get { return BackingStore?.Get<Json>("findText"); }
            set { BackingStore?.Set("findText", value); }
        }
#endif
        /// <summary>The startNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartNum {
            get { return BackingStore?.Get<Json?>("startNum"); }
            set { BackingStore?.Set("startNum", value); }
        }
#nullable restore
#else
        public Json StartNum {
            get { return BackingStore?.Get<Json>("startNum"); }
            set { BackingStore?.Set("startNum", value); }
        }
#endif
        /// <summary>The withinText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? WithinText {
            get { return BackingStore?.Get<Json?>("withinText"); }
            set { BackingStore?.Set("withinText", value); }
        }
#nullable restore
#else
        public Json WithinText {
            get { return BackingStore?.Get<Json>("withinText"); }
            set { BackingStore?.Set("withinText", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new findPostRequestBody and sets the default values.
        /// </summary>
        public FindPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FindPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FindPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"findText", n => { FindText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startNum", n => { StartNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"withinText", n => { WithinText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("findText", FindText);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteObjectValue<Json>("withinText", WithinText);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
