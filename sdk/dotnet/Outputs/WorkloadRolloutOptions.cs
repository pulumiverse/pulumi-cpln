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
    public sealed class WorkloadRolloutOptions
    {
        public readonly string? MaxSurgeReplicas;
        public readonly string? MaxUnavailableReplicas;
        public readonly int? MinReadySeconds;
        public readonly string? ScalingPolicy;

        [OutputConstructor]
        private WorkloadRolloutOptions(
            string? maxSurgeReplicas,

            string? maxUnavailableReplicas,

            int? minReadySeconds,

            string? scalingPolicy)
        {
            MaxSurgeReplicas = maxSurgeReplicas;
            MaxUnavailableReplicas = maxUnavailableReplicas;
            MinReadySeconds = minReadySeconds;
            ScalingPolicy = scalingPolicy;
        }
    }
}
