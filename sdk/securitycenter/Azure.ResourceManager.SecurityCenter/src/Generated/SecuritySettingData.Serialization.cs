// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecuritySettingData : IUtf8JsonSerializable, IJsonModel<SecuritySettingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecuritySettingData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecuritySettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecuritySettingData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
        }

        SecuritySettingData IJsonModel<SecuritySettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecuritySettingData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecuritySettingData(document.RootElement, options);
        }

        internal static SecuritySettingData DeserializeSecuritySettingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AlertSyncSettings": return SecurityAlertSyncSettings.DeserializeSecurityAlertSyncSettings(element, options);
                    case "DataExportSettings": return DataExportSettings.DeserializeDataExportSettings(element, options);
                }
            }
            return UnknownSetting.DeserializeUnknownSetting(element, options);
        }

        BinaryData IPersistableModel<SecuritySettingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SecuritySettingData)} does not support writing '{options.Format}' format.");
            }
        }

        SecuritySettingData IPersistableModel<SecuritySettingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecuritySettingData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecuritySettingData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecuritySettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
