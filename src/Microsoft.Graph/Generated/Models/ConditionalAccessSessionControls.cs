using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ConditionalAccessSessionControls : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Session control to enforce application restrictions. Only Exchange Online and Sharepoint Online support this session control.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApplicationEnforcedRestrictionsSessionControl? ApplicationEnforcedRestrictions {
            get { return BackingStore?.Get<ApplicationEnforcedRestrictionsSessionControl?>("applicationEnforcedRestrictions"); }
            set { BackingStore?.Set("applicationEnforcedRestrictions", value); }
        }
#nullable restore
#else
        public ApplicationEnforcedRestrictionsSessionControl ApplicationEnforcedRestrictions {
            get { return BackingStore?.Get<ApplicationEnforcedRestrictionsSessionControl>("applicationEnforcedRestrictions"); }
            set { BackingStore?.Set("applicationEnforcedRestrictions", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Session control to apply cloud app security.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudAppSecuritySessionControl? CloudAppSecurity {
            get { return BackingStore?.Get<CloudAppSecuritySessionControl?>("cloudAppSecurity"); }
            set { BackingStore?.Set("cloudAppSecurity", value); }
        }
#nullable restore
#else
        public CloudAppSecuritySessionControl CloudAppSecurity {
            get { return BackingStore?.Get<CloudAppSecuritySessionControl>("cloudAppSecurity"); }
            set { BackingStore?.Set("cloudAppSecurity", value); }
        }
#endif
        /// <summary>Session control that determines whether it is acceptable for Azure AD to extend existing sessions based on information collected prior to an outage or not.</summary>
        public bool? DisableResilienceDefaults {
            get { return BackingStore?.Get<bool?>("disableResilienceDefaults"); }
            set { BackingStore?.Set("disableResilienceDefaults", value); }
        }
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
        /// <summary>Session control to define whether to persist cookies or not. All apps should be selected for this session control to work correctly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PersistentBrowserSessionControl? PersistentBrowser {
            get { return BackingStore?.Get<PersistentBrowserSessionControl?>("persistentBrowser"); }
            set { BackingStore?.Set("persistentBrowser", value); }
        }
#nullable restore
#else
        public PersistentBrowserSessionControl PersistentBrowser {
            get { return BackingStore?.Get<PersistentBrowserSessionControl>("persistentBrowser"); }
            set { BackingStore?.Set("persistentBrowser", value); }
        }
#endif
        /// <summary>Session control to enforce signin frequency.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInFrequencySessionControl? SignInFrequency {
            get { return BackingStore?.Get<SignInFrequencySessionControl?>("signInFrequency"); }
            set { BackingStore?.Set("signInFrequency", value); }
        }
#nullable restore
#else
        public SignInFrequencySessionControl SignInFrequency {
            get { return BackingStore?.Get<SignInFrequencySessionControl>("signInFrequency"); }
            set { BackingStore?.Set("signInFrequency", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new conditionalAccessSessionControls and sets the default values.
        /// </summary>
        public ConditionalAccessSessionControls() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessSessionControls CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessSessionControls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationEnforcedRestrictions", n => { ApplicationEnforcedRestrictions = n.GetObjectValue<ApplicationEnforcedRestrictionsSessionControl>(ApplicationEnforcedRestrictionsSessionControl.CreateFromDiscriminatorValue); } },
                {"cloudAppSecurity", n => { CloudAppSecurity = n.GetObjectValue<CloudAppSecuritySessionControl>(CloudAppSecuritySessionControl.CreateFromDiscriminatorValue); } },
                {"disableResilienceDefaults", n => { DisableResilienceDefaults = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"persistentBrowser", n => { PersistentBrowser = n.GetObjectValue<PersistentBrowserSessionControl>(PersistentBrowserSessionControl.CreateFromDiscriminatorValue); } },
                {"signInFrequency", n => { SignInFrequency = n.GetObjectValue<SignInFrequencySessionControl>(SignInFrequencySessionControl.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApplicationEnforcedRestrictionsSessionControl>("applicationEnforcedRestrictions", ApplicationEnforcedRestrictions);
            writer.WriteObjectValue<CloudAppSecuritySessionControl>("cloudAppSecurity", CloudAppSecurity);
            writer.WriteBoolValue("disableResilienceDefaults", DisableResilienceDefaults);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<PersistentBrowserSessionControl>("persistentBrowser", PersistentBrowser);
            writer.WriteObjectValue<SignInFrequencySessionControl>("signInFrequency", SignInFrequency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
