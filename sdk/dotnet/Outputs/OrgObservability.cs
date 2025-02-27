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
    public sealed class OrgObservability
    {
        /// <summary>
        /// Log retention days. Default: 30
        /// </summary>
        public readonly int? LogsRetentionDays;
        /// <summary>
        /// Metrics retention days. Default: 30
        /// </summary>
        public readonly int? MetricsRetentionDays;
        /// <summary>
        /// Traces retention days. Default: 30
        /// </summary>
        public readonly int? TracesRetentionDays;

        [OutputConstructor]
        private OrgObservability(
            int? logsRetentionDays,

            int? metricsRetentionDays,

            int? tracesRetentionDays)
        {
            LogsRetentionDays = logsRetentionDays;
            MetricsRetentionDays = metricsRetentionDays;
            TracesRetentionDays = tracesRetentionDays;
        }
    }
}
