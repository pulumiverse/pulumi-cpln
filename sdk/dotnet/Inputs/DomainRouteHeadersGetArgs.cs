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

    public sealed class DomainRouteHeadersGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("request")]
        public Input<Inputs.DomainRouteHeadersRequestGetArgs>? Request { get; set; }

        public DomainRouteHeadersGetArgs()
        {
        }
        public static new DomainRouteHeadersGetArgs Empty => new DomainRouteHeadersGetArgs();
    }
}
