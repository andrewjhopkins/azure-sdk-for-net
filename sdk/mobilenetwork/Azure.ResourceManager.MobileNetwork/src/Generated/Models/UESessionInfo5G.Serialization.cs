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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class UESessionInfo5G : IUtf8JsonSerializable, IJsonModel<UESessionInfo5G>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UESessionInfo5G>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UESessionInfo5G>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UESessionInfo5G>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UESessionInfo5G)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("pduSessionId"u8);
            writer.WriteNumberValue(PduSessionId);
            writer.WritePropertyName("dnn"u8);
            writer.WriteStringValue(Dnn);
            writer.WritePropertyName("pdnType"u8);
            writer.WriteStringValue(PdnType.ToString());
            writer.WritePropertyName("qosFlow"u8);
            writer.WriteStartArray();
            foreach (var item in QosFlow)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("ambr"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("uplink"u8);
            writer.WriteStringValue(Uplink);
            writer.WritePropertyName("downlink"u8);
            writer.WriteStringValue(Downlink);
            writer.WriteEndObject();
            writer.WritePropertyName("ueIpAddress"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IPV4Addr))
            {
                writer.WritePropertyName("ipV4Addr"u8);
                writer.WriteStringValue(IPV4Addr);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("snssai"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("sst"u8);
            writer.WriteNumberValue(Sst);
            if (Optional.IsDefined(Sd))
            {
                writer.WritePropertyName("sd"u8);
                writer.WriteStringValue(Sd);
            }
            writer.WriteEndObject();
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

        UESessionInfo5G IJsonModel<UESessionInfo5G>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UESessionInfo5G>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UESessionInfo5G)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUESessionInfo5G(document.RootElement, options);
        }

        internal static UESessionInfo5G DeserializeUESessionInfo5G(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int pduSessionId = default;
            string dnn = default;
            PdnType pdnType = default;
            IList<UEQosFlow> qosFlow = default;
            string uplink = default;
            string downlink = default;
            string ipV4Addr = default;
            int sst = default;
            string sd = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pduSessionId"u8))
                {
                    pduSessionId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dnn"u8))
                {
                    dnn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pdnType"u8))
                {
                    pdnType = new PdnType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("qosFlow"u8))
                {
                    List<UEQosFlow> array = new List<UEQosFlow>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UEQosFlow.DeserializeUEQosFlow(item, options));
                    }
                    qosFlow = array;
                    continue;
                }
                if (property.NameEquals("ambr"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uplink"u8))
                        {
                            uplink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("downlink"u8))
                        {
                            downlink = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("ueIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("ipV4Addr"u8))
                        {
                            ipV4Addr = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("snssai"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sst"u8))
                        {
                            sst = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sd"u8))
                        {
                            sd = property0.Value.GetString();
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
            return new UESessionInfo5G(
                pduSessionId,
                dnn,
                pdnType,
                qosFlow,
                uplink,
                downlink,
                ipV4Addr,
                sst,
                sd,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PduSessionId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pduSessionId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  pduSessionId: ");
                builder.AppendLine($"{PduSessionId}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Dnn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dnn: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Dnn))
                {
                    builder.Append("  dnn: ");
                    if (Dnn.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Dnn}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Dnn}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PdnType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pdnType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  pdnType: ");
                builder.AppendLine($"'{PdnType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QosFlow), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  qosFlow: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(QosFlow))
                {
                    if (QosFlow.Any())
                    {
                        builder.Append("  qosFlow: ");
                        builder.AppendLine("[");
                        foreach (var item in QosFlow)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  qosFlow: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.Append("  ambr:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Uplink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    uplink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Uplink))
                {
                    builder.Append("    uplink: ");
                    if (Uplink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Uplink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Uplink}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Downlink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    downlink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Downlink))
                {
                    builder.Append("    downlink: ");
                    if (Downlink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Downlink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Downlink}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.Append("  ueIpAddress:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IPV4Addr), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    ipV4Addr: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IPV4Addr))
                {
                    builder.Append("    ipV4Addr: ");
                    if (IPV4Addr.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{IPV4Addr}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{IPV4Addr}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.Append("  snssai:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sst), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sst: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("    sst: ");
                builder.AppendLine($"{Sst}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sd), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sd: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Sd))
                {
                    builder.Append("    sd: ");
                    if (Sd.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Sd}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Sd}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<UESessionInfo5G>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UESessionInfo5G>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMobileNetworkContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UESessionInfo5G)} does not support writing '{options.Format}' format.");
            }
        }

        UESessionInfo5G IPersistableModel<UESessionInfo5G>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UESessionInfo5G>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUESessionInfo5G(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UESessionInfo5G)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UESessionInfo5G>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
