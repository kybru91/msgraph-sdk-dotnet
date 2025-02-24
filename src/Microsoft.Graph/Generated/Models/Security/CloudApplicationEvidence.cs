using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.Security {
    public class CloudApplicationEvidence : AlertEvidence, IParsable {
        /// <summary>Unique identifier of the application.</summary>
        public long? AppId {
            get { return BackingStore?.Get<long?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
        /// <summary>Name of the application.</summary>
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
        /// <summary>Identifier of the instance of the Software as a Service (SaaS) application.</summary>
        public long? InstanceId {
            get { return BackingStore?.Get<long?>("instanceId"); }
            set { BackingStore?.Set("instanceId", value); }
        }
        /// <summary>Name of the instance of the SaaS application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstanceName {
            get { return BackingStore?.Get<string?>("instanceName"); }
            set { BackingStore?.Set("instanceName", value); }
        }
#nullable restore
#else
        public string InstanceName {
            get { return BackingStore?.Get<string>("instanceName"); }
            set { BackingStore?.Set("instanceName", value); }
        }
#endif
        /// <summary>The identifier of the SaaS application.</summary>
        public long? SaasAppId {
            get { return BackingStore?.Get<long?>("saasAppId"); }
            set { BackingStore?.Set("saasAppId", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudApplicationEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudApplicationEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appId", n => { AppId = n.GetLongValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"instanceId", n => { InstanceId = n.GetLongValue(); } },
                {"instanceName", n => { InstanceName = n.GetStringValue(); } },
                {"saasAppId", n => { SaasAppId = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("appId", AppId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteLongValue("instanceId", InstanceId);
            writer.WriteStringValue("instanceName", InstanceName);
            writer.WriteLongValue("saasAppId", SaasAppId);
        }
    }
}
