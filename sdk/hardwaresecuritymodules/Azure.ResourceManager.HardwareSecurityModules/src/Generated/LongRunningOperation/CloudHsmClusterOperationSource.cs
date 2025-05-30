// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    internal class CloudHsmClusterOperationSource : IOperationSource<CloudHsmClusterResource>
    {
        private readonly ArmClient _client;

        internal CloudHsmClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        CloudHsmClusterResource IOperationSource<CloudHsmClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CloudHsmClusterData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHardwareSecurityModulesContext.Default);
            return new CloudHsmClusterResource(_client, data);
        }

        async ValueTask<CloudHsmClusterResource> IOperationSource<CloudHsmClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CloudHsmClusterData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerHardwareSecurityModulesContext.Default);
            return await Task.FromResult(new CloudHsmClusterResource(_client, data)).ConfigureAwait(false);
        }
    }
}
