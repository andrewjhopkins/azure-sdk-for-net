// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    internal class SapDiscoveryServerInstanceOperationSource : IOperationSource<SapDiscoveryServerInstanceResource>
    {
        private readonly ArmClient _client;

        internal SapDiscoveryServerInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapDiscoveryServerInstanceResource IOperationSource<SapDiscoveryServerInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SapDiscoveryServerInstanceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMigrationDiscoverySapContext.Default);
            return new SapDiscoveryServerInstanceResource(_client, data);
        }

        async ValueTask<SapDiscoveryServerInstanceResource> IOperationSource<SapDiscoveryServerInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SapDiscoveryServerInstanceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMigrationDiscoverySapContext.Default);
            return await Task.FromResult(new SapDiscoveryServerInstanceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
