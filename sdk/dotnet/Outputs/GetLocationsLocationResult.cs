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
    public sealed class GetLocationsLocationResult
    {
        /// <summary>
        /// Cloud Provider of the location.
        /// </summary>
        public readonly string CloudProvider;
        /// <summary>
        /// The ID, in GUID format, of the location.
        /// </summary>
        public readonly string CplnId;
        /// <summary>
        /// Description of the location.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Indication if location is enabled.
        /// </summary>
        public readonly bool Enabled;
        public readonly ImmutableArray<Outputs.GetLocationsLocationGeoResult> Geos;
        /// <summary>
        /// A list of IP ranges of the location.
        /// </summary>
        public readonly ImmutableArray<string> IpRanges;
        /// <summary>
        /// Name of the location.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Region of the location.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        public readonly string SelfLink;
        /// <summary>
        /// Key-value map of resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetLocationsLocationResult(
            string cloudProvider,

            string cplnId,

            string description,

            bool enabled,

            ImmutableArray<Outputs.GetLocationsLocationGeoResult> geos,

            ImmutableArray<string> ipRanges,

            string name,

            string region,

            string selfLink,

            ImmutableDictionary<string, string> tags)
        {
            CloudProvider = cloudProvider;
            CplnId = cplnId;
            Description = description;
            Enabled = enabled;
            Geos = geos;
            IpRanges = ipRanges;
            Name = name;
            Region = region;
            SelfLink = selfLink;
            Tags = tags;
        }
    }
}
