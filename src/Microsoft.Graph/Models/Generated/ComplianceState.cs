// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ComplianceState.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ComplianceState
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// compliant
        /// </summary>
        Compliant = 1,
	
        /// <summary>
        /// noncompliant
        /// </summary>
        Noncompliant = 2,
	
        /// <summary>
        /// conflict
        /// </summary>
        Conflict = 3,
	
        /// <summary>
        /// error
        /// </summary>
        Error = 4,
	
        /// <summary>
        /// in Grace Period
        /// </summary>
        InGracePeriod = 254,
	
        /// <summary>
        /// config Manager
        /// </summary>
        ConfigManager = 255,
	
    }
}