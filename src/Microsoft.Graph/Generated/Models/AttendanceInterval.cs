using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AttendanceInterval : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Duration of the meeting interval in seconds; that is, the difference between joinDateTime and leaveDateTime.</summary>
        public int? DurationInSeconds {
            get { return BackingStore?.Get<int?>("durationInSeconds"); }
            set { BackingStore?.Set("durationInSeconds", value); }
        }
        /// <summary>The time the attendee joined in UTC.</summary>
        public DateTimeOffset? JoinDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("joinDateTime"); }
            set { BackingStore?.Set("joinDateTime", value); }
        }
        /// <summary>The time the attendee left in UTC.</summary>
        public DateTimeOffset? LeaveDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("leaveDateTime"); }
            set { BackingStore?.Set("leaveDateTime", value); }
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
        /// <summary>
        /// Instantiates a new attendanceInterval and sets the default values.
        /// </summary>
        public AttendanceInterval() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttendanceInterval CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttendanceInterval();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"durationInSeconds", n => { DurationInSeconds = n.GetIntValue(); } },
                {"joinDateTime", n => { JoinDateTime = n.GetDateTimeOffsetValue(); } },
                {"leaveDateTime", n => { LeaveDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("durationInSeconds", DurationInSeconds);
            writer.WriteDateTimeOffsetValue("joinDateTime", JoinDateTime);
            writer.WriteDateTimeOffsetValue("leaveDateTime", LeaveDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
