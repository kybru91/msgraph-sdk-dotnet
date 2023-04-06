using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ConditionalAccessStatus {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "notApplied")]
        NotApplied,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
