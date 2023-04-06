using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UserTrainingContentEventInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Browser of the user from where the training event was generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Browser {
            get { return BackingStore?.Get<string?>("browser"); }
            set { BackingStore?.Set("browser", value); }
        }
#nullable restore
#else
        public string Browser {
            get { return BackingStore?.Get<string>("browser"); }
            set { BackingStore?.Set("browser", value); }
        }
#endif
        /// <summary>Date and time of the training content playback by the user.</summary>
        public DateTimeOffset? ContentDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("contentDateTime"); }
            set { BackingStore?.Set("contentDateTime", value); }
        }
        /// <summary>IP address of the user for the training event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
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
        /// <summary>The operating system, platform, and device details of the user for the training event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsPlatformDeviceDetails {
            get { return BackingStore?.Get<string?>("osPlatformDeviceDetails"); }
            set { BackingStore?.Set("osPlatformDeviceDetails", value); }
        }
#nullable restore
#else
        public string OsPlatformDeviceDetails {
            get { return BackingStore?.Get<string>("osPlatformDeviceDetails"); }
            set { BackingStore?.Set("osPlatformDeviceDetails", value); }
        }
#endif
        /// <summary>Potential improvement in the tenant security posture after completion of the training by the user.</summary>
        public double? PotentialScoreImpact {
            get { return BackingStore?.Get<double?>("potentialScoreImpact"); }
            set { BackingStore?.Set("potentialScoreImpact", value); }
        }
        /// <summary>
        /// Instantiates a new userTrainingContentEventInfo and sets the default values.
        /// </summary>
        public UserTrainingContentEventInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserTrainingContentEventInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserTrainingContentEventInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"browser", n => { Browser = n.GetStringValue(); } },
                {"contentDateTime", n => { ContentDateTime = n.GetDateTimeOffsetValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"osPlatformDeviceDetails", n => { OsPlatformDeviceDetails = n.GetStringValue(); } },
                {"potentialScoreImpact", n => { PotentialScoreImpact = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("browser", Browser);
            writer.WriteDateTimeOffsetValue("contentDateTime", ContentDateTime);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("osPlatformDeviceDetails", OsPlatformDeviceDetails);
            writer.WriteDoubleValue("potentialScoreImpact", PotentialScoreImpact);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
