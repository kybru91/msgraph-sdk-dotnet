using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ScopeOperatorMultiValuedComparisonType {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Any")]
        Any,
    }
}