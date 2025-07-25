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
    public sealed class GvcLightstepTracing
    {
        /// <summary>
        /// Full link to referenced Opaque Secret.
        /// </summary>
        public readonly string? Credentials;
        /// <summary>
        /// Key-value map of custom tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? CustomTags;
        /// <summary>
        /// Tracing Endpoint Workload. Either the canonical endpoint or internal endpoint.
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// Determines what percentage of requests should be traced.
        /// </summary>
        public readonly double Sampling;

        [OutputConstructor]
        private GvcLightstepTracing(
            string? credentials,

            ImmutableDictionary<string, string>? customTags,

            string endpoint,

            double sampling)
        {
            Credentials = credentials;
            CustomTags = customTags;
            Endpoint = endpoint;
            Sampling = sampling;
        }
    }
}
