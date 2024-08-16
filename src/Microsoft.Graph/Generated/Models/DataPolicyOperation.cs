// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class DataPolicyOperation : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents when the request for this data policy operation was completed, in UTC time, using the ISO 8601 format. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Null until the operation completes.</summary>
        public DateTimeOffset? CompletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>Specifies the progress of an operation.</summary>
        public double? Progress
        {
            get { return BackingStore?.Get<double?>("progress"); }
            set { BackingStore?.Set("progress", value); }
        }
        /// <summary>Possible values are: notStarted, running, complete, failed, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.DataPolicyOperationStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DataPolicyOperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The URL location to where data is being exported for export requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StorageLocation
        {
            get { return BackingStore?.Get<string?>("storageLocation"); }
            set { BackingStore?.Set("storageLocation", value); }
        }
#nullable restore
#else
        public string StorageLocation
        {
            get { return BackingStore?.Get<string>("storageLocation"); }
            set { BackingStore?.Set("storageLocation", value); }
        }
#endif
        /// <summary>Represents when the request for this data operation was submitted, in UTC time, using the ISO 8601 format. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? SubmittedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("submittedDateTime"); }
            set { BackingStore?.Set("submittedDateTime", value); }
        }
        /// <summary>The id for the user on whom the operation is performed.</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.DataPolicyOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.DataPolicyOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.DataPolicyOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "progress", n => { Progress = n.GetDoubleValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Models.DataPolicyOperationStatus>(); } },
                { "storageLocation", n => { StorageLocation = n.GetStringValue(); } },
                { "submittedDateTime", n => { SubmittedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteDoubleValue("progress", Progress);
            writer.WriteEnumValue<Microsoft.Graph.Models.DataPolicyOperationStatus>("status", Status);
            writer.WriteStringValue("storageLocation", StorageLocation);
            writer.WriteDateTimeOffsetValue("submittedDateTime", SubmittedDateTime);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
