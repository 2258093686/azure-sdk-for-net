// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class RestApiPollerRequestConfig : IUtf8JsonSerializable, IJsonModel<RestApiPollerRequestConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestApiPollerRequestConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RestApiPollerRequestConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestApiPollerRequestConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestApiPollerRequestConfig)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("apiEndpoint"u8);
            writer.WriteStringValue(ApiEndpoint);
            if (Optional.IsDefined(RateLimitQPS))
            {
                if (RateLimitQPS != null)
                {
                    writer.WritePropertyName("rateLimitQPS"u8);
                    writer.WriteNumberValue(RateLimitQPS.Value);
                }
                else
                {
                    writer.WriteNull("rateLimitQPS");
                }
            }
            if (Optional.IsDefined(QueryWindowInMin))
            {
                if (QueryWindowInMin != null)
                {
                    writer.WritePropertyName("queryWindowInMin"u8);
                    writer.WriteNumberValue(QueryWindowInMin.Value);
                }
                else
                {
                    writer.WriteNull("queryWindowInMin");
                }
            }
            if (Optional.IsDefined(HttpMethod))
            {
                writer.WritePropertyName("httpMethod"u8);
                writer.WriteStringValue(HttpMethod.Value.ToString());
            }
            if (Optional.IsDefined(QueryTimeFormat))
            {
                writer.WritePropertyName("queryTimeFormat"u8);
                writer.WriteStringValue(QueryTimeFormat);
            }
            if (Optional.IsDefined(RetryCount))
            {
                if (RetryCount != null)
                {
                    writer.WritePropertyName("retryCount"u8);
                    writer.WriteNumberValue(RetryCount.Value);
                }
                else
                {
                    writer.WriteNull("retryCount");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(IsPostPayloadJson))
            {
                if (IsPostPayloadJson != null)
                {
                    writer.WritePropertyName("isPostPayloadJson"u8);
                    writer.WriteBooleanValue(IsPostPayloadJson.Value);
                }
                else
                {
                    writer.WriteNull("isPostPayloadJson");
                }
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartObject();
                foreach (var item in Headers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(QueryParameters))
            {
                writer.WritePropertyName("queryParameters"u8);
                writer.WriteStartObject();
                foreach (var item in QueryParameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(QueryParametersTemplate))
            {
                writer.WritePropertyName("queryParametersTemplate"u8);
                writer.WriteStringValue(QueryParametersTemplate);
            }
            if (Optional.IsDefined(StartTimeAttributeName))
            {
                writer.WritePropertyName("startTimeAttributeName"u8);
                writer.WriteStringValue(StartTimeAttributeName);
            }
            if (Optional.IsDefined(EndTimeAttributeName))
            {
                writer.WritePropertyName("endTimeAttributeName"u8);
                writer.WriteStringValue(EndTimeAttributeName);
            }
            if (Optional.IsDefined(QueryTimeIntervalAttributeName))
            {
                writer.WritePropertyName("queryTimeIntervalAttributeName"u8);
                writer.WriteStringValue(QueryTimeIntervalAttributeName);
            }
            if (Optional.IsDefined(QueryTimeIntervalPrepend))
            {
                writer.WritePropertyName("queryTimeIntervalPrepend"u8);
                writer.WriteStringValue(QueryTimeIntervalPrepend);
            }
            if (Optional.IsDefined(QueryTimeIntervalDelimiter))
            {
                writer.WritePropertyName("queryTimeIntervalDelimiter"u8);
                writer.WriteStringValue(QueryTimeIntervalDelimiter);
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

        RestApiPollerRequestConfig IJsonModel<RestApiPollerRequestConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestApiPollerRequestConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestApiPollerRequestConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestApiPollerRequestConfig(document.RootElement, options);
        }

        internal static RestApiPollerRequestConfig DeserializeRestApiPollerRequestConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string apiEndpoint = default;
            int? rateLimitQPS = default;
            int? queryWindowInMin = default;
            ConnectorHttpMethodVerb? httpMethod = default;
            string queryTimeFormat = default;
            int? retryCount = default;
            int? timeoutInSeconds = default;
            bool? isPostPayloadJson = default;
            IDictionary<string, string> headers = default;
            IDictionary<string, BinaryData> queryParameters = default;
            string queryParametersTemplate = default;
            string startTimeAttributeName = default;
            string endTimeAttributeName = default;
            string queryTimeIntervalAttributeName = default;
            string queryTimeIntervalPrepend = default;
            string queryTimeIntervalDelimiter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiEndpoint"u8))
                {
                    apiEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rateLimitQPS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rateLimitQPS = null;
                        continue;
                    }
                    rateLimitQPS = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("queryWindowInMin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        queryWindowInMin = null;
                        continue;
                    }
                    queryWindowInMin = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpMethod = new ConnectorHttpMethodVerb(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryTimeFormat"u8))
                {
                    queryTimeFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        retryCount = null;
                        continue;
                    }
                    retryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isPostPayloadJson"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isPostPayloadJson = null;
                        continue;
                    }
                    isPostPayloadJson = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    headers = dictionary;
                    continue;
                }
                if (property.NameEquals("queryParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    queryParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("queryParametersTemplate"u8))
                {
                    queryParametersTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTimeAttributeName"u8))
                {
                    startTimeAttributeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endTimeAttributeName"u8))
                {
                    endTimeAttributeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryTimeIntervalAttributeName"u8))
                {
                    queryTimeIntervalAttributeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryTimeIntervalPrepend"u8))
                {
                    queryTimeIntervalPrepend = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryTimeIntervalDelimiter"u8))
                {
                    queryTimeIntervalDelimiter = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RestApiPollerRequestConfig(
                apiEndpoint,
                rateLimitQPS,
                queryWindowInMin,
                httpMethod,
                queryTimeFormat,
                retryCount,
                timeoutInSeconds,
                isPostPayloadJson,
                headers ?? new ChangeTrackingDictionary<string, string>(),
                queryParameters ?? new ChangeTrackingDictionary<string, BinaryData>(),
                queryParametersTemplate,
                startTimeAttributeName,
                endTimeAttributeName,
                queryTimeIntervalAttributeName,
                queryTimeIntervalPrepend,
                queryTimeIntervalDelimiter,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiEndpoint))
                {
                    builder.Append("  apiEndpoint: ");
                    if (ApiEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiEndpoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RateLimitQPS), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rateLimitQPS: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RateLimitQPS))
                {
                    builder.Append("  rateLimitQPS: ");
                    builder.AppendLine($"{RateLimitQPS.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryWindowInMin), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryWindowInMin: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryWindowInMin))
                {
                    builder.Append("  queryWindowInMin: ");
                    builder.AppendLine($"{QueryWindowInMin.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HttpMethod), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  httpMethod: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HttpMethod))
                {
                    builder.Append("  httpMethod: ");
                    builder.AppendLine($"'{HttpMethod.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryTimeFormat), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryTimeFormat: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryTimeFormat))
                {
                    builder.Append("  queryTimeFormat: ");
                    if (QueryTimeFormat.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueryTimeFormat}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueryTimeFormat}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RetryCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  retryCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RetryCount))
                {
                    builder.Append("  retryCount: ");
                    builder.AppendLine($"{RetryCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeoutInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeoutInSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeoutInSeconds))
                {
                    builder.Append("  timeoutInSeconds: ");
                    builder.AppendLine($"{TimeoutInSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsPostPayloadJson), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isPostPayloadJson: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsPostPayloadJson))
                {
                    builder.Append("  isPostPayloadJson: ");
                    var boolValue = IsPostPayloadJson.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Headers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  headers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Headers))
                {
                    if (Headers.Any())
                    {
                        builder.Append("  headers: ");
                        builder.AppendLine("{");
                        foreach (var item in Headers)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryParameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(QueryParameters))
                {
                    if (QueryParameters.Any())
                    {
                        builder.Append("  queryParameters: ");
                        builder.AppendLine("{");
                        foreach (var item in QueryParameters)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"'{item.Value.ToString()}'");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryParametersTemplate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryParametersTemplate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryParametersTemplate))
                {
                    builder.Append("  queryParametersTemplate: ");
                    if (QueryParametersTemplate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueryParametersTemplate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueryParametersTemplate}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartTimeAttributeName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startTimeAttributeName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartTimeAttributeName))
                {
                    builder.Append("  startTimeAttributeName: ");
                    if (StartTimeAttributeName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StartTimeAttributeName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StartTimeAttributeName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndTimeAttributeName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endTimeAttributeName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndTimeAttributeName))
                {
                    builder.Append("  endTimeAttributeName: ");
                    if (EndTimeAttributeName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EndTimeAttributeName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EndTimeAttributeName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryTimeIntervalAttributeName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryTimeIntervalAttributeName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryTimeIntervalAttributeName))
                {
                    builder.Append("  queryTimeIntervalAttributeName: ");
                    if (QueryTimeIntervalAttributeName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueryTimeIntervalAttributeName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueryTimeIntervalAttributeName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryTimeIntervalPrepend), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryTimeIntervalPrepend: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryTimeIntervalPrepend))
                {
                    builder.Append("  queryTimeIntervalPrepend: ");
                    if (QueryTimeIntervalPrepend.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueryTimeIntervalPrepend}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueryTimeIntervalPrepend}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryTimeIntervalDelimiter), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryTimeIntervalDelimiter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryTimeIntervalDelimiter))
                {
                    builder.Append("  queryTimeIntervalDelimiter: ");
                    if (QueryTimeIntervalDelimiter.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueryTimeIntervalDelimiter}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueryTimeIntervalDelimiter}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RestApiPollerRequestConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestApiPollerRequestConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RestApiPollerRequestConfig)} does not support writing '{options.Format}' format.");
            }
        }

        RestApiPollerRequestConfig IPersistableModel<RestApiPollerRequestConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestApiPollerRequestConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRestApiPollerRequestConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestApiPollerRequestConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestApiPollerRequestConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
