using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Pin Character Requirements</summary>
    public enum WindowsInformationProtectionPinCharacterRequirements {
        /// <summary>Not allow</summary>
        [EnumMember(Value = "notAllow")]
        NotAllow,
        /// <summary>Require atleast one</summary>
        [EnumMember(Value = "requireAtLeastOne")]
        RequireAtLeastOne,
        /// <summary>Allow any number</summary>
        [EnumMember(Value = "allow")]
        Allow,
    }
}
