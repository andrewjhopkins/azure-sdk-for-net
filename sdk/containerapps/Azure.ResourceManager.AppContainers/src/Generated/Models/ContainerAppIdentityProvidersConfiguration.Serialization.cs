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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppIdentityProvidersConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppIdentityProvidersConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppIdentityProvidersConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppIdentityProvidersConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIdentityProvidersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppIdentityProvidersConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AzureActiveDirectory))
            {
                writer.WritePropertyName("azureActiveDirectory"u8);
                writer.WriteObjectValue(AzureActiveDirectory, options);
            }
            if (Optional.IsDefined(Facebook))
            {
                writer.WritePropertyName("facebook"u8);
                writer.WriteObjectValue(Facebook, options);
            }
            if (Optional.IsDefined(GitHub))
            {
                writer.WritePropertyName("gitHub"u8);
                writer.WriteObjectValue(GitHub, options);
            }
            if (Optional.IsDefined(Google))
            {
                writer.WritePropertyName("google"u8);
                writer.WriteObjectValue(Google, options);
            }
            if (Optional.IsDefined(Twitter))
            {
                writer.WritePropertyName("twitter"u8);
                writer.WriteObjectValue(Twitter, options);
            }
            if (Optional.IsDefined(Apple))
            {
                writer.WritePropertyName("apple"u8);
                writer.WriteObjectValue(Apple, options);
            }
            if (Optional.IsDefined(AzureStaticWebApps))
            {
                writer.WritePropertyName("azureStaticWebApps"u8);
                writer.WriteObjectValue(AzureStaticWebApps, options);
            }
            if (Optional.IsCollectionDefined(CustomOpenIdConnectProviders))
            {
                writer.WritePropertyName("customOpenIdConnectProviders"u8);
                writer.WriteStartObject();
                foreach (var item in CustomOpenIdConnectProviders)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
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

        ContainerAppIdentityProvidersConfiguration IJsonModel<ContainerAppIdentityProvidersConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIdentityProvidersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppIdentityProvidersConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppIdentityProvidersConfiguration(document.RootElement, options);
        }

        internal static ContainerAppIdentityProvidersConfiguration DeserializeContainerAppIdentityProvidersConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerAppAzureActiveDirectoryConfiguration azureActiveDirectory = default;
            ContainerAppFacebookConfiguration facebook = default;
            ContainerAppGitHubConfiguration gitHub = default;
            ContainerAppGoogleConfiguration google = default;
            ContainerAppTwitterConfiguration twitter = default;
            ContainerAppAppleConfiguration apple = default;
            ContainerAppAzureStaticWebAppsConfiguration azureStaticWebApps = default;
            IDictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration> customOpenIdConnectProviders = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureActiveDirectory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureActiveDirectory = ContainerAppAzureActiveDirectoryConfiguration.DeserializeContainerAppAzureActiveDirectoryConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("facebook"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    facebook = ContainerAppFacebookConfiguration.DeserializeContainerAppFacebookConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("gitHub"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHub = ContainerAppGitHubConfiguration.DeserializeContainerAppGitHubConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("google"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    google = ContainerAppGoogleConfiguration.DeserializeContainerAppGoogleConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("twitter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    twitter = ContainerAppTwitterConfiguration.DeserializeContainerAppTwitterConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("apple"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apple = ContainerAppAppleConfiguration.DeserializeContainerAppAppleConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureStaticWebApps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStaticWebApps = ContainerAppAzureStaticWebAppsConfiguration.DeserializeContainerAppAzureStaticWebAppsConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("customOpenIdConnectProviders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration> dictionary = new Dictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ContainerAppCustomOpenIdConnectProviderConfiguration.DeserializeContainerAppCustomOpenIdConnectProviderConfiguration(property0.Value, options));
                    }
                    customOpenIdConnectProviders = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppIdentityProvidersConfiguration(
                azureActiveDirectory,
                facebook,
                gitHub,
                google,
                twitter,
                apple,
                azureStaticWebApps,
                customOpenIdConnectProviders ?? new ChangeTrackingDictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureActiveDirectory), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureActiveDirectory: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureActiveDirectory))
                {
                    builder.Append("  azureActiveDirectory: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AzureActiveDirectory, options, 2, false, "  azureActiveDirectory: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Facebook), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  facebook: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Facebook))
                {
                    builder.Append("  facebook: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Facebook, options, 2, false, "  facebook: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GitHub), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  gitHub: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GitHub))
                {
                    builder.Append("  gitHub: ");
                    BicepSerializationHelpers.AppendChildObject(builder, GitHub, options, 2, false, "  gitHub: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Google), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  google: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Google))
                {
                    builder.Append("  google: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Google, options, 2, false, "  google: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Twitter), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  twitter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Twitter))
                {
                    builder.Append("  twitter: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Twitter, options, 2, false, "  twitter: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Apple), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apple: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Apple))
                {
                    builder.Append("  apple: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Apple, options, 2, false, "  apple: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureStaticWebApps), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureStaticWebApps: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureStaticWebApps))
                {
                    builder.Append("  azureStaticWebApps: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AzureStaticWebApps, options, 2, false, "  azureStaticWebApps: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomOpenIdConnectProviders), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customOpenIdConnectProviders: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(CustomOpenIdConnectProviders))
                {
                    if (CustomOpenIdConnectProviders.Any())
                    {
                        builder.Append("  customOpenIdConnectProviders: ");
                        builder.AppendLine("{");
                        foreach (var item in CustomOpenIdConnectProviders)
                        {
                            builder.Append($"    '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 4, false, "  customOpenIdConnectProviders: ");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppIdentityProvidersConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIdentityProvidersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppIdentityProvidersConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppIdentityProvidersConfiguration IPersistableModel<ContainerAppIdentityProvidersConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIdentityProvidersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppIdentityProvidersConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppIdentityProvidersConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppIdentityProvidersConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
