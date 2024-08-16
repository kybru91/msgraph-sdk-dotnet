// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class Fido2CombinationConfiguration : Microsoft.Graph.Models.AuthenticationCombinationConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A list of AAGUIDs allowed to be used as part of the specified authentication method combinations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedAAGUIDs
        {
            get { return BackingStore?.Get<List<string>?>("allowedAAGUIDs"); }
            set { BackingStore?.Set("allowedAAGUIDs", value); }
        }
#nullable restore
#else
        public List<string> AllowedAAGUIDs
        {
            get { return BackingStore?.Get<List<string>>("allowedAAGUIDs"); }
            set { BackingStore?.Set("allowedAAGUIDs", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.Fido2CombinationConfiguration"/> and sets the default values.
        /// </summary>
        public Fido2CombinationConfiguration() : base()
        {
            OdataType = "#microsoft.graph.fido2CombinationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Fido2CombinationConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.Fido2CombinationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.Fido2CombinationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedAAGUIDs", n => { AllowedAAGUIDs = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedAAGUIDs", AllowedAAGUIDs);
        }
    }
}
