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

    public sealed class Mk8sLinodeProviderArgs : global::Pulumi.ResourceArgs
    {
        [Input("authorizedKeys")]
        private InputList<string>? _authorizedKeys;
        public InputList<string> AuthorizedKeys
        {
            get => _authorizedKeys ?? (_authorizedKeys = new InputList<string>());
            set => _authorizedKeys = value;
        }

        [Input("authorizedUsers")]
        private InputList<string>? _authorizedUsers;
        public InputList<string> AuthorizedUsers
        {
            get => _authorizedUsers ?? (_authorizedUsers = new InputList<string>());
            set => _authorizedUsers = value;
        }

        [Input("autoscaler")]
        public Input<Inputs.Mk8sLinodeProviderAutoscalerArgs>? Autoscaler { get; set; }

        [Input("firewallId")]
        public Input<string>? FirewallId { get; set; }

        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        [Input("networking", required: true)]
        public Input<Inputs.Mk8sLinodeProviderNetworkingArgs> Networking { get; set; } = null!;

        [Input("nodePools")]
        private InputList<Inputs.Mk8sLinodeProviderNodePoolArgs>? _nodePools;
        public InputList<Inputs.Mk8sLinodeProviderNodePoolArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sLinodeProviderNodePoolArgs>());
            set => _nodePools = value;
        }

        [Input("preInstallScript")]
        public Input<string>? PreInstallScript { get; set; }

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("tokenSecretLink", required: true)]
        public Input<string> TokenSecretLink { get; set; } = null!;

        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public Mk8sLinodeProviderArgs()
        {
        }
        public static new Mk8sLinodeProviderArgs Empty => new Mk8sLinodeProviderArgs();
    }
}
