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
    public sealed class Mk8sGenericProvider
    {
        /// <summary>
        /// Control Plane location that will host the K8s components. Prefer one that is closest to where the nodes are running.
        /// </summary>
        public readonly string Location;
        public readonly Outputs.Mk8sGenericProviderNetworking Networking;
        /// <summary>
        /// List of node pools.
        /// </summary>
        public readonly ImmutableArray<Outputs.Mk8sGenericProviderNodePool> NodePools;

        [OutputConstructor]
        private Mk8sGenericProvider(
            string location,

            Outputs.Mk8sGenericProviderNetworking networking,

            ImmutableArray<Outputs.Mk8sGenericProviderNodePool> nodePools)
        {
            Location = location;
            Networking = networking;
            NodePools = nodePools;
        }
    }
}
