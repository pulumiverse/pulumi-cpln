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

    public sealed class Mk8sGenericProviderGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("networking")]
        public Input<Inputs.Mk8sGenericProviderNetworkingGetArgs>? Networking { get; set; }

        [Input("nodePools")]
        private InputList<Inputs.Mk8sGenericProviderNodePoolGetArgs>? _nodePools;
        public InputList<Inputs.Mk8sGenericProviderNodePoolGetArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sGenericProviderNodePoolGetArgs>());
            set => _nodePools = value;
        }

        public Mk8sGenericProviderGetArgs()
        {
        }
        public static new Mk8sGenericProviderGetArgs Empty => new Mk8sGenericProviderGetArgs();
    }
}