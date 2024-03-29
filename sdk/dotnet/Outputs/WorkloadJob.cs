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
    public sealed class WorkloadJob
    {
        public readonly int? ActiveDeadlineSeconds;
        public readonly string? ConcurrencyPolicy;
        public readonly int? HistoryLimit;
        public readonly string? RestartPolicy;
        public readonly string Schedule;

        [OutputConstructor]
        private WorkloadJob(
            int? activeDeadlineSeconds,

            string? concurrencyPolicy,

            int? historyLimit,

            string? restartPolicy,

            string schedule)
        {
            ActiveDeadlineSeconds = activeDeadlineSeconds;
            ConcurrencyPolicy = concurrencyPolicy;
            HistoryLimit = historyLimit;
            RestartPolicy = restartPolicy;
            Schedule = schedule;
        }
    }
}
