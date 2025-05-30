// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionStateSnapshot : IUtf8JsonSerializable, IJsonModel<ConnectionStateSnapshot>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionStateSnapshot>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectionStateSnapshot>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionStateSnapshot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionStateSnapshot)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(NetworkConnectionState))
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteStringValue(NetworkConnectionState.Value.ToString());
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(EvaluationState))
            {
                writer.WritePropertyName("evaluationState"u8);
                writer.WriteStringValue(EvaluationState.Value.ToString());
            }
            if (Optional.IsDefined(AvgLatencyInMs))
            {
                writer.WritePropertyName("avgLatencyInMs"u8);
                writer.WriteNumberValue(AvgLatencyInMs.Value);
            }
            if (Optional.IsDefined(MinLatencyInMs))
            {
                writer.WritePropertyName("minLatencyInMs"u8);
                writer.WriteNumberValue(MinLatencyInMs.Value);
            }
            if (Optional.IsDefined(MaxLatencyInMs))
            {
                writer.WritePropertyName("maxLatencyInMs"u8);
                writer.WriteNumberValue(MaxLatencyInMs.Value);
            }
            if (Optional.IsDefined(ProbesSent))
            {
                writer.WritePropertyName("probesSent"u8);
                writer.WriteNumberValue(ProbesSent.Value);
            }
            if (Optional.IsDefined(ProbesFailed))
            {
                writer.WritePropertyName("probesFailed"u8);
                writer.WriteNumberValue(ProbesFailed.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Hops))
            {
                writer.WritePropertyName("hops"u8);
                writer.WriteStartArray();
                foreach (var item in Hops)
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

        ConnectionStateSnapshot IJsonModel<ConnectionStateSnapshot>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionStateSnapshot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionStateSnapshot)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionStateSnapshot(document.RootElement, options);
        }

        internal static ConnectionStateSnapshot DeserializeConnectionStateSnapshot(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NetworkConnectionState? connectionState = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            EvaluationState? evaluationState = default;
            long? avgLatencyInMs = default;
            long? minLatencyInMs = default;
            long? maxLatencyInMs = default;
            long? probesSent = default;
            long? probesFailed = default;
            IReadOnlyList<ConnectivityHopInfo> hops = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = new NetworkConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("evaluationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationState = new EvaluationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("avgLatencyInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    avgLatencyInMs = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minLatencyInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minLatencyInMs = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxLatencyInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLatencyInMs = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("probesSent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesSent = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("probesFailed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesFailed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("hops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectivityHopInfo> array = new List<ConnectivityHopInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityHopInfo.DeserializeConnectivityHopInfo(item, options));
                    }
                    hops = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectionStateSnapshot(
                connectionState,
                startTime,
                endTime,
                evaluationState,
                avgLatencyInMs,
                minLatencyInMs,
                maxLatencyInMs,
                probesSent,
                probesFailed,
                hops ?? new ChangeTrackingList<ConnectivityHopInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectionStateSnapshot>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionStateSnapshot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConnectionStateSnapshot)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectionStateSnapshot IPersistableModel<ConnectionStateSnapshot>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionStateSnapshot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectionStateSnapshot(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectionStateSnapshot)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectionStateSnapshot>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
