using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class SharedDriveItem : BaseItem, IParsable {
        /// <summary>Used to access the underlying driveItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DriveItem? DriveItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DriveItem?>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DriveItem DriveItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DriveItem>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#endif
        /// <summary>All driveItems contained in the sharing root. This collection cannot be enumerated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.DriveItem>? Items {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.DriveItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.DriveItem> Items {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.DriveItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>Used to access the underlying list</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.List? List {
            get { return BackingStore?.Get<Microsoft.Graph.Models.List?>("list"); }
            set { BackingStore?.Set("list", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.List List {
            get { return BackingStore?.Get<Microsoft.Graph.Models.List>("list"); }
            set { BackingStore?.Set("list", value); }
        }
#endif
        /// <summary>Used to access the underlying listItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ListItem? ListItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ListItem?>("listItem"); }
            set { BackingStore?.Set("listItem", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ListItem ListItem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ListItem>("listItem"); }
            set { BackingStore?.Set("listItem", value); }
        }
#endif
        /// <summary>Information about the owner of the shared item being referenced.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Owner {
            get { return BackingStore?.Get<IdentitySet?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public IdentitySet Owner {
            get { return BackingStore?.Get<IdentitySet>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>Used to access the permission representing the underlying sharing link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Permission? Permission {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Permission?>("permission"); }
            set { BackingStore?.Set("permission", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Permission Permission {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Permission>("permission"); }
            set { BackingStore?.Set("permission", value); }
        }
#endif
        /// <summary>Used to access the underlying driveItem. Deprecated -- use driveItem instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DriveItem? Root {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DriveItem?>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DriveItem Root {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DriveItem>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#endif
        /// <summary>Used to access the underlying site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Site? Site {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Site?>("site"); }
            set { BackingStore?.Set("site", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Site Site {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Site>("site"); }
            set { BackingStore?.Set("site", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new SharedDriveItem and sets the default values.
        /// </summary>
        public SharedDriveItem() : base() {
            OdataType = "#microsoft.graph.sharedDriveItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharedDriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedDriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"driveItem", n => { DriveItem = n.GetObjectValue<Microsoft.Graph.Models.DriveItem>(Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.DriveItem>(Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"list", n => { List = n.GetObjectValue<Microsoft.Graph.Models.List>(Microsoft.Graph.Models.List.CreateFromDiscriminatorValue); } },
                {"listItem", n => { ListItem = n.GetObjectValue<Microsoft.Graph.Models.ListItem>(Microsoft.Graph.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"permission", n => { Permission = n.GetObjectValue<Microsoft.Graph.Models.Permission>(Microsoft.Graph.Models.Permission.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<Microsoft.Graph.Models.DriveItem>(Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"site", n => { Site = n.GetObjectValue<Microsoft.Graph.Models.Site>(Microsoft.Graph.Models.Site.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.DriveItem>("items", Items);
            writer.WriteObjectValue<Microsoft.Graph.Models.List>("list", List);
            writer.WriteObjectValue<Microsoft.Graph.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteObjectValue<Microsoft.Graph.Models.Permission>("permission", Permission);
            writer.WriteObjectValue<Microsoft.Graph.Models.DriveItem>("root", Root);
            writer.WriteObjectValue<Microsoft.Graph.Models.Site>("site", Site);
        }
    }
}
