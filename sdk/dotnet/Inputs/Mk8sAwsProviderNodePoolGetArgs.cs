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

    public sealed class Mk8sAwsProviderNodePoolGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("bootDiskSize")]
        public Input<int>? BootDiskSize { get; set; }

        [Input("extraSecurityGroupIds")]
        private InputList<string>? _extraSecurityGroupIds;
        public InputList<string> ExtraSecurityGroupIds
        {
            get => _extraSecurityGroupIds ?? (_extraSecurityGroupIds = new InputList<string>());
            set => _extraSecurityGroupIds = value;
        }

        [Input("instanceTypes", required: true)]
        private InputList<string>? _instanceTypes;
        public InputList<string> InstanceTypes
        {
            get => _instanceTypes ?? (_instanceTypes = new InputList<string>());
            set => _instanceTypes = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;
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

        [Input("onDemandBaseCapacity")]
        public Input<int>? OnDemandBaseCapacity { get; set; }

        [Input("onDemandPercentageAboveBaseCapacity")]
        public Input<int>? OnDemandPercentageAboveBaseCapacity { get; set; }

        [Input("overrideImage", required: true)]
        public Input<Inputs.Mk8sAwsProviderNodePoolOverrideImageGetArgs> OverrideImage { get; set; } = null!;

        [Input("spotAllocationStrategy")]
        public Input<string>? SpotAllocationStrategy { get; set; }

        [Input("subnetIds", required: true)]
        private InputList<string>? _subnetIds;
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        [Input("taints")]
        private InputList<Inputs.Mk8sAwsProviderNodePoolTaintGetArgs>? _taints;
        public InputList<Inputs.Mk8sAwsProviderNodePoolTaintGetArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.Mk8sAwsProviderNodePoolTaintGetArgs>());
            set => _taints = value;
        }

        public Mk8sAwsProviderNodePoolGetArgs()
        {
        }
        public static new Mk8sAwsProviderNodePoolGetArgs Empty => new Mk8sAwsProviderNodePoolGetArgs();
    }
}
