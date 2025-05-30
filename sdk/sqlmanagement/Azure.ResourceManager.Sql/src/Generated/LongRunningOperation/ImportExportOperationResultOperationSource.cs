// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    internal class ImportExportOperationResultOperationSource : IOperationSource<ImportExportOperationResult>
    {
        ImportExportOperationResult IOperationSource<ImportExportOperationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return ImportExportOperationResult.DeserializeImportExportOperationResult(document.RootElement);
        }

        async ValueTask<ImportExportOperationResult> IOperationSource<ImportExportOperationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return ImportExportOperationResult.DeserializeImportExportOperationResult(document.RootElement);
        }
    }
}
