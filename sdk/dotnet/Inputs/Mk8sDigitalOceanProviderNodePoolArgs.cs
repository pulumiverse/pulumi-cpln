// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class Mk8sDigitalOceanProviderNodePoolArgs : global::Pulumi.ResourceArgs
    {
        [Input("dropletSize", required: true)]
        public Input<string> DropletSize { get; set; } = null!;

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

        [Input("taints")]
        private InputList<Inputs.Mk8sDigitalOceanProviderNodePoolTaintArgs>? _taints;

        /// <summary>
        /// Taint for the nodes of a pool.
        /// </summary>
        public InputList<Inputs.Mk8sDigitalOceanProviderNodePoolTaintArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.Mk8sDigitalOceanProviderNodePoolTaintArgs>());
            set => _taints = value;
        }

        public Mk8sDigitalOceanProviderNodePoolArgs()
        {
        }
        public static new Mk8sDigitalOceanProviderNodePoolArgs Empty => new Mk8sDigitalOceanProviderNodePoolArgs();
    }
}
