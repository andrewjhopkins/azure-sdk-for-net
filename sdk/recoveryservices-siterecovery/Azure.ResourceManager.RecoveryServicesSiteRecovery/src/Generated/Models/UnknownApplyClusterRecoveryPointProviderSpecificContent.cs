// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Unknown version of ApplyClusterRecoveryPointProviderSpecificInput. </summary>
    internal partial class UnknownApplyClusterRecoveryPointProviderSpecificContent : ApplyClusterRecoveryPointProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownApplyClusterRecoveryPointProviderSpecificContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownApplyClusterRecoveryPointProviderSpecificContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownApplyClusterRecoveryPointProviderSpecificContent"/> for deserialization. </summary>
        internal UnknownApplyClusterRecoveryPointProviderSpecificContent()
        {
        }
    }
}
