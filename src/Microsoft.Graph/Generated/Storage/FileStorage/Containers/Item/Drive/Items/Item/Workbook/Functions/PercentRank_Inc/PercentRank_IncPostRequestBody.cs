// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.PercentRank_Inc
{
    #pragma warning disable CS1591
    public class PercentRank_IncPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The array property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Array
        {
            get { return BackingStore?.Get<UntypedNode?>("array"); }
            set { BackingStore?.Set("array", value); }
        }
#nullable restore
#else
        public UntypedNode Array
        {
            get { return BackingStore?.Get<UntypedNode>("array"); }
            set { BackingStore?.Set("array", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The significance property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Significance
        {
            get { return BackingStore?.Get<UntypedNode?>("significance"); }
            set { BackingStore?.Set("significance", value); }
        }
#nullable restore
#else
        public UntypedNode Significance
        {
            get { return BackingStore?.Get<UntypedNode>("significance"); }
            set { BackingStore?.Set("significance", value); }
        }
#endif
        /// <summary>The x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? X
        {
            get { return BackingStore?.Get<UntypedNode?>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#nullable restore
#else
        public UntypedNode X
        {
            get { return BackingStore?.Get<UntypedNode>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.PercentRank_Inc.PercentRank_IncPostRequestBody"/> and sets the default values.
        /// </summary>
        public PercentRank_IncPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.PercentRank_Inc.PercentRank_IncPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.PercentRank_Inc.PercentRank_IncPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.PercentRank_Inc.PercentRank_IncPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "array", n => { Array = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "significance", n => { Significance = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "x", n => { X = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("array", Array);
            writer.WriteObjectValue<UntypedNode>("significance", Significance);
            writer.WriteObjectValue<UntypedNode>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
