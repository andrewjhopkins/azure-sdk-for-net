// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The secrets related to a databox job.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataBox")]
    public partial class DataboxJobSecrets : JobSecrets
    {
        /// <summary>
        /// Initializes a new instance of the DataboxJobSecrets class.
        /// </summary>
        public DataboxJobSecrets()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataboxJobSecrets class.
        /// </summary>
        /// <param name="podSecrets">Contains the list of secret objects for a
        /// job.</param>
        public DataboxJobSecrets(IList<DataBoxSecret> podSecrets = default(IList<DataBoxSecret>))
        {
            PodSecrets = podSecrets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets contains the list of secret objects for a job.
        /// </summary>
        [JsonProperty(PropertyName = "podSecrets")]
        public IList<DataBoxSecret> PodSecrets { get; set; }

    }
}