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

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingAzurePlan : IUtf8JsonSerializable, IJsonModel<BillingAzurePlan>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingAzurePlan>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingAzurePlan>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAzurePlan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingAzurePlan)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ProductId))
            {
                writer.WritePropertyName("productId"u8);
                writer.WriteStringValue(ProductId);
            }
            if (Optional.IsDefined(SkuId))
            {
                writer.WritePropertyName("skuId"u8);
                writer.WriteStringValue(SkuId);
            }
            if (Optional.IsDefined(SkuDescription))
            {
                writer.WritePropertyName("skuDescription"u8);
                writer.WriteStringValue(SkuDescription);
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

        BillingAzurePlan IJsonModel<BillingAzurePlan>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAzurePlan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingAzurePlan)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingAzurePlan(document.RootElement, options);
        }

        internal static BillingAzurePlan DeserializeBillingAzurePlan(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string productId = default;
            string skuId = default;
            string skuDescription = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("productId"u8))
                {
                    productId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuId"u8))
                {
                    skuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuDescription"u8))
                {
                    skuDescription = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingAzurePlan(productId, skuId, skuDescription, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProductId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  productId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProductId))
                {
                    builder.Append("  productId: ");
                    if (ProductId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProductId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProductId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SkuId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  skuId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SkuId))
                {
                    builder.Append("  skuId: ");
                    if (SkuId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SkuId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SkuId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SkuDescription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  skuDescription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SkuDescription))
                {
                    builder.Append("  skuDescription: ");
                    if (SkuDescription.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SkuDescription}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SkuDescription}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingAzurePlan>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAzurePlan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerBillingContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingAzurePlan)} does not support writing '{options.Format}' format.");
            }
        }

        BillingAzurePlan IPersistableModel<BillingAzurePlan>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAzurePlan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBillingAzurePlan(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingAzurePlan)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingAzurePlan>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
