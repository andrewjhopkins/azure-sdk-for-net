// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeClusterMemoryCapacity : IUtf8JsonSerializable, IJsonModel<EdgeClusterMemoryCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeClusterMemoryCapacity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdgeClusterMemoryCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterMemoryCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeClusterMemoryCapacity)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ClusterFreeMemoryInMB))
            {
                writer.WritePropertyName("clusterFreeMemoryMb"u8);
                writer.WriteNumberValue(ClusterFreeMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterUsedMemoryInMB))
            {
                writer.WritePropertyName("clusterUsedMemoryMb"u8);
                writer.WriteNumberValue(ClusterUsedMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterFailoverMemoryInMB))
            {
                writer.WritePropertyName("clusterFailoverMemoryMb"u8);
                writer.WriteNumberValue(ClusterFailoverMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterFragmentationMemoryInMB))
            {
                writer.WritePropertyName("clusterFragmentationMemoryMb"u8);
                writer.WriteNumberValue(ClusterFragmentationMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterHyperVReserveMemoryMb))
            {
                writer.WritePropertyName("clusterHypervReserveMemoryMb"u8);
                writer.WriteNumberValue(ClusterHyperVReserveMemoryMb.Value);
            }
            if (Optional.IsDefined(ClusterInfraVmMemoryInMB))
            {
                writer.WritePropertyName("clusterInfraVmMemoryMb"u8);
                writer.WriteNumberValue(ClusterInfraVmMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterTotalMemoryInMB))
            {
                writer.WritePropertyName("clusterTotalMemoryMb"u8);
                writer.WriteNumberValue(ClusterTotalMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterNonFailoverVmInMB))
            {
                writer.WritePropertyName("clusterNonFailoverVmMb"u8);
                writer.WriteNumberValue(ClusterNonFailoverVmInMB.Value);
            }
            if (Optional.IsDefined(ClusterMemoryUsedByVmsInMB))
            {
                writer.WritePropertyName("clusterMemoryUsedByVmsMb"u8);
                writer.WriteNumberValue(ClusterMemoryUsedByVmsInMB.Value);
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

        EdgeClusterMemoryCapacity IJsonModel<EdgeClusterMemoryCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterMemoryCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeClusterMemoryCapacity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeClusterMemoryCapacity(document.RootElement, options);
        }

        internal static EdgeClusterMemoryCapacity DeserializeEdgeClusterMemoryCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double? clusterFreeMemoryMb = default;
            double? clusterUsedMemoryMb = default;
            double? clusterFailoverMemoryMb = default;
            double? clusterFragmentationMemoryMb = default;
            double? clusterHyperVReserveMemoryMb = default;
            double? clusterInfraVmMemoryMb = default;
            double? clusterTotalMemoryMb = default;
            double? clusterNonFailoverVmMb = default;
            double? clusterMemoryUsedByVmsMb = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterFreeMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterFreeMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterUsedMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterUsedMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterFailoverMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterFailoverMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterFragmentationMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterFragmentationMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterHypervReserveMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterHyperVReserveMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterInfraVmMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterInfraVmMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterTotalMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterTotalMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterNonFailoverVmMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterNonFailoverVmMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterMemoryUsedByVmsMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterMemoryUsedByVmsMb = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdgeClusterMemoryCapacity(
                clusterFreeMemoryMb,
                clusterUsedMemoryMb,
                clusterFailoverMemoryMb,
                clusterFragmentationMemoryMb,
                clusterHyperVReserveMemoryMb,
                clusterInfraVmMemoryMb,
                clusterTotalMemoryMb,
                clusterNonFailoverVmMb,
                clusterMemoryUsedByVmsMb,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeClusterMemoryCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterMemoryCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxEdgeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EdgeClusterMemoryCapacity)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeClusterMemoryCapacity IPersistableModel<EdgeClusterMemoryCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterMemoryCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdgeClusterMemoryCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeClusterMemoryCapacity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeClusterMemoryCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
