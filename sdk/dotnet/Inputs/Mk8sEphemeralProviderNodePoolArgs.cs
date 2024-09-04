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
        [Input("arch", required: true)]
        public Input<string> Arch { get; set; } = null!;

        [Input("count", required: true)]
        public Input<int> Count { get; set; } = null!;

        [Input("cpu", required: true)]
        public Input<string> Cpu { get; set; } = null!;

        [Input("flavor", required: true)]
        public Input<string> Flavor { get; set; } = null!;

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("memory", required: true)]
        public Input<string> Memory { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("taints")]
        private InputList<Inputs.Mk8sEphemeralProviderNodePoolTaintArgs>? _taints;
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
