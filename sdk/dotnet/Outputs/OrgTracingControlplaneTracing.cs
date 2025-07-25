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
    public sealed class OrgTracingControlplaneTracing
    {
        /// <summary>
        /// Key-value map of custom tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? CustomTags;
        /// <summary>
        /// Determines what percentage of requests should be traced.
        /// </summary>
        public readonly double Sampling;

        [OutputConstructor]
        private OrgTracingControlplaneTracing(
            ImmutableDictionary<string, string>? customTags,

            double sampling)
        {
            CustomTags = customTags;
            Sampling = sampling;
        }
    }
}
