// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsRouterJobSchedulingFailedEventDataConverter))]
    public partial class AcsRouterJobSchedulingFailedEventData
    {
        internal static AcsRouterJobSchedulingFailedEventData DeserializeAcsRouterJobSchedulingFailedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? priority = default;
            IReadOnlyList<AcsRouterWorkerSelector> expiredAttachedWorkerSelectors = default;
            IReadOnlyList<AcsRouterWorkerSelector> expiredRequestedWorkerSelectors = default;
            DateTimeOffset? scheduledOn = default;
            string failureReason = default;
            string queueId = default;
            IReadOnlyDictionary<string, string> labels = default;
            IReadOnlyDictionary<string, string> tags = default;
            string jobId = default;
            string channelReference = default;
            string channelId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("expiredAttachedWorkerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsRouterWorkerSelector> array = new List<AcsRouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsRouterWorkerSelector.DeserializeAcsRouterWorkerSelector(item));
                    }
                    expiredAttachedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("expiredRequestedWorkerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsRouterWorkerSelector> array = new List<AcsRouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsRouterWorkerSelector.DeserializeAcsRouterWorkerSelector(item));
                    }
                    expiredRequestedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("scheduledOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("failureReason"u8))
                {
                    failureReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsRouterJobSchedulingFailedEventData(
                jobId,
                channelReference,
                channelId,
                queueId,
                labels,
                tags,
                priority,
                expiredAttachedWorkerSelectors ?? new ChangeTrackingList<AcsRouterWorkerSelector>(),
                expiredRequestedWorkerSelectors ?? new ChangeTrackingList<AcsRouterWorkerSelector>(),
                scheduledOn,
                failureReason);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AcsRouterJobSchedulingFailedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsRouterJobSchedulingFailedEventData(document.RootElement);
        }

        internal partial class AcsRouterJobSchedulingFailedEventDataConverter : JsonConverter<AcsRouterJobSchedulingFailedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterJobSchedulingFailedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AcsRouterJobSchedulingFailedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterJobSchedulingFailedEventData(document.RootElement);
            }
        }
    }
}
