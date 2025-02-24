using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Me.AssignLicense {
    public class AssignLicensePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The addLicenses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignedLicense>? AddLicenses {
            get { return BackingStore?.Get<List<AssignedLicense>?>("addLicenses"); }
            set { BackingStore?.Set("addLicenses", value); }
        }
#nullable restore
#else
        public List<AssignedLicense> AddLicenses {
            get { return BackingStore?.Get<List<AssignedLicense>>("addLicenses"); }
            set { BackingStore?.Set("addLicenses", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The removeLicenses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? RemoveLicenses {
            get { return BackingStore?.Get<List<Guid?>?>("removeLicenses"); }
            set { BackingStore?.Set("removeLicenses", value); }
        }
#nullable restore
#else
        public List<Guid?> RemoveLicenses {
            get { return BackingStore?.Get<List<Guid?>>("removeLicenses"); }
            set { BackingStore?.Set("removeLicenses", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new assignLicensePostRequestBody and sets the default values.
        /// </summary>
        public AssignLicensePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignLicensePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignLicensePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addLicenses", n => { AddLicenses = n.GetCollectionOfObjectValues<AssignedLicense>(AssignedLicense.CreateFromDiscriminatorValue)?.ToList(); } },
                {"removeLicenses", n => { RemoveLicenses = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AssignedLicense>("addLicenses", AddLicenses);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("removeLicenses", RemoveLicenses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
