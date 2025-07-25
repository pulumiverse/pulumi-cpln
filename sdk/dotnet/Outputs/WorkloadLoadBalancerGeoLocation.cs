// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Outputs
{

    [OutputType]
    public sealed class WorkloadLoadBalancerGeoLocation
    {
        /// <summary>
        /// When enabled, geo location headers will be included on inbound http requests. Existing headers will be replaced.
        /// </summary>
        public readonly bool? Enabled;
        public readonly Outputs.WorkloadLoadBalancerGeoLocationHeaders? Headers;

        [OutputConstructor]
        private WorkloadLoadBalancerGeoLocation(
            bool? enabled,

            Outputs.WorkloadLoadBalancerGeoLocationHeaders? headers)
        {
            Enabled = enabled;
            Headers = headers;
        }
    }
}
