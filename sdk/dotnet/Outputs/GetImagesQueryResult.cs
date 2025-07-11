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
    public sealed class GetImagesQueryResult
    {
        /// <summary>
        /// Type of fetch. Specify either: `links` or `items`. Default: `items`.
        /// </summary>
        public readonly string Fetch;
        /// <summary>
        /// The specification of the query.
        /// </summary>
        public readonly Outputs.GetImagesQuerySpecResult? Spec;

        [OutputConstructor]
        private GetImagesQueryResult(
            string fetch,

            Outputs.GetImagesQuerySpecResult? spec)
        {
            Fetch = fetch;
            Spec = spec;
        }
    }
}
