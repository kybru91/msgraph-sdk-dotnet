using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ChangeNotificationEncryptedContent : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Base64-encoded encrypted data that produces a full resource respresented as JSON. The data has been encrypted with the provided dataKey using an AES/CBC/PKCS5PADDING cipher suite.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Data {
            get { return BackingStore?.Get<string?>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#nullable restore
#else
        public string Data {
            get { return BackingStore?.Get<string>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#endif
        /// <summary>Base64-encoded symmetric key generated by Microsoft Graph to encrypt the data value and to generate the data signature. This key is encrypted with the certificate public key that was provided during the subscription. It must be decrypted with the certificate private key before it can be used to decrypt the data or verify the signature. This key has been encrypted with the following cipher suite: RSA/ECB/OAEPWithSHA1AndMGF1Padding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataKey {
            get { return BackingStore?.Get<string?>("dataKey"); }
            set { BackingStore?.Set("dataKey", value); }
        }
#nullable restore
#else
        public string DataKey {
            get { return BackingStore?.Get<string>("dataKey"); }
            set { BackingStore?.Set("dataKey", value); }
        }
#endif
        /// <summary>Base64-encoded HMAC-SHA256 hash of the data for validation purposes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataSignature {
            get { return BackingStore?.Get<string?>("dataSignature"); }
            set { BackingStore?.Set("dataSignature", value); }
        }
#nullable restore
#else
        public string DataSignature {
            get { return BackingStore?.Get<string>("dataSignature"); }
            set { BackingStore?.Set("dataSignature", value); }
        }
#endif
        /// <summary>ID of the certificate used to encrypt the dataKey.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptionCertificateId {
            get { return BackingStore?.Get<string?>("encryptionCertificateId"); }
            set { BackingStore?.Set("encryptionCertificateId", value); }
        }
#nullable restore
#else
        public string EncryptionCertificateId {
            get { return BackingStore?.Get<string>("encryptionCertificateId"); }
            set { BackingStore?.Set("encryptionCertificateId", value); }
        }
#endif
        /// <summary>Hexadecimal representation of the thumbprint of the certificate used to encrypt the dataKey.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptionCertificateThumbprint {
            get { return BackingStore?.Get<string?>("encryptionCertificateThumbprint"); }
            set { BackingStore?.Set("encryptionCertificateThumbprint", value); }
        }
#nullable restore
#else
        public string EncryptionCertificateThumbprint {
            get { return BackingStore?.Get<string>("encryptionCertificateThumbprint"); }
            set { BackingStore?.Set("encryptionCertificateThumbprint", value); }
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
        /// <summary>
        /// Instantiates a new changeNotificationEncryptedContent and sets the default values.
        /// </summary>
        public ChangeNotificationEncryptedContent() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ChangeNotificationEncryptedContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChangeNotificationEncryptedContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetStringValue(); } },
                {"dataKey", n => { DataKey = n.GetStringValue(); } },
                {"dataSignature", n => { DataSignature = n.GetStringValue(); } },
                {"encryptionCertificateId", n => { EncryptionCertificateId = n.GetStringValue(); } },
                {"encryptionCertificateThumbprint", n => { EncryptionCertificateThumbprint = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("data", Data);
            writer.WriteStringValue("dataKey", DataKey);
            writer.WriteStringValue("dataSignature", DataSignature);
            writer.WriteStringValue("encryptionCertificateId", EncryptionCertificateId);
            writer.WriteStringValue("encryptionCertificateThumbprint", EncryptionCertificateThumbprint);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
