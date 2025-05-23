// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_AppServiceDomainCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAppServiceDomain()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2024-11-01/examples/CreateAppServiceDomain.json
            // this example is just showing the usage of "Domains_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppServiceDomainResource
            AppServiceDomainCollection collection = resourceGroupResource.GetAppServiceDomains();

            // invoke the operation
            string domainName = "example.com";
            AppServiceDomainData data = new AppServiceDomainData(new AzureLocation("global"))
            {
                ContactAdmin = new RegistrationContactInfo("admin@email.com", "John", "Doe", "1-245-534-2242")
                {
                    AddressMailing = new RegistrationAddressInfo("3400 State St", "Chicago", "United States", "67098", "IL"),
                    Fax = "1-245-534-2242",
                    JobTitle = "Admin",
                    NameMiddle = "",
                    Organization = "Microsoft Inc.",
                },
                ContactBilling = new RegistrationContactInfo("billing@email.com", "John", "Doe", "1-245-534-2242")
                {
                    AddressMailing = new RegistrationAddressInfo("3400 State St", "Chicago", "United States", "67098", "IL"),
                    Fax = "1-245-534-2242",
                    JobTitle = "Billing",
                    NameMiddle = "",
                    Organization = "Microsoft Inc.",
                },
                ContactRegistrant = new RegistrationContactInfo("registrant@email.com", "John", "Doe", "1-245-534-2242")
                {
                    AddressMailing = new RegistrationAddressInfo("3400 State St", "Chicago", "United States", "67098", "IL"),
                    Fax = "1-245-534-2242",
                    JobTitle = "Registrant",
                    NameMiddle = "",
                    Organization = "Microsoft Inc.",
                },
                ContactTech = new RegistrationContactInfo("tech@email.com", "John", "Doe", "1-245-534-2242")
                {
                    AddressMailing = new RegistrationAddressInfo("3400 State St", "Chicago", "United States", "67098", "IL"),
                    Fax = "1-245-534-2242",
                    JobTitle = "Tech",
                    NameMiddle = "",
                    Organization = "Microsoft Inc.",
                },
                IsDomainPrivacyEnabled = false,
                IsAutoRenew = true,
                Consent = new DomainPurchaseConsent
                {
                    AgreementKeys = { "agreementKey1" },
                    AgreedBy = "192.0.2.1",
                    AgreedOn = DateTimeOffset.Parse("2021-09-10T19:30:53Z"),
                },
                DnsType = AppServiceDnsType.DefaultDomainRegistrarDns,
                AuthCode = "exampleAuthCode",
                Tags = { },
            };
            ArmOperation<AppServiceDomainResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, domainName, data);
            AppServiceDomainResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDomain()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2024-11-01/examples/GetDomain.json
            // this example is just showing the usage of "Domains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppServiceDomainResource
            AppServiceDomainCollection collection = resourceGroupResource.GetAppServiceDomains();

            // invoke the operation
            string domainName = "example.com";
            AppServiceDomainResource result = await collection.GetAsync(domainName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListDomainsByResourceGroup()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2024-11-01/examples/ListDomainsByResourceGroup.json
            // this example is just showing the usage of "Domains_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppServiceDomainResource
            AppServiceDomainCollection collection = resourceGroupResource.GetAppServiceDomains();

            // invoke the operation and iterate over the result
            await foreach (AppServiceDomainResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDomainData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetDomain()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2024-11-01/examples/GetDomain.json
            // this example is just showing the usage of "Domains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppServiceDomainResource
            AppServiceDomainCollection collection = resourceGroupResource.GetAppServiceDomains();

            // invoke the operation
            string domainName = "example.com";
            bool result = await collection.ExistsAsync(domainName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetDomain()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2024-11-01/examples/GetDomain.json
            // this example is just showing the usage of "Domains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppServiceDomainResource
            AppServiceDomainCollection collection = resourceGroupResource.GetAppServiceDomains();

            // invoke the operation
            string domainName = "example.com";
            NullableResponse<AppServiceDomainResource> response = await collection.GetIfExistsAsync(domainName);
            AppServiceDomainResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDomainData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
