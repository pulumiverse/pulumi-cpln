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
    public sealed class WorkloadStatusHealthCheck
    {
        /// <summary>
        /// Active boolean for the associated workload.
        /// </summary>
        public readonly bool? Active;
        /// <summary>
        /// Current output code for the associated workload.
        /// </summary>
        public readonly int? Code;
        /// <summary>
        /// Failure integer for the associated workload.
        /// </summary>
        public readonly int? Failures;
        /// <summary>
        /// Timestamp in UTC of the last health check.
        /// </summary>
        public readonly string? LastChecked;
        /// <summary>
        /// Current health status for the associated workload.
        /// </summary>
        public readonly string? Message;
        /// <summary>
        /// Success boolean for the associated workload.
        /// </summary>
        public readonly bool? Success;
        /// <summary>
        /// Success integer for the associated workload.
        /// </summary>
        public readonly int? Successes;

        [OutputConstructor]
        private WorkloadStatusHealthCheck(
            bool? active,

            int? code,

            int? failures,

            string? lastChecked,

            string? message,

            bool? success,

            int? successes)
        {
            Active = active;
            Code = code;
            Failures = failures;
            LastChecked = lastChecked;
            Message = message;
            Success = success;
            Successes = successes;
        }
    }
}
