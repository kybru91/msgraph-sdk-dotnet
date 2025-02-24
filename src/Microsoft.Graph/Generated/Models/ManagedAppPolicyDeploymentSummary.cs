using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ManagedAppPolicyDeploymentSummary : Entity, IParsable {
        /// <summary>Not yet documented</summary>
        public int? ConfigurationDeployedUserCount {
            get { return BackingStore?.Get<int?>("configurationDeployedUserCount"); }
            set { BackingStore?.Set("configurationDeployedUserCount", value); }
        }
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppPolicyDeploymentSummaryPerApp>? ConfigurationDeploymentSummaryPerApp {
            get { return BackingStore?.Get<List<ManagedAppPolicyDeploymentSummaryPerApp>?>("configurationDeploymentSummaryPerApp"); }
            set { BackingStore?.Set("configurationDeploymentSummaryPerApp", value); }
        }
#nullable restore
#else
        public List<ManagedAppPolicyDeploymentSummaryPerApp> ConfigurationDeploymentSummaryPerApp {
            get { return BackingStore?.Get<List<ManagedAppPolicyDeploymentSummaryPerApp>>("configurationDeploymentSummaryPerApp"); }
            set { BackingStore?.Set("configurationDeploymentSummaryPerApp", value); }
        }
#endif
        /// <summary>Not yet documented</summary>
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
        /// <summary>Not yet documented</summary>
        public DateTimeOffset? LastRefreshTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshTime"); }
            set { BackingStore?.Set("lastRefreshTime", value); }
        }
        /// <summary>Version of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedAppPolicyDeploymentSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppPolicyDeploymentSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationDeployedUserCount", n => { ConfigurationDeployedUserCount = n.GetIntValue(); } },
                {"configurationDeploymentSummaryPerApp", n => { ConfigurationDeploymentSummaryPerApp = n.GetCollectionOfObjectValues<ManagedAppPolicyDeploymentSummaryPerApp>(ManagedAppPolicyDeploymentSummaryPerApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastRefreshTime", n => { LastRefreshTime = n.GetDateTimeOffsetValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("configurationDeployedUserCount", ConfigurationDeployedUserCount);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicyDeploymentSummaryPerApp>("configurationDeploymentSummaryPerApp", ConfigurationDeploymentSummaryPerApp);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastRefreshTime", LastRefreshTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
