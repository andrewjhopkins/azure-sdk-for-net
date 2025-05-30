// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SiteManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SiteManager.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEdgeSites_ListBySubscriptionGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2025-03-01-preview/SitesBySubscription_List_MaximumSet_Gen.json
            // this example is just showing the usage of "Site_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "0154f7fe-df09-4981-bf82-7ad5c1f596eb";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (EdgeSiteResource item in subscriptionResource.GetEdgeSitesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EdgeSiteData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSitesBySubscription_GetSiteSubscriptionGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2025-03-01-preview/SitesBySubscription_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Site_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "0154f7fe-df09-4981-bf82-7ad5c1f596eb";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            string siteName = "string";
            EdgeSiteResource result = await subscriptionResource.GetSitesBySubscriptionAsync(siteName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EdgeSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdateSitesBySubscription_CreateSiteSubscriptionGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2025-03-01-preview/SitesBySubscription_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "Site_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "0154f7fe-df09-4981-bf82-7ad5c1f596eb";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            string siteName = "string";
            EdgeSiteData data = new EdgeSiteData
            {
                Properties = new EdgeSiteProperties
                {
                    DisplayName = "string",
                    Description = "enxcmpvfvadbapo",
                    SiteAddress = new SiteAddressProperties
                    {
                        StreetAddress1 = "fodimymrxbhrfslsmzfhmitn",
                        StreetAddress2 = "widjg",
                        City = "zkcbzjkatafo",
                        StateOrProvince = "wk",
                        Country = "xeevcfvimlfzsfuxtyujw",
                        PostalCode = "qbrhqk",
                    },
                    Labels =
{
["key8188"] = "mcgnu"
},
                },
            };
            ArmOperation<EdgeSiteResource> lro = await subscriptionResource.CreateOrUpdateSitesBySubscriptionAsync(WaitUntil.Completed, siteName, data);
            EdgeSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EdgeSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateSitesBySubscription_PatchSiteSubscriptionGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2025-03-01-preview/SitesBySubscription_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "Site_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "0154f7fe-df09-4981-bf82-7ad5c1f596eb";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            string siteName = "string";
            EdgeSitePatch patch = new EdgeSitePatch
            {
                Properties = new EdgeSitePatchProperties
                {
                    DisplayName = "string",
                    Description = "zztr",
                    SiteAddress = new SiteAddressProperties
                    {
                        StreetAddress1 = "fodimymrxbhrfslsmzfhmitn",
                        StreetAddress2 = "widjg",
                        City = "zkcbzjkatafo",
                        StateOrProvince = "wk",
                        Country = "xeevcfvimlfzsfuxtyujw",
                        PostalCode = "qbrhqk",
                    },
                    Labels =
{
["key9939"] = "jdlzxcvcfqmruq"
},
                },
            };
            EdgeSiteResource result = await subscriptionResource.UpdateSitesBySubscriptionAsync(siteName, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EdgeSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DeleteSitesBySubscription_DeleteSiteSubscriptionGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2025-03-01-preview/SitesBySubscription_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "Site_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "0154f7fe-df09-4981-bf82-7ad5c1f596eb";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            string siteName = "string";
            await subscriptionResource.DeleteSitesBySubscriptionAsync(siteName);

            Console.WriteLine("Succeeded");
        }
    }
}
