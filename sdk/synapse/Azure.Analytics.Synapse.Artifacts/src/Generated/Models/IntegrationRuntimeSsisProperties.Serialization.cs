// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(IntegrationRuntimeSsisPropertiesConverter))]
    public partial class IntegrationRuntimeSsisProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CatalogInfo))
            {
                writer.WritePropertyName("catalogInfo"u8);
                writer.WriteObjectValue(CatalogInfo);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(CustomSetupScriptProperties))
            {
                writer.WritePropertyName("customSetupScriptProperties"u8);
                writer.WriteObjectValue(CustomSetupScriptProperties);
            }
            if (Optional.IsDefined(DataProxyProperties))
            {
                writer.WritePropertyName("dataProxyProperties"u8);
                writer.WriteObjectValue(DataProxyProperties);
            }
            if (Optional.IsDefined(Edition))
            {
                writer.WritePropertyName("edition"u8);
                writer.WriteStringValue(Edition.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExpressCustomSetupProperties))
            {
                writer.WritePropertyName("expressCustomSetupProperties"u8);
                writer.WriteStartArray();
                foreach (var item in ExpressCustomSetupProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeSsisProperties DeserializeIntegrationRuntimeSsisProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeSsisCatalogInfo catalogInfo = default;
            IntegrationRuntimeLicenseType? licenseType = default;
            IntegrationRuntimeCustomSetupScriptProperties customSetupScriptProperties = default;
            IntegrationRuntimeDataProxyProperties dataProxyProperties = default;
            IntegrationRuntimeEdition? edition = default;
            IList<CustomSetupBase> expressCustomSetupProperties = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogInfo = IntegrationRuntimeSsisCatalogInfo.DeserializeIntegrationRuntimeSsisCatalogInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new IntegrationRuntimeLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customSetupScriptProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customSetupScriptProperties = IntegrationRuntimeCustomSetupScriptProperties.DeserializeIntegrationRuntimeCustomSetupScriptProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("dataProxyProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataProxyProperties = IntegrationRuntimeDataProxyProperties.DeserializeIntegrationRuntimeDataProxyProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("edition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    edition = new IntegrationRuntimeEdition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expressCustomSetupProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomSetupBase> array = new List<CustomSetupBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomSetupBase.DeserializeCustomSetupBase(item));
                    }
                    expressCustomSetupProperties = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeSsisProperties(
                catalogInfo,
                licenseType,
                customSetupScriptProperties,
                dataProxyProperties,
                edition,
                expressCustomSetupProperties ?? new ChangeTrackingList<CustomSetupBase>(),
                additionalProperties);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static IntegrationRuntimeSsisProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeIntegrationRuntimeSsisProperties(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class IntegrationRuntimeSsisPropertiesConverter : JsonConverter<IntegrationRuntimeSsisProperties>
        {
            public override void Write(Utf8JsonWriter writer, IntegrationRuntimeSsisProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override IntegrationRuntimeSsisProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIntegrationRuntimeSsisProperties(document.RootElement);
            }
        }
    }
}
