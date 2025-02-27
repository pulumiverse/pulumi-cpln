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
    public sealed class GetGvcLoadBalancerRedirectResult
    {
        public readonly bool? _sentinel;
        /// <summary>
        /// Specify the redirect url for all status codes in a class.
        /// </summary>
        public readonly Outputs.GetGvcLoadBalancerRedirectClassResult? Class;

        [OutputConstructor]
        private GetGvcLoadBalancerRedirectResult(
            bool? _sentinel,

            Outputs.GetGvcLoadBalancerRedirectClassResult? @class)
        {
            this._sentinel = _sentinel;
            Class = @class;
        }
    }
}
