// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Advisor.Samples
{
    public partial class Sample_MetadataEntityResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetMetadata()
        {
            // Generated from example definition: specification/advisor/resource-manager/Microsoft.Advisor/stable/2020-01-01/examples/GetRecommendationMetadataEntity.json
            // this example is just showing the usage of "RecommendationMetadata_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MetadataEntityResource created on azure
            // for more information of creating MetadataEntityResource, please refer to the document of MetadataEntityResource
            string name = "types";
            ResourceIdentifier metadataEntityResourceId = MetadataEntityResource.CreateResourceIdentifier(name);
            MetadataEntityResource metadataEntity = client.GetMetadataEntityResource(metadataEntityResourceId);

            // invoke the operation
            MetadataEntityResource result = await metadataEntity.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MetadataEntityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
