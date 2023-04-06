using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// You purchase multiple licenses for iOS apps through the Apple Volume Purchase Program for Business or Education. This involves setting up an Apple VPP account from the Apple website and uploading the Apple VPP Business or Education token to Intune. You can then synchronize your volume purchase information with Intune and track your volume-purchased app use. You can upload multiple Apple VPP Business or Education tokens.
    /// </summary>
    public class VppToken : Entity, IParsable {
        /// <summary>The apple Id associated with the given Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppleId {
            get { return BackingStore?.Get<string?>("appleId"); }
            set { BackingStore?.Set("appleId", value); }
        }
#nullable restore
#else
        public string AppleId {
            get { return BackingStore?.Get<string>("appleId"); }
            set { BackingStore?.Set("appleId", value); }
        }
#endif
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
        public bool? AutomaticallyUpdateApps {
            get { return BackingStore?.Get<bool?>("automaticallyUpdateApps"); }
            set { BackingStore?.Set("automaticallyUpdateApps", value); }
        }
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOrRegion {
            get { return BackingStore?.Get<string?>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#nullable restore
#else
        public string CountryOrRegion {
            get { return BackingStore?.Get<string>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#endif
        /// <summary>The expiration date time of the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Last modification date time associated with the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>Possible sync statuses associated with an Apple Volume Purchase Program token.</summary>
        public VppTokenSyncStatus? LastSyncStatus {
            get { return BackingStore?.Get<VppTokenSyncStatus?>("lastSyncStatus"); }
            set { BackingStore?.Set("lastSyncStatus", value); }
        }
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName {
            get { return BackingStore?.Get<string?>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#nullable restore
#else
        public string OrganizationName {
            get { return BackingStore?.Get<string>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#endif
        /// <summary>Possible states associated with an Apple Volume Purchase Program token.</summary>
        public VppTokenState? State {
            get { return BackingStore?.Get<VppTokenState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token {
            get { return BackingStore?.Get<string?>("token"); }
            set { BackingStore?.Set("token", value); }
        }
#nullable restore
#else
        public string Token {
            get { return BackingStore?.Get<string>("token"); }
            set { BackingStore?.Set("token", value); }
        }
#endif
        /// <summary>Possible types of an Apple Volume Purchase Program token.</summary>
        public Microsoft.Graph.Models.VppTokenAccountType? VppTokenAccountType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.VppTokenAccountType?>("vppTokenAccountType"); }
            set { BackingStore?.Set("vppTokenAccountType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VppToken CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VppToken();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleId", n => { AppleId = n.GetStringValue(); } },
                {"automaticallyUpdateApps", n => { AutomaticallyUpdateApps = n.GetBoolValue(); } },
                {"countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncStatus", n => { LastSyncStatus = n.GetEnumValue<VppTokenSyncStatus>(); } },
                {"organizationName", n => { OrganizationName = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<VppTokenState>(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"vppTokenAccountType", n => { VppTokenAccountType = n.GetEnumValue<VppTokenAccountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteBoolValue("automaticallyUpdateApps", AutomaticallyUpdateApps);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<VppTokenSyncStatus>("lastSyncStatus", LastSyncStatus);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteEnumValue<VppTokenState>("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
        }
    }
}
