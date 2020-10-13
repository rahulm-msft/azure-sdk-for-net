// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteLinkMacSecConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CknSecretIdentifier))
            {
                writer.WritePropertyName("cknSecretIdentifier");
                writer.WriteStringValue(CknSecretIdentifier);
            }
            if (Optional.IsDefined(CakSecretIdentifier))
            {
                writer.WritePropertyName("cakSecretIdentifier");
                writer.WriteStringValue(CakSecretIdentifier);
            }
            if (Optional.IsDefined(Cipher))
            {
                writer.WritePropertyName("cipher");
                writer.WriteStringValue(Cipher.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ExpressRouteLinkMacSecConfig DeserializeExpressRouteLinkMacSecConfig(JsonElement element)
        {
            Optional<string> cknSecretIdentifier = default;
            Optional<string> cakSecretIdentifier = default;
            Optional<ExpressRouteLinkMacSecCipher> cipher = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cknSecretIdentifier"))
                {
                    cknSecretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cakSecretIdentifier"))
                {
                    cakSecretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cipher"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cipher = new ExpressRouteLinkMacSecCipher(property.Value.GetString());
                    continue;
                }
            }
            return new ExpressRouteLinkMacSecConfig(cknSecretIdentifier.Value, cakSecretIdentifier.Value, Optional.ToNullable(cipher));
        }
    }
}
