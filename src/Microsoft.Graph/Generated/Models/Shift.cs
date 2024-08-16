// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class Shift : Microsoft.Graph.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Draft changes in the shift. Draft changes are only visible to managers. The changes are visible to employees when they are shared, which copies the changes from the draftShift to the sharedShift property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ShiftItem? DraftShift
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ShiftItem?>("draftShift"); }
            set { BackingStore?.Set("draftShift", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ShiftItem DraftShift
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ShiftItem>("draftShift"); }
            set { BackingStore?.Set("draftShift", value); }
        }
#endif
        /// <summary>ID of the scheduling group the shift is part of. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchedulingGroupId
        {
            get { return BackingStore?.Get<string?>("schedulingGroupId"); }
            set { BackingStore?.Set("schedulingGroupId", value); }
        }
#nullable restore
#else
        public string SchedulingGroupId
        {
            get { return BackingStore?.Get<string>("schedulingGroupId"); }
            set { BackingStore?.Set("schedulingGroupId", value); }
        }
#endif
        /// <summary>The shared version of this shift that is viewable by both employees and managers. Updates to the sharedShift property send notifications to users in the Teams client.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ShiftItem? SharedShift
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ShiftItem?>("sharedShift"); }
            set { BackingStore?.Set("sharedShift", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ShiftItem SharedShift
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ShiftItem>("sharedShift"); }
            set { BackingStore?.Set("sharedShift", value); }
        }
#endif
        /// <summary>ID of the user assigned to the shift. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.Shift"/> and sets the default values.
        /// </summary>
        public Shift() : base()
        {
            OdataType = "#microsoft.graph.shift";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Shift"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.Shift CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.Shift();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "draftShift", n => { DraftShift = n.GetObjectValue<Microsoft.Graph.Models.ShiftItem>(Microsoft.Graph.Models.ShiftItem.CreateFromDiscriminatorValue); } },
                { "schedulingGroupId", n => { SchedulingGroupId = n.GetStringValue(); } },
                { "sharedShift", n => { SharedShift = n.GetObjectValue<Microsoft.Graph.Models.ShiftItem>(Microsoft.Graph.Models.ShiftItem.CreateFromDiscriminatorValue); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.ShiftItem>("draftShift", DraftShift);
            writer.WriteStringValue("schedulingGroupId", SchedulingGroupId);
            writer.WriteObjectValue<Microsoft.Graph.Models.ShiftItem>("sharedShift", SharedShift);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
