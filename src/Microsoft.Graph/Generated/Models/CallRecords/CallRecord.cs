using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.CallRecords {
    public class CallRecord : Entity, IParsable {
        /// <summary>UTC time when the last user left the call. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Meeting URL associated to the call. May not be available for a peerToPeer call record type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl {
            get { return BackingStore?.Get<string?>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#nullable restore
#else
        public string JoinWebUrl {
            get { return BackingStore?.Get<string>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#endif
        /// <summary>UTC time when the call record was created. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>List of all the modalities used in the call. Possible values are: unknown, audio, video, videoBasedScreenSharing, data, screenSharing, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Modality?>? Modalities {
            get { return BackingStore?.Get<List<Modality?>?>("modalities"); }
            set { BackingStore?.Set("modalities", value); }
        }
#nullable restore
#else
        public List<Modality?> Modalities {
            get { return BackingStore?.Get<List<Modality?>>("modalities"); }
            set { BackingStore?.Set("modalities", value); }
        }
#endif
        /// <summary>The organizing party&apos;s identity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.IdentitySet? Organizer {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet?>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.IdentitySet Organizer {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#endif
        /// <summary>List of distinct identities involved in the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.IdentitySet>? Participants {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.IdentitySet>?>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.IdentitySet> Participants {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.IdentitySet>>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#endif
        /// <summary>List of sessions involved in the call. Peer-to-peer calls typically only have one session, whereas group calls typically have at least one session per participant. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Session>? Sessions {
            get { return BackingStore?.Get<List<Session>?>("sessions"); }
            set { BackingStore?.Set("sessions", value); }
        }
#nullable restore
#else
        public List<Session> Sessions {
            get { return BackingStore?.Get<List<Session>>("sessions"); }
            set { BackingStore?.Set("sessions", value); }
        }
#endif
        /// <summary>UTC time when the first user joined the call. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The type property</summary>
        public CallType? Type {
            get { return BackingStore?.Get<CallType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>Monotonically increasing version of the call record. Higher version call records with the same id includes additional data compared to the lower version.</summary>
        public long? Version {
            get { return BackingStore?.Get<long?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CallRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"modalities", n => { Modalities = n.GetCollectionOfEnumValues<Modality>()?.ToList(); } },
                {"organizer", n => { Organizer = n.GetObjectValue<Microsoft.Graph.Models.IdentitySet>(Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"participants", n => { Participants = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.IdentitySet>(Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sessions", n => { Sessions = n.GetCollectionOfObjectValues<Session>(Session.CreateFromDiscriminatorValue)?.ToList(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"type", n => { Type = n.GetEnumValue<CallType>(); } },
                {"version", n => { Version = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfEnumValues<Modality>("modalities", Modalities);
            writer.WriteObjectValue<Microsoft.Graph.Models.IdentitySet>("organizer", Organizer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.IdentitySet>("participants", Participants);
            writer.WriteCollectionOfObjectValues<Session>("sessions", Sessions);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<CallType>("type", Type);
            writer.WriteLongValue("version", Version);
        }
    }
}
