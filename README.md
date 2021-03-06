# Azure SDK for .NET

[![Packages](https://img.shields.io/badge/packages-latest-blue.svg)](https://azure.github.io/azure-sdk/releases/latest/dotnet.html) [![Dependencies](https://img.shields.io/badge/dependency-report-blue.svg)](https://azuresdkartifacts.blob.core.windows.net/azure-sdk-for-net/dependencies/dependencies.html) [![Dependencies Graph](https://img.shields.io/badge/dependency-graph-blue.svg)](https://azuresdkartifacts.blob.core.windows.net/azure-sdk-for-net/dependencies/InterdependencyGraph.html)

This repository is for active development of the Azure SDK for .NET. For consumers of the SDK we recommend visiting our [public developer docs](https://docs.microsoft.com/en-us/dotnet/azure/) or our versioned [developer docs](https://azure.github.io/azure-sdk-for-net).

## Getting started

To get started with a library, see the README.md file located in the library's project folder. You can find these library folders grouped by service in the /sdk directory.

For tutorials, samples, quick starts, and other documentation, go to [Azure for .NET Developers](https://docs.microsoft.com/en-us/dotnet/azure/).

## Packages available

### Client

New wave of packages that we are announcing as **GA** and several that are currently releasing in **preview**. These libraries follow the [Azure SDK Design Guidelines for .NET](https://azure.github.io/azure-sdk/dotnet/guidelines/) and share a number of core features such as HTTP retries, logging, transport protocols, authentication protocols, etc., so that once you learn how to use these features in one client library, you will know how to use them in other client libraries. You can learn about these shared features at [Azure.Core](sdk/core/Azure.Core/README.md).

These new client libraries can be identified by the naming used for their folder, package, and namespace. Each will start with `Azure`, followed by the service category, and then the name of the service. For example `Azure.Storage.Blobs`. 

For a complete list of available packages, please see the [latest available packages](https://azure.github.io/azure-sdk/releases/latest/dotnet.html) page.

> NOTE: If you need to ensure your code is ready for production we strongly recommend using one of the stable, non-preview libraries.

### Client: Previous Versions

Last stable versions of packages that are production-ready. These libraries provide similar functionalities to the preview packages, as they allow you to use and consume existing resources and interact with them, for example: upload a storage blob. Stable library directories typically contain 'Microsoft.Azure' in their names, e.g. 'Microsoft.Azure.KeyVault'. They might not implement the [guidelines](https://azure.github.io/azure-sdk/dotnet_introduction.html) or have the same feature set as the Novemeber releases. They do however offer wider coverage of services.

### Management

Libraries which enable you to provision specific server resources. They are directly mirroring Azure service's REST endpoints. Management library directories typically contain the word 'Management' in their names, e.g. 'Microsoft.Azure.Management.Storage'.

## Need help?

* For reference documentation visit the [Azure SDK for .NET API Reference](http://aka.ms/net-docs).
* For tutorials, samples, quick starts, and other documentation, go to [Azure for .NET Developers](https://docs.microsoft.com/en-us/dotnet/azure/).
* File an issue via [Github Issues](https://github.com/Azure/azure-sdk-for-net/issues/new/choose).
* Check [previous questions](https://stackoverflow.com/questions/tagged/azure+.net) or ask new ones on StackOverflow using `azure` and `.net` tags.

### Reporting security issues and security bugs

Security issues and bugs should be reported privately, via email, to the Microsoft Security Response Center (MSRC) <secure@microsoft.com>. You should receive a response within 24 hours. If for some reason you do not, please follow up via email to ensure we received your original message. Further information, including the MSRC PGP key, can be found in the [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue).

## Contributing
For details on contributing to this repository, see the [contributing guide](CONTRIBUTING.md).

This project welcomes contributions and suggestions. Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit
https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repositories using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

![Impressions](https://azure-sdk-impressions.azurewebsites.net/api/impressions/azure-sdk-for-net%2FREADME.png)
