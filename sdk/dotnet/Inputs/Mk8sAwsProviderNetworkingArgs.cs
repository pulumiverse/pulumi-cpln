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

    public sealed class Mk8sAwsProviderNetworkingArgs : global::Pulumi.ResourceArgs
    {
        [Input("podNetwork")]
        public Input<string>? PodNetwork { get; set; }

        [Input("serviceNetwork")]
        public Input<string>? ServiceNetwork { get; set; }

        public Mk8sAwsProviderNetworkingArgs()
        {
        }
        public static new Mk8sAwsProviderNetworkingArgs Empty => new Mk8sAwsProviderNetworkingArgs();
    }
}
