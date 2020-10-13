// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class CheckNameResult
    {
        internal static CheckNameResult DeserializeCheckNameResult(JsonElement element)
        {
            Optional<bool> nameAvailable = default;
            Optional<string> name = default;
            Optional<string> message = default;
            Optional<Reason> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reason = new Reason(property.Value.GetString());
                    continue;
                }
            }
            return new CheckNameResult(Optional.ToNullable(nameAvailable), name.Value, message.Value, Optional.ToNullable(reason));
        }
    }
}
