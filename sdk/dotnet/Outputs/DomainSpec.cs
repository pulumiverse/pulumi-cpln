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
    public sealed class DomainSpec
    {
        /// <summary>
        /// Allows domain to accept wildcards. The associated GVC must have dedicated load balancing enabled.
        /// </summary>
        public readonly bool? AcceptAllHosts;
        /// <summary>
        /// In `cname` dnsMode, Control Plane will configure workloads to accept traffic for the domain but will not manage DNS records for the domain. End users must configure CNAME records in their own DNS pointed to the canonical workload endpoint. Currently `cname` dnsMode requires that a TLS server certificate be configured when subdomain based routing is used. In `ns` dnsMode, Control Plane will manage the subdomains and create all necessary DNS records. End users configure NS records to forward DNS requests to the Control Plane managed DNS servers. Valid values: `cname`, `ns`. Default: `cname`.
        /// </summary>
        public readonly string? DnsMode;
        /// <summary>
        /// This value is set to a target GVC (using a full link) for use by subdomain based routing. Each workload in the GVC will receive a subdomain in the form ${workload.name}.${domain.name}. **Do not include if path based routing is used.**
        /// </summary>
        public readonly string? GvcLink;
        /// <summary>
        /// Domain port specifications.
        /// </summary>
        public readonly ImmutableArray<Outputs.DomainSpecPort> Ports;

        [OutputConstructor]
        private DomainSpec(
            bool? acceptAllHosts,

            string? dnsMode,

            string? gvcLink,

            ImmutableArray<Outputs.DomainSpecPort> ports)
        {
            AcceptAllHosts = acceptAllHosts;
            DnsMode = dnsMode;
            GvcLink = gvcLink;
            Ports = ports;
        }
    }
}
