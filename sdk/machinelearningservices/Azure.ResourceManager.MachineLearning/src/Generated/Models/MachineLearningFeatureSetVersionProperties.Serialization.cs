// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningFeatureSetVersionProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningFeatureSetVersionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningFeatureSetVersionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningFeatureSetVersionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFeatureSetVersionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningFeatureSetVersionProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Specification))
            {
                if (Specification != null)
                {
                    writer.WritePropertyName("specification"u8);
                    writer.WriteObjectValue(Specification, options);
                }
                else
                {
                    writer.WriteNull("specification");
                }
            }
            if (Optional.IsDefined(MaterializationSettings))
            {
                if (MaterializationSettings != null)
                {
                    writer.WritePropertyName("materializationSettings"u8);
                    writer.WriteObjectValue(MaterializationSettings, options);
                }
                else
                {
                    writer.WriteNull("materializationSettings");
                }
            }
            if (Optional.IsDefined(Stage))
            {
                if (Stage != null)
                {
                    writer.WritePropertyName("stage"u8);
                    writer.WriteStringValue(Stage);
                }
                else
                {
                    writer.WriteNull("stage");
                }
            }
            if (Optional.IsCollectionDefined(Entities))
            {
                if (Entities != null)
                {
                    writer.WritePropertyName("entities"u8);
                    writer.WriteStartArray();
                    foreach (var item in Entities)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("entities");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
        }

        MachineLearningFeatureSetVersionProperties IJsonModel<MachineLearningFeatureSetVersionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFeatureSetVersionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningFeatureSetVersionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningFeatureSetVersionProperties(document.RootElement, options);
        }

        internal static MachineLearningFeatureSetVersionProperties DeserializeMachineLearningFeatureSetVersionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FeaturesetSpecification specification = default;
            MaterializationSettings materializationSettings = default;
            string stage = default;
            IList<string> entities = default;
            RegistryAssetProvisioningState? provisioningState = default;
            bool? isArchived = default;
            bool? isAnonymous = default;
            string description = default;
            IDictionary<string, string> tags = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("specification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        specification = null;
                        continue;
                    }
                    specification = FeaturesetSpecification.DeserializeFeaturesetSpecification(property.Value, options);
                    continue;
                }
                if (property.NameEquals("materializationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        materializationSettings = null;
                        continue;
                    }
                    materializationSettings = MaterializationSettings.DeserializeMaterializationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("stage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stage = null;
                        continue;
                    }
                    stage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        entities = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new RegistryAssetProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningFeatureSetVersionProperties(
                description,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                properties ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                isArchived,
                isAnonymous,
                specification,
                materializationSettings,
                stage,
                entities ?? new ChangeTrackingList<string>(),
                provisioningState);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("SpecificationPath", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  specification: ");
                builder.AppendLine("{");
                builder.Append("    path: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Specification))
                {
                    builder.Append("  specification: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Specification, options, 2, false, "  specification: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaterializationSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  materializationSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaterializationSettings))
                {
                    builder.Append("  materializationSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, MaterializationSettings, options, 2, false, "  materializationSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Stage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  stage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Stage))
                {
                    builder.Append("  stage: ");
                    if (Stage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Stage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Stage}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Entities), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  entities: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Entities))
                {
                    if (Entities.Any())
                    {
                        builder.Append("  entities: ");
                        builder.AppendLine("[");
                        foreach (var item in Entities)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsArchived), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isArchived: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsArchived))
                {
                    builder.Append("  isArchived: ");
                    var boolValue = IsArchived.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsAnonymous), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isAnonymous: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsAnonymous))
                {
                    builder.Append("  isAnonymous: ");
                    var boolValue = IsAnonymous.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Properties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  properties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Properties))
                {
                    if (Properties.Any())
                    {
                        builder.Append("  properties: ");
                        builder.AppendLine("{");
                        foreach (var item in Properties)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningFeatureSetVersionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFeatureSetVersionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningFeatureSetVersionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningFeatureSetVersionProperties IPersistableModel<MachineLearningFeatureSetVersionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFeatureSetVersionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningFeatureSetVersionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningFeatureSetVersionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningFeatureSetVersionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
