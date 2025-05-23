// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Encode.Duration._Property
{
    public partial class FloatSecondsDurationArrayProperty : IJsonModel<FloatSecondsDurationArrayProperty>
    {
        internal FloatSecondsDurationArrayProperty() => throw null;

        void IJsonModel<FloatSecondsDurationArrayProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        FloatSecondsDurationArrayProperty IJsonModel<FloatSecondsDurationArrayProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual FloatSecondsDurationArrayProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<FloatSecondsDurationArrayProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        FloatSecondsDurationArrayProperty IPersistableModel<FloatSecondsDurationArrayProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual FloatSecondsDurationArrayProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<FloatSecondsDurationArrayProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="floatSecondsDurationArrayProperty"> The <see cref="FloatSecondsDurationArrayProperty"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(FloatSecondsDurationArrayProperty floatSecondsDurationArrayProperty) => throw null;

        public static explicit operator FloatSecondsDurationArrayProperty(Response result) => throw null;
    }
}
