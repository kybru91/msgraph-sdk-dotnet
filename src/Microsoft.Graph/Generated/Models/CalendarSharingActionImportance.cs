using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum CalendarSharingActionImportance {
        [EnumMember(Value = "primary")]
        Primary,
        [EnumMember(Value = "secondary")]
        Secondary,
    }
}
