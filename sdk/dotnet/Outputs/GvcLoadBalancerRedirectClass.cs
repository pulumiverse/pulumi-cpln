// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class GvcLoadBalancerRedirectClass
    {
        public readonly bool? _sentinel;
        /// <summary>
        /// Specify the redirect url for any 500 level status code.
        /// </summary>
        public readonly string? Status5xx;

        [OutputConstructor]
        private GvcLoadBalancerRedirectClass(
            bool? _sentinel,

            string? status5xx)
        {
            this._sentinel = _sentinel;
            Status5xx = status5xx;
        }
    }
}
