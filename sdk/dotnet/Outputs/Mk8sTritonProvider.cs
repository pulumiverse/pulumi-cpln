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
    public sealed class Mk8sTritonProvider
    {
        public readonly Outputs.Mk8sTritonProviderAutoscaler? Autoscaler;
        public readonly Outputs.Mk8sTritonProviderConnection Connection;
        public readonly bool? FirewallEnabled;
        public readonly string ImageId;
        public readonly string Location;
        public readonly Outputs.Mk8sTritonProviderNetworking Networking;
        public readonly ImmutableArray<Outputs.Mk8sTritonProviderNodePool> NodePools;
        public readonly string? PreInstallScript;
        public readonly string PrivateNetworkId;
        public readonly ImmutableArray<string> SshKeys;

        [OutputConstructor]
        private Mk8sTritonProvider(
            Outputs.Mk8sTritonProviderAutoscaler? autoscaler,

            Outputs.Mk8sTritonProviderConnection connection,

            bool? firewallEnabled,

            string imageId,

            string location,

            Outputs.Mk8sTritonProviderNetworking networking,

            ImmutableArray<Outputs.Mk8sTritonProviderNodePool> nodePools,

            string? preInstallScript,

            string privateNetworkId,

            ImmutableArray<string> sshKeys)
        {
            Autoscaler = autoscaler;
            Connection = connection;
            FirewallEnabled = firewallEnabled;
            ImageId = imageId;
            Location = location;
            Networking = networking;
            NodePools = nodePools;
            PreInstallScript = preInstallScript;
            PrivateNetworkId = privateNetworkId;
            SshKeys = sshKeys;
        }
    }
}
