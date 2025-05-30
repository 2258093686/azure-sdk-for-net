// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class MsixPackageResource : IJsonModel<MsixPackageData>
    {
        private static MsixPackageData s_dataDeserializationInstance;
        private static MsixPackageData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MsixPackageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MsixPackageData>)Data).Write(writer, options);

        MsixPackageData IJsonModel<MsixPackageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MsixPackageData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MsixPackageData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MsixPackageData>(Data, options, AzureResourceManagerDesktopVirtualizationContext.Default);

        MsixPackageData IPersistableModel<MsixPackageData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MsixPackageData>(data, options, AzureResourceManagerDesktopVirtualizationContext.Default);

        string IPersistableModel<MsixPackageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MsixPackageData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
