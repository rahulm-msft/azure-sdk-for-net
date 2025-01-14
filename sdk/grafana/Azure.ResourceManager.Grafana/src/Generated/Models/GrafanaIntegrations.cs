// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> GrafanaIntegrations is a bundled observability experience (e.g. pre-configured data source, tailored Grafana dashboards, alerting defaults) for common monitoring scenarios. </summary>
    internal partial class GrafanaIntegrations
    {
        /// <summary> Initializes a new instance of GrafanaIntegrations. </summary>
        public GrafanaIntegrations()
        {
            MonitorWorkspaceIntegrations = new ChangeTrackingList<MonitorWorkspaceIntegration>();
        }

        /// <summary> Initializes a new instance of GrafanaIntegrations. </summary>
        /// <param name="monitorWorkspaceIntegrations"></param>
        internal GrafanaIntegrations(IList<MonitorWorkspaceIntegration> monitorWorkspaceIntegrations)
        {
            MonitorWorkspaceIntegrations = monitorWorkspaceIntegrations;
        }

        /// <summary> Gets the monitor workspace integrations. </summary>
        public IList<MonitorWorkspaceIntegration> MonitorWorkspaceIntegrations { get; }
    }
}
