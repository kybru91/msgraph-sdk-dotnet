// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Audit Log Root.
    /// </summary>
    public partial class AuditLogRoot : Entity
    {
    
        /// <summary>
        /// Gets or sets directory audits.
        /// </summary>
        [JsonPropertyName("directoryAudits")]
        public IAuditLogRootDirectoryAuditsCollectionPage DirectoryAudits { get; set; }

        /// <summary>
        /// Gets or sets directoryAuditsNextLink.
        /// </summary>
        [JsonPropertyName("directoryAudits@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DirectoryAuditsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets provisioning.
        /// </summary>
        [JsonPropertyName("provisioning")]
        public IAuditLogRootProvisioningCollectionPage Provisioning { get; set; }

        /// <summary>
        /// Gets or sets provisioningNextLink.
        /// </summary>
        [JsonPropertyName("provisioning@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ProvisioningNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets restricted sign ins.
        /// </summary>
        [JsonPropertyName("restrictedSignIns")]
        public IAuditLogRootRestrictedSignInsCollectionPage RestrictedSignIns { get; set; }

        /// <summary>
        /// Gets or sets restrictedSignInsNextLink.
        /// </summary>
        [JsonPropertyName("restrictedSignIns@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RestrictedSignInsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sign ins.
        /// </summary>
        [JsonPropertyName("signIns")]
        public IAuditLogRootSignInsCollectionPage SignIns { get; set; }

        /// <summary>
        /// Gets or sets signInsNextLink.
        /// </summary>
        [JsonPropertyName("signIns@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SignInsNextLink { get; set; }
    
    }
}

