// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ScVmm
{
    internal class ScVmmServerOperationSource : IOperationSource<ScVmmServerResource>
    {
        private readonly ArmClient _client;

        internal ScVmmServerOperationSource(ArmClient client)
        {
            _client = client;
        }

        ScVmmServerResource IOperationSource<ScVmmServerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ScVmmServerData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerScVmmContext.Default);
            return new ScVmmServerResource(_client, data);
        }

        async ValueTask<ScVmmServerResource> IOperationSource<ScVmmServerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ScVmmServerData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerScVmmContext.Default);
            return await Task.FromResult(new ScVmmServerResource(_client, data)).ConfigureAwait(false);
        }
    }
}
