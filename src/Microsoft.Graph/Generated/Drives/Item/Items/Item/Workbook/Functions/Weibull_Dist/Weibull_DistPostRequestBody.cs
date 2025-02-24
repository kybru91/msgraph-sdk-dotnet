using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Weibull_Dist {
    public class Weibull_DistPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The alpha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Alpha {
            get { return BackingStore?.Get<Json?>("alpha"); }
            set { BackingStore?.Set("alpha", value); }
        }
#nullable restore
#else
        public Json Alpha {
            get { return BackingStore?.Get<Json>("alpha"); }
            set { BackingStore?.Set("alpha", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The beta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Beta {
            get { return BackingStore?.Get<Json?>("beta"); }
            set { BackingStore?.Set("beta", value); }
        }
#nullable restore
#else
        public Json Beta {
            get { return BackingStore?.Get<Json>("beta"); }
            set { BackingStore?.Set("beta", value); }
        }
#endif
        /// <summary>The cumulative property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Cumulative {
            get { return BackingStore?.Get<Json?>("cumulative"); }
            set { BackingStore?.Set("cumulative", value); }
        }
#nullable restore
#else
        public Json Cumulative {
            get { return BackingStore?.Get<Json>("cumulative"); }
            set { BackingStore?.Set("cumulative", value); }
        }
#endif
        /// <summary>The x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? X {
            get { return BackingStore?.Get<Json?>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#nullable restore
#else
        public Json X {
            get { return BackingStore?.Get<Json>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new weibull_DistPostRequestBody and sets the default values.
        /// </summary>
        public Weibull_DistPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Weibull_DistPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Weibull_DistPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alpha", n => { Alpha = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"beta", n => { Beta = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"cumulative", n => { Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"x", n => { X = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("alpha", Alpha);
            writer.WriteObjectValue<Json>("beta", Beta);
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
