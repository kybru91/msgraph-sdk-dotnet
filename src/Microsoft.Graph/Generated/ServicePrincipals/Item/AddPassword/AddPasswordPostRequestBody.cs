using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.ServicePrincipals.Item.AddPassword {
    public class AddPasswordPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The passwordCredential property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.PasswordCredential? PasswordCredential {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PasswordCredential?>("passwordCredential"); }
            set { BackingStore?.Set("passwordCredential", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.PasswordCredential PasswordCredential {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PasswordCredential>("passwordCredential"); }
            set { BackingStore?.Set("passwordCredential", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new addPasswordPostRequestBody and sets the default values.
        /// </summary>
        public AddPasswordPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AddPasswordPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddPasswordPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"passwordCredential", n => { PasswordCredential = n.GetObjectValue<Microsoft.Graph.Models.PasswordCredential>(Microsoft.Graph.Models.PasswordCredential.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.PasswordCredential>("passwordCredential", PasswordCredential);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
