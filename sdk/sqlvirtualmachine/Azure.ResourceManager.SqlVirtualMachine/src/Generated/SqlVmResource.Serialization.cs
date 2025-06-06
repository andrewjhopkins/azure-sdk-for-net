// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    public partial class SqlVmResource : IJsonModel<SqlVmData>
    {
        private static SqlVmData s_dataDeserializationInstance;
        private static SqlVmData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SqlVmData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlVmData>)Data).Write(writer, options);

        SqlVmData IJsonModel<SqlVmData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlVmData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SqlVmData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SqlVmData>(Data, options, AzureResourceManagerSqlVirtualMachineContext.Default);

        SqlVmData IPersistableModel<SqlVmData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlVmData>(data, options, AzureResourceManagerSqlVirtualMachineContext.Default);

        string IPersistableModel<SqlVmData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlVmData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
