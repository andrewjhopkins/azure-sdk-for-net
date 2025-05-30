// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontDoorResource : IJsonModel<FrontDoorData>
    {
        private static FrontDoorData s_dataDeserializationInstance;
        private static FrontDoorData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<FrontDoorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorData>)Data).Write(writer, options);

        FrontDoorData IJsonModel<FrontDoorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<FrontDoorData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<FrontDoorData>(Data, options, AzureResourceManagerFrontDoorContext.Default);

        FrontDoorData IPersistableModel<FrontDoorData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FrontDoorData>(data, options, AzureResourceManagerFrontDoorContext.Default);

        string IPersistableModel<FrontDoorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FrontDoorData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
