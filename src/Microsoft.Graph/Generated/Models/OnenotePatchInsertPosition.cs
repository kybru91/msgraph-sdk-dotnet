using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum OnenotePatchInsertPosition {
        [EnumMember(Value = "After")]
        After,
        [EnumMember(Value = "Before")]
        Before,
    }
}
