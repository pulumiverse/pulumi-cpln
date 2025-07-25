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
    public sealed class Mk8sPaperspaceProviderNodePool
    {
        public readonly int? BootDiskSize;
        /// <summary>
        /// Labels to attach to nodes of a node pool.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly string MachineType;
        public readonly int? MaxSize;
        public readonly int? MinSize;
        public readonly string Name;
        public readonly string PublicIpType;
        /// <summary>
        /// Taint for the nodes of a pool.
        /// </summary>
        public readonly ImmutableArray<Outputs.Mk8sPaperspaceProviderNodePoolTaint> Taints;

        [OutputConstructor]
        private Mk8sPaperspaceProviderNodePool(
            int? bootDiskSize,

            ImmutableDictionary<string, string>? labels,

            string machineType,

            int? maxSize,

            int? minSize,

            string name,

            string publicIpType,

            ImmutableArray<Outputs.Mk8sPaperspaceProviderNodePoolTaint> taints)
        {
            BootDiskSize = bootDiskSize;
            Labels = labels;
            MachineType = machineType;
            MaxSize = maxSize;
            MinSize = minSize;
            Name = name;
            PublicIpType = publicIpType;
            Taints = taints;
        }
    }
}
