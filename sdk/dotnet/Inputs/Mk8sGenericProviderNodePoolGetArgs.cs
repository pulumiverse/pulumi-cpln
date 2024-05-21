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

    public sealed class Mk8sGenericProviderNodePoolGetArgs : global::Pulumi.ResourceArgs
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
        private InputList<Inputs.Mk8sGenericProviderNodePoolTaintGetArgs>? _taints;
        public InputList<Inputs.Mk8sGenericProviderNodePoolTaintGetArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.Mk8sGenericProviderNodePoolTaintGetArgs>());
            set => _taints = value;
        }

        public Mk8sGenericProviderNodePoolGetArgs()
        {
        }
        public static new Mk8sGenericProviderNodePoolGetArgs Empty => new Mk8sGenericProviderNodePoolGetArgs();
    }
}