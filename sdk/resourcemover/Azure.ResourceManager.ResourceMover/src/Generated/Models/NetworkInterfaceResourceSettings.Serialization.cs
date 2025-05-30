// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class NetworkInterfaceResourceSettings : IUtf8JsonSerializable, IJsonModel<NetworkInterfaceResourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaceResourceSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkInterfaceResourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceResourceSettings)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableAcceleratedNetworking))
            {
                if (EnableAcceleratedNetworking != null)
                {
                    writer.WritePropertyName("enableAcceleratedNetworking"u8);
                    writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
                }
                else
                {
                    writer.WriteNull("enableAcceleratedNetworking");
                }
            }
        }

        NetworkInterfaceResourceSettings IJsonModel<NetworkInterfaceResourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceResourceSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceResourceSettings(document.RootElement, options);
        }

        internal static NetworkInterfaceResourceSettings DeserializeNetworkInterfaceResourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            IList<NicIPConfigurationResourceSettings> ipConfigurations = default;
            bool? enableAcceleratedNetworking = default;
            string resourceType = default;
            string targetResourceName = default;
            string targetResourceGroupName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("ipConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NicIPConfigurationResourceSettings> array = new List<NicIPConfigurationResourceSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NicIPConfigurationResourceSettings.DeserializeNicIPConfigurationResourceSettings(item, options));
                    }
                    ipConfigurations = array;
                    continue;
                }
                if (property.NameEquals("enableAcceleratedNetworking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableAcceleratedNetworking = null;
                        continue;
                    }
                    enableAcceleratedNetworking = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupName"u8))
                {
                    targetResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkInterfaceResourceSettings(
                resourceType,
                targetResourceName,
                targetResourceGroupName,
                serializedAdditionalRawData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                ipConfigurations ?? new ChangeTrackingList<NicIPConfigurationResourceSettings>(),
                enableAcceleratedNetworking);
        }

        BinaryData IPersistableModel<NetworkInterfaceResourceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerResourceMoverContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceResourceSettings)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkInterfaceResourceSettings IPersistableModel<NetworkInterfaceResourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkInterfaceResourceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceResourceSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkInterfaceResourceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
