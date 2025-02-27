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

    public sealed class Mk8sHetznerProviderNodePoolGetArgs : global::Pulumi.ResourceArgs
    {
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

        [Input("maxSize")]
        public Input<int>? MaxSize { get; set; }

        [Input("minSize")]
        public Input<int>? MinSize { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("overrideImage")]
        public Input<string>? OverrideImage { get; set; }

        [Input("serverType", required: true)]
        public Input<string> ServerType { get; set; } = null!;

        [Input("taints")]
        private InputList<Inputs.Mk8sHetznerProviderNodePoolTaintGetArgs>? _taints;

        /// <summary>
        /// Taint for the nodes of a pool.
        /// </summary>
        public InputList<Inputs.Mk8sHetznerProviderNodePoolTaintGetArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.Mk8sHetznerProviderNodePoolTaintGetArgs>());
            set => _taints = value;
        }

        public Mk8sHetznerProviderNodePoolGetArgs()
        {
        }
        public static new Mk8sHetznerProviderNodePoolGetArgs Empty => new Mk8sHetznerProviderNodePoolGetArgs();
    }
}
