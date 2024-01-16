// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class EducationAssignmentSettings : Entity, IParsable {
        /// <summary>When set, enables users to weight assignments differently when computing a class average grade.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationGradingCategory>? GradingCategories {
            get { return BackingStore?.Get<List<EducationGradingCategory>?>("gradingCategories"); }
            set { BackingStore?.Set("gradingCategories", value); }
        }
#nullable restore
#else
        public List<EducationGradingCategory> GradingCategories {
            get { return BackingStore?.Get<List<EducationGradingCategory>>("gradingCategories"); }
            set { BackingStore?.Set("gradingCategories", value); }
        }
#endif
        /// <summary>Indicates whether to show the turn-in celebration animation. If true, indicates to skip the animation. The default value is false.</summary>
        public bool? SubmissionAnimationDisabled {
            get { return BackingStore?.Get<bool?>("submissionAnimationDisabled"); }
            set { BackingStore?.Set("submissionAnimationDisabled", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"gradingCategories", n => { GradingCategories = n.GetCollectionOfObjectValues<EducationGradingCategory>(EducationGradingCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"submissionAnimationDisabled", n => { SubmissionAnimationDisabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EducationGradingCategory>("gradingCategories", GradingCategories);
            writer.WriteBoolValue("submissionAnimationDisabled", SubmissionAnimationDisabled);
        }
    }
}
