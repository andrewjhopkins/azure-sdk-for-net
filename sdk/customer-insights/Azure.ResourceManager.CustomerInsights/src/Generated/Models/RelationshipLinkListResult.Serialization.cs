// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    internal partial class RelationshipLinkListResult : IUtf8JsonSerializable, IJsonModel<RelationshipLinkListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RelationshipLinkListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RelationshipLinkListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelationshipLinkListResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        RelationshipLinkListResult IJsonModel<RelationshipLinkListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelationshipLinkListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRelationshipLinkListResult(document.RootElement, options);
        }

        internal static RelationshipLinkListResult DeserializeRelationshipLinkListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RelationshipLinkResourceFormatData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RelationshipLinkResourceFormatData> array = new List<RelationshipLinkResourceFormatData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RelationshipLinkResourceFormatData.DeserializeRelationshipLinkResourceFormatData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RelationshipLinkListResult(value ?? new ChangeTrackingList<RelationshipLinkResourceFormatData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RelationshipLinkListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCustomerInsightsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RelationshipLinkListResult)} does not support writing '{options.Format}' format.");
            }
        }

        RelationshipLinkListResult IPersistableModel<RelationshipLinkListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRelationshipLinkListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RelationshipLinkListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RelationshipLinkListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
