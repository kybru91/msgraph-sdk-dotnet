using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Devices that are managed or pre-enrolled through Intune
    /// </summary>
    public class ManagedDevice : Entity, IParsable {
        /// <summary>The code that allows the Activation Lock on managed device to be bypassed. Default, is Null (Non-Default property) for this property when returned as part of managedDevice entity in LIST call. Individual GET call with select query options is needed to retrieve actual values. Supports: $select. $Search is not supported. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivationLockBypassCode {
            get { return BackingStore?.Get<string?>("activationLockBypassCode"); }
            set { BackingStore?.Set("activationLockBypassCode", value); }
        }
#nullable restore
#else
        public string ActivationLockBypassCode {
            get { return BackingStore?.Get<string>("activationLockBypassCode"); }
            set { BackingStore?.Set("activationLockBypassCode", value); }
        }
#endif
        /// <summary>Android security patch level. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AndroidSecurityPatchLevel {
            get { return BackingStore?.Get<string?>("androidSecurityPatchLevel"); }
            set { BackingStore?.Set("androidSecurityPatchLevel", value); }
        }
#nullable restore
#else
        public string AndroidSecurityPatchLevel {
            get { return BackingStore?.Get<string>("androidSecurityPatchLevel"); }
            set { BackingStore?.Set("androidSecurityPatchLevel", value); }
        }
#endif
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureADDeviceId {
            get { return BackingStore?.Get<string?>("azureADDeviceId"); }
            set { BackingStore?.Set("azureADDeviceId", value); }
        }
#nullable restore
#else
        public string AzureADDeviceId {
            get { return BackingStore?.Get<string>("azureADDeviceId"); }
            set { BackingStore?.Set("azureADDeviceId", value); }
        }
#endif
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AzureADRegistered {
            get { return BackingStore?.Get<bool?>("azureADRegistered"); }
            set { BackingStore?.Set("azureADRegistered", value); }
        }
        /// <summary>The DateTime when device compliance grace period expires. This property is read-only.</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("complianceGracePeriodExpirationDateTime"); }
            set { BackingStore?.Set("complianceGracePeriodExpirationDateTime", value); }
        }
        /// <summary>Compliance state.</summary>
        public Microsoft.Graph.Models.ComplianceState? ComplianceState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ComplianceState?>("complianceState"); }
            set { BackingStore?.Set("complianceState", value); }
        }
        /// <summary>ConfigrMgr client enabled features. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures? ConfigurationManagerClientEnabledFeatures {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures?>("configurationManagerClientEnabledFeatures"); }
            set { BackingStore?.Set("configurationManagerClientEnabledFeatures", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures>("configurationManagerClientEnabledFeatures"); }
            set { BackingStore?.Set("configurationManagerClientEnabledFeatures", value); }
        }
#endif
        /// <summary>List of ComplexType deviceActionResult objects. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceActionResult>? DeviceActionResults {
            get { return BackingStore?.Get<List<DeviceActionResult>?>("deviceActionResults"); }
            set { BackingStore?.Set("deviceActionResults", value); }
        }
#nullable restore
#else
        public List<DeviceActionResult> DeviceActionResults {
            get { return BackingStore?.Get<List<DeviceActionResult>>("deviceActionResults"); }
            set { BackingStore?.Set("deviceActionResults", value); }
        }
#endif
        /// <summary>Device category</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DeviceCategory? DeviceCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceCategory?>("deviceCategory"); }
            set { BackingStore?.Set("deviceCategory", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DeviceCategory DeviceCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceCategory>("deviceCategory"); }
            set { BackingStore?.Set("deviceCategory", value); }
        }
#endif
        /// <summary>Device category display name. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceCategoryDisplayName {
            get { return BackingStore?.Get<string?>("deviceCategoryDisplayName"); }
            set { BackingStore?.Set("deviceCategoryDisplayName", value); }
        }
#nullable restore
#else
        public string DeviceCategoryDisplayName {
            get { return BackingStore?.Get<string>("deviceCategoryDisplayName"); }
            set { BackingStore?.Set("deviceCategoryDisplayName", value); }
        }
#endif
        /// <summary>Device compliance policy states for this device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicyState>? DeviceCompliancePolicyStates {
            get { return BackingStore?.Get<List<DeviceCompliancePolicyState>?>("deviceCompliancePolicyStates"); }
            set { BackingStore?.Set("deviceCompliancePolicyStates", value); }
        }
#nullable restore
#else
        public List<DeviceCompliancePolicyState> DeviceCompliancePolicyStates {
            get { return BackingStore?.Get<List<DeviceCompliancePolicyState>>("deviceCompliancePolicyStates"); }
            set { BackingStore?.Set("deviceCompliancePolicyStates", value); }
        }
#endif
        /// <summary>Device configuration states for this device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceConfigurationState>? DeviceConfigurationStates {
            get { return BackingStore?.Get<List<DeviceConfigurationState>?>("deviceConfigurationStates"); }
            set { BackingStore?.Set("deviceConfigurationStates", value); }
        }
#nullable restore
#else
        public List<DeviceConfigurationState> DeviceConfigurationStates {
            get { return BackingStore?.Get<List<DeviceConfigurationState>>("deviceConfigurationStates"); }
            set { BackingStore?.Set("deviceConfigurationStates", value); }
        }
#endif
        /// <summary>Possible ways of adding a mobile device to management.</summary>
        public Microsoft.Graph.Models.DeviceEnrollmentType? DeviceEnrollmentType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceEnrollmentType?>("deviceEnrollmentType"); }
            set { BackingStore?.Set("deviceEnrollmentType", value); }
        }
        /// <summary>The device health attestation state. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DeviceHealthAttestationState? DeviceHealthAttestationState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceHealthAttestationState?>("deviceHealthAttestationState"); }
            set { BackingStore?.Set("deviceHealthAttestationState", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DeviceHealthAttestationState DeviceHealthAttestationState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceHealthAttestationState>("deviceHealthAttestationState"); }
            set { BackingStore?.Set("deviceHealthAttestationState", value); }
        }
#endif
        /// <summary>Name of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>Device registration status.</summary>
        public Microsoft.Graph.Models.DeviceRegistrationState? DeviceRegistrationState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceRegistrationState?>("deviceRegistrationState"); }
            set { BackingStore?.Set("deviceRegistrationState", value); }
        }
        /// <summary>Whether the device is Exchange ActiveSync activated. This property is read-only.</summary>
        public bool? EasActivated {
            get { return BackingStore?.Get<bool?>("easActivated"); }
            set { BackingStore?.Set("easActivated", value); }
        }
        /// <summary>Exchange ActivationSync activation time of the device. This property is read-only.</summary>
        public DateTimeOffset? EasActivationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("easActivationDateTime"); }
            set { BackingStore?.Set("easActivationDateTime", value); }
        }
        /// <summary>Exchange ActiveSync Id of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EasDeviceId {
            get { return BackingStore?.Get<string?>("easDeviceId"); }
            set { BackingStore?.Set("easDeviceId", value); }
        }
#nullable restore
#else
        public string EasDeviceId {
            get { return BackingStore?.Get<string>("easDeviceId"); }
            set { BackingStore?.Set("easDeviceId", value); }
        }
#endif
        /// <summary>Email(s) for the user associated with the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress {
            get { return BackingStore?.Get<string?>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#nullable restore
#else
        public string EmailAddress {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#endif
        /// <summary>Enrollment time of the device. This property is read-only.</summary>
        public DateTimeOffset? EnrolledDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("enrolledDateTime"); }
            set { BackingStore?.Set("enrolledDateTime", value); }
        }
        /// <summary>Indicates Ethernet MAC Address of the device. Default, is Null (Non-Default property) for this property when returned as part of managedDevice entity. Individual get call with select query options is needed to retrieve actual values. Example: deviceManagement/managedDevices({managedDeviceId})?$select=ethernetMacAddress Supports: $select. $Search is not supported. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EthernetMacAddress {
            get { return BackingStore?.Get<string?>("ethernetMacAddress"); }
            set { BackingStore?.Set("ethernetMacAddress", value); }
        }
#nullable restore
#else
        public string EthernetMacAddress {
            get { return BackingStore?.Get<string>("ethernetMacAddress"); }
            set { BackingStore?.Set("ethernetMacAddress", value); }
        }
#endif
        /// <summary>Device Exchange Access State.</summary>
        public DeviceManagementExchangeAccessState? ExchangeAccessState {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessState?>("exchangeAccessState"); }
            set { BackingStore?.Set("exchangeAccessState", value); }
        }
        /// <summary>Device Exchange Access State Reason.</summary>
        public DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessStateReason?>("exchangeAccessStateReason"); }
            set { BackingStore?.Set("exchangeAccessStateReason", value); }
        }
        /// <summary>Last time the device contacted Exchange. This property is read-only.</summary>
        public DateTimeOffset? ExchangeLastSuccessfulSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("exchangeLastSuccessfulSyncDateTime"); }
            set { BackingStore?.Set("exchangeLastSuccessfulSyncDateTime", value); }
        }
        /// <summary>Free Storage in Bytes. Default value is 0. Read-only. This property is read-only.</summary>
        public long? FreeStorageSpaceInBytes {
            get { return BackingStore?.Get<long?>("freeStorageSpaceInBytes"); }
            set { BackingStore?.Set("freeStorageSpaceInBytes", value); }
        }
        /// <summary>Integrated Circuit Card Identifier, it is A SIM card&apos;s unique identification number. Return default value null in LIST managedDevices. Real value only returned in singel device GET call with device id and included in select parameter. Supports: $select. $Search is not supported. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Iccid {
            get { return BackingStore?.Get<string?>("iccid"); }
            set { BackingStore?.Set("iccid", value); }
        }
#nullable restore
#else
        public string Iccid {
            get { return BackingStore?.Get<string>("iccid"); }
            set { BackingStore?.Set("iccid", value); }
        }
#endif
        /// <summary>IMEI. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Imei {
            get { return BackingStore?.Get<string?>("imei"); }
            set { BackingStore?.Set("imei", value); }
        }
#nullable restore
#else
        public string Imei {
            get { return BackingStore?.Get<string>("imei"); }
            set { BackingStore?.Set("imei", value); }
        }
#endif
        /// <summary>Device encryption status. This property is read-only.</summary>
        public bool? IsEncrypted {
            get { return BackingStore?.Get<bool?>("isEncrypted"); }
            set { BackingStore?.Set("isEncrypted", value); }
        }
        /// <summary>Device supervised status. This property is read-only.</summary>
        public bool? IsSupervised {
            get { return BackingStore?.Get<bool?>("isSupervised"); }
            set { BackingStore?.Set("isSupervised", value); }
        }
        /// <summary>whether the device is jail broken or rooted. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JailBroken {
            get { return BackingStore?.Get<string?>("jailBroken"); }
            set { BackingStore?.Set("jailBroken", value); }
        }
#nullable restore
#else
        public string JailBroken {
            get { return BackingStore?.Get<string>("jailBroken"); }
            set { BackingStore?.Set("jailBroken", value); }
        }
#endif
        /// <summary>The date and time that the device last completed a successful sync with Intune. This property is read-only.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>Automatically generated name to identify a device. Can be overwritten to a user friendly name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceName {
            get { return BackingStore?.Get<string?>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
#nullable restore
#else
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
#endif
        /// <summary>Owner type of device.</summary>
        public Microsoft.Graph.Models.ManagedDeviceOwnerType? ManagedDeviceOwnerType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ManagedDeviceOwnerType?>("managedDeviceOwnerType"); }
            set { BackingStore?.Set("managedDeviceOwnerType", value); }
        }
        /// <summary>The managementAgent property</summary>
        public ManagementAgentType? ManagementAgent {
            get { return BackingStore?.Get<ManagementAgentType?>("managementAgent"); }
            set { BackingStore?.Set("managementAgent", value); }
        }
        /// <summary>Reports device management certificate expiration date. This property is read-only.</summary>
        public DateTimeOffset? ManagementCertificateExpirationDate {
            get { return BackingStore?.Get<DateTimeOffset?>("managementCertificateExpirationDate"); }
            set { BackingStore?.Set("managementCertificateExpirationDate", value); }
        }
        /// <summary>Manufacturer of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>MEID. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Meid {
            get { return BackingStore?.Get<string?>("meid"); }
            set { BackingStore?.Set("meid", value); }
        }
#nullable restore
#else
        public string Meid {
            get { return BackingStore?.Get<string>("meid"); }
            set { BackingStore?.Set("meid", value); }
        }
#endif
        /// <summary>Model of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>Notes on the device created by IT Admin. Return default value null in LIST managedDevices. Real value only returned in singel device GET call with device id and included in select parameter. Supports: $select.  $Search is not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes {
            get { return BackingStore?.Get<string?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public string Notes {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>Operating system of the device. Windows, iOS, etc. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem {
            get { return BackingStore?.Get<string?>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#nullable restore
#else
        public string OperatingSystem {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#endif
        /// <summary>Operating system version of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>Available health states for the Device Health API</summary>
        public ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState {
            get { return BackingStore?.Get<ManagedDevicePartnerReportedHealthState?>("partnerReportedThreatState"); }
            set { BackingStore?.Set("partnerReportedThreatState", value); }
        }
        /// <summary>Phone number of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber {
            get { return BackingStore?.Get<string?>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#nullable restore
#else
        public string PhoneNumber {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#endif
        /// <summary>Total Memory in Bytes. Return default value 0 in LIST managedDevices. Real value only returned in singel device GET call with device id and included in select parameter. Supports: $select. Default value is 0. Read-only. This property is read-only.</summary>
        public long? PhysicalMemoryInBytes {
            get { return BackingStore?.Get<long?>("physicalMemoryInBytes"); }
            set { BackingStore?.Set("physicalMemoryInBytes", value); }
        }
        /// <summary>An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteAssistanceSessionErrorDetails {
            get { return BackingStore?.Get<string?>("remoteAssistanceSessionErrorDetails"); }
            set { BackingStore?.Set("remoteAssistanceSessionErrorDetails", value); }
        }
#nullable restore
#else
        public string RemoteAssistanceSessionErrorDetails {
            get { return BackingStore?.Get<string>("remoteAssistanceSessionErrorDetails"); }
            set { BackingStore?.Set("remoteAssistanceSessionErrorDetails", value); }
        }
#endif
        /// <summary>Url that allows a Remote Assistance session to be established with the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteAssistanceSessionUrl {
            get { return BackingStore?.Get<string?>("remoteAssistanceSessionUrl"); }
            set { BackingStore?.Set("remoteAssistanceSessionUrl", value); }
        }
#nullable restore
#else
        public string RemoteAssistanceSessionUrl {
            get { return BackingStore?.Get<string>("remoteAssistanceSessionUrl"); }
            set { BackingStore?.Set("remoteAssistanceSessionUrl", value); }
        }
#endif
        /// <summary>Reports if the managed iOS device is user approval enrollment. This property is read-only.</summary>
        public bool? RequireUserEnrollmentApproval {
            get { return BackingStore?.Get<bool?>("requireUserEnrollmentApproval"); }
            set { BackingStore?.Set("requireUserEnrollmentApproval", value); }
        }
        /// <summary>SerialNumber. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>Subscriber Carrier. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriberCarrier {
            get { return BackingStore?.Get<string?>("subscriberCarrier"); }
            set { BackingStore?.Set("subscriberCarrier", value); }
        }
#nullable restore
#else
        public string SubscriberCarrier {
            get { return BackingStore?.Get<string>("subscriberCarrier"); }
            set { BackingStore?.Set("subscriberCarrier", value); }
        }
#endif
        /// <summary>Total Storage in Bytes. This property is read-only.</summary>
        public long? TotalStorageSpaceInBytes {
            get { return BackingStore?.Get<long?>("totalStorageSpaceInBytes"); }
            set { BackingStore?.Set("totalStorageSpaceInBytes", value); }
        }
        /// <summary>Unique Device Identifier for iOS and macOS devices. Return default value null in LIST managedDevices. Real value only returned in singel device GET call with device id and included in select parameter. Supports: $select. $Search is not supported. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Udid {
            get { return BackingStore?.Get<string?>("udid"); }
            set { BackingStore?.Set("udid", value); }
        }
#nullable restore
#else
        public string Udid {
            get { return BackingStore?.Get<string>("udid"); }
            set { BackingStore?.Set("udid", value); }
        }
#endif
        /// <summary>User display name. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>Unique Identifier for the user associated with the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>Device user principal name. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>The primary users associated with the managed device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<User>? Users {
            get { return BackingStore?.Get<List<User>?>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#nullable restore
#else
        public List<User> Users {
            get { return BackingStore?.Get<List<User>>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#endif
        /// <summary>Wi-Fi MAC. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WiFiMacAddress {
            get { return BackingStore?.Get<string?>("wiFiMacAddress"); }
            set { BackingStore?.Set("wiFiMacAddress", value); }
        }
#nullable restore
#else
        public string WiFiMacAddress {
            get { return BackingStore?.Get<string>("wiFiMacAddress"); }
            set { BackingStore?.Set("wiFiMacAddress", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activationLockBypassCode", n => { ActivationLockBypassCode = n.GetStringValue(); } },
                {"androidSecurityPatchLevel", n => { AndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"azureADDeviceId", n => { AzureADDeviceId = n.GetStringValue(); } },
                {"azureADRegistered", n => { AzureADRegistered = n.GetBoolValue(); } },
                {"complianceGracePeriodExpirationDateTime", n => { ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"complianceState", n => { ComplianceState = n.GetEnumValue<ComplianceState>(); } },
                {"configurationManagerClientEnabledFeatures", n => { ConfigurationManagerClientEnabledFeatures = n.GetObjectValue<Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures>(Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures.CreateFromDiscriminatorValue); } },
                {"deviceActionResults", n => { DeviceActionResults = n.GetCollectionOfObjectValues<DeviceActionResult>(DeviceActionResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCategory", n => { DeviceCategory = n.GetObjectValue<Microsoft.Graph.Models.DeviceCategory>(Microsoft.Graph.Models.DeviceCategory.CreateFromDiscriminatorValue); } },
                {"deviceCategoryDisplayName", n => { DeviceCategoryDisplayName = n.GetStringValue(); } },
                {"deviceCompliancePolicyStates", n => { DeviceCompliancePolicyStates = n.GetCollectionOfObjectValues<DeviceCompliancePolicyState>(DeviceCompliancePolicyState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurationStates", n => { DeviceConfigurationStates = n.GetCollectionOfObjectValues<DeviceConfigurationState>(DeviceConfigurationState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceEnrollmentType", n => { DeviceEnrollmentType = n.GetEnumValue<DeviceEnrollmentType>(); } },
                {"deviceHealthAttestationState", n => { DeviceHealthAttestationState = n.GetObjectValue<Microsoft.Graph.Models.DeviceHealthAttestationState>(Microsoft.Graph.Models.DeviceHealthAttestationState.CreateFromDiscriminatorValue); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceRegistrationState", n => { DeviceRegistrationState = n.GetEnumValue<DeviceRegistrationState>(); } },
                {"easActivated", n => { EasActivated = n.GetBoolValue(); } },
                {"easActivationDateTime", n => { EasActivationDateTime = n.GetDateTimeOffsetValue(); } },
                {"easDeviceId", n => { EasDeviceId = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"enrolledDateTime", n => { EnrolledDateTime = n.GetDateTimeOffsetValue(); } },
                {"ethernetMacAddress", n => { EthernetMacAddress = n.GetStringValue(); } },
                {"exchangeAccessState", n => { ExchangeAccessState = n.GetEnumValue<DeviceManagementExchangeAccessState>(); } },
                {"exchangeAccessStateReason", n => { ExchangeAccessStateReason = n.GetEnumValue<DeviceManagementExchangeAccessStateReason>(); } },
                {"exchangeLastSuccessfulSyncDateTime", n => { ExchangeLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"freeStorageSpaceInBytes", n => { FreeStorageSpaceInBytes = n.GetLongValue(); } },
                {"iccid", n => { Iccid = n.GetStringValue(); } },
                {"imei", n => { Imei = n.GetStringValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"isSupervised", n => { IsSupervised = n.GetBoolValue(); } },
                {"jailBroken", n => { JailBroken = n.GetStringValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"managedDeviceOwnerType", n => { ManagedDeviceOwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
                {"managementAgent", n => { ManagementAgent = n.GetEnumValue<ManagementAgentType>(); } },
                {"managementCertificateExpirationDate", n => { ManagementCertificateExpirationDate = n.GetDateTimeOffsetValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"meid", n => { Meid = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"partnerReportedThreatState", n => { PartnerReportedThreatState = n.GetEnumValue<ManagedDevicePartnerReportedHealthState>(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"physicalMemoryInBytes", n => { PhysicalMemoryInBytes = n.GetLongValue(); } },
                {"remoteAssistanceSessionErrorDetails", n => { RemoteAssistanceSessionErrorDetails = n.GetStringValue(); } },
                {"remoteAssistanceSessionUrl", n => { RemoteAssistanceSessionUrl = n.GetStringValue(); } },
                {"requireUserEnrollmentApproval", n => { RequireUserEnrollmentApproval = n.GetBoolValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"subscriberCarrier", n => { SubscriberCarrier = n.GetStringValue(); } },
                {"totalStorageSpaceInBytes", n => { TotalStorageSpaceInBytes = n.GetLongValue(); } },
                {"udid", n => { Udid = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<User>(User.CreateFromDiscriminatorValue)?.ToList(); } },
                {"wiFiMacAddress", n => { WiFiMacAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ComplianceState>("complianceState", ComplianceState);
            writer.WriteObjectValue<Microsoft.Graph.Models.DeviceCategory>("deviceCategory", DeviceCategory);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicyState>("deviceCompliancePolicyStates", DeviceCompliancePolicyStates);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationState>("deviceConfigurationStates", DeviceConfigurationStates);
            writer.WriteEnumValue<DeviceEnrollmentType>("deviceEnrollmentType", DeviceEnrollmentType);
            writer.WriteEnumValue<DeviceRegistrationState>("deviceRegistrationState", DeviceRegistrationState);
            writer.WriteEnumValue<DeviceManagementExchangeAccessState>("exchangeAccessState", ExchangeAccessState);
            writer.WriteEnumValue<DeviceManagementExchangeAccessStateReason>("exchangeAccessStateReason", ExchangeAccessStateReason);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteEnumValue<ManagedDeviceOwnerType>("managedDeviceOwnerType", ManagedDeviceOwnerType);
            writer.WriteEnumValue<ManagementAgentType>("managementAgent", ManagementAgent);
            writer.WriteStringValue("notes", Notes);
            writer.WriteEnumValue<ManagedDevicePartnerReportedHealthState>("partnerReportedThreatState", PartnerReportedThreatState);
            writer.WriteCollectionOfObjectValues<User>("users", Users);
        }
    }
}
