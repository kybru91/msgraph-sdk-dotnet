using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.HypGeom_Dist {
    public class HypGeom_DistPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The numberPop property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NumberPop {
            get { return BackingStore?.Get<Json?>("numberPop"); }
            set { BackingStore?.Set("numberPop", value); }
        }
#nullable restore
#else
        public Json NumberPop {
            get { return BackingStore?.Get<Json>("numberPop"); }
            set { BackingStore?.Set("numberPop", value); }
        }
#endif
        /// <summary>The numberSample property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NumberSample {
            get { return BackingStore?.Get<Json?>("numberSample"); }
            set { BackingStore?.Set("numberSample", value); }
        }
#nullable restore
#else
        public Json NumberSample {
            get { return BackingStore?.Get<Json>("numberSample"); }
            set { BackingStore?.Set("numberSample", value); }
        }
#endif
        /// <summary>The populationS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? PopulationS {
            get { return BackingStore?.Get<Json?>("populationS"); }
            set { BackingStore?.Set("populationS", value); }
        }
#nullable restore
#else
        public Json PopulationS {
            get { return BackingStore?.Get<Json>("populationS"); }
            set { BackingStore?.Set("populationS", value); }
        }
#endif
        /// <summary>The sampleS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? SampleS {
            get { return BackingStore?.Get<Json?>("sampleS"); }
            set { BackingStore?.Set("sampleS", value); }
        }
#nullable restore
#else
        public Json SampleS {
            get { return BackingStore?.Get<Json>("sampleS"); }
            set { BackingStore?.Set("sampleS", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new hypGeom_DistPostRequestBody and sets the default values.
        /// </summary>
        public HypGeom_DistPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HypGeom_DistPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HypGeom_DistPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cumulative", n => { Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numberPop", n => { NumberPop = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numberSample", n => { NumberSample = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"populationS", n => { PopulationS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"sampleS", n => { SampleS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("numberPop", NumberPop);
            writer.WriteObjectValue<Json>("numberSample", NumberSample);
            writer.WriteObjectValue<Json>("populationS", PopulationS);
            writer.WriteObjectValue<Json>("sampleS", SampleS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
