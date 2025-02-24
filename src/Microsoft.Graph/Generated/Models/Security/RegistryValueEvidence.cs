using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.Security {
    public class RegistryValueEvidence : AlertEvidence, IParsable {
        /// <summary>Registry hive of the key that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryHive {
            get { return BackingStore?.Get<string?>("registryHive"); }
            set { BackingStore?.Set("registryHive", value); }
        }
#nullable restore
#else
        public string RegistryHive {
            get { return BackingStore?.Get<string>("registryHive"); }
            set { BackingStore?.Set("registryHive", value); }
        }
#endif
        /// <summary>Registry key that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryKey {
            get { return BackingStore?.Get<string?>("registryKey"); }
            set { BackingStore?.Set("registryKey", value); }
        }
#nullable restore
#else
        public string RegistryKey {
            get { return BackingStore?.Get<string>("registryKey"); }
            set { BackingStore?.Set("registryKey", value); }
        }
#endif
        /// <summary>Data of the registry value that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryValue {
            get { return BackingStore?.Get<string?>("registryValue"); }
            set { BackingStore?.Set("registryValue", value); }
        }
#nullable restore
#else
        public string RegistryValue {
            get { return BackingStore?.Get<string>("registryValue"); }
            set { BackingStore?.Set("registryValue", value); }
        }
#endif
        /// <summary>Name of the registry value that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryValueName {
            get { return BackingStore?.Get<string?>("registryValueName"); }
            set { BackingStore?.Set("registryValueName", value); }
        }
#nullable restore
#else
        public string RegistryValueName {
            get { return BackingStore?.Get<string>("registryValueName"); }
            set { BackingStore?.Set("registryValueName", value); }
        }
#endif
        /// <summary>Data type, such as binary or string, of the registry value that the recorded action was applied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistryValueType {
            get { return BackingStore?.Get<string?>("registryValueType"); }
            set { BackingStore?.Set("registryValueType", value); }
        }
#nullable restore
#else
        public string RegistryValueType {
            get { return BackingStore?.Get<string>("registryValueType"); }
            set { BackingStore?.Set("registryValueType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RegistryValueEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegistryValueEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"registryHive", n => { RegistryHive = n.GetStringValue(); } },
                {"registryKey", n => { RegistryKey = n.GetStringValue(); } },
                {"registryValue", n => { RegistryValue = n.GetStringValue(); } },
                {"registryValueName", n => { RegistryValueName = n.GetStringValue(); } },
                {"registryValueType", n => { RegistryValueType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("registryHive", RegistryHive);
            writer.WriteStringValue("registryKey", RegistryKey);
            writer.WriteStringValue("registryValue", RegistryValue);
            writer.WriteStringValue("registryValueName", RegistryValueName);
            writer.WriteStringValue("registryValueType", RegistryValueType);
        }
    }
}
