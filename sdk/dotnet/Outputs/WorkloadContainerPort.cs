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
    public sealed class WorkloadContainerPort
    {
        /// <summary>
        /// Port to expose.
        /// </summary>
        public readonly int Number;
        /// <summary>
        /// Protocol. Choice of: `http`, `http2`, `tcp`, or `grpc`.
        /// </summary>
        public readonly string? Protocol;

        [OutputConstructor]
        private WorkloadContainerPort(
            int number,

            string? protocol)
        {
            Number = number;
            Protocol = protocol;
        }
    }
}
