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
    public sealed class Mk8sOblivusProviderAutoscaler
    {
        public readonly ImmutableArray<string> Expanders;
        public readonly string? UnneededTime;
        public readonly string? UnreadyTime;
        public readonly double? UtilizationThreshold;

        [OutputConstructor]
        private Mk8sOblivusProviderAutoscaler(
            ImmutableArray<string> expanders,

            string? unneededTime,

            string? unreadyTime,

            double? utilizationThreshold)
        {
            Expanders = expanders;
            UnneededTime = unneededTime;
            UnreadyTime = unreadyTime;
            UtilizationThreshold = utilizationThreshold;
        }
    }
}
