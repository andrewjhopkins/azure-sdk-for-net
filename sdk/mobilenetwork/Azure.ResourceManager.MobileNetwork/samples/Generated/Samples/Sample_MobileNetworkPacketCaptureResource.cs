// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MobileNetwork.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MobileNetwork.Samples
{
    public partial class Sample_MobileNetworkPacketCaptureResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPacketCaptureSession()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCaptureGet.json
            // this example is just showing the usage of "PacketCaptures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MobileNetworkPacketCaptureResource created on azure
            // for more information of creating MobileNetworkPacketCaptureResource, please refer to the document of MobileNetworkPacketCaptureResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            string packetCaptureName = "pc1";
            ResourceIdentifier mobileNetworkPacketCaptureResourceId = MobileNetworkPacketCaptureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCaptureName);
            MobileNetworkPacketCaptureResource mobileNetworkPacketCapture = client.GetMobileNetworkPacketCaptureResource(mobileNetworkPacketCaptureResourceId);

            // invoke the operation
            MobileNetworkPacketCaptureResource result = await mobileNetworkPacketCapture.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MobileNetworkPacketCaptureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletePacketCapture()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCaptureDelete.json
            // this example is just showing the usage of "PacketCaptures_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MobileNetworkPacketCaptureResource created on azure
            // for more information of creating MobileNetworkPacketCaptureResource, please refer to the document of MobileNetworkPacketCaptureResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            string packetCaptureName = "pc1";
            ResourceIdentifier mobileNetworkPacketCaptureResourceId = MobileNetworkPacketCaptureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCaptureName);
            MobileNetworkPacketCaptureResource mobileNetworkPacketCapture = client.GetMobileNetworkPacketCaptureResource(mobileNetworkPacketCaptureResourceId);

            // invoke the operation
            await mobileNetworkPacketCapture.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatePacketCapture()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCaptureCreate.json
            // this example is just showing the usage of "PacketCaptures_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MobileNetworkPacketCaptureResource created on azure
            // for more information of creating MobileNetworkPacketCaptureResource, please refer to the document of MobileNetworkPacketCaptureResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            string packetCaptureName = "pc1";
            ResourceIdentifier mobileNetworkPacketCaptureResourceId = MobileNetworkPacketCaptureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCaptureName);
            MobileNetworkPacketCaptureResource mobileNetworkPacketCapture = client.GetMobileNetworkPacketCaptureResource(mobileNetworkPacketCaptureResourceId);

            // invoke the operation
            MobileNetworkPacketCaptureData data = new MobileNetworkPacketCaptureData
            {
                NetworkInterfaces = { "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/TestPacketCoreCP", "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/TestPacketCoreCP/packetCoreDataPlanes/TestPacketCoreDP", "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/TestPacketCoreCP/packetCoreDataPlanes/TestPacketCoreDP/attachedDataNetworks/TestADN" },
                BytesToCapturePerPacket = 10000L,
                TotalBytesPerSession = 100000L,
                TimeLimitInSeconds = 100,
            };
            ArmOperation<MobileNetworkPacketCaptureResource> lro = await mobileNetworkPacketCapture.UpdateAsync(WaitUntil.Completed, data);
            MobileNetworkPacketCaptureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MobileNetworkPacketCaptureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_StopPacketCaptureSession()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCaptureStop.json
            // this example is just showing the usage of "PacketCaptures_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MobileNetworkPacketCaptureResource created on azure
            // for more information of creating MobileNetworkPacketCaptureResource, please refer to the document of MobileNetworkPacketCaptureResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            string packetCaptureName = "pc1";
            ResourceIdentifier mobileNetworkPacketCaptureResourceId = MobileNetworkPacketCaptureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCaptureName);
            MobileNetworkPacketCaptureResource mobileNetworkPacketCapture = client.GetMobileNetworkPacketCaptureResource(mobileNetworkPacketCaptureResourceId);

            // invoke the operation
            ArmOperation<AsyncOperationStatus> lro = await mobileNetworkPacketCapture.StopAsync(WaitUntil.Completed);
            AsyncOperationStatus result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
