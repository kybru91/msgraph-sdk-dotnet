using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UnifiedRoleManagementPolicy : Entity, IParsable {
        /// <summary>Description for the policy.</summary>
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
        /// <summary>Display name for the policy.</summary>
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
        /// <summary>The list of effective rules like approval rules and expiration rules evaluated based on inherited referenced rules. For example, if there is a tenant-wide policy to enforce enabling an approval rule, the effective rule will be to enable approval even if the policy has a rule to disable approval. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementPolicyRule>? EffectiveRules {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyRule>?>("effectiveRules"); }
            set { BackingStore?.Set("effectiveRules", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleManagementPolicyRule> EffectiveRules {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyRule>>("effectiveRules"); }
            set { BackingStore?.Set("effectiveRules", value); }
        }
#endif
        /// <summary>This can only be set to true for a single tenant-wide policy which will apply to all scopes and roles. Set the scopeId to / and scopeType to Directory. Supports $filter (eq, ne).</summary>
        public bool? IsOrganizationDefault {
            get { return BackingStore?.Get<bool?>("isOrganizationDefault"); }
            set { BackingStore?.Set("isOrganizationDefault", value); }
        }
        /// <summary>The identity who last modified the role setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? LastModifiedBy {
            get { return BackingStore?.Get<Identity?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public Identity LastModifiedBy {
            get { return BackingStore?.Get<Identity>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The time when the role setting was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The collection of rules like approval rules and expiration rules. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementPolicyRule>? Rules {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyRule>?>("rules"); }
            set { BackingStore?.Set("rules", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleManagementPolicyRule> Rules {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyRule>>("rules"); }
            set { BackingStore?.Set("rules", value); }
        }
#endif
        /// <summary>The identifier of the scope where the policy is created. Can be / for the tenant or a group ID. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeId {
            get { return BackingStore?.Get<string?>("scopeId"); }
            set { BackingStore?.Set("scopeId", value); }
        }
#nullable restore
#else
        public string ScopeId {
            get { return BackingStore?.Get<string>("scopeId"); }
            set { BackingStore?.Set("scopeId", value); }
        }
#endif
        /// <summary>The type of the scope where the policy is created. One of Directory, DirectoryRole. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeType {
            get { return BackingStore?.Get<string?>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#nullable restore
#else
        public string ScopeType {
            get { return BackingStore?.Get<string>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"effectiveRules", n => { EffectiveRules = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>(UnifiedRoleManagementPolicyRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isOrganizationDefault", n => { IsOrganizationDefault = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"rules", n => { Rules = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>(UnifiedRoleManagementPolicyRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"scopeId", n => { ScopeId = n.GetStringValue(); } },
                {"scopeType", n => { ScopeType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>("effectiveRules", EffectiveRules);
            writer.WriteBoolValue("isOrganizationDefault", IsOrganizationDefault);
            writer.WriteObjectValue<Identity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>("rules", Rules);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}
