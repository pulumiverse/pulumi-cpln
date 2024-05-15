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
    public sealed class Mk8sHetznerProviderNodePool
    {
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly int? MaxSize;
        public readonly int? MinSize;
        public readonly string Name;
        public readonly string? OverrideImage;
        public readonly string ServerType;
        public readonly ImmutableArray<Outputs.Mk8sHetznerProviderNodePoolTaint> Taints;

        [OutputConstructor]
        private Mk8sHetznerProviderNodePool(
            ImmutableDictionary<string, string>? labels,

            int? maxSize,

            int? minSize,

            string name,

            string? overrideImage,

            string serverType,

            ImmutableArray<Outputs.Mk8sHetznerProviderNodePoolTaint> taints)
        {
            Labels = labels;
            MaxSize = maxSize;
            MinSize = minSize;
            Name = name;
            OverrideImage = overrideImage;
            ServerType = serverType;
            Taints = taints;
        }
    }
}
