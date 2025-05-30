// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Quantum.Jobs.Models
{
    public partial class UsageEvent
    {
        internal static UsageEvent DeserializeUsageEvent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dimensionId = default;
            string dimensionName = default;
            string measureUnit = default;
            float? amountBilled = default;
            float? amountConsumed = default;
            float? unitPrice = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensionId"u8))
                {
                    dimensionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionName"u8))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("measureUnit"u8))
                {
                    measureUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amountBilled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amountBilled = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("amountConsumed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amountConsumed = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("unitPrice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unitPrice = property.Value.GetSingle();
                    continue;
                }
            }
            return new UsageEvent(
                dimensionId,
                dimensionName,
                measureUnit,
                amountBilled,
                amountConsumed,
                unitPrice);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UsageEvent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeUsageEvent(document.RootElement);
        }
    }
}
