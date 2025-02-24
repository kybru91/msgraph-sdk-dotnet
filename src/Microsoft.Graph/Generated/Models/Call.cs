using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Call : Entity, IParsable {
        /// <summary>The audioRoutingGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AudioRoutingGroup>? AudioRoutingGroups {
            get { return BackingStore?.Get<List<AudioRoutingGroup>?>("audioRoutingGroups"); }
            set { BackingStore?.Set("audioRoutingGroups", value); }
        }
#nullable restore
#else
        public List<AudioRoutingGroup> AudioRoutingGroups {
            get { return BackingStore?.Get<List<AudioRoutingGroup>>("audioRoutingGroups"); }
            set { BackingStore?.Set("audioRoutingGroups", value); }
        }
#endif
        /// <summary>The callback URL on which callbacks will be delivered. Must be https.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallbackUri {
            get { return BackingStore?.Get<string?>("callbackUri"); }
            set { BackingStore?.Set("callbackUri", value); }
        }
#nullable restore
#else
        public string CallbackUri {
            get { return BackingStore?.Get<string>("callbackUri"); }
            set { BackingStore?.Set("callbackUri", value); }
        }
#endif
        /// <summary>A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallChainId {
            get { return BackingStore?.Get<string?>("callChainId"); }
            set { BackingStore?.Set("callChainId", value); }
        }
#nullable restore
#else
        public string CallChainId {
            get { return BackingStore?.Get<string>("callChainId"); }
            set { BackingStore?.Set("callChainId", value); }
        }
#endif
        /// <summary>Contains the optional features for the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.CallOptions? CallOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CallOptions?>("callOptions"); }
            set { BackingStore?.Set("callOptions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.CallOptions CallOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CallOptions>("callOptions"); }
            set { BackingStore?.Set("callOptions", value); }
        }
#endif
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CallRoute>? CallRoutes {
            get { return BackingStore?.Get<List<CallRoute>?>("callRoutes"); }
            set { BackingStore?.Set("callRoutes", value); }
        }
#nullable restore
#else
        public List<CallRoute> CallRoutes {
            get { return BackingStore?.Get<List<CallRoute>>("callRoutes"); }
            set { BackingStore?.Set("callRoutes", value); }
        }
#endif
        /// <summary>The chat information. Required information for joining a meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ChatInfo? ChatInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChatInfo?>("chatInfo"); }
            set { BackingStore?.Set("chatInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ChatInfo ChatInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChatInfo>("chatInfo"); }
            set { BackingStore?.Set("chatInfo", value); }
        }
#endif
        /// <summary>The contentSharingSessions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContentSharingSession>? ContentSharingSessions {
            get { return BackingStore?.Get<List<ContentSharingSession>?>("contentSharingSessions"); }
            set { BackingStore?.Set("contentSharingSessions", value); }
        }
#nullable restore
#else
        public List<ContentSharingSession> ContentSharingSessions {
            get { return BackingStore?.Get<List<ContentSharingSession>>("contentSharingSessions"); }
            set { BackingStore?.Set("contentSharingSessions", value); }
        }
#endif
        /// <summary>The direction of the call. The possible value are incoming or outgoing. Read-only.</summary>
        public CallDirection? Direction {
            get { return BackingStore?.Get<CallDirection?>("direction"); }
            set { BackingStore?.Set("direction", value); }
        }
        /// <summary>Call context associated with an incoming call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.IncomingContext? IncomingContext {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IncomingContext?>("incomingContext"); }
            set { BackingStore?.Set("incomingContext", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.IncomingContext IncomingContext {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IncomingContext>("incomingContext"); }
            set { BackingStore?.Set("incomingContext", value); }
        }
#endif
        /// <summary>The media configuration. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.MediaConfig? MediaConfig {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaConfig?>("mediaConfig"); }
            set { BackingStore?.Set("mediaConfig", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.MediaConfig MediaConfig {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaConfig>("mediaConfig"); }
            set { BackingStore?.Set("mediaConfig", value); }
        }
#endif
        /// <summary>Read-only. The call media state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CallMediaState? MediaState {
            get { return BackingStore?.Get<CallMediaState?>("mediaState"); }
            set { BackingStore?.Set("mediaState", value); }
        }
#nullable restore
#else
        public CallMediaState MediaState {
            get { return BackingStore?.Get<CallMediaState>("mediaState"); }
            set { BackingStore?.Set("mediaState", value); }
        }
#endif
        /// <summary>The meeting information. Required information for meeting scenarios.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.MeetingInfo? MeetingInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MeetingInfo?>("meetingInfo"); }
            set { BackingStore?.Set("meetingInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.MeetingInfo MeetingInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MeetingInfo>("meetingInfo"); }
            set { BackingStore?.Set("meetingInfo", value); }
        }
#endif
        /// <summary>The myParticipantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MyParticipantId {
            get { return BackingStore?.Get<string?>("myParticipantId"); }
            set { BackingStore?.Set("myParticipantId", value); }
        }
#nullable restore
#else
        public string MyParticipantId {
            get { return BackingStore?.Get<string>("myParticipantId"); }
            set { BackingStore?.Set("myParticipantId", value); }
        }
#endif
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CommsOperation>? Operations {
            get { return BackingStore?.Get<List<CommsOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<CommsOperation> Operations {
            get { return BackingStore?.Get<List<CommsOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The participants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Participant>? Participants {
            get { return BackingStore?.Get<List<Participant>?>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#nullable restore
#else
        public List<Participant> Participants {
            get { return BackingStore?.Get<List<Participant>>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#endif
        /// <summary>The list of requested modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Modality?>? RequestedModalities {
            get { return BackingStore?.Get<List<Modality?>?>("requestedModalities"); }
            set { BackingStore?.Set("requestedModalities", value); }
        }
#nullable restore
#else
        public List<Modality?> RequestedModalities {
            get { return BackingStore?.Get<List<Modality?>>("requestedModalities"); }
            set { BackingStore?.Set("requestedModalities", value); }
        }
#endif
        /// <summary>The result information. For example can hold termination reason. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ResultInfo? ResultInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResultInfo?>("resultInfo"); }
            set { BackingStore?.Set("resultInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ResultInfo ResultInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResultInfo>("resultInfo"); }
            set { BackingStore?.Set("resultInfo", value); }
        }
#endif
        /// <summary>The originator of the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ParticipantInfo? Source {
            get { return BackingStore?.Get<ParticipantInfo?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#nullable restore
#else
        public ParticipantInfo Source {
            get { return BackingStore?.Get<ParticipantInfo>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>The call state. Possible values are: incoming, establishing, ringing, established, hold, transferring, transferAccepted, redirecting, terminating, terminated. Read-only.</summary>
        public CallState? State {
            get { return BackingStore?.Get<CallState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The subject of the conversation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The targets of the call. Required information for creating peer to peer call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InvitationParticipantInfo>? Targets {
            get { return BackingStore?.Get<List<InvitationParticipantInfo>?>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#nullable restore
#else
        public List<InvitationParticipantInfo> Targets {
            get { return BackingStore?.Get<List<InvitationParticipantInfo>>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#endif
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The toneInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ToneInfo? ToneInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ToneInfo?>("toneInfo"); }
            set { BackingStore?.Set("toneInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ToneInfo ToneInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ToneInfo>("toneInfo"); }
            set { BackingStore?.Set("toneInfo", value); }
        }
#endif
        /// <summary>The transcription information for the call. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CallTranscriptionInfo? Transcription {
            get { return BackingStore?.Get<CallTranscriptionInfo?>("transcription"); }
            set { BackingStore?.Set("transcription", value); }
        }
#nullable restore
#else
        public CallTranscriptionInfo Transcription {
            get { return BackingStore?.Get<CallTranscriptionInfo>("transcription"); }
            set { BackingStore?.Set("transcription", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Call CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Call();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audioRoutingGroups", n => { AudioRoutingGroups = n.GetCollectionOfObjectValues<AudioRoutingGroup>(AudioRoutingGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                {"callChainId", n => { CallChainId = n.GetStringValue(); } },
                {"callOptions", n => { CallOptions = n.GetObjectValue<Microsoft.Graph.Models.CallOptions>(Microsoft.Graph.Models.CallOptions.CreateFromDiscriminatorValue); } },
                {"callRoutes", n => { CallRoutes = n.GetCollectionOfObjectValues<CallRoute>(CallRoute.CreateFromDiscriminatorValue)?.ToList(); } },
                {"chatInfo", n => { ChatInfo = n.GetObjectValue<Microsoft.Graph.Models.ChatInfo>(Microsoft.Graph.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                {"contentSharingSessions", n => { ContentSharingSessions = n.GetCollectionOfObjectValues<ContentSharingSession>(ContentSharingSession.CreateFromDiscriminatorValue)?.ToList(); } },
                {"direction", n => { Direction = n.GetEnumValue<CallDirection>(); } },
                {"incomingContext", n => { IncomingContext = n.GetObjectValue<Microsoft.Graph.Models.IncomingContext>(Microsoft.Graph.Models.IncomingContext.CreateFromDiscriminatorValue); } },
                {"mediaConfig", n => { MediaConfig = n.GetObjectValue<Microsoft.Graph.Models.MediaConfig>(Microsoft.Graph.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                {"mediaState", n => { MediaState = n.GetObjectValue<CallMediaState>(CallMediaState.CreateFromDiscriminatorValue); } },
                {"meetingInfo", n => { MeetingInfo = n.GetObjectValue<Microsoft.Graph.Models.MeetingInfo>(Microsoft.Graph.Models.MeetingInfo.CreateFromDiscriminatorValue); } },
                {"myParticipantId", n => { MyParticipantId = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<CommsOperation>(CommsOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"participants", n => { Participants = n.GetCollectionOfObjectValues<Participant>(Participant.CreateFromDiscriminatorValue)?.ToList(); } },
                {"requestedModalities", n => { RequestedModalities = n.GetCollectionOfEnumValues<Modality>()?.ToList(); } },
                {"resultInfo", n => { ResultInfo = n.GetObjectValue<Microsoft.Graph.Models.ResultInfo>(Microsoft.Graph.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                {"source", n => { Source = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<CallState>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"targets", n => { Targets = n.GetCollectionOfObjectValues<InvitationParticipantInfo>(InvitationParticipantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"toneInfo", n => { ToneInfo = n.GetObjectValue<Microsoft.Graph.Models.ToneInfo>(Microsoft.Graph.Models.ToneInfo.CreateFromDiscriminatorValue); } },
                {"transcription", n => { Transcription = n.GetObjectValue<CallTranscriptionInfo>(CallTranscriptionInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AudioRoutingGroup>("audioRoutingGroups", AudioRoutingGroups);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteStringValue("callChainId", CallChainId);
            writer.WriteObjectValue<Microsoft.Graph.Models.CallOptions>("callOptions", CallOptions);
            writer.WriteCollectionOfObjectValues<CallRoute>("callRoutes", CallRoutes);
            writer.WriteObjectValue<Microsoft.Graph.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteCollectionOfObjectValues<ContentSharingSession>("contentSharingSessions", ContentSharingSessions);
            writer.WriteEnumValue<CallDirection>("direction", Direction);
            writer.WriteObjectValue<Microsoft.Graph.Models.IncomingContext>("incomingContext", IncomingContext);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteObjectValue<CallMediaState>("mediaState", MediaState);
            writer.WriteObjectValue<Microsoft.Graph.Models.MeetingInfo>("meetingInfo", MeetingInfo);
            writer.WriteStringValue("myParticipantId", MyParticipantId);
            writer.WriteCollectionOfObjectValues<CommsOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Participant>("participants", Participants);
            writer.WriteCollectionOfEnumValues<Modality>("requestedModalities", RequestedModalities);
            writer.WriteObjectValue<Microsoft.Graph.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteObjectValue<ParticipantInfo>("source", Source);
            writer.WriteEnumValue<CallState>("state", State);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<InvitationParticipantInfo>("targets", Targets);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<Microsoft.Graph.Models.ToneInfo>("toneInfo", ToneInfo);
            writer.WriteObjectValue<CallTranscriptionInfo>("transcription", Transcription);
        }
    }
}
