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
    public sealed class VolumeSetMountOptionsResources
    {
        public readonly string? MaxCpu;
        public readonly string? MaxMemory;
        public readonly string? MinCpu;
        public readonly string? MinMemory;

        [OutputConstructor]
        private VolumeSetMountOptionsResources(
            string? maxCpu,

            string? maxMemory,

            string? minCpu,

            string? minMemory)
        {
            MaxCpu = maxCpu;
            MaxMemory = maxMemory;
            MinCpu = minCpu;
            MinMemory = minMemory;
        }
    }
}
