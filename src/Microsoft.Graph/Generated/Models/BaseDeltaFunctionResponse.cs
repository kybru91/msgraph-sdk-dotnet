using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class BaseDeltaFunctionResponse : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataDeltaLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataDeltaLink {
            get { return BackingStore?.Get<string?>("@odata.deltaLink"); }
            set { BackingStore?.Set("@odata.deltaLink", value); }
        }
#nullable restore
#else
        public string OdataDeltaLink {
            get { return BackingStore?.Get<string>("@odata.deltaLink"); }
            set { BackingStore?.Set("@odata.deltaLink", value); }
        }
#endif
        /// <summary>The OdataNextLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataNextLink {
            get { return BackingStore?.Get<string?>("@odata.nextLink"); }
            set { BackingStore?.Set("@odata.nextLink", value); }
        }
#nullable restore
#else
        public string OdataNextLink {
            get { return BackingStore?.Get<string>("@odata.nextLink"); }
            set { BackingStore?.Set("@odata.nextLink", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new BaseDeltaFunctionResponse and sets the default values.
        /// </summary>
        public BaseDeltaFunctionResponse() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BaseDeltaFunctionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BaseDeltaFunctionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.deltaLink", n => { OdataDeltaLink = n.GetStringValue(); } },
                {"@odata.nextLink", n => { OdataNextLink = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.deltaLink", OdataDeltaLink);
            writer.WriteStringValue("@odata.nextLink", OdataNextLink);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
