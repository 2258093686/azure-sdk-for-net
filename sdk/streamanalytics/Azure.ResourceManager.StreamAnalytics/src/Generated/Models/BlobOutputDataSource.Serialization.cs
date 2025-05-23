// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class BlobOutputDataSource : IUtf8JsonSerializable, IJsonModel<BlobOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobOutputDataSource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BlobOutputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobOutputDataSource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container"u8);
                writer.WriteStringValue(Container);
            }
            if (Optional.IsDefined(PathPattern))
            {
                writer.WritePropertyName("pathPattern"u8);
                writer.WriteStringValue(PathPattern);
            }
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                writer.WriteStringValue(DateFormat);
            }
            if (Optional.IsDefined(TimeFormat))
            {
                writer.WritePropertyName("timeFormat"u8);
                writer.WriteStringValue(TimeFormat);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(BlobPathPrefix))
            {
                writer.WritePropertyName("blobPathPrefix"u8);
                writer.WriteStringValue(BlobPathPrefix);
            }
            if (Optional.IsDefined(BlobWriteMode))
            {
                writer.WritePropertyName("blobWriteMode"u8);
                writer.WriteStringValue(BlobWriteMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        BlobOutputDataSource IJsonModel<BlobOutputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobOutputDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobOutputDataSource(document.RootElement, options);
        }

        internal static BlobOutputDataSource DeserializeBlobOutputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IList<StreamAnalyticsStorageAccount> storageAccounts = default;
            string container = default;
            string pathPattern = default;
            string dateFormat = default;
            string timeFormat = default;
            StreamAnalyticsAuthenticationMode? authenticationMode = default;
            string blobPathPrefix = default;
            BlobOutputWriteMode? blobWriteMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamAnalyticsStorageAccount> array = new List<StreamAnalyticsStorageAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamAnalyticsStorageAccount.DeserializeStreamAnalyticsStorageAccount(item, options));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("container"u8))
                        {
                            container = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pathPattern"u8))
                        {
                            pathPattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dateFormat"u8))
                        {
                            dateFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeFormat"u8))
                        {
                            timeFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobPathPrefix"u8))
                        {
                            blobPathPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blobWriteMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            blobWriteMode = new BlobOutputWriteMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BlobOutputDataSource(
                type,
                serializedAdditionalRawData,
                storageAccounts ?? new ChangeTrackingList<StreamAnalyticsStorageAccount>(),
                container,
                pathPattern,
                dateFormat,
                timeFormat,
                authenticationMode,
                blobPathPrefix,
                blobWriteMode);
        }

        BinaryData IPersistableModel<BlobOutputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStreamAnalyticsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(BlobOutputDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        BlobOutputDataSource IPersistableModel<BlobOutputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBlobOutputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BlobOutputDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlobOutputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
