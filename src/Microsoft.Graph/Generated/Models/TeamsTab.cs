using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class TeamsTab : Entity, IParsable {
        /// <summary>Container for custom settings applied to a tab. The tab is considered configured only once this property is set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamsTabConfiguration? Configuration {
            get { return BackingStore?.Get<TeamsTabConfiguration?>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#nullable restore
#else
        public TeamsTabConfiguration Configuration {
            get { return BackingStore?.Get<TeamsTabConfiguration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#endif
        /// <summary>Name of the tab.</summary>
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
        /// <summary>The application that is linked to the tab. This cannot be changed after tab creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.TeamsApp? TeamsApp {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TeamsApp?>("teamsApp"); }
            set { BackingStore?.Set("teamsApp", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.TeamsApp TeamsApp {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TeamsApp>("teamsApp"); }
            set { BackingStore?.Set("teamsApp", value); }
        }
#endif
        /// <summary>Deep link URL of the tab instance. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamsTab CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsTab();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configuration", n => { Configuration = n.GetObjectValue<TeamsTabConfiguration>(TeamsTabConfiguration.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"teamsApp", n => { TeamsApp = n.GetObjectValue<Microsoft.Graph.Models.TeamsApp>(Microsoft.Graph.Models.TeamsApp.CreateFromDiscriminatorValue); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamsTabConfiguration>("configuration", Configuration);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Models.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
