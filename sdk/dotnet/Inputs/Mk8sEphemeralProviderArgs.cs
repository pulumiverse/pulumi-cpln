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

    public sealed class Mk8sEphemeralProviderArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Control Plane location that will host the K8s components. Prefer one that is closest to where the nodes are running.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("nodePools")]
        private InputList<Inputs.Mk8sEphemeralProviderNodePoolArgs>? _nodePools;

        /// <summary>
        /// List of node pools.
        /// </summary>
        public InputList<Inputs.Mk8sEphemeralProviderNodePoolArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sEphemeralProviderNodePoolArgs>());
            set => _nodePools = value;
        }

        public Mk8sEphemeralProviderArgs()
        {
        }
        public static new Mk8sEphemeralProviderArgs Empty => new Mk8sEphemeralProviderArgs();
    }
}
