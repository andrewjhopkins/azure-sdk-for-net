// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Unknown version of RestoreRequest. </summary>
    internal partial class UnknownRestoreRequest : RestoreContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRestoreRequest"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuardOperationRequests on which LAC check will be performed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRestoreRequest(string objectType, IList<string> resourceGuardOperationRequests, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(objectType, resourceGuardOperationRequests, serializedAdditionalRawData)
        {
            ObjectType = objectType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRestoreRequest"/> for deserialization. </summary>
        internal UnknownRestoreRequest()
        {
        }
    }
}
