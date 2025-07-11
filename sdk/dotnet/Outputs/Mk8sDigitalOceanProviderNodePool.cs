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
    public sealed class Mk8sDigitalOceanProviderNodePool
    {
        public readonly string DropletSize;
        /// <summary>
        /// Labels to attach to nodes of a node pool.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly int? MaxSize;
        public readonly int? MinSize;
        public readonly string Name;
        public readonly string? OverrideImage;
        /// <summary>
        /// Taint for the nodes of a pool.
        /// </summary>
        public readonly ImmutableArray<Outputs.Mk8sDigitalOceanProviderNodePoolTaint> Taints;

        [OutputConstructor]
        private Mk8sDigitalOceanProviderNodePool(
            string dropletSize,

            ImmutableDictionary<string, string>? labels,

            int? maxSize,

            int? minSize,

            string name,

            string? overrideImage,

            ImmutableArray<Outputs.Mk8sDigitalOceanProviderNodePoolTaint> taints)
        {
            DropletSize = dropletSize;
            Labels = labels;
            MaxSize = maxSize;
            MinSize = minSize;
            Name = name;
            OverrideImage = overrideImage;
            Taints = taints;
        }
    }
}
