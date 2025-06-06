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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AnalysisDetectorEvidences : IUtf8JsonSerializable, IJsonModel<AnalysisDetectorEvidences>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalysisDetectorEvidences>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnalysisDetectorEvidences>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisDetectorEvidences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisDetectorEvidences)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(DetectorDefinition))
            {
                writer.WritePropertyName("detectorDefinition"u8);
                writer.WriteObjectValue(DetectorDefinition, options);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0, options);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DetectorMetaData))
            {
                writer.WritePropertyName("detectorMetaData"u8);
                writer.WriteObjectValue(DetectorMetaData, options);
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

        AnalysisDetectorEvidences IJsonModel<AnalysisDetectorEvidences>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisDetectorEvidences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisDetectorEvidences)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalysisDetectorEvidences(document.RootElement, options);
        }

        internal static AnalysisDetectorEvidences DeserializeAnalysisDetectorEvidences(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string source = default;
            DetectorDefinition detectorDefinition = default;
            IList<DiagnosticMetricSet> metrics = default;
            IList<IList<AppServiceNameValuePair>> data = default;
            DetectorMetadata detectorMetaData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detectorDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectorDefinition = DetectorDefinition.DeserializeDetectorDefinition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiagnosticMetricSet> array = new List<DiagnosticMetricSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiagnosticMetricSet.DeserializeDiagnosticMetricSet(item, options));
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<AppServiceNameValuePair>> array = new List<IList<AppServiceNameValuePair>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<AppServiceNameValuePair> array0 = new List<AppServiceNameValuePair>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item0, options));
                            }
                            array.Add(array0);
                        }
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("detectorMetaData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectorMetaData = DetectorMetadata.DeserializeDetectorMetadata(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AnalysisDetectorEvidences(
                source,
                detectorDefinition,
                metrics ?? new ChangeTrackingList<DiagnosticMetricSet>(),
                data ?? new ChangeTrackingList<IList<AppServiceNameValuePair>>(),
                detectorMetaData,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Source), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  source: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Source))
                {
                    builder.Append("  source: ");
                    if (Source.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Source}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Source}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DetectorDefinition), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  detectorDefinition: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DetectorDefinition))
                {
                    builder.Append("  detectorDefinition: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DetectorDefinition, options, 2, false, "  detectorDefinition: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Metrics), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metrics: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Metrics))
                {
                    if (Metrics.Any())
                    {
                        builder.Append("  metrics: ");
                        builder.AppendLine("[");
                        foreach (var item in Metrics)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  metrics: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Data), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  data: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Data))
                {
                    if (Data.Any())
                    {
                        builder.Append("  data: ");
                        builder.AppendLine("[");
                        foreach (var item in Data)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine("[");
                            foreach (var item0 in item)
                            {
                                BicepSerializationHelpers.AppendChildObject(builder, item0, options, 4, true, "  data: ");
                            }
                            builder.AppendLine("  ]");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("DataSource", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  detectorMetaData: ");
                builder.AppendLine("{");
                builder.Append("    dataSource: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(DetectorMetaData))
                {
                    builder.Append("  detectorMetaData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DetectorMetaData, options, 2, false, "  detectorMetaData: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AnalysisDetectorEvidences>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisDetectorEvidences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AnalysisDetectorEvidences)} does not support writing '{options.Format}' format.");
            }
        }

        AnalysisDetectorEvidences IPersistableModel<AnalysisDetectorEvidences>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisDetectorEvidences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAnalysisDetectorEvidences(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalysisDetectorEvidences)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalysisDetectorEvidences>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
