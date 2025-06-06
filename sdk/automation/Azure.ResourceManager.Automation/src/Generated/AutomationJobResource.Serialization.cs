// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationJobResource : IJsonModel<AutomationJobData>
    {
        private static AutomationJobData s_dataDeserializationInstance;
        private static AutomationJobData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<AutomationJobData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AutomationJobData>)Data).Write(writer, options);

        AutomationJobData IJsonModel<AutomationJobData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AutomationJobData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<AutomationJobData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AutomationJobData>(Data, options, AzureResourceManagerAutomationContext.Default);

        AutomationJobData IPersistableModel<AutomationJobData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AutomationJobData>(data, options, AzureResourceManagerAutomationContext.Default);

        string IPersistableModel<AutomationJobData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AutomationJobData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
