// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class BillingProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxPrice))
            {
                writer.WritePropertyName("maxPrice");
                writer.WriteNumberValue(MaxPrice.Value);
            }
            writer.WriteEndObject();
        }

        internal static BillingProfile DeserializeBillingProfile(JsonElement element)
        {
            Optional<double> maxPrice = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPrice"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxPrice = property.Value.GetDouble();
                    continue;
                }
            }
            return new BillingProfile(Optional.ToNullable(maxPrice));
        }
    }
}
