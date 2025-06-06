// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ManagedRuleSet : IUtf8JsonSerializable, IJsonModel<ManagedRuleSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedRuleSet>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedRuleSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedRuleSet)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("ruleSetType"u8);
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion"u8);
            writer.WriteStringValue(RuleSetVersion);
            if (Optional.IsCollectionDefined(RuleGroupOverrides))
            {
                writer.WritePropertyName("ruleGroupOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in RuleGroupOverrides)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ComputedDisabledRules))
            {
                writer.WritePropertyName("computedDisabledRules"u8);
                writer.WriteStartArray();
                foreach (var item in ComputedDisabledRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ManagedRuleSet IJsonModel<ManagedRuleSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedRuleSet)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedRuleSet(document.RootElement, options);
        }

        internal static ManagedRuleSet DeserializeManagedRuleSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleSetType = default;
            string ruleSetVersion = default;
            IList<ManagedRuleGroupOverride> ruleGroupOverrides = default;
            IReadOnlyList<ManagedRuleSetRuleGroup> computedDisabledRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleSetType"u8))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"u8))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleGroupOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedRuleGroupOverride> array = new List<ManagedRuleGroupOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleGroupOverride.DeserializeManagedRuleGroupOverride(item, options));
                    }
                    ruleGroupOverrides = array;
                    continue;
                }
                if (property.NameEquals("computedDisabledRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedRuleSetRuleGroup> array = new List<ManagedRuleSetRuleGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleSetRuleGroup.DeserializeManagedRuleSetRuleGroup(item, options));
                    }
                    computedDisabledRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedRuleSet(ruleSetType, ruleSetVersion, ruleGroupOverrides ?? new ChangeTrackingList<ManagedRuleGroupOverride>(), computedDisabledRules ?? new ChangeTrackingList<ManagedRuleSetRuleGroup>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedRuleSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ManagedRuleSet)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedRuleSet IPersistableModel<ManagedRuleSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedRuleSet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedRuleSet)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedRuleSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
