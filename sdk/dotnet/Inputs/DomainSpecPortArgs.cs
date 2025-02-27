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

    public sealed class DomainSpecPortArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A security feature implemented by web browsers to allow resources on a web page to be requested from another domain outside the domain from which the resource originated.
        /// </summary>
        [Input("cors")]
        public Input<Inputs.DomainSpecPortCorsArgs>? Cors { get; set; }

        /// <summary>
        /// Port to expose externally. Values: `80`, `443`. Default: `443`.
        /// </summary>
        [Input("number")]
        public Input<int>? Number { get; set; }

        /// <summary>
        /// Allowed protocol. Valid values: `http`, `http2`, `tcp`. Default: `http2`.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        [Input("tls", required: true)]
        public Input<Inputs.DomainSpecPortTlsArgs> Tls { get; set; } = null!;

        public DomainSpecPortArgs()
        {
        }
        public static new DomainSpecPortArgs Empty => new DomainSpecPortArgs();
    }
}
