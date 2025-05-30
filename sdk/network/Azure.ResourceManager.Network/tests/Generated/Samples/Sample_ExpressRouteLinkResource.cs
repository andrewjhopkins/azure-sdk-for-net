// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRouteLinkResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ExpressRouteLinkGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/ExpressRouteLinkGet.json
            // this example is just showing the usage of "ExpressRouteLinks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteLinkResource created on azure
            // for more information of creating ExpressRouteLinkResource, please refer to the document of ExpressRouteLinkResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "portName";
            string linkName = "linkName";
            ResourceIdentifier expressRouteLinkResourceId = ExpressRouteLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName, linkName);
            ExpressRouteLinkResource expressRouteLink = client.GetExpressRouteLinkResource(expressRouteLinkResourceId);

            // invoke the operation
            ExpressRouteLinkResource result = await expressRouteLink.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
