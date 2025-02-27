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

    public sealed class Mk8sTritonProviderLoadBalancerManualArgs : global::Pulumi.ResourceArgs
    {
        [Input("cnsInternalDomain", required: true)]
        public Input<string> CnsInternalDomain { get; set; } = null!;

        [Input("cnsPublicDomain", required: true)]
        public Input<string> CnsPublicDomain { get; set; } = null!;

        [Input("count", required: true)]
        public Input<int> Count { get; set; } = null!;

        [Input("imageId", required: true)]
        public Input<string> ImageId { get; set; } = null!;

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// Extra tags to attach to instances from a node pool.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        [Input("packageId", required: true)]
        public Input<string> PackageId { get; set; } = null!;

        [Input("privateNetworkIds")]
        private InputList<string>? _privateNetworkIds;

        /// <summary>
        /// More private networks to join.
        /// </summary>
        public InputList<string> PrivateNetworkIds
        {
            get => _privateNetworkIds ?? (_privateNetworkIds = new InputList<string>());
            set => _privateNetworkIds = value;
        }

        /// <summary>
        /// If set, machine will also get a public IP.
        /// </summary>
        [Input("publicNetworkId", required: true)]
        public Input<string> PublicNetworkId { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Extra tags to attach to instances from a node pool.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public Mk8sTritonProviderLoadBalancerManualArgs()
        {
        }
        public static new Mk8sTritonProviderLoadBalancerManualArgs Empty => new Mk8sTritonProviderLoadBalancerManualArgs();
    }
}
