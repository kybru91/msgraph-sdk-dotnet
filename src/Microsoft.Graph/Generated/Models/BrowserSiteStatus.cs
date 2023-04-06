using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum BrowserSiteStatus {
        /// <summary>A site that has been published</summary>
        [EnumMember(Value = "published")]
        Published,
        /// <summary>A site that has been added pending publish</summary>
        [EnumMember(Value = "pendingAdd")]
        PendingAdd,
        /// <summary>A site that has been edited pending publish</summary>
        [EnumMember(Value = "pendingEdit")]
        PendingEdit,
        /// <summary>A site that has been deleted pending publish</summary>
        [EnumMember(Value = "pendingDelete")]
        PendingDelete,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
