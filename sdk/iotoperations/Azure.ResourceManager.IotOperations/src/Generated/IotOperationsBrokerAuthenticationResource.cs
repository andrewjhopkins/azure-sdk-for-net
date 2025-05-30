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

namespace Azure.ResourceManager.IotOperations
{
    /// <summary>
    /// A Class representing an IotOperationsBrokerAuthentication along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="IotOperationsBrokerAuthenticationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetIotOperationsBrokerAuthenticationResource method.
    /// Otherwise you can get one from its parent resource <see cref="IotOperationsBrokerResource"/> using the GetIotOperationsBrokerAuthentication method.
    /// </summary>
    public partial class IotOperationsBrokerAuthenticationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IotOperationsBrokerAuthenticationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="instanceName"> The instanceName. </param>
        /// <param name="brokerName"> The brokerName. </param>
        /// <param name="authenticationName"> The authenticationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authenticationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}/authentications/{authenticationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics;
        private readonly BrokerAuthenticationRestOperations _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient;
        private readonly IotOperationsBrokerAuthenticationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.IoTOperations/instances/brokers/authentications";

        /// <summary> Initializes a new instance of the <see cref="IotOperationsBrokerAuthenticationResource"/> class for mocking. </summary>
        protected IotOperationsBrokerAuthenticationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotOperationsBrokerAuthenticationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IotOperationsBrokerAuthenticationResource(ArmClient client, IotOperationsBrokerAuthenticationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IotOperationsBrokerAuthenticationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotOperationsBrokerAuthenticationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotOperations", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string iotOperationsBrokerAuthenticationBrokerAuthenticationApiVersion);
            _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient = new BrokerAuthenticationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotOperationsBrokerAuthenticationBrokerAuthenticationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IotOperationsBrokerAuthenticationData Data
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
        /// Get a BrokerAuthenticationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}/authentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerAuthenticationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotOperationsBrokerAuthenticationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics.CreateScope("IotOperationsBrokerAuthenticationResource.Get");
            scope.Start();
            try
            {
                var response = await _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotOperationsBrokerAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a BrokerAuthenticationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}/authentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerAuthenticationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotOperationsBrokerAuthenticationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics.CreateScope("IotOperationsBrokerAuthenticationResource.Get");
            scope.Start();
            try
            {
                var response = _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotOperationsBrokerAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a BrokerAuthenticationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}/authentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerAuthenticationResource_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics.CreateScope("IotOperationsBrokerAuthenticationResource.Delete");
            scope.Start();
            try
            {
                var response = await _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new IotOperationsArmOperation(_iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics, Pipeline, _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a BrokerAuthenticationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}/authentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerAuthenticationResource_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics.CreateScope("IotOperationsBrokerAuthenticationResource.Delete");
            scope.Start();
            try
            {
                var response = _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new IotOperationsArmOperation(_iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics, Pipeline, _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create a BrokerAuthenticationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}/authentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerAuthenticationResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IotOperationsBrokerAuthenticationResource>> UpdateAsync(WaitUntil waitUntil, IotOperationsBrokerAuthenticationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics.CreateScope("IotOperationsBrokerAuthenticationResource.Update");
            scope.Start();
            try
            {
                var response = await _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new IotOperationsArmOperation<IotOperationsBrokerAuthenticationResource>(new IotOperationsBrokerAuthenticationOperationSource(Client), _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics, Pipeline, _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a BrokerAuthenticationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}/authentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerAuthenticationResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IotOperationsBrokerAuthenticationResource> Update(WaitUntil waitUntil, IotOperationsBrokerAuthenticationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics.CreateScope("IotOperationsBrokerAuthenticationResource.Update");
            scope.Start();
            try
            {
                var response = _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new IotOperationsArmOperation<IotOperationsBrokerAuthenticationResource>(new IotOperationsBrokerAuthenticationOperationSource(Client), _iotOperationsBrokerAuthenticationBrokerAuthenticationClientDiagnostics, Pipeline, _iotOperationsBrokerAuthenticationBrokerAuthenticationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
