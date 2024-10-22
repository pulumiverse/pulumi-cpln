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

    public sealed class Mk8sAwsProviderGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoscaler")]
        public Input<Inputs.Mk8sAwsProviderAutoscalerGetArgs>? Autoscaler { get; set; }

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
        private InputList<Inputs.Mk8sAwsProviderDeployRoleChainGetArgs>? _deployRoleChains;
        public InputList<Inputs.Mk8sAwsProviderDeployRoleChainGetArgs> DeployRoleChains
        {
            get => _deployRoleChains ?? (_deployRoleChains = new InputList<Inputs.Mk8sAwsProviderDeployRoleChainGetArgs>());
            set => _deployRoleChains = value;
        }

        [Input("diskEncryptionKeyArn")]
        public Input<string>? DiskEncryptionKeyArn { get; set; }

        [Input("image", required: true)]
        public Input<Inputs.Mk8sAwsProviderImageGetArgs> Image { get; set; } = null!;

        [Input("keyPair")]
        public Input<string>? KeyPair { get; set; }

        [Input("networking", required: true)]
        public Input<Inputs.Mk8sAwsProviderNetworkingGetArgs> Networking { get; set; } = null!;

        [Input("nodePools")]
        private InputList<Inputs.Mk8sAwsProviderNodePoolGetArgs>? _nodePools;
        public InputList<Inputs.Mk8sAwsProviderNodePoolGetArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sAwsProviderNodePoolGetArgs>());
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

        public Mk8sAwsProviderGetArgs()
        {
        }
        public static new Mk8sAwsProviderGetArgs Empty => new Mk8sAwsProviderGetArgs();
    }
}
