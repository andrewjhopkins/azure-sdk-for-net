// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class IPAllocationOperationSource : IOperationSource<IPAllocationResource>
    {
        private readonly ArmClient _client;

        internal IPAllocationOperationSource(ArmClient client)
        {
            _client = client;
        }

        IPAllocationResource IOperationSource<IPAllocationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<IPAllocationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return new IPAllocationResource(_client, data);
        }

        async ValueTask<IPAllocationResource> IOperationSource<IPAllocationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<IPAllocationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return await Task.FromResult(new IPAllocationResource(_client, data)).ConfigureAwait(false);
        }
    }
}
