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

    public sealed class Mk8sTritonProviderArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoscaler")]
        public Input<Inputs.Mk8sTritonProviderAutoscalerArgs>? Autoscaler { get; set; }

        [Input("connection", required: true)]
        public Input<Inputs.Mk8sTritonProviderConnectionArgs> Connection { get; set; } = null!;

        [Input("firewallEnabled")]
        public Input<bool>? FirewallEnabled { get; set; }

        [Input("imageId", required: true)]
        public Input<string> ImageId { get; set; } = null!;

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("networking", required: true)]
        public Input<Inputs.Mk8sTritonProviderNetworkingArgs> Networking { get; set; } = null!;

        [Input("nodePools")]
        private InputList<Inputs.Mk8sTritonProviderNodePoolArgs>? _nodePools;
        public InputList<Inputs.Mk8sTritonProviderNodePoolArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sTritonProviderNodePoolArgs>());
            set => _nodePools = value;
        }

        [Input("preInstallScript")]
        public Input<string>? PreInstallScript { get; set; }

        [Input("privateNetworkId", required: true)]
        public Input<string> PrivateNetworkId { get; set; } = null!;

        [Input("sshKeys")]
        private InputList<string>? _sshKeys;
        public InputList<string> SshKeys
        {
            get => _sshKeys ?? (_sshKeys = new InputList<string>());
            set => _sshKeys = value;
        }

        public Mk8sTritonProviderArgs()
        {
        }
        public static new Mk8sTritonProviderArgs Empty => new Mk8sTritonProviderArgs();
    }
}
