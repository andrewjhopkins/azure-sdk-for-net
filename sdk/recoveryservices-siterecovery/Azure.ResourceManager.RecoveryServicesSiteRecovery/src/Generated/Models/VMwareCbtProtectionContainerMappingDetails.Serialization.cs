// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtProtectionContainerMappingDetails : IUtf8JsonSerializable, IJsonModel<VMwareCbtProtectionContainerMappingDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtProtectionContainerMappingDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareCbtProtectionContainerMappingDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectionContainerMappingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtProtectionContainerMappingDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUri"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageAccountSasSecretName))
            {
                writer.WritePropertyName("storageAccountSasSecretName"u8);
                writer.WriteStringValue(StorageAccountSasSecretName);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceBusConnectionStringSecretName))
            {
                writer.WritePropertyName("serviceBusConnectionStringSecretName"u8);
                writer.WriteStringValue(ServiceBusConnectionStringSecretName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetLocation))
            {
                writer.WritePropertyName("targetLocation"u8);
                writer.WriteStringValue(TargetLocation);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RoleSizeToNicCountMap))
            {
                writer.WritePropertyName("roleSizeToNicCountMap"u8);
                writer.WriteStartObject();
                foreach (var item in RoleSizeToNicCountMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ExcludedSkus))
            {
                writer.WritePropertyName("excludedSkus"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedSkus)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
        }

        VMwareCbtProtectionContainerMappingDetails IJsonModel<VMwareCbtProtectionContainerMappingDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectionContainerMappingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtProtectionContainerMappingDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtProtectionContainerMappingDetails(document.RootElement, options);
        }

        internal static VMwareCbtProtectionContainerMappingDetails DeserializeVMwareCbtProtectionContainerMappingDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier keyVaultId = default;
            Uri keyVaultUri = default;
            ResourceIdentifier storageAccountId = default;
            string storageAccountSasSecretName = default;
            string serviceBusConnectionStringSecretName = default;
            string targetLocation = default;
            IReadOnlyDictionary<string, int> roleSizeToNicCountMap = default;
            IReadOnlyList<string> excludedSkus = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountSasSecretName"u8))
                {
                    storageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceBusConnectionStringSecretName"u8))
                {
                    serviceBusConnectionStringSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleSizeToNicCountMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    roleSizeToNicCountMap = dictionary;
                    continue;
                }
                if (property.NameEquals("excludedSkus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedSkus = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VMwareCbtProtectionContainerMappingDetails(
                instanceType,
                serializedAdditionalRawData,
                keyVaultId,
                keyVaultUri,
                storageAccountId,
                storageAccountSasSecretName,
                serviceBusConnectionStringSecretName,
                targetLocation,
                roleSizeToNicCountMap ?? new ChangeTrackingDictionary<string, int>(),
                excludedSkus ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<VMwareCbtProtectionContainerMappingDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectionContainerMappingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtProtectionContainerMappingDetails)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareCbtProtectionContainerMappingDetails IPersistableModel<VMwareCbtProtectionContainerMappingDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectionContainerMappingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVMwareCbtProtectionContainerMappingDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtProtectionContainerMappingDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareCbtProtectionContainerMappingDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
