using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Possible values for prompting user for samples submission.</summary>
    public enum DefenderPromptForSampleSubmission {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Always prompt.</summary>
        [EnumMember(Value = "alwaysPrompt")]
        AlwaysPrompt,
        /// <summary>Send safe samples automatically.</summary>
        [EnumMember(Value = "promptBeforeSendingPersonalData")]
        PromptBeforeSendingPersonalData,
        /// <summary>Never send data.</summary>
        [EnumMember(Value = "neverSendData")]
        NeverSendData,
        /// <summary>Send all data without prompting.</summary>
        [EnumMember(Value = "sendAllDataWithoutPrompting")]
        SendAllDataWithoutPrompting,
    }
}
