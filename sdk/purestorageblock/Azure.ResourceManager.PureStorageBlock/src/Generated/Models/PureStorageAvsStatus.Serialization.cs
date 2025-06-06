// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PureStorageBlock.Models
{
    public partial class PureStorageAvsStatus : IUtf8JsonSerializable, IJsonModel<PureStorageAvsStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PureStorageAvsStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PureStorageAvsStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PureStorageAvsStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PureStorageAvsStatus)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("avsEnabled"u8);
            writer.WriteBooleanValue(IsAvsEnabled);
            writer.WritePropertyName("currentConnectionStatus"u8);
            writer.WriteStringValue(CurrentConnectionStatus);
            if (Optional.IsDefined(ClusterResourceId))
            {
                writer.WritePropertyName("sddcResourceId"u8);
                writer.WriteStringValue(ClusterResourceId);
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

        PureStorageAvsStatus IJsonModel<PureStorageAvsStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PureStorageAvsStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PureStorageAvsStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePureStorageAvsStatus(document.RootElement, options);
        }

        internal static PureStorageAvsStatus DeserializePureStorageAvsStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool avsEnabled = default;
            string currentConnectionStatus = default;
            ResourceIdentifier sddcResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("avsEnabled"u8))
                {
                    avsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("currentConnectionStatus"u8))
                {
                    currentConnectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sddcResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sddcResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PureStorageAvsStatus(avsEnabled, currentConnectionStatus, sddcResourceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PureStorageAvsStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PureStorageAvsStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPureStorageBlockContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PureStorageAvsStatus)} does not support writing '{options.Format}' format.");
            }
        }

        PureStorageAvsStatus IPersistableModel<PureStorageAvsStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PureStorageAvsStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePureStorageAvsStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PureStorageAvsStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PureStorageAvsStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
