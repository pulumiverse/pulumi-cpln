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

    public sealed class WorkloadStatusLoadBalancerArgs : global::Pulumi.ResourceArgs
    {
        [Input("origin")]
        public Input<string>? Origin { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        public WorkloadStatusLoadBalancerArgs()
        {
        }
        public static new WorkloadStatusLoadBalancerArgs Empty => new WorkloadStatusLoadBalancerArgs();
    }
}
