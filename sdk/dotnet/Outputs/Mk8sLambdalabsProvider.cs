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
    public sealed class Mk8sLambdalabsProvider
    {
        public readonly Outputs.Mk8sLambdalabsProviderAutoscaler? Autoscaler;
        public readonly ImmutableArray<Outputs.Mk8sLambdalabsProviderNodePool> NodePools;
        public readonly string? PreInstallScript;
        public readonly string Region;
        public readonly string SshKey;
        public readonly string TokenSecretLink;
        public readonly ImmutableArray<Outputs.Mk8sLambdalabsProviderUnmanagedNodePool> UnmanagedNodePools;

        [OutputConstructor]
        private Mk8sLambdalabsProvider(
            Outputs.Mk8sLambdalabsProviderAutoscaler? autoscaler,

            ImmutableArray<Outputs.Mk8sLambdalabsProviderNodePool> nodePools,

            string? preInstallScript,

            string region,

            string sshKey,

            string tokenSecretLink,

            ImmutableArray<Outputs.Mk8sLambdalabsProviderUnmanagedNodePool> unmanagedNodePools)
        {
            Autoscaler = autoscaler;
            NodePools = nodePools;
            PreInstallScript = preInstallScript;
            Region = region;
            SshKey = sshKey;
            TokenSecretLink = tokenSecretLink;
            UnmanagedNodePools = unmanagedNodePools;
        }
    }
}
