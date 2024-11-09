// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Outputs
{

    [OutputType]
    public sealed class Mk8sAwsProvider
    {
        public readonly Outputs.Mk8sAwsProviderAutoscaler? Autoscaler;
        public readonly ImmutableDictionary<string, string>? AwsTags;
        public readonly string DeployRoleArn;
        public readonly ImmutableArray<Outputs.Mk8sAwsProviderDeployRoleChain> DeployRoleChains;
        public readonly string? DiskEncryptionKeyArn;
        public readonly ImmutableArray<string> ExtraNodePolicies;
        public readonly Outputs.Mk8sAwsProviderImage Image;
        public readonly string? KeyPair;
        public readonly Outputs.Mk8sAwsProviderNetworking Networking;
        public readonly ImmutableArray<Outputs.Mk8sAwsProviderNodePool> NodePools;
        public readonly string? PreInstallScript;
        public readonly string Region;
        public readonly ImmutableArray<string> SecurityGroupIds;
        public readonly bool? SkipCreateRoles;
        public readonly string VpcId;

        [OutputConstructor]
        private Mk8sAwsProvider(
            Outputs.Mk8sAwsProviderAutoscaler? autoscaler,

            ImmutableDictionary<string, string>? awsTags,

            string deployRoleArn,

            ImmutableArray<Outputs.Mk8sAwsProviderDeployRoleChain> deployRoleChains,

            string? diskEncryptionKeyArn,

            ImmutableArray<string> extraNodePolicies,

            Outputs.Mk8sAwsProviderImage image,

            string? keyPair,

            Outputs.Mk8sAwsProviderNetworking networking,

            ImmutableArray<Outputs.Mk8sAwsProviderNodePool> nodePools,

            string? preInstallScript,

            string region,

            ImmutableArray<string> securityGroupIds,

            bool? skipCreateRoles,

            string vpcId)
        {
            Autoscaler = autoscaler;
            AwsTags = awsTags;
            DeployRoleArn = deployRoleArn;
            DeployRoleChains = deployRoleChains;
            DiskEncryptionKeyArn = diskEncryptionKeyArn;
            ExtraNodePolicies = extraNodePolicies;
            Image = image;
            KeyPair = keyPair;
            Networking = networking;
            NodePools = nodePools;
            PreInstallScript = preInstallScript;
            Region = region;
            SecurityGroupIds = securityGroupIds;
            SkipCreateRoles = skipCreateRoles;
            VpcId = vpcId;
        }
    }
}
