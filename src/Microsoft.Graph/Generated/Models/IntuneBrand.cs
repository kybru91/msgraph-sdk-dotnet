using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.
    /// </summary>
    public class IntuneBrand : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Email address of the person/organization responsible for IT support.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITEmailAddress {
            get { return BackingStore?.Get<string?>("contactITEmailAddress"); }
            set { BackingStore?.Set("contactITEmailAddress", value); }
        }
#nullable restore
#else
        public string ContactITEmailAddress {
            get { return BackingStore?.Get<string>("contactITEmailAddress"); }
            set { BackingStore?.Set("contactITEmailAddress", value); }
        }
#endif
        /// <summary>Name of the person/organization responsible for IT support.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITName {
            get { return BackingStore?.Get<string?>("contactITName"); }
            set { BackingStore?.Set("contactITName", value); }
        }
#nullable restore
#else
        public string ContactITName {
            get { return BackingStore?.Get<string>("contactITName"); }
            set { BackingStore?.Set("contactITName", value); }
        }
#endif
        /// <summary>Text comments regarding the person/organization responsible for IT support.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITNotes {
            get { return BackingStore?.Get<string?>("contactITNotes"); }
            set { BackingStore?.Set("contactITNotes", value); }
        }
#nullable restore
#else
        public string ContactITNotes {
            get { return BackingStore?.Get<string>("contactITNotes"); }
            set { BackingStore?.Set("contactITNotes", value); }
        }
#endif
        /// <summary>Phone number of the person/organization responsible for IT support.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITPhoneNumber {
            get { return BackingStore?.Get<string?>("contactITPhoneNumber"); }
            set { BackingStore?.Set("contactITPhoneNumber", value); }
        }
#nullable restore
#else
        public string ContactITPhoneNumber {
            get { return BackingStore?.Get<string>("contactITPhoneNumber"); }
            set { BackingStore?.Set("contactITPhoneNumber", value); }
        }
#endif
        /// <summary>Logo image displayed in Company Portal apps which have a dark background behind the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? DarkBackgroundLogo {
            get { return BackingStore?.Get<MimeContent?>("darkBackgroundLogo"); }
            set { BackingStore?.Set("darkBackgroundLogo", value); }
        }
#nullable restore
#else
        public MimeContent DarkBackgroundLogo {
            get { return BackingStore?.Get<MimeContent>("darkBackgroundLogo"); }
            set { BackingStore?.Set("darkBackgroundLogo", value); }
        }
#endif
        /// <summary>Company/organization name that is displayed to end users.</summary>
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
        /// <summary>Logo image displayed in Company Portal apps which have a light background behind the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? LightBackgroundLogo {
            get { return BackingStore?.Get<MimeContent?>("lightBackgroundLogo"); }
            set { BackingStore?.Set("lightBackgroundLogo", value); }
        }
#nullable restore
#else
        public MimeContent LightBackgroundLogo {
            get { return BackingStore?.Get<MimeContent>("lightBackgroundLogo"); }
            set { BackingStore?.Set("lightBackgroundLogo", value); }
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
        /// <summary>Display name of the company/organization’s IT helpdesk site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineSupportSiteName {
            get { return BackingStore?.Get<string?>("onlineSupportSiteName"); }
            set { BackingStore?.Set("onlineSupportSiteName", value); }
        }
#nullable restore
#else
        public string OnlineSupportSiteName {
            get { return BackingStore?.Get<string>("onlineSupportSiteName"); }
            set { BackingStore?.Set("onlineSupportSiteName", value); }
        }
#endif
        /// <summary>URL to the company/organization’s IT helpdesk site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineSupportSiteUrl {
            get { return BackingStore?.Get<string?>("onlineSupportSiteUrl"); }
            set { BackingStore?.Set("onlineSupportSiteUrl", value); }
        }
#nullable restore
#else
        public string OnlineSupportSiteUrl {
            get { return BackingStore?.Get<string>("onlineSupportSiteUrl"); }
            set { BackingStore?.Set("onlineSupportSiteUrl", value); }
        }
#endif
        /// <summary>URL to the company/organization’s privacy policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyUrl {
            get { return BackingStore?.Get<string?>("privacyUrl"); }
            set { BackingStore?.Set("privacyUrl", value); }
        }
#nullable restore
#else
        public string PrivacyUrl {
            get { return BackingStore?.Get<string>("privacyUrl"); }
            set { BackingStore?.Set("privacyUrl", value); }
        }
#endif
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowDisplayNameNextToLogo {
            get { return BackingStore?.Get<bool?>("showDisplayNameNextToLogo"); }
            set { BackingStore?.Set("showDisplayNameNextToLogo", value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied logo images are shown or not shown.</summary>
        public bool? ShowLogo {
            get { return BackingStore?.Get<bool?>("showLogo"); }
            set { BackingStore?.Set("showLogo", value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowNameNextToLogo {
            get { return BackingStore?.Get<bool?>("showNameNextToLogo"); }
            set { BackingStore?.Set("showNameNextToLogo", value); }
        }
        /// <summary>Primary theme color used in the Company Portal applications and web portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RgbColor? ThemeColor {
            get { return BackingStore?.Get<RgbColor?>("themeColor"); }
            set { BackingStore?.Set("themeColor", value); }
        }
#nullable restore
#else
        public RgbColor ThemeColor {
            get { return BackingStore?.Get<RgbColor>("themeColor"); }
            set { BackingStore?.Set("themeColor", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new intuneBrand and sets the default values.
        /// </summary>
        public IntuneBrand() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IntuneBrand CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntuneBrand();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contactITEmailAddress", n => { ContactITEmailAddress = n.GetStringValue(); } },
                {"contactITName", n => { ContactITName = n.GetStringValue(); } },
                {"contactITNotes", n => { ContactITNotes = n.GetStringValue(); } },
                {"contactITPhoneNumber", n => { ContactITPhoneNumber = n.GetStringValue(); } },
                {"darkBackgroundLogo", n => { DarkBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lightBackgroundLogo", n => { LightBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onlineSupportSiteName", n => { OnlineSupportSiteName = n.GetStringValue(); } },
                {"onlineSupportSiteUrl", n => { OnlineSupportSiteUrl = n.GetStringValue(); } },
                {"privacyUrl", n => { PrivacyUrl = n.GetStringValue(); } },
                {"showDisplayNameNextToLogo", n => { ShowDisplayNameNextToLogo = n.GetBoolValue(); } },
                {"showLogo", n => { ShowLogo = n.GetBoolValue(); } },
                {"showNameNextToLogo", n => { ShowNameNextToLogo = n.GetBoolValue(); } },
                {"themeColor", n => { ThemeColor = n.GetObjectValue<RgbColor>(RgbColor.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contactITEmailAddress", ContactITEmailAddress);
            writer.WriteStringValue("contactITName", ContactITName);
            writer.WriteStringValue("contactITNotes", ContactITNotes);
            writer.WriteStringValue("contactITPhoneNumber", ContactITPhoneNumber);
            writer.WriteObjectValue<MimeContent>("darkBackgroundLogo", DarkBackgroundLogo);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<MimeContent>("lightBackgroundLogo", LightBackgroundLogo);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("onlineSupportSiteName", OnlineSupportSiteName);
            writer.WriteStringValue("onlineSupportSiteUrl", OnlineSupportSiteUrl);
            writer.WriteStringValue("privacyUrl", PrivacyUrl);
            writer.WriteBoolValue("showDisplayNameNextToLogo", ShowDisplayNameNextToLogo);
            writer.WriteBoolValue("showLogo", ShowLogo);
            writer.WriteBoolValue("showNameNextToLogo", ShowNameNextToLogo);
            writer.WriteObjectValue<RgbColor>("themeColor", ThemeColor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
