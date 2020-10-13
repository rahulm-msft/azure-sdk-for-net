// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class RouteListResult
    {
        internal static RouteListResult DeserializeRouteListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Route>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Route> array = new List<Route>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Route.DeserializeRoute(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new RouteListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
