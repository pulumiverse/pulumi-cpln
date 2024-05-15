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

    public sealed class Mk8sGenericProviderArgs : global::Pulumi.ResourceArgs
    {
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("networking")]
        public Input<Inputs.Mk8sGenericProviderNetworkingArgs>? Networking { get; set; }

        [Input("nodePools")]
        private InputList<Inputs.Mk8sGenericProviderNodePoolArgs>? _nodePools;
        public InputList<Inputs.Mk8sGenericProviderNodePoolArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sGenericProviderNodePoolArgs>());
            set => _nodePools = value;
        }

        public Mk8sGenericProviderArgs()
        {
        }
        public static new Mk8sGenericProviderArgs Empty => new Mk8sGenericProviderArgs();
    }
}
