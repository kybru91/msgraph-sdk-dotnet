using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ResourceSpecificPermissionGrant : DirectoryObject, IParsable {
        /// <summary>ID of the service principal of the Azure AD app that has been granted access. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientAppId {
            get { return BackingStore?.Get<string?>("clientAppId"); }
            set { BackingStore?.Set("clientAppId", value); }
        }
#nullable restore
#else
        public string ClientAppId {
            get { return BackingStore?.Get<string>("clientAppId"); }
            set { BackingStore?.Set("clientAppId", value); }
        }
#endif
        /// <summary>ID of the Azure AD app that has been granted access. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId {
            get { return BackingStore?.Get<string?>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
#nullable restore
#else
        public string ClientId {
            get { return BackingStore?.Get<string>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
#endif
        /// <summary>The name of the resource-specific permission. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Permission {
            get { return BackingStore?.Get<string?>("permission"); }
            set { BackingStore?.Set("permission", value); }
        }
#nullable restore
#else
        public string Permission {
            get { return BackingStore?.Get<string>("permission"); }
            set { BackingStore?.Set("permission", value); }
        }
#endif
        /// <summary>The type of permission. Possible values are: Application, Delegated. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PermissionType {
            get { return BackingStore?.Get<string?>("permissionType"); }
            set { BackingStore?.Set("permissionType", value); }
        }
#nullable restore
#else
        public string PermissionType {
            get { return BackingStore?.Get<string>("permissionType"); }
            set { BackingStore?.Set("permissionType", value); }
        }
#endif
        /// <summary>ID of the Azure AD app that is hosting the resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceAppId {
            get { return BackingStore?.Get<string?>("resourceAppId"); }
            set { BackingStore?.Set("resourceAppId", value); }
        }
#nullable restore
#else
        public string ResourceAppId {
            get { return BackingStore?.Get<string>("resourceAppId"); }
            set { BackingStore?.Set("resourceAppId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new resourceSpecificPermissionGrant and sets the default values.
        /// </summary>
        public ResourceSpecificPermissionGrant() : base() {
            OdataType = "#microsoft.graph.resourceSpecificPermissionGrant";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ResourceSpecificPermissionGrant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResourceSpecificPermissionGrant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clientAppId", n => { ClientAppId = n.GetStringValue(); } },
                {"clientId", n => { ClientId = n.GetStringValue(); } },
                {"permission", n => { Permission = n.GetStringValue(); } },
                {"permissionType", n => { PermissionType = n.GetStringValue(); } },
                {"resourceAppId", n => { ResourceAppId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clientAppId", ClientAppId);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("permission", Permission);
            writer.WriteStringValue("permissionType", PermissionType);
            writer.WriteStringValue("resourceAppId", ResourceAppId);
        }
    }
}
