// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VpnSiteLinkConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VpnSiteLink))
            {
                writer.WritePropertyName("vpnSiteLink");
                writer.WriteObjectValue(VpnSiteLink);
            }
            if (Optional.IsDefined(RoutingWeight))
            {
                writer.WritePropertyName("routingWeight");
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (Optional.IsDefined(VpnConnectionProtocolType))
            {
                writer.WritePropertyName("vpnConnectionProtocolType");
                writer.WriteStringValue(VpnConnectionProtocolType.Value.ToString());
            }
            if (Optional.IsDefined(ConnectionBandwidth))
            {
                writer.WritePropertyName("connectionBandwidth");
                writer.WriteNumberValue(ConnectionBandwidth.Value);
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey");
                writer.WriteStringValue(SharedKey);
            }
            if (Optional.IsDefined(EnableBgp))
            {
                writer.WritePropertyName("enableBgp");
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (Optional.IsDefined(UsePolicyBasedTrafficSelectors))
            {
                writer.WritePropertyName("usePolicyBasedTrafficSelectors");
                writer.WriteBooleanValue(UsePolicyBasedTrafficSelectors.Value);
            }
            if (Optional.IsCollectionDefined(IpsecPolicies))
            {
                writer.WritePropertyName("ipsecPolicies");
                writer.WriteStartArray();
                foreach (var item in IpsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableRateLimiting))
            {
                writer.WritePropertyName("enableRateLimiting");
                writer.WriteBooleanValue(EnableRateLimiting.Value);
            }
            if (Optional.IsDefined(UseLocalAzureIpAddress))
            {
                writer.WritePropertyName("useLocalAzureIpAddress");
                writer.WriteBooleanValue(UseLocalAzureIpAddress.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnSiteLinkConnection DeserializeVpnSiteLinkConnection(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<SubResource> vpnSiteLink = default;
            Optional<int> routingWeight = default;
            Optional<VpnConnectionStatus> connectionStatus = default;
            Optional<VirtualNetworkGatewayConnectionProtocol> vpnConnectionProtocolType = default;
            Optional<long> ingressBytesTransferred = default;
            Optional<long> egressBytesTransferred = default;
            Optional<int> connectionBandwidth = default;
            Optional<string> sharedKey = default;
            Optional<bool> enableBgp = default;
            Optional<bool> usePolicyBasedTrafficSelectors = default;
            Optional<IList<IpsecPolicy>> ipsecPolicies = default;
            Optional<bool> enableRateLimiting = default;
            Optional<bool> useLocalAzureIpAddress = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("vpnSiteLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnSiteLink = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectionStatus = new VpnConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnConnectionProtocolType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnConnectionProtocolType = new VirtualNetworkGatewayConnectionProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ingressBytesTransferred"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ingressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("egressBytesTransferred"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            egressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("connectionBandwidth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectionBandwidth = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("usePolicyBasedTrafficSelectors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usePolicyBasedTrafficSelectors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ipsecPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<IpsecPolicy> array = new List<IpsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IpsecPolicy.DeserializeIpsecPolicy(item));
                            }
                            ipsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("enableRateLimiting"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableRateLimiting = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useLocalAzureIpAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useLocalAzureIpAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnSiteLinkConnection(id.Value, name.Value, etag.Value, type.Value, vpnSiteLink.Value, Optional.ToNullable(routingWeight), Optional.ToNullable(connectionStatus), Optional.ToNullable(vpnConnectionProtocolType), Optional.ToNullable(ingressBytesTransferred), Optional.ToNullable(egressBytesTransferred), Optional.ToNullable(connectionBandwidth), sharedKey.Value, Optional.ToNullable(enableBgp), Optional.ToNullable(usePolicyBasedTrafficSelectors), Optional.ToList(ipsecPolicies), Optional.ToNullable(enableRateLimiting), Optional.ToNullable(useLocalAzureIpAddress), Optional.ToNullable(provisioningState));
        }
    }
}
