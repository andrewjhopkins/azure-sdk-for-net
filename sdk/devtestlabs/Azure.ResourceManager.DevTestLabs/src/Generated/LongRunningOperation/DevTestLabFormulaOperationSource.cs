// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs
{
    internal class DevTestLabFormulaOperationSource : IOperationSource<DevTestLabFormulaResource>
    {
        private readonly ArmClient _client;

        internal DevTestLabFormulaOperationSource(ArmClient client)
        {
            _client = client;
        }

        DevTestLabFormulaResource IOperationSource<DevTestLabFormulaResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevTestLabFormulaData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDevTestLabsContext.Default);
            return new DevTestLabFormulaResource(_client, data);
        }

        async ValueTask<DevTestLabFormulaResource> IOperationSource<DevTestLabFormulaResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevTestLabFormulaData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDevTestLabsContext.Default);
            return await Task.FromResult(new DevTestLabFormulaResource(_client, data)).ConfigureAwait(false);
        }
    }
}
