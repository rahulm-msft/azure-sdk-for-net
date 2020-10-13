// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteGatewayList
    {
        internal static ExpressRouteGatewayList DeserializeExpressRouteGatewayList(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressRouteGateway>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ExpressRouteGateway> array = new List<ExpressRouteGateway>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRouteGateway.DeserializeExpressRouteGateway(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ExpressRouteGatewayList(Optional.ToList(value));
        }
    }
}
