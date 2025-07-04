// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class WorkloadContainerLivenessProbeGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("exec")]
        public Input<Inputs.WorkloadContainerLivenessProbeExecGetArgs>? Exec { get; set; }

        [Input("failureThreshold")]
        public Input<int>? FailureThreshold { get; set; }

        [Input("grpc")]
        public Input<Inputs.WorkloadContainerLivenessProbeGrpcGetArgs>? Grpc { get; set; }

        [Input("httpGet")]
        public Input<Inputs.WorkloadContainerLivenessProbeHttpGetGetArgs>? HttpGet { get; set; }

        [Input("initialDelaySeconds")]
        public Input<int>? InitialDelaySeconds { get; set; }

        [Input("periodSeconds")]
        public Input<int>? PeriodSeconds { get; set; }

        [Input("successThreshold")]
        public Input<int>? SuccessThreshold { get; set; }

        [Input("tcpSocket")]
        public Input<Inputs.WorkloadContainerLivenessProbeTcpSocketGetArgs>? TcpSocket { get; set; }

        [Input("timeoutSeconds")]
        public Input<int>? TimeoutSeconds { get; set; }

        public WorkloadContainerLivenessProbeGetArgs()
        {
        }
        public static new WorkloadContainerLivenessProbeGetArgs Empty => new WorkloadContainerLivenessProbeGetArgs();
    }
}
