// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class Mk8sHetznerProviderGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoscaler")]
        public Input<Inputs.Mk8sHetznerProviderAutoscalerGetArgs>? Autoscaler { get; set; }

        [Input("dedicatedServerNodePools")]
        private InputList<Inputs.Mk8sHetznerProviderDedicatedServerNodePoolGetArgs>? _dedicatedServerNodePools;

        /// <summary>
        /// Node pools that can configure dedicated Hetzner servers.
        /// </summary>
        public InputList<Inputs.Mk8sHetznerProviderDedicatedServerNodePoolGetArgs> DedicatedServerNodePools
        {
            get => _dedicatedServerNodePools ?? (_dedicatedServerNodePools = new InputList<Inputs.Mk8sHetznerProviderDedicatedServerNodePoolGetArgs>());
            set => _dedicatedServerNodePools = value;
        }

        /// <summary>
        /// Optional firewall rule to attach to all nodes.
        /// </summary>
        [Input("firewallId")]
        public Input<string>? FirewallId { get; set; }

        [Input("floatingIpSelector")]
        private InputMap<string>? _floatingIpSelector;

        /// <summary>
        /// If supplied, nodes will get assigned a random floating ip matching the selector.
        /// </summary>
        public InputMap<string> FloatingIpSelector
        {
            get => _floatingIpSelector ?? (_floatingIpSelector = new InputMap<string>());
            set => _floatingIpSelector = value;
        }

        [Input("hetznerLabels")]
        private InputMap<string>? _hetznerLabels;

        /// <summary>
        /// Extra labels to attach to servers.
        /// </summary>
        public InputMap<string> HetznerLabels
        {
            get => _hetznerLabels ?? (_hetznerLabels = new InputMap<string>());
            set => _hetznerLabels = value;
        }

        /// <summary>
        /// Default image for all nodes.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// ID of the Hetzner network to deploy nodes to.
        /// </summary>
        [Input("networkId", required: true)]
        public Input<string> NetworkId { get; set; } = null!;

        [Input("networking", required: true)]
        public Input<Inputs.Mk8sHetznerProviderNetworkingGetArgs> Networking { get; set; } = null!;

        [Input("nodePools")]
        private InputList<Inputs.Mk8sHetznerProviderNodePoolGetArgs>? _nodePools;

        /// <summary>
        /// List of node pools.
        /// </summary>
        public InputList<Inputs.Mk8sHetznerProviderNodePoolGetArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sHetznerProviderNodePoolGetArgs>());
            set => _nodePools = value;
        }

        /// <summary>
        /// Optional shell script that will be run before K8s is installed. Supports SSM.
        /// </summary>
        [Input("preInstallScript")]
        public Input<string>? PreInstallScript { get; set; }

        /// <summary>
        /// Hetzner region to deploy nodes to.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        /// <summary>
        /// SSH key name for accessing deployed nodes.
        /// </summary>
        [Input("sshKey")]
        public Input<string>? SshKey { get; set; }

        /// <summary>
        /// Link to a secret holding Hetzner access key.
        /// </summary>
        [Input("tokenSecretLink", required: true)]
        public Input<string> TokenSecretLink { get; set; } = null!;

        public Mk8sHetznerProviderGetArgs()
        {
        }
        public static new Mk8sHetznerProviderGetArgs Empty => new Mk8sHetznerProviderGetArgs();
    }
}
