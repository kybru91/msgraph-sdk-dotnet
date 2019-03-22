// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mac OSGeneral Device Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSGeneralDeviceConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets compliant apps list.
        /// List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppsList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> CompliantAppsList { get; set; }
    
        /// <summary>
        /// Gets or sets compliant app list type.
        /// List that is in the CompliantAppsList. Possible values are: none, appsInListCompliant, appsNotInListCompliant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppListType", Required = Newtonsoft.Json.Required.Default)]
        public AppListType? CompliantAppListType { get; set; }
    
        /// <summary>
        /// Gets or sets email in domain suffixes.
        /// An email address lacking a suffix that matches any of these strings will be considered out-of-domain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailInDomainSuffixes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> EmailInDomainSuffixes { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// Block simple passwords.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockSimple", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// Number of character sets a password must contain. Valid values 0 to 4
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumCharacterSetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum length of passwords.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity required before a password is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// Minutes of inactivity required before the screen times out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Type of password that is required. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Whether or not to require a password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
    }
}
