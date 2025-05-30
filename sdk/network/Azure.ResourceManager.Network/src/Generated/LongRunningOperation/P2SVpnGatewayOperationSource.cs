// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class P2SVpnGatewayOperationSource : IOperationSource<P2SVpnGatewayResource>
    {
        private readonly ArmClient _client;

        internal P2SVpnGatewayOperationSource(ArmClient client)
        {
            _client = client;
        }

        P2SVpnGatewayResource IOperationSource<P2SVpnGatewayResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<P2SVpnGatewayData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return new P2SVpnGatewayResource(_client, data);
        }

        async ValueTask<P2SVpnGatewayResource> IOperationSource<P2SVpnGatewayResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<P2SVpnGatewayData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return await Task.FromResult(new P2SVpnGatewayResource(_client, data)).ConfigureAwait(false);
        }
    }
}
