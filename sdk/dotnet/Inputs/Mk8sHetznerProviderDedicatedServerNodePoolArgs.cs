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

    public sealed class Mk8sHetznerProviderDedicatedServerNodePoolArgs : global::Pulumi.ResourceArgs
    {
        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("taints")]
        private InputList<Inputs.Mk8sHetznerProviderDedicatedServerNodePoolTaintArgs>? _taints;
        public InputList<Inputs.Mk8sHetznerProviderDedicatedServerNodePoolTaintArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.Mk8sHetznerProviderDedicatedServerNodePoolTaintArgs>());
            set => _taints = value;
        }

        public Mk8sHetznerProviderDedicatedServerNodePoolArgs()
        {
        }
        public static new Mk8sHetznerProviderDedicatedServerNodePoolArgs Empty => new Mk8sHetznerProviderDedicatedServerNodePoolArgs();
    }
}