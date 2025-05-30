// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class EnrichmentDomainWhoisRegistrarDetails : IUtf8JsonSerializable, IJsonModel<EnrichmentDomainWhoisRegistrarDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EnrichmentDomainWhoisRegistrarDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EnrichmentDomainWhoisRegistrarDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnrichmentDomainWhoisRegistrarDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EnrichmentDomainWhoisRegistrarDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AbuseContactEmail))
            {
                writer.WritePropertyName("abuseContactEmail"u8);
                writer.WriteStringValue(AbuseContactEmail);
            }
            if (Optional.IsDefined(AbuseContactPhone))
            {
                writer.WritePropertyName("abuseContactPhone"u8);
                writer.WriteStringValue(AbuseContactPhone);
            }
            if (Optional.IsDefined(IanaId))
            {
                writer.WritePropertyName("ianaId"u8);
                writer.WriteStringValue(IanaId);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(WhoisServer))
            {
                writer.WritePropertyName("whoisServer"u8);
                writer.WriteStringValue(WhoisServer);
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

        EnrichmentDomainWhoisRegistrarDetails IJsonModel<EnrichmentDomainWhoisRegistrarDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnrichmentDomainWhoisRegistrarDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EnrichmentDomainWhoisRegistrarDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEnrichmentDomainWhoisRegistrarDetails(document.RootElement, options);
        }

        internal static EnrichmentDomainWhoisRegistrarDetails DeserializeEnrichmentDomainWhoisRegistrarDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string abuseContactEmail = default;
            string abuseContactPhone = default;
            string ianaId = default;
            Uri url = default;
            string whoisServer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("abuseContactEmail"u8))
                {
                    abuseContactEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("abuseContactPhone"u8))
                {
                    abuseContactPhone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ianaId"u8))
                {
                    ianaId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("whoisServer"u8))
                {
                    whoisServer = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EnrichmentDomainWhoisRegistrarDetails(
                name,
                abuseContactEmail,
                abuseContactPhone,
                ianaId,
                url,
                whoisServer,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AbuseContactEmail), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  abuseContactEmail: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AbuseContactEmail))
                {
                    builder.Append("  abuseContactEmail: ");
                    if (AbuseContactEmail.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AbuseContactEmail}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AbuseContactEmail}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AbuseContactPhone), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  abuseContactPhone: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AbuseContactPhone))
                {
                    builder.Append("  abuseContactPhone: ");
                    if (AbuseContactPhone.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AbuseContactPhone}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AbuseContactPhone}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IanaId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ianaId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IanaId))
                {
                    builder.Append("  ianaId: ");
                    if (IanaId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{IanaId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{IanaId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Uri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  url: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Uri))
                {
                    builder.Append("  url: ");
                    builder.AppendLine($"'{Uri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WhoisServer), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  whoisServer: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WhoisServer))
                {
                    builder.Append("  whoisServer: ");
                    if (WhoisServer.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WhoisServer}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WhoisServer}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EnrichmentDomainWhoisRegistrarDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnrichmentDomainWhoisRegistrarDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EnrichmentDomainWhoisRegistrarDetails)} does not support writing '{options.Format}' format.");
            }
        }

        EnrichmentDomainWhoisRegistrarDetails IPersistableModel<EnrichmentDomainWhoisRegistrarDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnrichmentDomainWhoisRegistrarDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEnrichmentDomainWhoisRegistrarDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EnrichmentDomainWhoisRegistrarDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EnrichmentDomainWhoisRegistrarDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
