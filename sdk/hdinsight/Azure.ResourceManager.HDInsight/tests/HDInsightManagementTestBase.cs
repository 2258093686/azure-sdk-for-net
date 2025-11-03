// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.HDInsight.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.HDInsight.Tests
{
    public class HDInsightManagementTestBase : ManagementRecordedTestBase<HDInsightManagementTestEnvironment>
    {
        protected ArmClient Client { get; private set; }
        protected const string DefaultResourceGroupPrefix = "HDInsightRG-";
        protected AzureLocation DefaultLocation = AzureLocation.WestUS2;
        protected const string Common_User = "sshusername";
        protected const string Common_Password = "Password1!";
        //protected const string Common_VNet_Id = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/yukundemo2/providers/Microsoft.Network/virtualNetworks/yk01networkwestus2";
        //protected const string Common_VNet_Id = "/subscriptions/964c10bb-8a6c-43bc-83d3-6b318c6c7305/resourceGroups/yukundemo2/providers/Microsoft.Network/virtualNetworks/yk01networkwestus2";
        protected const string Common_VNet_Id = "/subscriptions/964c10bb-8a6c-43bc-83d3-6b318c6c7305/resourceGroups/yukundemo1/providers/Microsoft.Network/virtualNetworks/yk04networkeastasia";
        //protected const string Common_SubNet = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/yukundemo2/providers/Microsoft.Network/virtualNetworks/yk01networkwestus2/subnets/default";
        //protected const string Common_SubNet = "/subscriptions/964c10bb-8a6c-43bc-83d3-6b318c6c7305/resourceGroups/yukundemo2/providers/Microsoft.Network/virtualNetworks/yk01networkwestus2/subnets/default";
        protected const string Common_SubNet = "/subscriptions/964c10bb-8a6c-43bc-83d3-6b318c6c7305/resourceGroups/yukundemo1/providers/Microsoft.Network/virtualNetworks/yk04networkeastasia/subnets/default";
        protected HDInsightManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
            JsonPathSanitizers.Add("$..key");
        }

        protected HDInsightManagementTestBase(bool isAsync)
            : base(isAsync)
        {
            JsonPathSanitizers.Add("$..key");
        }

        [SetUp]
        public void CreateCommonClient()
        {
            Client = GetArmClient();
        }

        protected async Task<ResourceGroupResource> CreateResourceGroup(string rgName)
        {
            var subscription = await Client.GetDefaultSubscriptionAsync();
            var input = new ResourceGroupData(DefaultLocation);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }

        protected async Task<string> CreateStorageResources(ResourceGroupResource resourceGroup, string storageAccountName, string containerName)
        {
            StorageSku sku = new StorageSku(StorageSkuName.StandardGrs);
            StorageKind kind = StorageKind.Storage;
            var location = DefaultLocation;
            StorageAccountCreateOrUpdateContent storagedata = new StorageAccountCreateOrUpdateContent(sku, kind, location);
            var lro = await resourceGroup.GetStorageAccounts().CreateOrUpdateAsync(WaitUntil.Completed, storageAccountName, storagedata);
            var storageAccount = lro.Value;
            await storageAccount.GetBlobService().GetBlobContainers().CreateOrUpdateAsync(WaitUntil.Completed, containerName, new BlobContainerData());
            return (await storageAccount.GetKeysAsync().ToEnumerableAsync()).FirstOrDefault().Value;
        }

        protected async Task<HDInsightClusterResource> CreateDefaultHadoopCluster(ResourceGroupResource resourceGroup, string clusterName, string storageAccountName, string containerName, string accessKey = null, string msi = null, string resourceId = null)
        {
            var properties = PrepareClusterCreateParams(storageAccountName, containerName, accessKey, msi, resourceId);
            var data = new HDInsightClusterCreateOrUpdateContent()
            {
                Properties = properties,
                Location = DefaultLocation
            };
            if (!string.IsNullOrWhiteSpace(msi) && !string.IsNullOrWhiteSpace(resourceId))
            {
                ManagedServiceIdentity identity = new ManagedServiceIdentity(ManagedServiceIdentityType.UserAssigned)
                {
                    UserAssignedIdentities =
                    {
                        [new ResourceIdentifier(msi)] = new UserAssignedIdentity()
                    }
                };
                data.Identity = identity;
            }
            data.Tags.Add(new KeyValuePair<string, string>("key0", "value0"));
            var cluster = await resourceGroup.GetHDInsightClusters().CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            return cluster.Value;
        }

        protected HDInsightClusterCreateOrUpdateProperties PrepareClusterCreateParams(string storageAccountName, string containerName, string accessKey=null, string msi=null, string resourceId = null)
        {
            string clusterDeifnitionConfigurations = "{         \"gateway\": {             \"restAuthCredential.isEnabled\": \"true\",             \"restAuthCredential.username\": \"admin\",             \"restAuthCredential.password\": \"Password1!\"         }     } ";
            var properties = new HDInsightClusterCreateOrUpdateProperties()
            {
                ClusterVersion = "5.1",
                OSType = HDInsightOSType.Linux,
                Tier = HDInsightTier.Standard,
                ClusterDefinition = new HDInsightClusterDefinition()
                {
                    Kind = "Hadoop",
                    Configurations = new BinaryData(clusterDeifnitionConfigurations),
                },
                IsEncryptionInTransitEnabled = true,
            };
            properties.ComputeRoles.Add(new HDInsightClusterRole()
            {
                Name = "headnode",
                TargetInstanceCount = 2,
                HardwareVmSize = "standard_e8_v3",
                OSLinuxProfile = new HDInsightLinuxOSProfile()
                {
                    Username = Common_User,
                    Password = Common_Password
                },
                VirtualNetworkProfile = new HDInsightVirtualNetworkProfile()
                {
                    Id = new ResourceIdentifier(Common_VNet_Id),
                    Subnet = Common_SubNet
                }
            });
            properties.ComputeRoles.Add(new HDInsightClusterRole()
            {
                Name = "workernode",
                TargetInstanceCount = 3,
                HardwareVmSize = "standard_e8_v3",
                OSLinuxProfile = new HDInsightLinuxOSProfile()
                {
                    Username = Common_User,
                    Password = Common_Password
                },
                VirtualNetworkProfile = new HDInsightVirtualNetworkProfile()
                {
                    Id = new ResourceIdentifier(Common_VNet_Id),
                    Subnet = Common_SubNet
                }
            });
            properties.ComputeRoles.Add(new HDInsightClusterRole()
            {
                Name = "zookeepernode",
                TargetInstanceCount = 3,
                HardwareVmSize = "standard_a2_v2",
                OSLinuxProfile = new HDInsightLinuxOSProfile()
                {
                    Username = Common_User,
                    Password = Common_Password
                },
                VirtualNetworkProfile = new HDInsightVirtualNetworkProfile()
                {
                    Id = new ResourceIdentifier(Common_VNet_Id),
                    Subnet = Common_SubNet
                }
            });
            HDInsightStorageAccountInfo storageAccountproperties = new HDInsightStorageAccountInfo
            {
                Name = $"{storageAccountName}.blob.core.windows.net",
                IsDefault = true,
                Container = containerName
            };
            if (!string.IsNullOrWhiteSpace(msi) && !string.IsNullOrWhiteSpace(resourceId))
            {
                storageAccountproperties.MsiResourceId = new ResourceIdentifier(msi);
                storageAccountproperties.ResourceId = new ResourceIdentifier(resourceId);
            } else
            {
                storageAccountproperties.Key = accessKey;
            }
            properties.StorageAccounts.Add(storageAccountproperties);
            return properties;
        }
    }
}
