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

    public sealed class GetGvcLoadBalancerRedirectClassArgs : global::Pulumi.InvokeArgs
    {
        [Input("_sentinel")]
        public bool? _sentinel { get; set; }

        [Input("status5xx")]
        public string? Status5xx { get; set; }

        public GetGvcLoadBalancerRedirectClassArgs()
        {
        }
        public static new GetGvcLoadBalancerRedirectClassArgs Empty => new GetGvcLoadBalancerRedirectClassArgs();
    }
}
