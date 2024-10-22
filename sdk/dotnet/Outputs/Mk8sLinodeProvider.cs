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
    public sealed class Mk8sLinodeProvider
    {
        public readonly ImmutableArray<string> AuthorizedKeys;
        public readonly ImmutableArray<string> AuthorizedUsers;
        public readonly Outputs.Mk8sLinodeProviderAutoscaler? Autoscaler;
        public readonly string? FirewallId;
        public readonly string Image;
        public readonly Outputs.Mk8sLinodeProviderNetworking Networking;
        public readonly ImmutableArray<Outputs.Mk8sLinodeProviderNodePool> NodePools;
        public readonly string? PreInstallScript;
        public readonly string Region;
        public readonly string TokenSecretLink;
        public readonly string VpcId;

        [OutputConstructor]
        private Mk8sLinodeProvider(
            ImmutableArray<string> authorizedKeys,

            ImmutableArray<string> authorizedUsers,

            Outputs.Mk8sLinodeProviderAutoscaler? autoscaler,

            string? firewallId,

            string image,

            Outputs.Mk8sLinodeProviderNetworking networking,

            ImmutableArray<Outputs.Mk8sLinodeProviderNodePool> nodePools,

            string? preInstallScript,

            string region,

            string tokenSecretLink,

            string vpcId)
        {
            AuthorizedKeys = authorizedKeys;
            AuthorizedUsers = authorizedUsers;
            Autoscaler = autoscaler;
            FirewallId = firewallId;
            Image = image;
            Networking = networking;
            NodePools = nodePools;
            PreInstallScript = preInstallScript;
            Region = region;
            TokenSecretLink = tokenSecretLink;
            VpcId = vpcId;
        }
    }
}
