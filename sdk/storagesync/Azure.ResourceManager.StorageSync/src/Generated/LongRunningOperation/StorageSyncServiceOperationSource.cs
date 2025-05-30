// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync
{
    internal class StorageSyncServiceOperationSource : IOperationSource<StorageSyncServiceResource>
    {
        private readonly ArmClient _client;

        internal StorageSyncServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        StorageSyncServiceResource IOperationSource<StorageSyncServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StorageSyncServiceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerStorageSyncContext.Default);
            return new StorageSyncServiceResource(_client, data);
        }

        async ValueTask<StorageSyncServiceResource> IOperationSource<StorageSyncServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StorageSyncServiceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerStorageSyncContext.Default);
            return await Task.FromResult(new StorageSyncServiceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
