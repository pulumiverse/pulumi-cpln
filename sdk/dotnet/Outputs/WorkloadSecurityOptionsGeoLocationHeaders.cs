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
    public sealed class WorkloadSecurityOptionsGeoLocationHeaders
    {
        public readonly string? Asn;
        public readonly string? City;
        public readonly string? Country;
        public readonly string? Region;

        [OutputConstructor]
        private WorkloadSecurityOptionsGeoLocationHeaders(
            string? asn,

            string? city,

            string? country,

            string? region)
        {
            Asn = asn;
            City = city;
            Country = country;
            Region = region;
        }
    }
}
