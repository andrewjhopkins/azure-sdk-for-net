// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing an ExpressRouteCircuitConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ExpressRouteCircuitConnectionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetExpressRouteCircuitConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ExpressRouteCircuitPeeringResource"/> using the GetExpressRouteCircuitConnection method.
    /// </summary>
    public partial class ExpressRouteCircuitConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExpressRouteCircuitConnectionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="circuitName"> The circuitName. </param>
        /// <param name="peeringName"> The peeringName. </param>
        /// <param name="connectionName"> The connectionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string circuitName, string peeringName, string connectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _expressRouteCircuitConnectionClientDiagnostics;
        private readonly ExpressRouteCircuitConnectionsRestOperations _expressRouteCircuitConnectionRestClient;
        private readonly ExpressRouteCircuitConnectionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteCircuits/peerings/connections";

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnectionResource"/> class for mocking. </summary>
        protected ExpressRouteCircuitConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExpressRouteCircuitConnectionResource(ArmClient client, ExpressRouteCircuitConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExpressRouteCircuitConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCircuitConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string expressRouteCircuitConnectionApiVersion);
            _expressRouteCircuitConnectionRestClient = new ExpressRouteCircuitConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteCircuitConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExpressRouteCircuitConnectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified Express Route Circuit Connection from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCircuitConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Express Route Circuit Connection from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified Express Route Circuit Connection from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified Express Route Circuit Connection from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a Express Route Circuit Connection in the specified express route circuits.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCircuitConnectionResource>> UpdateAsync(WaitUntil waitUntil, ExpressRouteCircuitConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuitConnectionResource>(new ExpressRouteCircuitConnectionOperationSource(Client), _expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a Express Route Circuit Connection in the specified express route circuits.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuitConnectionResource> Update(WaitUntil waitUntil, ExpressRouteCircuitConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuitConnectionResource>(new ExpressRouteCircuitConnectionOperationSource(Client), _expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
