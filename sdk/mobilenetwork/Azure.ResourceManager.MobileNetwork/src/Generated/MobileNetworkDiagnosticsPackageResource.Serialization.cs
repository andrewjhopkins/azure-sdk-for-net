// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkDiagnosticsPackageResource : IJsonModel<MobileNetworkDiagnosticsPackageData>
    {
        private static MobileNetworkDiagnosticsPackageData s_dataDeserializationInstance;
        private static MobileNetworkDiagnosticsPackageData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MobileNetworkDiagnosticsPackageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MobileNetworkDiagnosticsPackageData>)Data).Write(writer, options);

        MobileNetworkDiagnosticsPackageData IJsonModel<MobileNetworkDiagnosticsPackageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MobileNetworkDiagnosticsPackageData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MobileNetworkDiagnosticsPackageData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MobileNetworkDiagnosticsPackageData>(Data, options, AzureResourceManagerMobileNetworkContext.Default);

        MobileNetworkDiagnosticsPackageData IPersistableModel<MobileNetworkDiagnosticsPackageData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MobileNetworkDiagnosticsPackageData>(data, options, AzureResourceManagerMobileNetworkContext.Default);

        string IPersistableModel<MobileNetworkDiagnosticsPackageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MobileNetworkDiagnosticsPackageData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
