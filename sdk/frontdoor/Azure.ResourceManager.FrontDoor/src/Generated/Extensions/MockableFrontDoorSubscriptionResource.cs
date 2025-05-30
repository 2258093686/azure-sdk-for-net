// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.FrontDoor.Models;

namespace Azure.ResourceManager.FrontDoor.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableFrontDoorSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _frontDoorWebApplicationFirewallPolicyPoliciesClientDiagnostics;
        private PoliciesRestOperations _frontDoorWebApplicationFirewallPolicyPoliciesRestClient;
        private ClientDiagnostics _managedRuleSetsClientDiagnostics;
        private ManagedRuleSetsRestOperations _managedRuleSetsRestClient;
        private ClientDiagnostics _frontDoorNameAvailabilityWithSubscriptionClientDiagnostics;
        private FrontDoorNameAvailabilityWithSubscriptionRestOperations _frontDoorNameAvailabilityWithSubscriptionRestClient;
        private ClientDiagnostics _frontDoorClientDiagnostics;
        private FrontDoorsRestOperations _frontDoorRestClient;
        private ClientDiagnostics _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics;
        private NetworkExperimentProfilesRestOperations _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableFrontDoorSubscriptionResource"/> class for mocking. </summary>
        protected MockableFrontDoorSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableFrontDoorSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableFrontDoorSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics FrontDoorWebApplicationFirewallPolicyPoliciesClientDiagnostics => _frontDoorWebApplicationFirewallPolicyPoliciesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", FrontDoorWebApplicationFirewallPolicyResource.ResourceType.Namespace, Diagnostics);
        private PoliciesRestOperations FrontDoorWebApplicationFirewallPolicyPoliciesRestClient => _frontDoorWebApplicationFirewallPolicyPoliciesRestClient ??= new PoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FrontDoorWebApplicationFirewallPolicyResource.ResourceType));
        private ClientDiagnostics ManagedRuleSetsClientDiagnostics => _managedRuleSetsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ManagedRuleSetsRestOperations ManagedRuleSetsRestClient => _managedRuleSetsRestClient ??= new ManagedRuleSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics FrontDoorNameAvailabilityWithSubscriptionClientDiagnostics => _frontDoorNameAvailabilityWithSubscriptionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private FrontDoorNameAvailabilityWithSubscriptionRestOperations FrontDoorNameAvailabilityWithSubscriptionRestClient => _frontDoorNameAvailabilityWithSubscriptionRestClient ??= new FrontDoorNameAvailabilityWithSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics FrontDoorClientDiagnostics => _frontDoorClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", FrontDoorResource.ResourceType.Namespace, Diagnostics);
        private FrontDoorsRestOperations FrontDoorRestClient => _frontDoorRestClient ??= new FrontDoorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FrontDoorResource.ResourceType));
        private ClientDiagnostics FrontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics => _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", FrontDoorNetworkExperimentProfileResource.ResourceType.Namespace, Diagnostics);
        private NetworkExperimentProfilesRestOperations FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient => _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient ??= new NetworkExperimentProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FrontDoorNetworkExperimentProfileResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all of the protection policies within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoorWebApplicationFirewallPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorWebApplicationFirewallPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorWebApplicationFirewallPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorWebApplicationFirewallPolicyResource> GetFrontDoorWebApplicationFirewallPoliciesByFrontDoorWebApplicationFirewallPolicyAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FrontDoorWebApplicationFirewallPolicyPoliciesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FrontDoorWebApplicationFirewallPolicyPoliciesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontDoorWebApplicationFirewallPolicyResource(Client, FrontDoorWebApplicationFirewallPolicyData.DeserializeFrontDoorWebApplicationFirewallPolicyData(e)), FrontDoorWebApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, "MockableFrontDoorSubscriptionResource.GetFrontDoorWebApplicationFirewallPoliciesByFrontDoorWebApplicationFirewallPolicy", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the protection policies within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoorWebApplicationFirewallPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorWebApplicationFirewallPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorWebApplicationFirewallPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorWebApplicationFirewallPolicyResource> GetFrontDoorWebApplicationFirewallPoliciesByFrontDoorWebApplicationFirewallPolicy(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FrontDoorWebApplicationFirewallPolicyPoliciesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FrontDoorWebApplicationFirewallPolicyPoliciesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontDoorWebApplicationFirewallPolicyResource(Client, FrontDoorWebApplicationFirewallPolicyData.DeserializeFrontDoorWebApplicationFirewallPolicyData(e)), FrontDoorWebApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, "MockableFrontDoorSubscriptionResource.GetFrontDoorWebApplicationFirewallPoliciesByFrontDoorWebApplicationFirewallPolicy", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all available managed rule sets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRuleSets_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedRuleSetDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedRuleSetsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedRuleSetsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ManagedRuleSetDefinition.DeserializeManagedRuleSetDefinition(e), ManagedRuleSetsClientDiagnostics, Pipeline, "MockableFrontDoorSubscriptionResource.GetManagedRuleSets", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all available managed rule sets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRuleSets_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedRuleSetDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedRuleSetsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedRuleSetsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ManagedRuleSetDefinition.DeserializeManagedRuleSetDefinition(e), ManagedRuleSetsClientDiagnostics, Pipeline, "MockableFrontDoorSubscriptionResource.GetManagedRuleSets", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check the availability of a Front Door subdomain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorNameAvailabilityWithSubscription_Check</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<FrontDoorNameAvailabilityResult>> CheckFrontDoorNameAvailabilityAsync(FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = FrontDoorNameAvailabilityWithSubscriptionClientDiagnostics.CreateScope("MockableFrontDoorSubscriptionResource.CheckFrontDoorNameAvailability");
            scope.Start();
            try
            {
                var response = await FrontDoorNameAvailabilityWithSubscriptionRestClient.CheckAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a Front Door subdomain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorNameAvailabilityWithSubscription_Check</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<FrontDoorNameAvailabilityResult> CheckFrontDoorNameAvailability(FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = FrontDoorNameAvailabilityWithSubscriptionClientDiagnostics.CreateScope("MockableFrontDoorSubscriptionResource.CheckFrontDoorNameAvailability");
            scope.Start();
            try
            {
                var response = FrontDoorNameAvailabilityWithSubscriptionRestClient.Check(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the Front Doors within an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoors_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorResource> GetFrontDoorsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FrontDoorRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FrontDoorRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontDoorResource(Client, FrontDoorData.DeserializeFrontDoorData(e)), FrontDoorClientDiagnostics, Pipeline, "MockableFrontDoorSubscriptionResource.GetFrontDoors", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the Front Doors within an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoors_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorResource> GetFrontDoors(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FrontDoorRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FrontDoorRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontDoorResource(Client, FrontDoorData.DeserializeFrontDoorData(e)), FrontDoorClientDiagnostics, Pipeline, "MockableFrontDoorSubscriptionResource.GetFrontDoors", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles under a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorNetworkExperimentProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorNetworkExperimentProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfilesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontDoorNetworkExperimentProfileResource(Client, FrontDoorNetworkExperimentProfileData.DeserializeFrontDoorNetworkExperimentProfileData(e)), FrontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics, Pipeline, "MockableFrontDoorSubscriptionResource.GetFrontDoorNetworkExperimentProfiles", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles under a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorNetworkExperimentProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorNetworkExperimentProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfiles(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FrontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontDoorNetworkExperimentProfileResource(Client, FrontDoorNetworkExperimentProfileData.DeserializeFrontDoorNetworkExperimentProfileData(e)), FrontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics, Pipeline, "MockableFrontDoorSubscriptionResource.GetFrontDoorNetworkExperimentProfiles", "value", "nextLink", cancellationToken);
        }
    }
}
