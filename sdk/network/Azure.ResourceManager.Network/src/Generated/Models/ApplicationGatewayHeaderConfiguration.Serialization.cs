// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayHeaderConfiguration : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayHeaderConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayHeaderConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationGatewayHeaderConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayHeaderConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayHeaderConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(HeaderName))
            {
                writer.WritePropertyName("headerName"u8);
                writer.WriteStringValue(HeaderName);
            }
            if (Optional.IsDefined(HeaderValueMatcher))
            {
                writer.WritePropertyName("headerValueMatcher"u8);
                writer.WriteObjectValue(HeaderValueMatcher, options);
            }
            if (Optional.IsDefined(HeaderValue))
            {
                writer.WritePropertyName("headerValue"u8);
                writer.WriteStringValue(HeaderValue);
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

        ApplicationGatewayHeaderConfiguration IJsonModel<ApplicationGatewayHeaderConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayHeaderConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayHeaderConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayHeaderConfiguration(document.RootElement, options);
        }

        internal static ApplicationGatewayHeaderConfiguration DeserializeApplicationGatewayHeaderConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string headerName = default;
            HeaderValueMatcher headerValueMatcher = default;
            string headerValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headerName"u8))
                {
                    headerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headerValueMatcher"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    headerValueMatcher = HeaderValueMatcher.DeserializeHeaderValueMatcher(property.Value, options);
                    continue;
                }
                if (property.NameEquals("headerValue"u8))
                {
                    headerValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationGatewayHeaderConfiguration(headerName, headerValueMatcher, headerValue, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayHeaderConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayHeaderConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayHeaderConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationGatewayHeaderConfiguration IPersistableModel<ApplicationGatewayHeaderConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayHeaderConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationGatewayHeaderConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayHeaderConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayHeaderConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
