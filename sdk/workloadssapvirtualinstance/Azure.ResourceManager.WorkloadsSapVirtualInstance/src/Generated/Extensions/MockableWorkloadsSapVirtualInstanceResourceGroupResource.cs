// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableWorkloadsSapVirtualInstanceResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableWorkloadsSapVirtualInstanceResourceGroupResource"/> class for mocking. </summary>
        protected MockableWorkloadsSapVirtualInstanceResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableWorkloadsSapVirtualInstanceResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableWorkloadsSapVirtualInstanceResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SapVirtualInstanceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SapVirtualInstanceResources and their operations over a SapVirtualInstanceResource. </returns>
        public virtual SapVirtualInstanceCollection GetSapVirtualInstances()
        {
            return GetCachedClient(client => new SapVirtualInstanceCollection(client, Id));
        }

        /// <summary>
        /// Gets a Virtual Instance for SAP solutions resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPVirtualInstance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapVirtualInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP solutions resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sapVirtualInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sapVirtualInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SapVirtualInstanceResource>> GetSapVirtualInstanceAsync(string sapVirtualInstanceName, CancellationToken cancellationToken = default)
        {
            return await GetSapVirtualInstances().GetAsync(sapVirtualInstanceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Virtual Instance for SAP solutions resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPVirtualInstance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapVirtualInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP solutions resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sapVirtualInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sapVirtualInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SapVirtualInstanceResource> GetSapVirtualInstance(string sapVirtualInstanceName, CancellationToken cancellationToken = default)
        {
            return GetSapVirtualInstances().Get(sapVirtualInstanceName, cancellationToken);
        }
    }
}
