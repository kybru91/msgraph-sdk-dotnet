// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// The user experience analytics metric for work from anywhere report.
    /// </summary>
    public class UserExperienceAnalyticsWorkFromAnywhereMetric : Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>The work from anywhere metric devices. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereDevice>? MetricDevices
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereDevice>?>("metricDevices"); }
            set { BackingStore?.Set("metricDevices", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereDevice> MetricDevices
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereDevice>>("metricDevices"); }
            set { BackingStore?.Set("metricDevices", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereMetric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereMetric CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "metricDevices", n => { MetricDevices = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereDevice>(Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereDevice.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereDevice>("metricDevices", MetricDevices);
        }
    }
}
