using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ConnectedOrganizationMembers : SubjectSet, IParsable {
        /// <summary>The ID of the connected organization in entitlement management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectedOrganizationId {
            get { return BackingStore?.Get<string?>("connectedOrganizationId"); }
            set { BackingStore?.Set("connectedOrganizationId", value); }
        }
#nullable restore
#else
        public string ConnectedOrganizationId {
            get { return BackingStore?.Get<string>("connectedOrganizationId"); }
            set { BackingStore?.Set("connectedOrganizationId", value); }
        }
#endif
        /// <summary>The name of the connected organization.</summary>
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
        /// <summary>
        /// Instantiates a new ConnectedOrganizationMembers and sets the default values.
        /// </summary>
        public ConnectedOrganizationMembers() : base() {
            OdataType = "#microsoft.graph.connectedOrganizationMembers";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConnectedOrganizationMembers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectedOrganizationMembers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectedOrganizationId", n => { ConnectedOrganizationId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("connectedOrganizationId", ConnectedOrganizationId);
            writer.WriteStringValue("description", Description);
        }
    }
}
