using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class DelegatedAdminCustomer : Entity, IParsable {
        /// <summary>The Azure AD display name of the customer tenant. Read-only. Supports $orderBy.</summary>
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
        /// <summary>Contains the management details of a service in the customer tenant that&apos;s managed by delegated administration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminServiceManagementDetail>? ServiceManagementDetails {
            get { return BackingStore?.Get<List<DelegatedAdminServiceManagementDetail>?>("serviceManagementDetails"); }
            set { BackingStore?.Set("serviceManagementDetails", value); }
        }
#nullable restore
#else
        public List<DelegatedAdminServiceManagementDetail> ServiceManagementDetails {
            get { return BackingStore?.Get<List<DelegatedAdminServiceManagementDetail>>("serviceManagementDetails"); }
            set { BackingStore?.Set("serviceManagementDetails", value); }
        }
#endif
        /// <summary>The Azure AD-assigned tenant ID of the customer. Read-only.</summary>
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DelegatedAdminCustomer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminCustomer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"serviceManagementDetails", n => { ServiceManagementDetails = n.GetCollectionOfObjectValues<DelegatedAdminServiceManagementDetail>(DelegatedAdminServiceManagementDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DelegatedAdminServiceManagementDetail>("serviceManagementDetails", ServiceManagementDetails);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
