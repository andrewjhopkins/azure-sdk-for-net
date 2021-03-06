// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The integration service environment.
    /// </summary>
    public partial class IntegrationServiceEnvironment : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationServiceEnvironment
        /// class.
        /// </summary>
        public IntegrationServiceEnvironment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationServiceEnvironment
        /// class.
        /// </summary>
        /// <param name="id">The resource id.</param>
        /// <param name="name">Gets the resource name.</param>
        /// <param name="type">Gets the resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="properties">The integration service environment
        /// properties.</param>
        /// <param name="sku">The sku.</param>
        public IntegrationServiceEnvironment(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IntegrationServiceEnvironmentProperties properties = default(IntegrationServiceEnvironmentProperties), IntegrationServiceEnvironmentSku sku = default(IntegrationServiceEnvironmentSku))
            : base(id, name, type, location, tags)
        {
            Properties = properties;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the integration service environment properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IntegrationServiceEnvironmentProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public IntegrationServiceEnvironmentSku Sku { get; set; }

    }
}
