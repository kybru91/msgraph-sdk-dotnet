using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class OnenotePatchContentCommand : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The action property</summary>
        public OnenotePatchActionType? Action {
            get { return BackingStore?.Get<OnenotePatchActionType?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A string of well-formed HTML to add to the page, and any image or file binary data. If the content contains binary data, the request must be sent using the multipart/form-data content type with a &apos;Commands&apos; part.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Content {
            get { return BackingStore?.Get<string?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public string Content {
            get { return BackingStore?.Get<string>("content"); }
            set { BackingStore?.Set("content", value); }
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
        /// <summary>The location to add the supplied content, relative to the target element. The possible values are: after (default) or before.</summary>
        public OnenotePatchInsertPosition? Position {
            get { return BackingStore?.Get<OnenotePatchInsertPosition?>("position"); }
            set { BackingStore?.Set("position", value); }
        }
        /// <summary>The element to update. Must be the #&lt;data-id&gt; or the generated &lt;id&gt; of the element, or the body or title keyword.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Target {
            get { return BackingStore?.Get<string?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public string Target {
            get { return BackingStore?.Get<string>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new onenotePatchContentCommand and sets the default values.
        /// </summary>
        public OnenotePatchContentCommand() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnenotePatchContentCommand CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnenotePatchContentCommand();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetEnumValue<OnenotePatchActionType>(); } },
                {"content", n => { Content = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"position", n => { Position = n.GetEnumValue<OnenotePatchInsertPosition>(); } },
                {"target", n => { Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<OnenotePatchActionType>("action", Action);
            writer.WriteStringValue("content", Content);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<OnenotePatchInsertPosition>("position", Position);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
