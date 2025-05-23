// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class SubResourceIntegrityCheck : IUtf8JsonSerializable, IJsonModel<SubResourceIntegrityCheck>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubResourceIntegrityCheck>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SubResourceIntegrityCheck>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubResourceIntegrityCheck>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubResourceIntegrityCheck)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Violation))
            {
                writer.WritePropertyName("violation"u8);
                writer.WriteBooleanValue(Violation.Value);
            }
            if (Optional.IsDefined(FirstSeen))
            {
                writer.WritePropertyName("firstSeen"u8);
                writer.WriteStringValue(FirstSeen.Value, "O");
            }
            if (Optional.IsDefined(LastSeen))
            {
                writer.WritePropertyName("lastSeen"u8);
                writer.WriteStringValue(LastSeen.Value, "O");
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(CausePageUrl))
            {
                writer.WritePropertyName("causePageUrl"u8);
                writer.WriteStringValue(CausePageUrl);
            }
            if (Optional.IsDefined(CrawlGuid))
            {
                writer.WritePropertyName("crawlGuid"u8);
                writer.WriteStringValue(CrawlGuid);
            }
            if (Optional.IsDefined(PageGuid))
            {
                writer.WritePropertyName("pageGuid"u8);
                writer.WriteStringValue(PageGuid);
            }
            if (Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid);
            }
            if (Optional.IsDefined(ExpectedHash))
            {
                writer.WritePropertyName("expectedHash"u8);
                writer.WriteStringValue(ExpectedHash);
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

        SubResourceIntegrityCheck IJsonModel<SubResourceIntegrityCheck>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubResourceIntegrityCheck>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubResourceIntegrityCheck)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubResourceIntegrityCheck(document.RootElement, options);
        }

        internal static SubResourceIntegrityCheck DeserializeSubResourceIntegrityCheck(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? violation = default;
            DateTimeOffset? firstSeen = default;
            DateTimeOffset? lastSeen = default;
            long? count = default;
            string causePageUrl = default;
            string crawlGuid = default;
            string pageGuid = default;
            string resourceGuid = default;
            string expectedHash = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("violation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    violation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("causePageUrl"u8))
                {
                    causePageUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crawlGuid"u8))
                {
                    crawlGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageGuid"u8))
                {
                    pageGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGuid"u8))
                {
                    resourceGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expectedHash"u8))
                {
                    expectedHash = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SubResourceIntegrityCheck(
                violation,
                firstSeen,
                lastSeen,
                count,
                causePageUrl,
                crawlGuid,
                pageGuid,
                resourceGuid,
                expectedHash,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubResourceIntegrityCheck>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubResourceIntegrityCheck>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAnalyticsDefenderEasmContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SubResourceIntegrityCheck)} does not support writing '{options.Format}' format.");
            }
        }

        SubResourceIntegrityCheck IPersistableModel<SubResourceIntegrityCheck>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubResourceIntegrityCheck>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSubResourceIntegrityCheck(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubResourceIntegrityCheck)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubResourceIntegrityCheck>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SubResourceIntegrityCheck FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSubResourceIntegrityCheck(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
