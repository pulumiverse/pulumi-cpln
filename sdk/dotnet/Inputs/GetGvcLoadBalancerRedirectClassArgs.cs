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

    public sealed class GetGvcLoadBalancerRedirectClassInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("placeholderAttribute")]
        public Input<bool>? PlaceholderAttribute { get; set; }

        /// <summary>
        /// Specify the redirect url for any 500 level status code.
        /// </summary>
        [Input("status5xx")]
        public Input<string>? Status5xx { get; set; }

        public GetGvcLoadBalancerRedirectClassInputArgs()
        {
        }
        public static new GetGvcLoadBalancerRedirectClassInputArgs Empty => new GetGvcLoadBalancerRedirectClassInputArgs();
    }
}
