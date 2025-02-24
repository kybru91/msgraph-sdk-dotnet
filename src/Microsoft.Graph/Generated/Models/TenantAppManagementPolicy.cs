using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class TenantAppManagementPolicy : PolicyBase, IParsable {
        /// <summary>The applicationRestrictions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppManagementConfiguration? ApplicationRestrictions {
            get { return BackingStore?.Get<AppManagementConfiguration?>("applicationRestrictions"); }
            set { BackingStore?.Set("applicationRestrictions", value); }
        }
#nullable restore
#else
        public AppManagementConfiguration ApplicationRestrictions {
            get { return BackingStore?.Get<AppManagementConfiguration>("applicationRestrictions"); }
            set { BackingStore?.Set("applicationRestrictions", value); }
        }
#endif
        /// <summary>The isEnabled property</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>The servicePrincipalRestrictions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppManagementConfiguration? ServicePrincipalRestrictions {
            get { return BackingStore?.Get<AppManagementConfiguration?>("servicePrincipalRestrictions"); }
            set { BackingStore?.Set("servicePrincipalRestrictions", value); }
        }
#nullable restore
#else
        public AppManagementConfiguration ServicePrincipalRestrictions {
            get { return BackingStore?.Get<AppManagementConfiguration>("servicePrincipalRestrictions"); }
            set { BackingStore?.Set("servicePrincipalRestrictions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new TenantAppManagementPolicy and sets the default values.
        /// </summary>
        public TenantAppManagementPolicy() : base() {
            OdataType = "#microsoft.graph.tenantAppManagementPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TenantAppManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantAppManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationRestrictions", n => { ApplicationRestrictions = n.GetObjectValue<AppManagementConfiguration>(AppManagementConfiguration.CreateFromDiscriminatorValue); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"servicePrincipalRestrictions", n => { ServicePrincipalRestrictions = n.GetObjectValue<AppManagementConfiguration>(AppManagementConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AppManagementConfiguration>("applicationRestrictions", ApplicationRestrictions);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<AppManagementConfiguration>("servicePrincipalRestrictions", ServicePrincipalRestrictions);
        }
    }
}
