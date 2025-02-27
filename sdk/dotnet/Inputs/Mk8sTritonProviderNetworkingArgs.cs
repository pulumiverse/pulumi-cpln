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

    public sealed class Mk8sTritonProviderNetworkingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The CIDR of the pod network.
        /// </summary>
        [Input("podNetwork")]
        public Input<string>? PodNetwork { get; set; }

        /// <summary>
        /// The CIDR of the service network.
        /// </summary>
        [Input("serviceNetwork")]
        public Input<string>? ServiceNetwork { get; set; }

        public Mk8sTritonProviderNetworkingArgs()
        {
        }
        public static new Mk8sTritonProviderNetworkingArgs Empty => new Mk8sTritonProviderNetworkingArgs();
    }
}
