// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Cdn
{
    internal class FrontDoorRuleOperationSource : IOperationSource<FrontDoorRuleResource>
    {
        private readonly ArmClient _client;

        internal FrontDoorRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        FrontDoorRuleResource IOperationSource<FrontDoorRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FrontDoorRuleData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCdnContext.Default);
            return new FrontDoorRuleResource(_client, data);
        }

        async ValueTask<FrontDoorRuleResource> IOperationSource<FrontDoorRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FrontDoorRuleData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCdnContext.Default);
            return await Task.FromResult(new FrontDoorRuleResource(_client, data)).ConfigureAwait(false);
        }
    }
}
