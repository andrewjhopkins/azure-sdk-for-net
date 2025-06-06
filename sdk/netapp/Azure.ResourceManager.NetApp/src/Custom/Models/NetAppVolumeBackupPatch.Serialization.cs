﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBackupPatch : IUtf8JsonSerializable, IJsonModel<NetAppVolumeBackupPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeBackupPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppVolumeBackupPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsDefined(UseExistingSnapshot))
            {
                writer.WritePropertyName("useExistingSnapshot"u8);
                writer.WriteBooleanValue(UseExistingSnapshot.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        NetAppVolumeBackupPatch IJsonModel<NetAppVolumeBackupPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBackupPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeBackupPatch(document.RootElement, options);
        }

        internal static NetAppVolumeBackupPatch DeserializeNetAppVolumeBackupPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumeBackupPatch(serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeBackupPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetAppContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBackupPatch)} does not support '{options.Format}' format.");
            }
        }

        NetAppVolumeBackupPatch IPersistableModel<NetAppVolumeBackupPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBackupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeBackupPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBackupPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeBackupPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
