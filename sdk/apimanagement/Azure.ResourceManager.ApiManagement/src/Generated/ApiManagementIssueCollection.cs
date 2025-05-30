// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementIssueResource"/> and their operations.
    /// Each <see cref="ApiManagementIssueResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get an <see cref="ApiManagementIssueCollection"/> instance call the GetApiManagementIssues method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class ApiManagementIssueCollection : ArmCollection, IEnumerable<ApiManagementIssueResource>, IAsyncEnumerable<ApiManagementIssueResource>
    {
        private readonly ClientDiagnostics _apiManagementIssueIssueClientDiagnostics;
        private readonly IssueRestOperations _apiManagementIssueIssueRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementIssueCollection"/> class for mocking. </summary>
        protected ApiManagementIssueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementIssueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementIssueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementIssueIssueClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementIssueResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementIssueResource.ResourceType, out string apiManagementIssueIssueApiVersion);
            _apiManagementIssueIssueRestClient = new IssueRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementIssueIssueApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets API Management issue details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementIssueResource>> GetAsync(string issueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiManagementIssueIssueClientDiagnostics.CreateScope("ApiManagementIssueCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementIssueIssueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, issueId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets API Management issue details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual Response<ApiManagementIssueResource> Get(string issueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiManagementIssueIssueClientDiagnostics.CreateScope("ApiManagementIssueCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementIssueIssueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, issueId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of issues in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| apiId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| title | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| authorName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementIssueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementIssueResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementIssueIssueRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementIssueIssueRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementIssueResource(Client, IssueContractData.DeserializeIssueContractData(e)), _apiManagementIssueIssueClientDiagnostics, Pipeline, "ApiManagementIssueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of issues in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| apiId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| title | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| authorName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementIssueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementIssueResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementIssueIssueRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementIssueIssueRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementIssueResource(Client, IssueContractData.DeserializeIssueContractData(e)), _apiManagementIssueIssueClientDiagnostics, Pipeline, "ApiManagementIssueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string issueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiManagementIssueIssueClientDiagnostics.CreateScope("ApiManagementIssueCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementIssueIssueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, issueId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual Response<bool> Exists(string issueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiManagementIssueIssueClientDiagnostics.CreateScope("ApiManagementIssueCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementIssueIssueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, issueId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementIssueResource>> GetIfExistsAsync(string issueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiManagementIssueIssueClientDiagnostics.CreateScope("ApiManagementIssueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementIssueIssueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, issueId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementIssueResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Issue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual NullableResponse<ApiManagementIssueResource> GetIfExists(string issueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiManagementIssueIssueClientDiagnostics.CreateScope("ApiManagementIssueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementIssueIssueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, issueId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementIssueResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementIssueResource> IEnumerable<ApiManagementIssueResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementIssueResource> IAsyncEnumerable<ApiManagementIssueResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
