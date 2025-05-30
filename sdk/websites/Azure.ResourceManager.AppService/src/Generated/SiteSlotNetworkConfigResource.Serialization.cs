// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteSlotNetworkConfigResource : IJsonModel<SwiftVirtualNetworkData>
    {
        private static SwiftVirtualNetworkData s_dataDeserializationInstance;
        private static SwiftVirtualNetworkData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SwiftVirtualNetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SwiftVirtualNetworkData>)Data).Write(writer, options);

        SwiftVirtualNetworkData IJsonModel<SwiftVirtualNetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SwiftVirtualNetworkData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SwiftVirtualNetworkData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SwiftVirtualNetworkData>(Data, options, AzureResourceManagerAppServiceContext.Default);

        SwiftVirtualNetworkData IPersistableModel<SwiftVirtualNetworkData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SwiftVirtualNetworkData>(data, options, AzureResourceManagerAppServiceContext.Default);

        string IPersistableModel<SwiftVirtualNetworkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SwiftVirtualNetworkData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
