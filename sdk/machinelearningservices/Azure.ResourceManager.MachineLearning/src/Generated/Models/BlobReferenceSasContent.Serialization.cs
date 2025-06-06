// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class BlobReferenceSasContent : IUtf8JsonSerializable, IJsonModel<BlobReferenceSasContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobReferenceSasContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BlobReferenceSasContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceSasContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobReferenceSasContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AssetId))
            {
                if (AssetId != null)
                {
                    writer.WritePropertyName("assetId"u8);
                    writer.WriteStringValue(AssetId);
                }
                else
                {
                    writer.WriteNull("assetId");
                }
            }
            if (Optional.IsDefined(BlobUri))
            {
                if (BlobUri != null)
                {
                    writer.WritePropertyName("blobUri"u8);
                    writer.WriteStringValue(BlobUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("blobUri");
                }
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

        BlobReferenceSasContent IJsonModel<BlobReferenceSasContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceSasContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobReferenceSasContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobReferenceSasContent(document.RootElement, options);
        }

        internal static BlobReferenceSasContent DeserializeBlobReferenceSasContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assetId = default;
            Uri blobUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assetId = null;
                        continue;
                    }
                    assetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blobUri = null;
                        continue;
                    }
                    blobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BlobReferenceSasContent(assetId, blobUri, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BlobReferenceSasContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceSasContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                default:
                    throw new FormatException($"The model {nameof(BlobReferenceSasContent)} does not support writing '{options.Format}' format.");
            }
        }

        BlobReferenceSasContent IPersistableModel<BlobReferenceSasContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceSasContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBlobReferenceSasContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BlobReferenceSasContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlobReferenceSasContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
