// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServicePlacementPreferPrimaryDomainPolicy : IUtf8JsonSerializable, IJsonModel<ServicePlacementPreferPrimaryDomainPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServicePlacementPreferPrimaryDomainPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServicePlacementPreferPrimaryDomainPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePlacementPreferPrimaryDomainPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServicePlacementPreferPrimaryDomainPolicy)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
        }

        ServicePlacementPreferPrimaryDomainPolicy IJsonModel<ServicePlacementPreferPrimaryDomainPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePlacementPreferPrimaryDomainPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServicePlacementPreferPrimaryDomainPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePlacementPreferPrimaryDomainPolicy(document.RootElement, options);
        }

        internal static ServicePlacementPreferPrimaryDomainPolicy DeserializeServicePlacementPreferPrimaryDomainPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            ServicePlacementPolicyType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ServicePlacementPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServicePlacementPreferPrimaryDomainPolicy(type, serializedAdditionalRawData, domainName);
        }

        BinaryData IPersistableModel<ServicePlacementPreferPrimaryDomainPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePlacementPreferPrimaryDomainPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerServiceFabricManagedClustersContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ServicePlacementPreferPrimaryDomainPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ServicePlacementPreferPrimaryDomainPolicy IPersistableModel<ServicePlacementPreferPrimaryDomainPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePlacementPreferPrimaryDomainPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeServicePlacementPreferPrimaryDomainPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServicePlacementPreferPrimaryDomainPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServicePlacementPreferPrimaryDomainPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
