// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    public partial class AgentEvaluationRedactionConfiguration : IUtf8JsonSerializable, IJsonModel<AgentEvaluationRedactionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentEvaluationRedactionConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AgentEvaluationRedactionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentEvaluationRedactionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentEvaluationRedactionConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RedactScoreProperties))
            {
                writer.WritePropertyName("redactScoreProperties"u8);
                writer.WriteBooleanValue(RedactScoreProperties.Value);
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

        AgentEvaluationRedactionConfiguration IJsonModel<AgentEvaluationRedactionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentEvaluationRedactionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentEvaluationRedactionConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentEvaluationRedactionConfiguration(document.RootElement, options);
        }

        internal static AgentEvaluationRedactionConfiguration DeserializeAgentEvaluationRedactionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? redactScoreProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("redactScoreProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redactScoreProperties = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AgentEvaluationRedactionConfiguration(redactScoreProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgentEvaluationRedactionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentEvaluationRedactionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIProjectsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AgentEvaluationRedactionConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        AgentEvaluationRedactionConfiguration IPersistableModel<AgentEvaluationRedactionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentEvaluationRedactionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAgentEvaluationRedactionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentEvaluationRedactionConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentEvaluationRedactionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AgentEvaluationRedactionConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAgentEvaluationRedactionConfiguration(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
