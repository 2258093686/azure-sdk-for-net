// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerSecurityContextCapabilitiesDefinition : IUtf8JsonSerializable, IJsonModel<ContainerSecurityContextCapabilitiesDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerSecurityContextCapabilitiesDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerSecurityContextCapabilitiesDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextCapabilitiesDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerSecurityContextCapabilitiesDefinition)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Add))
            {
                writer.WritePropertyName("add"u8);
                writer.WriteStartArray();
                foreach (var item in Add)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Drop))
            {
                writer.WritePropertyName("drop"u8);
                writer.WriteStartArray();
                foreach (var item in Drop)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ContainerSecurityContextCapabilitiesDefinition IJsonModel<ContainerSecurityContextCapabilitiesDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextCapabilitiesDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerSecurityContextCapabilitiesDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerSecurityContextCapabilitiesDefinition(document.RootElement, options);
        }

        internal static ContainerSecurityContextCapabilitiesDefinition DeserializeContainerSecurityContextCapabilitiesDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> @add = default;
            IList<string> drop = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("add"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    @add = array;
                    continue;
                }
                if (property.NameEquals("drop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    drop = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerSecurityContextCapabilitiesDefinition(@add ?? new ChangeTrackingList<string>(), drop ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerSecurityContextCapabilitiesDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextCapabilitiesDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerInstanceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ContainerSecurityContextCapabilitiesDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerSecurityContextCapabilitiesDefinition IPersistableModel<ContainerSecurityContextCapabilitiesDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextCapabilitiesDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerSecurityContextCapabilitiesDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerSecurityContextCapabilitiesDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerSecurityContextCapabilitiesDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
