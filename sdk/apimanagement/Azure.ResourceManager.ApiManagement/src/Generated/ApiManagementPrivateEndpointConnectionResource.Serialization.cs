// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementPrivateEndpointConnectionResource : IJsonModel<ApiManagementPrivateEndpointConnectionData>
    {
        private static ApiManagementPrivateEndpointConnectionData s_dataDeserializationInstance;
        private static ApiManagementPrivateEndpointConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ApiManagementPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementPrivateEndpointConnectionData>)Data).Write(writer, options);

        ApiManagementPrivateEndpointConnectionData IJsonModel<ApiManagementPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementPrivateEndpointConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ApiManagementPrivateEndpointConnectionData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        ApiManagementPrivateEndpointConnectionData IPersistableModel<ApiManagementPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementPrivateEndpointConnectionData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<ApiManagementPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementPrivateEndpointConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
