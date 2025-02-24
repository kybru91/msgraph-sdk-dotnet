using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class EducationSubmissionResource : Entity, IParsable {
        /// <summary>Pointer to the assignment from which this resource was copied. If this is null, the student uploaded the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentResourceUrl {
            get { return BackingStore?.Get<string?>("assignmentResourceUrl"); }
            set { BackingStore?.Set("assignmentResourceUrl", value); }
        }
#nullable restore
#else
        public string AssignmentResourceUrl {
            get { return BackingStore?.Get<string>("assignmentResourceUrl"); }
            set { BackingStore?.Set("assignmentResourceUrl", value); }
        }
#endif
        /// <summary>Resource object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationResource? Resource {
            get { return BackingStore?.Get<EducationResource?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public EducationResource Resource {
            get { return BackingStore?.Get<EducationResource>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationSubmissionResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSubmissionResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignmentResourceUrl", n => { AssignmentResourceUrl = n.GetStringValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<EducationResource>(EducationResource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignmentResourceUrl", AssignmentResourceUrl);
            writer.WriteObjectValue<EducationResource>("resource", Resource);
        }
    }
}
