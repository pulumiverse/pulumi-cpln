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
    public sealed class DomainSpecPort
    {
        public readonly Outputs.DomainSpecPortCors? Cors;
        public readonly int? Number;
        public readonly string? Protocol;
        public readonly Outputs.DomainSpecPortTls Tls;

        [OutputConstructor]
        private DomainSpecPort(
            Outputs.DomainSpecPortCors? cors,

            int? number,

            string? protocol,

            Outputs.DomainSpecPortTls tls)
        {
            Cors = cors;
            Number = number;
            Protocol = protocol;
            Tls = tls;
        }
    }
}
