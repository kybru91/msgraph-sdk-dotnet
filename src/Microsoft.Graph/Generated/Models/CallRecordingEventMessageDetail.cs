using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class CallRecordingEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Unique identifier of the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId {
            get { return BackingStore?.Get<string?>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#nullable restore
#else
        public string CallId {
            get { return BackingStore?.Get<string>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#endif
        /// <summary>Display name for the call recording.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallRecordingDisplayName {
            get { return BackingStore?.Get<string?>("callRecordingDisplayName"); }
            set { BackingStore?.Set("callRecordingDisplayName", value); }
        }
#nullable restore
#else
        public string CallRecordingDisplayName {
            get { return BackingStore?.Get<string>("callRecordingDisplayName"); }
            set { BackingStore?.Set("callRecordingDisplayName", value); }
        }
#endif
        /// <summary>Duration of the call recording.</summary>
        public TimeSpan? CallRecordingDuration {
            get { return BackingStore?.Get<TimeSpan?>("callRecordingDuration"); }
            set { BackingStore?.Set("callRecordingDuration", value); }
        }
        /// <summary>Status of the call recording. Possible values are: success, failure, initial, chunkFinished, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.CallRecordingStatus? CallRecordingStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CallRecordingStatus?>("callRecordingStatus"); }
            set { BackingStore?.Set("callRecordingStatus", value); }
        }
        /// <summary>Call recording URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallRecordingUrl {
            get { return BackingStore?.Get<string?>("callRecordingUrl"); }
            set { BackingStore?.Set("callRecordingUrl", value); }
        }
#nullable restore
#else
        public string CallRecordingUrl {
            get { return BackingStore?.Get<string>("callRecordingUrl"); }
            set { BackingStore?.Set("callRecordingUrl", value); }
        }
#endif
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Initiator {
            get { return BackingStore?.Get<IdentitySet?>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#nullable restore
#else
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#endif
        /// <summary>Organizer of the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? MeetingOrganizer {
            get { return BackingStore?.Get<IdentitySet?>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#nullable restore
#else
        public IdentitySet MeetingOrganizer {
            get { return BackingStore?.Get<IdentitySet>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new CallRecordingEventMessageDetail and sets the default values.
        /// </summary>
        public CallRecordingEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.callRecordingEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CallRecordingEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallRecordingEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callId", n => { CallId = n.GetStringValue(); } },
                {"callRecordingDisplayName", n => { CallRecordingDisplayName = n.GetStringValue(); } },
                {"callRecordingDuration", n => { CallRecordingDuration = n.GetTimeSpanValue(); } },
                {"callRecordingStatus", n => { CallRecordingStatus = n.GetEnumValue<CallRecordingStatus>(); } },
                {"callRecordingUrl", n => { CallRecordingUrl = n.GetStringValue(); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"meetingOrganizer", n => { MeetingOrganizer = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("callId", CallId);
            writer.WriteStringValue("callRecordingDisplayName", CallRecordingDisplayName);
            writer.WriteTimeSpanValue("callRecordingDuration", CallRecordingDuration);
            writer.WriteEnumValue<CallRecordingStatus>("callRecordingStatus", CallRecordingStatus);
            writer.WriteStringValue("callRecordingUrl", CallRecordingUrl);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteObjectValue<IdentitySet>("meetingOrganizer", MeetingOrganizer);
        }
    }
}
