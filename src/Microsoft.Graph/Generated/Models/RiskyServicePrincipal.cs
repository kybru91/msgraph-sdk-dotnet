using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class RiskyServicePrincipal : Entity, IParsable {
        /// <summary>The globally unique identifier for the associated application (its appId property), if any.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>The display name for the service principal.</summary>
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
        /// <summary>Represents the risk history of Azure AD service principals.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RiskyServicePrincipalHistoryItem>? History {
            get { return BackingStore?.Get<List<RiskyServicePrincipalHistoryItem>?>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#nullable restore
#else
        public List<RiskyServicePrincipalHistoryItem> History {
            get { return BackingStore?.Get<List<RiskyServicePrincipalHistoryItem>>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#endif
        /// <summary>true if the service principal account is enabled; otherwise, false.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Indicates whether Azure AD is currently processing the service principal&apos;s risky state.</summary>
        public bool? IsProcessing {
            get { return BackingStore?.Get<bool?>("isProcessing"); }
            set { BackingStore?.Set("isProcessing", value); }
        }
        /// <summary>Details of the detected risk. Note: Details for this property are only available for Workload Identities Premium customers. Events in tenants without this license will be returned hidden. The possible values are: none, hidden,  unknownFutureValue, adminConfirmedServicePrincipalCompromised, adminDismissedAllRiskForServicePrincipal. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: adminConfirmedServicePrincipalCompromised , adminDismissedAllRiskForServicePrincipal.</summary>
        public Microsoft.Graph.Models.RiskDetail? RiskDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RiskDetail?>("riskDetail"); }
            set { BackingStore?.Set("riskDetail", value); }
        }
        /// <summary>The date and time that the risk state was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2021 is 2021-01-01T00:00:00Z. Supports $filter (eq).</summary>
        public DateTimeOffset? RiskLastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("riskLastUpdatedDateTime"); }
            set { BackingStore?.Set("riskLastUpdatedDateTime", value); }
        }
        /// <summary>Level of the detected risky workload identity. The possible values are: low, medium, high, hidden, none, unknownFutureValue. Supports $filter (eq).</summary>
        public Microsoft.Graph.Models.RiskLevel? RiskLevel {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RiskLevel?>("riskLevel"); }
            set { BackingStore?.Set("riskLevel", value); }
        }
        /// <summary>State of the service principal&apos;s risk. The possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.RiskState? RiskState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RiskState?>("riskState"); }
            set { BackingStore?.Set("riskState", value); }
        }
        /// <summary>Identifies whether the service principal represents an Application, a ManagedIdentity, or a legacy application (socialIdp). This is set by Azure AD internally and is inherited from servicePrincipal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalType {
            get { return BackingStore?.Get<string?>("servicePrincipalType"); }
            set { BackingStore?.Set("servicePrincipalType", value); }
        }
#nullable restore
#else
        public string ServicePrincipalType {
            get { return BackingStore?.Get<string>("servicePrincipalType"); }
            set { BackingStore?.Set("servicePrincipalType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RiskyServicePrincipal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.riskyServicePrincipalHistoryItem" => new RiskyServicePrincipalHistoryItem(),
                _ => new RiskyServicePrincipal(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"history", n => { History = n.GetCollectionOfObjectValues<RiskyServicePrincipalHistoryItem>(RiskyServicePrincipalHistoryItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"isProcessing", n => { IsProcessing = n.GetBoolValue(); } },
                {"riskDetail", n => { RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskLastUpdatedDateTime", n => { RiskLastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskLevel", n => { RiskLevel = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", n => { RiskState = n.GetEnumValue<RiskState>(); } },
                {"servicePrincipalType", n => { ServicePrincipalType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<RiskyServicePrincipalHistoryItem>("history", History);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isProcessing", IsProcessing);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteDateTimeOffsetValue("riskLastUpdatedDateTime", RiskLastUpdatedDateTime);
            writer.WriteEnumValue<RiskLevel>("riskLevel", RiskLevel);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteStringValue("servicePrincipalType", ServicePrincipalType);
        }
    }
}
