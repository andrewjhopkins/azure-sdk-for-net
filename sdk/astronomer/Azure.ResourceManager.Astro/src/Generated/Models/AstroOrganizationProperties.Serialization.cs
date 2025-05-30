// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Astro.Models
{
    public partial class AstroOrganizationProperties : IUtf8JsonSerializable, IJsonModel<AstroOrganizationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AstroOrganizationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AstroOrganizationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AstroOrganizationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AstroOrganizationProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("marketplace"u8);
            writer.WriteObjectValue(Marketplace, options);
            writer.WritePropertyName("user"u8);
            writer.WriteObjectValue(User, options);
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(PartnerOrganizationProperties))
            {
                writer.WritePropertyName("partnerOrganizationProperties"u8);
                writer.WriteObjectValue(PartnerOrganizationProperties, options);
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

        AstroOrganizationProperties IJsonModel<AstroOrganizationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AstroOrganizationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AstroOrganizationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAstroOrganizationProperties(document.RootElement, options);
        }

        internal static AstroOrganizationProperties DeserializeAstroOrganizationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AstroMarketplaceDetails marketplace = default;
            AstroUserDetails user = default;
            AstroResourceProvisioningState? provisioningState = default;
            AstroPartnerOrganizationProperties partnerOrganizationProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplace"u8))
                {
                    marketplace = AstroMarketplaceDetails.DeserializeAstroMarketplaceDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    user = AstroUserDetails.DeserializeAstroUserDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AstroResourceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("partnerOrganizationProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partnerOrganizationProperties = AstroPartnerOrganizationProperties.DeserializeAstroPartnerOrganizationProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AstroOrganizationProperties(marketplace, user, provisioningState, partnerOrganizationProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AstroOrganizationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AstroOrganizationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAstroContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AstroOrganizationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AstroOrganizationProperties IPersistableModel<AstroOrganizationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AstroOrganizationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAstroOrganizationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AstroOrganizationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AstroOrganizationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
