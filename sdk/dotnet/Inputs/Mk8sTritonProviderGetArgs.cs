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

    public sealed class Mk8sTritonProviderGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoscaler")]
        public Input<Inputs.Mk8sTritonProviderAutoscalerGetArgs>? Autoscaler { get; set; }

        [Input("connection", required: true)]
        public Input<Inputs.Mk8sTritonProviderConnectionGetArgs> Connection { get; set; } = null!;

        /// <summary>
        /// Enable firewall for the instances deployed.
        /// </summary>
        [Input("firewallEnabled")]
        public Input<bool>? FirewallEnabled { get; set; }

        /// <summary>
        /// Default image for all nodes.
        /// </summary>
        [Input("imageId", required: true)]
        public Input<string> ImageId { get; set; } = null!;

        /// <summary>
        /// Control Plane location that will host the K8s components. Prefer one that is closest to the Triton datacenter.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("networking", required: true)]
        public Input<Inputs.Mk8sTritonProviderNetworkingGetArgs> Networking { get; set; } = null!;

        [Input("nodePools")]
        private InputList<Inputs.Mk8sTritonProviderNodePoolGetArgs>? _nodePools;

        /// <summary>
        /// List of node pools.
        /// </summary>
        public InputList<Inputs.Mk8sTritonProviderNodePoolGetArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sTritonProviderNodePoolGetArgs>());
            set => _nodePools = value;
        }

        /// <summary>
        /// Optional shell script that will be run before K8s is installed. Supports SSM.
        /// </summary>
        [Input("preInstallScript")]
        public Input<string>? PreInstallScript { get; set; }

        /// <summary>
        /// ID of the private Fabric/Network.
        /// </summary>
        [Input("privateNetworkId", required: true)]
        public Input<string> PrivateNetworkId { get; set; } = null!;

        [Input("sshKeys")]
        private InputList<string>? _sshKeys;

        /// <summary>
        /// Extra SSH keys to provision for user root.
        /// </summary>
        public InputList<string> SshKeys
        {
            get => _sshKeys ?? (_sshKeys = new InputList<string>());
            set => _sshKeys = value;
        }

        public Mk8sTritonProviderGetArgs()
        {
        }
        public static new Mk8sTritonProviderGetArgs Empty => new Mk8sTritonProviderGetArgs();
    }
}
