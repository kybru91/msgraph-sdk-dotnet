using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class TeamworkTag : Entity, IParsable {
        /// <summary>The description of the tag as it will appear to the user in Microsoft Teams.</summary>
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
        /// <summary>The name of the tag as it will appear to the user in Microsoft Teams.</summary>
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
        /// <summary>The number of users assigned to the tag.</summary>
        public int? MemberCount {
            get { return BackingStore?.Get<int?>("memberCount"); }
            set { BackingStore?.Set("memberCount", value); }
        }
        /// <summary>Users assigned to the tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkTagMember>? Members {
            get { return BackingStore?.Get<List<TeamworkTagMember>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<TeamworkTagMember> Members {
            get { return BackingStore?.Get<List<TeamworkTagMember>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>The type of the tag. Default is standard.</summary>
        public TeamworkTagType? TagType {
            get { return BackingStore?.Get<TeamworkTagType?>("tagType"); }
            set { BackingStore?.Set("tagType", value); }
        }
        /// <summary>ID of the team in which the tag is defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamId {
            get { return BackingStore?.Get<string?>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
#nullable restore
#else
        public string TeamId {
            get { return BackingStore?.Get<string>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamworkTag CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkTag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"memberCount", n => { MemberCount = n.GetIntValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<TeamworkTagMember>(TeamworkTagMember.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tagType", n => { TagType = n.GetEnumValue<TeamworkTagType>(); } },
                {"teamId", n => { TeamId = n.GetStringValue(); } },
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
            writer.WriteIntValue("memberCount", MemberCount);
            writer.WriteCollectionOfObjectValues<TeamworkTagMember>("members", Members);
            writer.WriteEnumValue<TeamworkTagType>("tagType", TagType);
            writer.WriteStringValue("teamId", TeamId);
        }
    }
}
