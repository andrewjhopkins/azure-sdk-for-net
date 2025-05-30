// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.DigitalTwins.Core
{
    internal partial class IncomingRelationshipCollection
    {
        internal static IncomingRelationshipCollection DeserializeIncomingRelationshipCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IncomingRelationship> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<IncomingRelationship> array = new List<IncomingRelationship>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IncomingRelationship.DeserializeIncomingRelationship(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new IncomingRelationshipCollection(value, nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static IncomingRelationshipCollection FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeIncomingRelationshipCollection(document.RootElement);
        }
    }
}
