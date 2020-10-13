// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ComputeOperationListResult
    {
        internal static ComputeOperationListResult DeserializeComputeOperationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ComputeOperationValue>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ComputeOperationValue> array = new List<ComputeOperationValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeOperationValue.DeserializeComputeOperationValue(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ComputeOperationListResult(Optional.ToList(value));
        }
    }
}
