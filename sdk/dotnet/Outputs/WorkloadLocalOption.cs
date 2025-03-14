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
    public sealed class WorkloadLocalOption
    {
        /// <summary>
        /// Auto-scaling adjusts horizontal scaling based on a set strategy, target value, and possibly a metric percentile.
        /// </summary>
        public readonly Outputs.WorkloadLocalOptionAutoscaling? Autoscaling;
        /// <summary>
        /// Capacity AI. Default: `true`.
        /// </summary>
        public readonly bool? CapacityAi;
        /// <summary>
        /// Debug mode. Default: `false`
        /// </summary>
        public readonly bool? Debug;
        /// <summary>
        /// Valid only for `local_options`. Override options for a specific location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Workload suspend. Default: `false`
        /// </summary>
        public readonly bool? Suspend;
        /// <summary>
        /// Timeout in seconds. Default: `5`.
        /// </summary>
        public readonly int? TimeoutSeconds;

        [OutputConstructor]
        private WorkloadLocalOption(
            Outputs.WorkloadLocalOptionAutoscaling? autoscaling,

            bool? capacityAi,

            bool? debug,

            string location,

            bool? suspend,

            int? timeoutSeconds)
        {
            Autoscaling = autoscaling;
            CapacityAi = capacityAi;
            Debug = debug;
            Location = location;
            Suspend = suspend;
            TimeoutSeconds = timeoutSeconds;
        }
    }
}
