// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class AvailableLabServicesSkuCost : IUtf8JsonSerializable, IJsonModel<AvailableLabServicesSkuCost>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailableLabServicesSkuCost>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvailableLabServicesSkuCost>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableLabServicesSkuCost>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableLabServicesSkuCost)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(MeterId))
            {
                writer.WritePropertyName("meterId"u8);
                writer.WriteStringValue(MeterId);
            }
            if (options.Format != "W" && Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ExtendedUnit))
            {
                writer.WritePropertyName("extendedUnit"u8);
                writer.WriteStringValue(ExtendedUnit);
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

        AvailableLabServicesSkuCost IJsonModel<AvailableLabServicesSkuCost>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableLabServicesSkuCost>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableLabServicesSkuCost)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableLabServicesSkuCost(document.RootElement, options);
        }

        internal static AvailableLabServicesSkuCost DeserializeAvailableLabServicesSkuCost(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string meterId = default;
            float? quantity = default;
            string extendedUnit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meterId"u8))
                {
                    meterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quantity = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("extendedUnit"u8))
                {
                    extendedUnit = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvailableLabServicesSkuCost(meterId, quantity, extendedUnit, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailableLabServicesSkuCost>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableLabServicesSkuCost>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerLabServicesContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AvailableLabServicesSkuCost)} does not support writing '{options.Format}' format.");
            }
        }

        AvailableLabServicesSkuCost IPersistableModel<AvailableLabServicesSkuCost>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableLabServicesSkuCost>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAvailableLabServicesSkuCost(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailableLabServicesSkuCost)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailableLabServicesSkuCost>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
