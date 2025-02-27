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
    public sealed class DomainRouteHeaders
    {
        public readonly bool? _sentinel;
        /// <summary>
        /// Manipulates HTTP headers.
        /// </summary>
        public readonly Outputs.DomainRouteHeadersRequest? Request;

        [OutputConstructor]
        private DomainRouteHeaders(
            bool? _sentinel,

            Outputs.DomainRouteHeadersRequest? request)
        {
            this._sentinel = _sentinel;
            Request = request;
        }
    }
}
