using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Contains all supported Powershell Script output detection type.</summary>
    public enum Win32LobAppPowerShellScriptRuleOperationType {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Output data type is string.</summary>
        [EnumMember(Value = "string")]
        String,
        /// <summary>Output data type is date time.</summary>
        [EnumMember(Value = "dateTime")]
        DateTime,
        /// <summary>Output data type is integer.</summary>
        [EnumMember(Value = "integer")]
        Integer,
        /// <summary>Output data type is float.</summary>
        [EnumMember(Value = "float")]
        Float,
        /// <summary>Output data type is version.</summary>
        [EnumMember(Value = "version")]
        Version,
        /// <summary>Output data type is boolean.</summary>
        [EnumMember(Value = "boolean")]
        Boolean,
    }
}
