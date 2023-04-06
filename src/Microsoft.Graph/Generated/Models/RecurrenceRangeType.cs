using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum RecurrenceRangeType {
        [EnumMember(Value = "endDate")]
        EndDate,
        [EnumMember(Value = "noEnd")]
        NoEnd,
        [EnumMember(Value = "numbered")]
        Numbered,
    }
}
