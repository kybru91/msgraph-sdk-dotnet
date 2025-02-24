using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UserSettings : Entity, IParsable {
        /// <summary>The contributionToContentDiscoveryAsOrganizationDisabled property</summary>
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled {
            get { return BackingStore?.Get<bool?>("contributionToContentDiscoveryAsOrganizationDisabled"); }
            set { BackingStore?.Set("contributionToContentDiscoveryAsOrganizationDisabled", value); }
        }
        /// <summary>The contributionToContentDiscoveryDisabled property</summary>
        public bool? ContributionToContentDiscoveryDisabled {
            get { return BackingStore?.Get<bool?>("contributionToContentDiscoveryDisabled"); }
            set { BackingStore?.Set("contributionToContentDiscoveryDisabled", value); }
        }
        /// <summary>The shiftPreferences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ShiftPreferences? ShiftPreferences {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ShiftPreferences?>("shiftPreferences"); }
            set { BackingStore?.Set("shiftPreferences", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ShiftPreferences ShiftPreferences {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ShiftPreferences>("shiftPreferences"); }
            set { BackingStore?.Set("shiftPreferences", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contributionToContentDiscoveryAsOrganizationDisabled", n => { ContributionToContentDiscoveryAsOrganizationDisabled = n.GetBoolValue(); } },
                {"contributionToContentDiscoveryDisabled", n => { ContributionToContentDiscoveryDisabled = n.GetBoolValue(); } },
                {"shiftPreferences", n => { ShiftPreferences = n.GetObjectValue<Microsoft.Graph.Models.ShiftPreferences>(Microsoft.Graph.Models.ShiftPreferences.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("contributionToContentDiscoveryAsOrganizationDisabled", ContributionToContentDiscoveryAsOrganizationDisabled);
            writer.WriteBoolValue("contributionToContentDiscoveryDisabled", ContributionToContentDiscoveryDisabled);
            writer.WriteObjectValue<Microsoft.Graph.Models.ShiftPreferences>("shiftPreferences", ShiftPreferences);
        }
    }
}
