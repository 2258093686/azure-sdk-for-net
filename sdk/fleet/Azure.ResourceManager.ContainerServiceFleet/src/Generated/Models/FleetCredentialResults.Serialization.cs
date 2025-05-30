// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    public partial class FleetCredentialResults : IUtf8JsonSerializable, IJsonModel<FleetCredentialResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FleetCredentialResults>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FleetCredentialResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FleetCredentialResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FleetCredentialResults)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(Kubeconfigs))
            {
                writer.WritePropertyName("kubeconfigs"u8);
                writer.WriteStartArray();
                foreach (var item in Kubeconfigs)
                {
                    writer.WriteObjectValue(item, options);
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

        FleetCredentialResults IJsonModel<FleetCredentialResults>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FleetCredentialResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FleetCredentialResults)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFleetCredentialResults(document.RootElement, options);
        }

        internal static FleetCredentialResults DeserializeFleetCredentialResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FleetCredentialResult> kubeconfigs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubeconfigs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FleetCredentialResult> array = new List<FleetCredentialResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FleetCredentialResult.DeserializeFleetCredentialResult(item, options));
                    }
                    kubeconfigs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FleetCredentialResults(kubeconfigs ?? new ChangeTrackingList<FleetCredentialResult>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FleetCredentialResults>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FleetCredentialResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerServiceFleetContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FleetCredentialResults)} does not support writing '{options.Format}' format.");
            }
        }

        FleetCredentialResults IPersistableModel<FleetCredentialResults>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FleetCredentialResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFleetCredentialResults(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FleetCredentialResults)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FleetCredentialResults>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
