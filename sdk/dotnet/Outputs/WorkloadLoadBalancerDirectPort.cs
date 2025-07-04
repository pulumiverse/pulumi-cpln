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
    public sealed class WorkloadLoadBalancerDirectPort
    {
        /// <summary>
        /// The port on the container tha will receive this traffic.
        /// </summary>
        public readonly int? ContainerPort;
        /// <summary>
        /// The port that is available publicly.
        /// </summary>
        public readonly int ExternalPort;
        /// <summary>
        /// The protocol that is exposed publicly.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Overrides the default `https` url scheme that will be used for links in the UI and status.
        /// </summary>
        public readonly string? Scheme;

        [OutputConstructor]
        private WorkloadLoadBalancerDirectPort(
            int? containerPort,

            int externalPort,

            string protocol,

            string? scheme)
        {
            ContainerPort = containerPort;
            ExternalPort = externalPort;
            Protocol = protocol;
            Scheme = scheme;
        }
    }
}
