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

    public sealed class Mk8sAwsProviderArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoscaler")]
        public Input<Inputs.Mk8sAwsProviderAutoscalerArgs>? Autoscaler { get; set; }

        [Input("awsTags")]
        private InputMap<string>? _awsTags;
        public InputMap<string> AwsTags
        {
            get => _awsTags ?? (_awsTags = new InputMap<string>());
            set => _awsTags = value;
        }

        [Input("deployRoleArn", required: true)]
        public Input<string> DeployRoleArn { get; set; } = null!;

        [Input("deployRoleChains")]
        private InputList<Inputs.Mk8sAwsProviderDeployRoleChainArgs>? _deployRoleChains;
        public InputList<Inputs.Mk8sAwsProviderDeployRoleChainArgs> DeployRoleChains
        {
            get => _deployRoleChains ?? (_deployRoleChains = new InputList<Inputs.Mk8sAwsProviderDeployRoleChainArgs>());
            set => _deployRoleChains = value;
        }

        [Input("diskEncryptionKeyArn")]
        public Input<string>? DiskEncryptionKeyArn { get; set; }

        [Input("extraNodePolicies")]
        private InputList<string>? _extraNodePolicies;
        public InputList<string> ExtraNodePolicies
        {
            get => _extraNodePolicies ?? (_extraNodePolicies = new InputList<string>());
            set => _extraNodePolicies = value;
        }

        [Input("image", required: true)]
        public Input<Inputs.Mk8sAwsProviderImageArgs> Image { get; set; } = null!;

        [Input("keyPair")]
        public Input<string>? KeyPair { get; set; }

        [Input("networking", required: true)]
        public Input<Inputs.Mk8sAwsProviderNetworkingArgs> Networking { get; set; } = null!;

        [Input("nodePools")]
        private InputList<Inputs.Mk8sAwsProviderNodePoolArgs>? _nodePools;
        public InputList<Inputs.Mk8sAwsProviderNodePoolArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sAwsProviderNodePoolArgs>());
            set => _nodePools = value;
        }

        [Input("preInstallScript")]
        public Input<string>? PreInstallScript { get; set; }

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("skipCreateRoles")]
        public Input<bool>? SkipCreateRoles { get; set; }

        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public Mk8sAwsProviderArgs()
        {
        }
        public static new Mk8sAwsProviderArgs Empty => new Mk8sAwsProviderArgs();
    }
}
