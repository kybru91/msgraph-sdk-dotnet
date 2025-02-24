using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Windows81GeneralConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to Block the user from adding email accounts to the device that are not associated with a Microsoft account.</summary>
        public bool? AccountsBlockAddingNonMicrosoftAccountEmail {
            get { return BackingStore?.Get<bool?>("accountsBlockAddingNonMicrosoftAccountEmail"); }
            set { BackingStore?.Set("accountsBlockAddingNonMicrosoftAccountEmail", value); }
        }
        /// <summary>Value indicating whether this policy only applies to Windows 8.1. This property is read-only.</summary>
        public bool? ApplyOnlyToWindows81 {
            get { return BackingStore?.Get<bool?>("applyOnlyToWindows81"); }
            set { BackingStore?.Set("applyOnlyToWindows81", value); }
        }
        /// <summary>Indicates whether or not to block auto fill.</summary>
        public bool? BrowserBlockAutofill {
            get { return BackingStore?.Get<bool?>("browserBlockAutofill"); }
            set { BackingStore?.Set("browserBlockAutofill", value); }
        }
        /// <summary>Indicates whether or not to block automatic detection of Intranet sites.</summary>
        public bool? BrowserBlockAutomaticDetectionOfIntranetSites {
            get { return BackingStore?.Get<bool?>("browserBlockAutomaticDetectionOfIntranetSites"); }
            set { BackingStore?.Set("browserBlockAutomaticDetectionOfIntranetSites", value); }
        }
        /// <summary>Indicates whether or not to block enterprise mode access.</summary>
        public bool? BrowserBlockEnterpriseModeAccess {
            get { return BackingStore?.Get<bool?>("browserBlockEnterpriseModeAccess"); }
            set { BackingStore?.Set("browserBlockEnterpriseModeAccess", value); }
        }
        /// <summary>Indicates whether or not to Block the user from using JavaScript.</summary>
        public bool? BrowserBlockJavaScript {
            get { return BackingStore?.Get<bool?>("browserBlockJavaScript"); }
            set { BackingStore?.Set("browserBlockJavaScript", value); }
        }
        /// <summary>Indicates whether or not to block plug-ins.</summary>
        public bool? BrowserBlockPlugins {
            get { return BackingStore?.Get<bool?>("browserBlockPlugins"); }
            set { BackingStore?.Set("browserBlockPlugins", value); }
        }
        /// <summary>Indicates whether or not to block popups.</summary>
        public bool? BrowserBlockPopups {
            get { return BackingStore?.Get<bool?>("browserBlockPopups"); }
            set { BackingStore?.Set("browserBlockPopups", value); }
        }
        /// <summary>Indicates whether or not to Block the user from sending the do not track header.</summary>
        public bool? BrowserBlockSendingDoNotTrackHeader {
            get { return BackingStore?.Get<bool?>("browserBlockSendingDoNotTrackHeader"); }
            set { BackingStore?.Set("browserBlockSendingDoNotTrackHeader", value); }
        }
        /// <summary>Indicates whether or not to block a single word entry on Intranet sites.</summary>
        public bool? BrowserBlockSingleWordEntryOnIntranetSites {
            get { return BackingStore?.Get<bool?>("browserBlockSingleWordEntryOnIntranetSites"); }
            set { BackingStore?.Set("browserBlockSingleWordEntryOnIntranetSites", value); }
        }
        /// <summary>The enterprise mode site list location. Could be a local file, local network or http location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BrowserEnterpriseModeSiteListLocation {
            get { return BackingStore?.Get<string?>("browserEnterpriseModeSiteListLocation"); }
            set { BackingStore?.Set("browserEnterpriseModeSiteListLocation", value); }
        }
#nullable restore
#else
        public string BrowserEnterpriseModeSiteListLocation {
            get { return BackingStore?.Get<string>("browserEnterpriseModeSiteListLocation"); }
            set { BackingStore?.Set("browserEnterpriseModeSiteListLocation", value); }
        }
#endif
        /// <summary>Possible values for internet site security level.</summary>
        public InternetSiteSecurityLevel? BrowserInternetSecurityLevel {
            get { return BackingStore?.Get<InternetSiteSecurityLevel?>("browserInternetSecurityLevel"); }
            set { BackingStore?.Set("browserInternetSecurityLevel", value); }
        }
        /// <summary>Possible values for site security level.</summary>
        public SiteSecurityLevel? BrowserIntranetSecurityLevel {
            get { return BackingStore?.Get<SiteSecurityLevel?>("browserIntranetSecurityLevel"); }
            set { BackingStore?.Set("browserIntranetSecurityLevel", value); }
        }
        /// <summary>The logging report location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BrowserLoggingReportLocation {
            get { return BackingStore?.Get<string?>("browserLoggingReportLocation"); }
            set { BackingStore?.Set("browserLoggingReportLocation", value); }
        }
#nullable restore
#else
        public string BrowserLoggingReportLocation {
            get { return BackingStore?.Get<string>("browserLoggingReportLocation"); }
            set { BackingStore?.Set("browserLoggingReportLocation", value); }
        }
#endif
        /// <summary>Indicates whether or not to require a firewall.</summary>
        public bool? BrowserRequireFirewall {
            get { return BackingStore?.Get<bool?>("browserRequireFirewall"); }
            set { BackingStore?.Set("browserRequireFirewall", value); }
        }
        /// <summary>Indicates whether or not to require fraud warning.</summary>
        public bool? BrowserRequireFraudWarning {
            get { return BackingStore?.Get<bool?>("browserRequireFraudWarning"); }
            set { BackingStore?.Set("browserRequireFraudWarning", value); }
        }
        /// <summary>Indicates whether or not to require high security for restricted sites.</summary>
        public bool? BrowserRequireHighSecurityForRestrictedSites {
            get { return BackingStore?.Get<bool?>("browserRequireHighSecurityForRestrictedSites"); }
            set { BackingStore?.Set("browserRequireHighSecurityForRestrictedSites", value); }
        }
        /// <summary>Indicates whether or not to require the user to use the smart screen filter.</summary>
        public bool? BrowserRequireSmartScreen {
            get { return BackingStore?.Get<bool?>("browserRequireSmartScreen"); }
            set { BackingStore?.Set("browserRequireSmartScreen", value); }
        }
        /// <summary>Possible values for site security level.</summary>
        public SiteSecurityLevel? BrowserTrustedSitesSecurityLevel {
            get { return BackingStore?.Get<SiteSecurityLevel?>("browserTrustedSitesSecurityLevel"); }
            set { BackingStore?.Set("browserTrustedSitesSecurityLevel", value); }
        }
        /// <summary>Indicates whether or not to block data roaming.</summary>
        public bool? CellularBlockDataRoaming {
            get { return BackingStore?.Get<bool?>("cellularBlockDataRoaming"); }
            set { BackingStore?.Set("cellularBlockDataRoaming", value); }
        }
        /// <summary>Indicates whether or not to block diagnostic data submission.</summary>
        public bool? DiagnosticsBlockDataSubmission {
            get { return BackingStore?.Get<bool?>("diagnosticsBlockDataSubmission"); }
            set { BackingStore?.Set("diagnosticsBlockDataSubmission", value); }
        }
        /// <summary>Indicates whether or not to Block the user from using a pictures password and pin.</summary>
        public bool? PasswordBlockPicturePasswordAndPin {
            get { return BackingStore?.Get<bool?>("passwordBlockPicturePasswordAndPin"); }
            set { BackingStore?.Set("passwordBlockPicturePasswordAndPin", value); }
        }
        /// <summary>Password expiration in days.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>("passwordMinimumCharacterSetCount"); }
            set { BackingStore?.Set("passwordMinimumCharacterSetCount", value); }
        }
        /// <summary>The minimum password length.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>The minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>The number of previous passwords to prevent re-use of. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Possible values of required passwords.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>The number of sign in failures before factory reset.</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>("passwordSignInFailureCountBeforeFactoryReset"); }
            set { BackingStore?.Set("passwordSignInFailureCountBeforeFactoryReset", value); }
        }
        /// <summary>Indicates whether or not to require encryption on a mobile device.</summary>
        public bool? StorageRequireDeviceEncryption {
            get { return BackingStore?.Get<bool?>("storageRequireDeviceEncryption"); }
            set { BackingStore?.Set("storageRequireDeviceEncryption", value); }
        }
        /// <summary>Indicates whether or not to require automatic updates.</summary>
        public bool? UpdatesRequireAutomaticUpdates {
            get { return BackingStore?.Get<bool?>("updatesRequireAutomaticUpdates"); }
            set { BackingStore?.Set("updatesRequireAutomaticUpdates", value); }
        }
        /// <summary>Possible values for Windows user account control settings.</summary>
        public WindowsUserAccountControlSettings? UserAccountControlSettings {
            get { return BackingStore?.Get<WindowsUserAccountControlSettings?>("userAccountControlSettings"); }
            set { BackingStore?.Set("userAccountControlSettings", value); }
        }
        /// <summary>The work folders url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkFoldersUrl {
            get { return BackingStore?.Get<string?>("workFoldersUrl"); }
            set { BackingStore?.Set("workFoldersUrl", value); }
        }
#nullable restore
#else
        public string WorkFoldersUrl {
            get { return BackingStore?.Get<string>("workFoldersUrl"); }
            set { BackingStore?.Set("workFoldersUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Windows81GeneralConfiguration and sets the default values.
        /// </summary>
        public Windows81GeneralConfiguration() : base() {
            OdataType = "#microsoft.graph.windows81GeneralConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows81GeneralConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows81GeneralConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountsBlockAddingNonMicrosoftAccountEmail", n => { AccountsBlockAddingNonMicrosoftAccountEmail = n.GetBoolValue(); } },
                {"applyOnlyToWindows81", n => { ApplyOnlyToWindows81 = n.GetBoolValue(); } },
                {"browserBlockAutofill", n => { BrowserBlockAutofill = n.GetBoolValue(); } },
                {"browserBlockAutomaticDetectionOfIntranetSites", n => { BrowserBlockAutomaticDetectionOfIntranetSites = n.GetBoolValue(); } },
                {"browserBlockEnterpriseModeAccess", n => { BrowserBlockEnterpriseModeAccess = n.GetBoolValue(); } },
                {"browserBlockJavaScript", n => { BrowserBlockJavaScript = n.GetBoolValue(); } },
                {"browserBlockPlugins", n => { BrowserBlockPlugins = n.GetBoolValue(); } },
                {"browserBlockPopups", n => { BrowserBlockPopups = n.GetBoolValue(); } },
                {"browserBlockSendingDoNotTrackHeader", n => { BrowserBlockSendingDoNotTrackHeader = n.GetBoolValue(); } },
                {"browserBlockSingleWordEntryOnIntranetSites", n => { BrowserBlockSingleWordEntryOnIntranetSites = n.GetBoolValue(); } },
                {"browserEnterpriseModeSiteListLocation", n => { BrowserEnterpriseModeSiteListLocation = n.GetStringValue(); } },
                {"browserInternetSecurityLevel", n => { BrowserInternetSecurityLevel = n.GetEnumValue<InternetSiteSecurityLevel>(); } },
                {"browserIntranetSecurityLevel", n => { BrowserIntranetSecurityLevel = n.GetEnumValue<SiteSecurityLevel>(); } },
                {"browserLoggingReportLocation", n => { BrowserLoggingReportLocation = n.GetStringValue(); } },
                {"browserRequireFirewall", n => { BrowserRequireFirewall = n.GetBoolValue(); } },
                {"browserRequireFraudWarning", n => { BrowserRequireFraudWarning = n.GetBoolValue(); } },
                {"browserRequireHighSecurityForRestrictedSites", n => { BrowserRequireHighSecurityForRestrictedSites = n.GetBoolValue(); } },
                {"browserRequireSmartScreen", n => { BrowserRequireSmartScreen = n.GetBoolValue(); } },
                {"browserTrustedSitesSecurityLevel", n => { BrowserTrustedSitesSecurityLevel = n.GetEnumValue<SiteSecurityLevel>(); } },
                {"cellularBlockDataRoaming", n => { CellularBlockDataRoaming = n.GetBoolValue(); } },
                {"diagnosticsBlockDataSubmission", n => { DiagnosticsBlockDataSubmission = n.GetBoolValue(); } },
                {"passwordBlockPicturePasswordAndPin", n => { PasswordBlockPicturePasswordAndPin = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"storageRequireDeviceEncryption", n => { StorageRequireDeviceEncryption = n.GetBoolValue(); } },
                {"updatesRequireAutomaticUpdates", n => { UpdatesRequireAutomaticUpdates = n.GetBoolValue(); } },
                {"userAccountControlSettings", n => { UserAccountControlSettings = n.GetEnumValue<WindowsUserAccountControlSettings>(); } },
                {"workFoldersUrl", n => { WorkFoldersUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountsBlockAddingNonMicrosoftAccountEmail", AccountsBlockAddingNonMicrosoftAccountEmail);
            writer.WriteBoolValue("browserBlockAutofill", BrowserBlockAutofill);
            writer.WriteBoolValue("browserBlockAutomaticDetectionOfIntranetSites", BrowserBlockAutomaticDetectionOfIntranetSites);
            writer.WriteBoolValue("browserBlockEnterpriseModeAccess", BrowserBlockEnterpriseModeAccess);
            writer.WriteBoolValue("browserBlockJavaScript", BrowserBlockJavaScript);
            writer.WriteBoolValue("browserBlockPlugins", BrowserBlockPlugins);
            writer.WriteBoolValue("browserBlockPopups", BrowserBlockPopups);
            writer.WriteBoolValue("browserBlockSendingDoNotTrackHeader", BrowserBlockSendingDoNotTrackHeader);
            writer.WriteBoolValue("browserBlockSingleWordEntryOnIntranetSites", BrowserBlockSingleWordEntryOnIntranetSites);
            writer.WriteStringValue("browserEnterpriseModeSiteListLocation", BrowserEnterpriseModeSiteListLocation);
            writer.WriteEnumValue<InternetSiteSecurityLevel>("browserInternetSecurityLevel", BrowserInternetSecurityLevel);
            writer.WriteEnumValue<SiteSecurityLevel>("browserIntranetSecurityLevel", BrowserIntranetSecurityLevel);
            writer.WriteStringValue("browserLoggingReportLocation", BrowserLoggingReportLocation);
            writer.WriteBoolValue("browserRequireFirewall", BrowserRequireFirewall);
            writer.WriteBoolValue("browserRequireFraudWarning", BrowserRequireFraudWarning);
            writer.WriteBoolValue("browserRequireHighSecurityForRestrictedSites", BrowserRequireHighSecurityForRestrictedSites);
            writer.WriteBoolValue("browserRequireSmartScreen", BrowserRequireSmartScreen);
            writer.WriteEnumValue<SiteSecurityLevel>("browserTrustedSitesSecurityLevel", BrowserTrustedSitesSecurityLevel);
            writer.WriteBoolValue("cellularBlockDataRoaming", CellularBlockDataRoaming);
            writer.WriteBoolValue("diagnosticsBlockDataSubmission", DiagnosticsBlockDataSubmission);
            writer.WriteBoolValue("passwordBlockPicturePasswordAndPin", PasswordBlockPicturePasswordAndPin);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("storageRequireDeviceEncryption", StorageRequireDeviceEncryption);
            writer.WriteBoolValue("updatesRequireAutomaticUpdates", UpdatesRequireAutomaticUpdates);
            writer.WriteEnumValue<WindowsUserAccountControlSettings>("userAccountControlSettings", UserAccountControlSettings);
            writer.WriteStringValue("workFoldersUrl", WorkFoldersUrl);
        }
    }
}
