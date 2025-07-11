// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
        public readonly Outputs.Mk8sTritonProviderConnection? Connection;
        /// <summary>
        /// Enable firewall for the instances deployed.
        /// </summary>
        public readonly bool? FirewallEnabled;
        /// <summary>
        /// Default image for all nodes.
        /// </summary>
        public readonly string ImageId;
        public readonly Outputs.Mk8sTritonProviderLoadBalancer? LoadBalancer;
        /// <summary>
        /// Control Plane location that will host the K8s components. Prefer one that is closest to the Triton datacenter.
        /// </summary>
        public readonly string Location;
        public readonly Outputs.Mk8sTritonProviderNetworking? Networking;
        /// <summary>
        /// List of node pools.
        /// </summary>
        public readonly ImmutableArray<Outputs.Mk8sTritonProviderNodePool> NodePools;
        /// <summary>
        /// Optional shell script that will be run before K8s is installed. Supports SSM.
        /// </summary>
        public readonly string? PreInstallScript;
        /// <summary>
        /// ID of the private Fabric/Network.
        /// </summary>
        public readonly string PrivateNetworkId;
        /// <summary>
        /// Extra SSH keys to provision for user root.
        /// </summary>
        public readonly ImmutableArray<string> SshKeys;

        [OutputConstructor]
        private Mk8sTritonProvider(
            Outputs.Mk8sTritonProviderAutoscaler? autoscaler,

            Outputs.Mk8sTritonProviderConnection? connection,

            bool? firewallEnabled,

            string imageId,

            Outputs.Mk8sTritonProviderLoadBalancer? loadBalancer,

            string location,

            Outputs.Mk8sTritonProviderNetworking? networking,

            ImmutableArray<Outputs.Mk8sTritonProviderNodePool> nodePools,

            string? preInstallScript,

            string privateNetworkId,

            ImmutableArray<string> sshKeys)
        {
            Autoscaler = autoscaler;
            Connection = connection;
            FirewallEnabled = firewallEnabled;
            ImageId = imageId;
            LoadBalancer = loadBalancer;
            Location = location;
            Networking = networking;
            NodePools = nodePools;
            PreInstallScript = preInstallScript;
            PrivateNetworkId = privateNetworkId;
            SshKeys = sshKeys;
        }
    }
}
