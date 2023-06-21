using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class BucketAggregationDefinition : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>True to specify the sort order as descending. The default is false, with the sort order as ascending. Optional.</summary>
        public bool? IsDescending {
            get { return BackingStore?.Get<bool?>("isDescending"); }
            set { BackingStore?.Set("isDescending", value); }
        }
        /// <summary>The minimum number of items that should be present in the aggregation to be returned in a bucket. Optional.</summary>
        public int? MinimumCount {
            get { return BackingStore?.Get<int?>("minimumCount"); }
            set { BackingStore?.Set("minimumCount", value); }
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
        /// <summary>A filter to define a matching criteria. The key should start with the specified prefix to be returned in the response. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrefixFilter {
            get { return BackingStore?.Get<string?>("prefixFilter"); }
            set { BackingStore?.Set("prefixFilter", value); }
        }
#nullable restore
#else
        public string PrefixFilter {
            get { return BackingStore?.Get<string>("prefixFilter"); }
            set { BackingStore?.Set("prefixFilter", value); }
        }
#endif
        /// <summary>Specifies the manual ranges to compute the aggregations. This is only valid for non-string refiners of date or numeric type. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BucketAggregationRange>? Ranges {
            get { return BackingStore?.Get<List<BucketAggregationRange>?>("ranges"); }
            set { BackingStore?.Set("ranges", value); }
        }
#nullable restore
#else
        public List<BucketAggregationRange> Ranges {
            get { return BackingStore?.Get<List<BucketAggregationRange>>("ranges"); }
            set { BackingStore?.Set("ranges", value); }
        }
#endif
        /// <summary>The sortBy property</summary>
        public BucketAggregationSortProperty? SortBy {
            get { return BackingStore?.Get<BucketAggregationSortProperty?>("sortBy"); }
            set { BackingStore?.Set("sortBy", value); }
        }
        /// <summary>
        /// Instantiates a new BucketAggregationDefinition and sets the default values.
        /// </summary>
        public BucketAggregationDefinition() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BucketAggregationDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BucketAggregationDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isDescending", n => { IsDescending = n.GetBoolValue(); } },
                {"minimumCount", n => { MinimumCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"prefixFilter", n => { PrefixFilter = n.GetStringValue(); } },
                {"ranges", n => { Ranges = n.GetCollectionOfObjectValues<BucketAggregationRange>(BucketAggregationRange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sortBy", n => { SortBy = n.GetEnumValue<BucketAggregationSortProperty>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isDescending", IsDescending);
            writer.WriteIntValue("minimumCount", MinimumCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("prefixFilter", PrefixFilter);
            writer.WriteCollectionOfObjectValues<BucketAggregationRange>("ranges", Ranges);
            writer.WriteEnumValue<BucketAggregationSortProperty>("sortBy", SortBy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
