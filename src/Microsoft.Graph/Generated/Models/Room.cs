using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Room : Place, IParsable {
        /// <summary>Specifies the name of the audio device in the room.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AudioDeviceName {
            get { return BackingStore?.Get<string?>("audioDeviceName"); }
            set { BackingStore?.Set("audioDeviceName", value); }
        }
#nullable restore
#else
        public string AudioDeviceName {
            get { return BackingStore?.Get<string>("audioDeviceName"); }
            set { BackingStore?.Set("audioDeviceName", value); }
        }
#endif
        /// <summary>Type of room. Possible values are standard, and reserved.</summary>
        public Microsoft.Graph.Models.BookingType? BookingType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.BookingType?>("bookingType"); }
            set { BackingStore?.Set("bookingType", value); }
        }
        /// <summary>Specifies the building name or building number that the room is in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Building {
            get { return BackingStore?.Get<string?>("building"); }
            set { BackingStore?.Set("building", value); }
        }
#nullable restore
#else
        public string Building {
            get { return BackingStore?.Get<string>("building"); }
            set { BackingStore?.Set("building", value); }
        }
#endif
        /// <summary>Specifies the capacity of the room.</summary>
        public int? Capacity {
            get { return BackingStore?.Get<int?>("capacity"); }
            set { BackingStore?.Set("capacity", value); }
        }
        /// <summary>Specifies the name of the display device in the room.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayDeviceName {
            get { return BackingStore?.Get<string?>("displayDeviceName"); }
            set { BackingStore?.Set("displayDeviceName", value); }
        }
#nullable restore
#else
        public string DisplayDeviceName {
            get { return BackingStore?.Get<string>("displayDeviceName"); }
            set { BackingStore?.Set("displayDeviceName", value); }
        }
#endif
        /// <summary>Email address of the room.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress {
            get { return BackingStore?.Get<string?>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#nullable restore
#else
        public string EmailAddress {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#endif
        /// <summary>Specifies a descriptive label for the floor, for example, P.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FloorLabel {
            get { return BackingStore?.Get<string?>("floorLabel"); }
            set { BackingStore?.Set("floorLabel", value); }
        }
#nullable restore
#else
        public string FloorLabel {
            get { return BackingStore?.Get<string>("floorLabel"); }
            set { BackingStore?.Set("floorLabel", value); }
        }
#endif
        /// <summary>Specifies the floor number that the room is on.</summary>
        public int? FloorNumber {
            get { return BackingStore?.Get<int?>("floorNumber"); }
            set { BackingStore?.Set("floorNumber", value); }
        }
        /// <summary>Specifies whether the room is wheelchair accessible.</summary>
        public bool? IsWheelChairAccessible {
            get { return BackingStore?.Get<bool?>("isWheelChairAccessible"); }
            set { BackingStore?.Set("isWheelChairAccessible", value); }
        }
        /// <summary>Specifies a descriptive label for the room, for example, a number or name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label {
            get { return BackingStore?.Get<string?>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#nullable restore
#else
        public string Label {
            get { return BackingStore?.Get<string>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#endif
        /// <summary>Specifies a nickname for the room, for example, &apos;conf room&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nickname {
            get { return BackingStore?.Get<string?>("nickname"); }
            set { BackingStore?.Set("nickname", value); }
        }
#nullable restore
#else
        public string Nickname {
            get { return BackingStore?.Get<string>("nickname"); }
            set { BackingStore?.Set("nickname", value); }
        }
#endif
        /// <summary>Specifies additional features of the room, for example, details like the type of view or furniture type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>Specifies the name of the video device in the room.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoDeviceName {
            get { return BackingStore?.Get<string?>("videoDeviceName"); }
            set { BackingStore?.Set("videoDeviceName", value); }
        }
#nullable restore
#else
        public string VideoDeviceName {
            get { return BackingStore?.Get<string>("videoDeviceName"); }
            set { BackingStore?.Set("videoDeviceName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Room and sets the default values.
        /// </summary>
        public Room() : base() {
            OdataType = "#microsoft.graph.room";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Room CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Room();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audioDeviceName", n => { AudioDeviceName = n.GetStringValue(); } },
                {"bookingType", n => { BookingType = n.GetEnumValue<BookingType>(); } },
                {"building", n => { Building = n.GetStringValue(); } },
                {"capacity", n => { Capacity = n.GetIntValue(); } },
                {"displayDeviceName", n => { DisplayDeviceName = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"floorLabel", n => { FloorLabel = n.GetStringValue(); } },
                {"floorNumber", n => { FloorNumber = n.GetIntValue(); } },
                {"isWheelChairAccessible", n => { IsWheelChairAccessible = n.GetBoolValue(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"nickname", n => { Nickname = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"videoDeviceName", n => { VideoDeviceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("audioDeviceName", AudioDeviceName);
            writer.WriteEnumValue<BookingType>("bookingType", BookingType);
            writer.WriteStringValue("building", Building);
            writer.WriteIntValue("capacity", Capacity);
            writer.WriteStringValue("displayDeviceName", DisplayDeviceName);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteStringValue("floorLabel", FloorLabel);
            writer.WriteIntValue("floorNumber", FloorNumber);
            writer.WriteBoolValue("isWheelChairAccessible", IsWheelChairAccessible);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("nickname", Nickname);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("videoDeviceName", VideoDeviceName);
        }
    }
}
