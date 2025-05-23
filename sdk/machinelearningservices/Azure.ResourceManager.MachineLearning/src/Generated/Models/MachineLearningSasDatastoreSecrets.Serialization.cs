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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningSasDatastoreSecrets : IUtf8JsonSerializable, IJsonModel<MachineLearningSasDatastoreSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSasDatastoreSecrets>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningSasDatastoreSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSasDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSasDatastoreSecrets)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(SasToken))
            {
                if (SasToken != null)
                {
                    writer.WritePropertyName("sasToken"u8);
                    writer.WriteStringValue(SasToken);
                }
                else
                {
                    writer.WriteNull("sasToken");
                }
            }
        }

        MachineLearningSasDatastoreSecrets IJsonModel<MachineLearningSasDatastoreSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSasDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSasDatastoreSecrets)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSasDatastoreSecrets(document.RootElement, options);
        }

        internal static MachineLearningSasDatastoreSecrets DeserializeMachineLearningSasDatastoreSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sasToken = default;
            SecretsType secretsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sasToken = null;
                        continue;
                    }
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"u8))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningSasDatastoreSecrets(secretsType, serializedAdditionalRawData, sasToken);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SasToken), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sasToken: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SasToken))
                {
                    builder.Append("  sasToken: ");
                    if (SasToken.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SasToken}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SasToken}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecretsType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  secretsType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  secretsType: ");
                builder.AppendLine($"'{SecretsType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningSasDatastoreSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSasDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSasDatastoreSecrets)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningSasDatastoreSecrets IPersistableModel<MachineLearningSasDatastoreSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSasDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningSasDatastoreSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSasDatastoreSecrets)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningSasDatastoreSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
