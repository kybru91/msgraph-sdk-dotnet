using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// An abstract class containing the base properties for Managed eBook.
    /// </summary>
    public class ManagedEBook : Entity, IParsable {
        /// <summary>The list of assignments for this eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedEBookAssignment>? Assignments {
            get { return BackingStore?.Get<List<ManagedEBookAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<ManagedEBookAssignment> Assignments {
            get { return BackingStore?.Get<List<ManagedEBookAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The date and time when the eBook file was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The list of installation states for this eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceInstallState>? DeviceStates {
            get { return BackingStore?.Get<List<DeviceInstallState>?>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#nullable restore
#else
        public List<DeviceInstallState> DeviceStates {
            get { return BackingStore?.Get<List<DeviceInstallState>>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#endif
        /// <summary>Name of the eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The more information Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InformationUrl {
            get { return BackingStore?.Get<string?>("informationUrl"); }
            set { BackingStore?.Set("informationUrl", value); }
        }
#nullable restore
#else
        public string InformationUrl {
            get { return BackingStore?.Get<string>("informationUrl"); }
            set { BackingStore?.Set("informationUrl", value); }
        }
#endif
        /// <summary>Mobile App Install Summary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EBookInstallSummary? InstallSummary {
            get { return BackingStore?.Get<EBookInstallSummary?>("installSummary"); }
            set { BackingStore?.Set("installSummary", value); }
        }
#nullable restore
#else
        public EBookInstallSummary InstallSummary {
            get { return BackingStore?.Get<EBookInstallSummary>("installSummary"); }
            set { BackingStore?.Set("installSummary", value); }
        }
#endif
        /// <summary>Book cover.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? LargeCover {
            get { return BackingStore?.Get<MimeContent?>("largeCover"); }
            set { BackingStore?.Set("largeCover", value); }
        }
#nullable restore
#else
        public MimeContent LargeCover {
            get { return BackingStore?.Get<MimeContent>("largeCover"); }
            set { BackingStore?.Set("largeCover", value); }
        }
#endif
        /// <summary>The date and time when the eBook was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The privacy statement Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyInformationUrl {
            get { return BackingStore?.Get<string?>("privacyInformationUrl"); }
            set { BackingStore?.Set("privacyInformationUrl", value); }
        }
#nullable restore
#else
        public string PrivacyInformationUrl {
            get { return BackingStore?.Get<string>("privacyInformationUrl"); }
            set { BackingStore?.Set("privacyInformationUrl", value); }
        }
#endif
        /// <summary>The date and time when the eBook was published.</summary>
        public DateTimeOffset? PublishedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("publishedDateTime"); }
            set { BackingStore?.Set("publishedDateTime", value); }
        }
        /// <summary>Publisher.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>The list of installation states for this eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserInstallStateSummary>? UserStateSummary {
            get { return BackingStore?.Get<List<UserInstallStateSummary>?>("userStateSummary"); }
            set { BackingStore?.Set("userStateSummary", value); }
        }
#nullable restore
#else
        public List<UserInstallStateSummary> UserStateSummary {
            get { return BackingStore?.Get<List<UserInstallStateSummary>>("userStateSummary"); }
            set { BackingStore?.Set("userStateSummary", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedEBook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.iosVppEBook" => new IosVppEBook(),
                _ => new ManagedEBook(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<ManagedEBookAssignment>(ManagedEBookAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceStates", n => { DeviceStates = n.GetCollectionOfObjectValues<DeviceInstallState>(DeviceInstallState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"informationUrl", n => { InformationUrl = n.GetStringValue(); } },
                {"installSummary", n => { InstallSummary = n.GetObjectValue<EBookInstallSummary>(EBookInstallSummary.CreateFromDiscriminatorValue); } },
                {"largeCover", n => { LargeCover = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"privacyInformationUrl", n => { PrivacyInformationUrl = n.GetStringValue(); } },
                {"publishedDateTime", n => { PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"userStateSummary", n => { UserStateSummary = n.GetCollectionOfObjectValues<UserInstallStateSummary>(UserInstallStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagedEBookAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<DeviceInstallState>("deviceStates", DeviceStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("informationUrl", InformationUrl);
            writer.WriteObjectValue<EBookInstallSummary>("installSummary", InstallSummary);
            writer.WriteObjectValue<MimeContent>("largeCover", LargeCover);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("privacyInformationUrl", PrivacyInformationUrl);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteCollectionOfObjectValues<UserInstallStateSummary>("userStateSummary", UserStateSummary);
        }
    }
}
