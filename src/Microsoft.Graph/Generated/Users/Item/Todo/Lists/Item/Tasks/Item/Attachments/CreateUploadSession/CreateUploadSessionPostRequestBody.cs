using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Users.Item.Todo.Lists.Item.Tasks.Item.Attachments.CreateUploadSession {
    public class CreateUploadSessionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The attachmentInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AttachmentInfo? AttachmentInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AttachmentInfo?>("attachmentInfo"); }
            set { BackingStore?.Set("attachmentInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AttachmentInfo AttachmentInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AttachmentInfo>("attachmentInfo"); }
            set { BackingStore?.Set("attachmentInfo", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>
        /// Instantiates a new createUploadSessionPostRequestBody and sets the default values.
        /// </summary>
        public CreateUploadSessionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateUploadSessionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateUploadSessionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attachmentInfo", n => { AttachmentInfo = n.GetObjectValue<Microsoft.Graph.Models.AttachmentInfo>(Microsoft.Graph.Models.AttachmentInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.AttachmentInfo>("attachmentInfo", AttachmentInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
