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

    public sealed class WorkloadLoadBalancerGeoLocationHeadersGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("asn")]
        public Input<string>? Asn { get; set; }

        [Input("city")]
        public Input<string>? City { get; set; }

        [Input("country")]
        public Input<string>? Country { get; set; }

        [Input("region")]
        public Input<string>? Region { get; set; }

        public WorkloadLoadBalancerGeoLocationHeadersGetArgs()
        {
        }
        public static new WorkloadLoadBalancerGeoLocationHeadersGetArgs Empty => new WorkloadLoadBalancerGeoLocationHeadersGetArgs();
    }
}
