using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class WorkbookChartAxes : Entity, IParsable {
        /// <summary>Represents the category axis in a chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartAxis? CategoryAxis {
            get { return BackingStore?.Get<WorkbookChartAxis?>("categoryAxis"); }
            set { BackingStore?.Set("categoryAxis", value); }
        }
#nullable restore
#else
        public WorkbookChartAxis CategoryAxis {
            get { return BackingStore?.Get<WorkbookChartAxis>("categoryAxis"); }
            set { BackingStore?.Set("categoryAxis", value); }
        }
#endif
        /// <summary>Represents the series axis of a 3-dimensional chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartAxis? SeriesAxis {
            get { return BackingStore?.Get<WorkbookChartAxis?>("seriesAxis"); }
            set { BackingStore?.Set("seriesAxis", value); }
        }
#nullable restore
#else
        public WorkbookChartAxis SeriesAxis {
            get { return BackingStore?.Get<WorkbookChartAxis>("seriesAxis"); }
            set { BackingStore?.Set("seriesAxis", value); }
        }
#endif
        /// <summary>Represents the value axis in an axis. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartAxis? ValueAxis {
            get { return BackingStore?.Get<WorkbookChartAxis?>("valueAxis"); }
            set { BackingStore?.Set("valueAxis", value); }
        }
#nullable restore
#else
        public WorkbookChartAxis ValueAxis {
            get { return BackingStore?.Get<WorkbookChartAxis>("valueAxis"); }
            set { BackingStore?.Set("valueAxis", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookChartAxes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartAxes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categoryAxis", n => { CategoryAxis = n.GetObjectValue<WorkbookChartAxis>(WorkbookChartAxis.CreateFromDiscriminatorValue); } },
                {"seriesAxis", n => { SeriesAxis = n.GetObjectValue<WorkbookChartAxis>(WorkbookChartAxis.CreateFromDiscriminatorValue); } },
                {"valueAxis", n => { ValueAxis = n.GetObjectValue<WorkbookChartAxis>(WorkbookChartAxis.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartAxis>("categoryAxis", CategoryAxis);
            writer.WriteObjectValue<WorkbookChartAxis>("seriesAxis", SeriesAxis);
            writer.WriteObjectValue<WorkbookChartAxis>("valueAxis", ValueAxis);
        }
    }
}
