using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class OnPremisesDirectorySynchronization : Entity, IParsable {
        /// <summary>Consists of configurations that can be fine-tuned and impact the on-premises directory synchronization process for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesDirectorySynchronizationConfiguration? Configuration {
            get { return BackingStore?.Get<OnPremisesDirectorySynchronizationConfiguration?>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#nullable restore
#else
        public OnPremisesDirectorySynchronizationConfiguration Configuration {
            get { return BackingStore?.Get<OnPremisesDirectorySynchronizationConfiguration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#endif
        /// <summary>The features property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesDirectorySynchronizationFeature? Features {
            get { return BackingStore?.Get<OnPremisesDirectorySynchronizationFeature?>("features"); }
            set { BackingStore?.Set("features", value); }
        }
#nullable restore
#else
        public OnPremisesDirectorySynchronizationFeature Features {
            get { return BackingStore?.Get<OnPremisesDirectorySynchronizationFeature>("features"); }
            set { BackingStore?.Set("features", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnPremisesDirectorySynchronization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesDirectorySynchronization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configuration", n => { Configuration = n.GetObjectValue<OnPremisesDirectorySynchronizationConfiguration>(OnPremisesDirectorySynchronizationConfiguration.CreateFromDiscriminatorValue); } },
                {"features", n => { Features = n.GetObjectValue<OnPremisesDirectorySynchronizationFeature>(OnPremisesDirectorySynchronizationFeature.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnPremisesDirectorySynchronizationConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<OnPremisesDirectorySynchronizationFeature>("features", Features);
        }
    }
}
