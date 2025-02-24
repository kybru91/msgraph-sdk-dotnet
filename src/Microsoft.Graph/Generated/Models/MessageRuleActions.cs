using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class MessageRuleActions : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>A list of categories to be assigned to a message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AssignCategories {
            get { return BackingStore?.Get<List<string>?>("assignCategories"); }
            set { BackingStore?.Set("assignCategories", value); }
        }
#nullable restore
#else
        public List<string> AssignCategories {
            get { return BackingStore?.Get<List<string>>("assignCategories"); }
            set { BackingStore?.Set("assignCategories", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The ID of a folder that a message is to be copied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CopyToFolder {
            get { return BackingStore?.Get<string?>("copyToFolder"); }
            set { BackingStore?.Set("copyToFolder", value); }
        }
#nullable restore
#else
        public string CopyToFolder {
            get { return BackingStore?.Get<string>("copyToFolder"); }
            set { BackingStore?.Set("copyToFolder", value); }
        }
#endif
        /// <summary>Indicates whether a message should be moved to the Deleted Items folder.</summary>
        public bool? Delete {
            get { return BackingStore?.Get<bool?>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
        /// <summary>The email addresses of the recipients to which a message should be forwarded as an attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? ForwardAsAttachmentTo {
            get { return BackingStore?.Get<List<Recipient>?>("forwardAsAttachmentTo"); }
            set { BackingStore?.Set("forwardAsAttachmentTo", value); }
        }
#nullable restore
#else
        public List<Recipient> ForwardAsAttachmentTo {
            get { return BackingStore?.Get<List<Recipient>>("forwardAsAttachmentTo"); }
            set { BackingStore?.Set("forwardAsAttachmentTo", value); }
        }
#endif
        /// <summary>The email addresses of the recipients to which a message should be forwarded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? ForwardTo {
            get { return BackingStore?.Get<List<Recipient>?>("forwardTo"); }
            set { BackingStore?.Set("forwardTo", value); }
        }
#nullable restore
#else
        public List<Recipient> ForwardTo {
            get { return BackingStore?.Get<List<Recipient>>("forwardTo"); }
            set { BackingStore?.Set("forwardTo", value); }
        }
#endif
        /// <summary>Indicates whether a message should be marked as read.</summary>
        public bool? MarkAsRead {
            get { return BackingStore?.Get<bool?>("markAsRead"); }
            set { BackingStore?.Set("markAsRead", value); }
        }
        /// <summary>Sets the importance of the message, which can be: low, normal, high.</summary>
        public Importance? MarkImportance {
            get { return BackingStore?.Get<Importance?>("markImportance"); }
            set { BackingStore?.Set("markImportance", value); }
        }
        /// <summary>The ID of the folder that a message will be moved to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MoveToFolder {
            get { return BackingStore?.Get<string?>("moveToFolder"); }
            set { BackingStore?.Set("moveToFolder", value); }
        }
#nullable restore
#else
        public string MoveToFolder {
            get { return BackingStore?.Get<string>("moveToFolder"); }
            set { BackingStore?.Set("moveToFolder", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Indicates whether a message should be permanently deleted and not saved to the Deleted Items folder.</summary>
        public bool? PermanentDelete {
            get { return BackingStore?.Get<bool?>("permanentDelete"); }
            set { BackingStore?.Set("permanentDelete", value); }
        }
        /// <summary>The email addresses to which a message should be redirected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? RedirectTo {
            get { return BackingStore?.Get<List<Recipient>?>("redirectTo"); }
            set { BackingStore?.Set("redirectTo", value); }
        }
#nullable restore
#else
        public List<Recipient> RedirectTo {
            get { return BackingStore?.Get<List<Recipient>>("redirectTo"); }
            set { BackingStore?.Set("redirectTo", value); }
        }
#endif
        /// <summary>Indicates whether subsequent rules should be evaluated.</summary>
        public bool? StopProcessingRules {
            get { return BackingStore?.Get<bool?>("stopProcessingRules"); }
            set { BackingStore?.Set("stopProcessingRules", value); }
        }
        /// <summary>
        /// Instantiates a new messageRuleActions and sets the default values.
        /// </summary>
        public MessageRuleActions() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MessageRuleActions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageRuleActions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignCategories", n => { AssignCategories = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"copyToFolder", n => { CopyToFolder = n.GetStringValue(); } },
                {"delete", n => { Delete = n.GetBoolValue(); } },
                {"forwardAsAttachmentTo", n => { ForwardAsAttachmentTo = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"forwardTo", n => { ForwardTo = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"markAsRead", n => { MarkAsRead = n.GetBoolValue(); } },
                {"markImportance", n => { MarkImportance = n.GetEnumValue<Importance>(); } },
                {"moveToFolder", n => { MoveToFolder = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"permanentDelete", n => { PermanentDelete = n.GetBoolValue(); } },
                {"redirectTo", n => { RedirectTo = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"stopProcessingRules", n => { StopProcessingRules = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("assignCategories", AssignCategories);
            writer.WriteStringValue("copyToFolder", CopyToFolder);
            writer.WriteBoolValue("delete", Delete);
            writer.WriteCollectionOfObjectValues<Recipient>("forwardAsAttachmentTo", ForwardAsAttachmentTo);
            writer.WriteCollectionOfObjectValues<Recipient>("forwardTo", ForwardTo);
            writer.WriteBoolValue("markAsRead", MarkAsRead);
            writer.WriteEnumValue<Importance>("markImportance", MarkImportance);
            writer.WriteStringValue("moveToFolder", MoveToFolder);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("permanentDelete", PermanentDelete);
            writer.WriteCollectionOfObjectValues<Recipient>("redirectTo", RedirectTo);
            writer.WriteBoolValue("stopProcessingRules", StopProcessingRules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
