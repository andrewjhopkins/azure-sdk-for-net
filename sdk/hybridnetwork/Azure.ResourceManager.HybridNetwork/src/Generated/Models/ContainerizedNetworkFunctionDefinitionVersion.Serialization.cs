// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ContainerizedNetworkFunctionDefinitionVersion : IUtf8JsonSerializable, IJsonModel<ContainerizedNetworkFunctionDefinitionVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerizedNetworkFunctionDefinitionVersion>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerizedNetworkFunctionDefinitionVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerizedNetworkFunctionDefinitionVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerizedNetworkFunctionDefinitionVersion)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(NetworkFunctionTemplate))
            {
                writer.WritePropertyName("networkFunctionTemplate"u8);
                writer.WriteObjectValue(NetworkFunctionTemplate, options);
            }
        }

        ContainerizedNetworkFunctionDefinitionVersion IJsonModel<ContainerizedNetworkFunctionDefinitionVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerizedNetworkFunctionDefinitionVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerizedNetworkFunctionDefinitionVersion)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerizedNetworkFunctionDefinitionVersion(document.RootElement, options);
        }

        internal static ContainerizedNetworkFunctionDefinitionVersion DeserializeContainerizedNetworkFunctionDefinitionVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerizedNetworkFunctionTemplate networkFunctionTemplate = default;
            ProvisioningState? provisioningState = default;
            VersionState? versionState = default;
            string description = default;
            string deployParameters = default;
            NetworkFunctionType networkFunctionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkFunctionTemplate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkFunctionTemplate = ContainerizedNetworkFunctionTemplate.DeserializeContainerizedNetworkFunctionTemplate(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionState = new VersionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deployParameters"u8))
                {
                    deployParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionType"u8))
                {
                    networkFunctionType = new NetworkFunctionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerizedNetworkFunctionDefinitionVersion(
                provisioningState,
                versionState,
                description,
                deployParameters,
                networkFunctionType,
                serializedAdditionalRawData,
                networkFunctionTemplate);
        }

        BinaryData IPersistableModel<ContainerizedNetworkFunctionDefinitionVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerizedNetworkFunctionDefinitionVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ContainerizedNetworkFunctionDefinitionVersion)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerizedNetworkFunctionDefinitionVersion IPersistableModel<ContainerizedNetworkFunctionDefinitionVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerizedNetworkFunctionDefinitionVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerizedNetworkFunctionDefinitionVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerizedNetworkFunctionDefinitionVersion)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerizedNetworkFunctionDefinitionVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
