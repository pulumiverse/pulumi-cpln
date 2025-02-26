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

    public sealed class Mk8sEphemeralProviderNodePoolArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// CPU architecture of the nodes.
        /// </summary>
        [Input("arch", required: true)]
        public Input<string> Arch { get; set; } = null!;

        /// <summary>
        /// Number of nodes to deploy.
        /// </summary>
        [Input("count", required: true)]
        public Input<int> Count { get; set; } = null!;

        /// <summary>
        /// Allocated CPU.
        /// </summary>
        [Input("cpu", required: true)]
        public Input<string> Cpu { get; set; } = null!;

        /// <summary>
        /// Linux distro to use for ephemeral nodes.
        /// </summary>
        [Input("flavor", required: true)]
        public Input<string> Flavor { get; set; } = null!;

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels to attach to nodes of a node pool.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Allocated memory.
        /// </summary>
        [Input("memory", required: true)]
        public Input<string> Memory { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("taints")]
        private InputList<Inputs.Mk8sEphemeralProviderNodePoolTaintArgs>? _taints;

        /// <summary>
        /// Taint for the nodes of a pool.
        /// </summary>
        public InputList<Inputs.Mk8sEphemeralProviderNodePoolTaintArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.Mk8sEphemeralProviderNodePoolTaintArgs>());
            set => _taints = value;
        }

        public Mk8sEphemeralProviderNodePoolArgs()
        {
        }
        public static new Mk8sEphemeralProviderNodePoolArgs Empty => new Mk8sEphemeralProviderNodePoolArgs();
    }
}
