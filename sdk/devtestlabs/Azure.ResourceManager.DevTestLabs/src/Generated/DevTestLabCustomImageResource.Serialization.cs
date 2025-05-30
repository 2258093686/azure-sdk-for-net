// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabCustomImageResource : IJsonModel<DevTestLabCustomImageData>
    {
        private static DevTestLabCustomImageData s_dataDeserializationInstance;
        private static DevTestLabCustomImageData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DevTestLabCustomImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabCustomImageData>)Data).Write(writer, options);

        DevTestLabCustomImageData IJsonModel<DevTestLabCustomImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabCustomImageData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DevTestLabCustomImageData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DevTestLabCustomImageData>(Data, options, AzureResourceManagerDevTestLabsContext.Default);

        DevTestLabCustomImageData IPersistableModel<DevTestLabCustomImageData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DevTestLabCustomImageData>(data, options, AzureResourceManagerDevTestLabsContext.Default);

        string IPersistableModel<DevTestLabCustomImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DevTestLabCustomImageData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
