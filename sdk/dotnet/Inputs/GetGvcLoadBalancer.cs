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

    public sealed class GetGvcLoadBalancerArgs : global::Pulumi.InvokeArgs
    {
        [Input("dedicated")]
        public bool? Dedicated { get; set; }

        [Input("redirect")]
        public Inputs.GetGvcLoadBalancerRedirectArgs? Redirect { get; set; }

        [Input("trustedProxies")]
        public int? TrustedProxies { get; set; }

        public GetGvcLoadBalancerArgs()
        {
        }
        public static new GetGvcLoadBalancerArgs Empty => new GetGvcLoadBalancerArgs();
    }
}
