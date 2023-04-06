using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class JoinMeetingIdMeetingInfo : MeetingInfo, IParsable {
        /// <summary>The ID used to join the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinMeetingId {
            get { return BackingStore?.Get<string?>("joinMeetingId"); }
            set { BackingStore?.Set("joinMeetingId", value); }
        }
#nullable restore
#else
        public string JoinMeetingId {
            get { return BackingStore?.Get<string>("joinMeetingId"); }
            set { BackingStore?.Set("joinMeetingId", value); }
        }
#endif
        /// <summary>The passcode used to join the meeting. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Passcode {
            get { return BackingStore?.Get<string?>("passcode"); }
            set { BackingStore?.Set("passcode", value); }
        }
#nullable restore
#else
        public string Passcode {
            get { return BackingStore?.Get<string>("passcode"); }
            set { BackingStore?.Set("passcode", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new JoinMeetingIdMeetingInfo and sets the default values.
        /// </summary>
        public JoinMeetingIdMeetingInfo() : base() {
            OdataType = "#microsoft.graph.joinMeetingIdMeetingInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new JoinMeetingIdMeetingInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JoinMeetingIdMeetingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"joinMeetingId", n => { JoinMeetingId = n.GetStringValue(); } },
                {"passcode", n => { Passcode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("joinMeetingId", JoinMeetingId);
            writer.WriteStringValue("passcode", Passcode);
        }
    }
}
