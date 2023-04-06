using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class AnalyzedMessageEvidence : AlertEvidence, IParsable {
        /// <summary>Direction of the email relative to your network. The possible values are: inbound, outbound or intraorg.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AntiSpamDirection {
            get { return BackingStore?.Get<string?>("antiSpamDirection"); }
            set { BackingStore?.Set("antiSpamDirection", value); }
        }
#nullable restore
#else
        public string AntiSpamDirection {
            get { return BackingStore?.Get<string>("antiSpamDirection"); }
            set { BackingStore?.Set("antiSpamDirection", value); }
        }
#endif
        /// <summary>Number of attachments in the email.</summary>
        public long? AttachmentsCount {
            get { return BackingStore?.Get<long?>("attachmentsCount"); }
            set { BackingStore?.Set("attachmentsCount", value); }
        }
        /// <summary>Delivery action of the email. The possible values are: delivered, deliveredAsSpam, junked, blocked, or replaced.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryAction {
            get { return BackingStore?.Get<string?>("deliveryAction"); }
            set { BackingStore?.Set("deliveryAction", value); }
        }
#nullable restore
#else
        public string DeliveryAction {
            get { return BackingStore?.Get<string>("deliveryAction"); }
            set { BackingStore?.Set("deliveryAction", value); }
        }
#endif
        /// <summary>Location where the email was delivered. The possible values are: inbox, external, junkFolder, quarantine, failed, dropped, deletedFolder or forwarded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryLocation {
            get { return BackingStore?.Get<string?>("deliveryLocation"); }
            set { BackingStore?.Set("deliveryLocation", value); }
        }
#nullable restore
#else
        public string DeliveryLocation {
            get { return BackingStore?.Get<string>("deliveryLocation"); }
            set { BackingStore?.Set("deliveryLocation", value); }
        }
#endif
        /// <summary>Public-facing identifier for the email that is set by the sending email system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternetMessageId {
            get { return BackingStore?.Get<string?>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
#nullable restore
#else
        public string InternetMessageId {
            get { return BackingStore?.Get<string>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
#endif
        /// <summary>Detected language of the email content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language {
            get { return BackingStore?.Get<string?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public string Language {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
        /// <summary>Unique identifier for the email, generated by Microsoft 365.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkMessageId {
            get { return BackingStore?.Get<string?>("networkMessageId"); }
            set { BackingStore?.Set("networkMessageId", value); }
        }
#nullable restore
#else
        public string NetworkMessageId {
            get { return BackingStore?.Get<string>("networkMessageId"); }
            set { BackingStore?.Set("networkMessageId", value); }
        }
#endif
        /// <summary>The P1 sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailSender? P1Sender {
            get { return BackingStore?.Get<EmailSender?>("p1Sender"); }
            set { BackingStore?.Set("p1Sender", value); }
        }
#nullable restore
#else
        public EmailSender P1Sender {
            get { return BackingStore?.Get<EmailSender>("p1Sender"); }
            set { BackingStore?.Set("p1Sender", value); }
        }
#endif
        /// <summary>The P2 sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailSender? P2Sender {
            get { return BackingStore?.Get<EmailSender?>("p2Sender"); }
            set { BackingStore?.Set("p2Sender", value); }
        }
#nullable restore
#else
        public EmailSender P2Sender {
            get { return BackingStore?.Get<EmailSender>("p2Sender"); }
            set { BackingStore?.Set("p2Sender", value); }
        }
#endif
        /// <summary>Date and time when the email was received.</summary>
        public DateTimeOffset? ReceivedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("receivedDateTime"); }
            set { BackingStore?.Set("receivedDateTime", value); }
        }
        /// <summary>Email address of the recipient, or email address of the recipient after distribution list expansion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientEmailAddress {
            get { return BackingStore?.Get<string?>("recipientEmailAddress"); }
            set { BackingStore?.Set("recipientEmailAddress", value); }
        }
#nullable restore
#else
        public string RecipientEmailAddress {
            get { return BackingStore?.Get<string>("recipientEmailAddress"); }
            set { BackingStore?.Set("recipientEmailAddress", value); }
        }
#endif
        /// <summary>IP address of the last detected mail server that relayed the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderIp {
            get { return BackingStore?.Get<string?>("senderIp"); }
            set { BackingStore?.Set("senderIp", value); }
        }
#nullable restore
#else
        public string SenderIp {
            get { return BackingStore?.Get<string>("senderIp"); }
            set { BackingStore?.Set("senderIp", value); }
        }
#endif
        /// <summary>Subject of the email.</summary>
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
        /// <summary>Collection of methods used to detect malware, phishing, or other threats found in the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ThreatDetectionMethods {
            get { return BackingStore?.Get<List<string>?>("threatDetectionMethods"); }
            set { BackingStore?.Set("threatDetectionMethods", value); }
        }
#nullable restore
#else
        public List<string> ThreatDetectionMethods {
            get { return BackingStore?.Get<List<string>>("threatDetectionMethods"); }
            set { BackingStore?.Set("threatDetectionMethods", value); }
        }
#endif
        /// <summary>Collection of detection names for malware or other threats found.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Threats {
            get { return BackingStore?.Get<List<string>?>("threats"); }
            set { BackingStore?.Set("threats", value); }
        }
#nullable restore
#else
        public List<string> Threats {
            get { return BackingStore?.Get<List<string>>("threats"); }
            set { BackingStore?.Set("threats", value); }
        }
#endif
        /// <summary>Number of embedded URLs in the email.</summary>
        public long? UrlCount {
            get { return BackingStore?.Get<long?>("urlCount"); }
            set { BackingStore?.Set("urlCount", value); }
        }
        /// <summary>Collection of the URLs contained in this email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Urls {
            get { return BackingStore?.Get<List<string>?>("urls"); }
            set { BackingStore?.Set("urls", value); }
        }
#nullable restore
#else
        public List<string> Urls {
            get { return BackingStore?.Get<List<string>>("urls"); }
            set { BackingStore?.Set("urls", value); }
        }
#endif
        /// <summary>Uniform resource name (URN) of the automated investigation where the cluster was identified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn {
            get { return BackingStore?.Get<string?>("urn"); }
            set { BackingStore?.Set("urn", value); }
        }
#nullable restore
#else
        public string Urn {
            get { return BackingStore?.Get<string>("urn"); }
            set { BackingStore?.Set("urn", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AnalyzedMessageEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnalyzedMessageEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"antiSpamDirection", n => { AntiSpamDirection = n.GetStringValue(); } },
                {"attachmentsCount", n => { AttachmentsCount = n.GetLongValue(); } },
                {"deliveryAction", n => { DeliveryAction = n.GetStringValue(); } },
                {"deliveryLocation", n => { DeliveryLocation = n.GetStringValue(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"networkMessageId", n => { NetworkMessageId = n.GetStringValue(); } },
                {"p1Sender", n => { P1Sender = n.GetObjectValue<EmailSender>(EmailSender.CreateFromDiscriminatorValue); } },
                {"p2Sender", n => { P2Sender = n.GetObjectValue<EmailSender>(EmailSender.CreateFromDiscriminatorValue); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipientEmailAddress", n => { RecipientEmailAddress = n.GetStringValue(); } },
                {"senderIp", n => { SenderIp = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"threatDetectionMethods", n => { ThreatDetectionMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"threats", n => { Threats = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"urlCount", n => { UrlCount = n.GetLongValue(); } },
                {"urls", n => { Urls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"urn", n => { Urn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("antiSpamDirection", AntiSpamDirection);
            writer.WriteLongValue("attachmentsCount", AttachmentsCount);
            writer.WriteStringValue("deliveryAction", DeliveryAction);
            writer.WriteStringValue("deliveryLocation", DeliveryLocation);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("networkMessageId", NetworkMessageId);
            writer.WriteObjectValue<EmailSender>("p1Sender", P1Sender);
            writer.WriteObjectValue<EmailSender>("p2Sender", P2Sender);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteStringValue("recipientEmailAddress", RecipientEmailAddress);
            writer.WriteStringValue("senderIp", SenderIp);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfPrimitiveValues<string>("threatDetectionMethods", ThreatDetectionMethods);
            writer.WriteCollectionOfPrimitiveValues<string>("threats", Threats);
            writer.WriteLongValue("urlCount", UrlCount);
            writer.WriteCollectionOfPrimitiveValues<string>("urls", Urls);
            writer.WriteStringValue("urn", Urn);
        }
    }
}
