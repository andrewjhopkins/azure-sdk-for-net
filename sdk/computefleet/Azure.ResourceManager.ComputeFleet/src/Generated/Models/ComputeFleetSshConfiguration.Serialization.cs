// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    internal partial class ComputeFleetSshConfiguration : IUtf8JsonSerializable, IJsonModel<ComputeFleetSshConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeFleetSshConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeFleetSshConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetSshConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetSshConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(PublicKeys))
            {
                writer.WritePropertyName("publicKeys"u8);
                writer.WriteStartArray();
                foreach (var item in PublicKeys)
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

        ComputeFleetSshConfiguration IJsonModel<ComputeFleetSshConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetSshConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetSshConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeFleetSshConfiguration(document.RootElement, options);
        }

        internal static ComputeFleetSshConfiguration DeserializeComputeFleetSshConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ComputeFleetSshPublicKey> publicKeys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeFleetSshPublicKey> array = new List<ComputeFleetSshPublicKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeFleetSshPublicKey.DeserializeComputeFleetSshPublicKey(item, options));
                    }
                    publicKeys = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeFleetSshConfiguration(publicKeys ?? new ChangeTrackingList<ComputeFleetSshPublicKey>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeFleetSshConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetSshConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerComputeFleetContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetSshConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeFleetSshConfiguration IPersistableModel<ComputeFleetSshConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetSshConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeComputeFleetSshConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetSshConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeFleetSshConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
