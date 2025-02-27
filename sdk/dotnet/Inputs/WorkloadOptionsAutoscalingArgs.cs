// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class WorkloadOptionsAutoscalingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A hard maximum for the number of concurrent requests allowed to a replica. If no replicas are available to fulfill the request then it will be queued until a replica with capacity is available and delivered as soon as one is available again. Capacity can be available from requests completing or when a new replica is available from scale out.Min: `0`. Max: `1000`. Default `0`.
        /// </summary>
        [Input("maxConcurrency")]
        public Input<int>? MaxConcurrency { get; set; }

        /// <summary>
        /// The maximum allowed number of replicas. Min: `0`. Default `5`.
        /// </summary>
        [Input("maxScale")]
        public Input<int>? MaxScale { get; set; }

        /// <summary>
        /// Valid values: `disabled`, `concurrency`, `cpu`, `memory`, `latency`, or `rps`.
        /// </summary>
        [Input("metric")]
        public Input<string>? Metric { get; set; }

        /// <summary>
        /// For metrics represented as a distribution (e.g. latency) a percentile within the distribution must be chosen as the target.
        /// </summary>
        [Input("metricPercentile")]
        public Input<string>? MetricPercentile { get; set; }

        /// <summary>
        /// The minimum allowed number of replicas. Control Plane can scale the workload down to 0 when there is no traffic and scale up immediately to fulfill new requests. Min: `0`. Max: `max_scale`. Default `1`.
        /// </summary>
        [Input("minScale")]
        public Input<int>? MinScale { get; set; }

        [Input("multis")]
        private InputList<Inputs.WorkloadOptionsAutoscalingMultiArgs>? _multis;
        public InputList<Inputs.WorkloadOptionsAutoscalingMultiArgs> Multis
        {
            get => _multis ?? (_multis = new InputList<Inputs.WorkloadOptionsAutoscalingMultiArgs>());
            set => _multis = value;
        }

        /// <summary>
        /// The amount of time (in seconds) with no requests received before a workload is scaled to 0. Min: `30`. Max: `3600`. Default: `300`.
        /// </summary>
        [Input("scaleToZeroDelay")]
        public Input<int>? ScaleToZeroDelay { get; set; }

        /// <summary>
        /// Control Plane will scale the number of replicas for this deployment up/down in order to be as close as possible to the target metric across all replicas of a deployment. Min: `1`. Max: `20000`. Default: `95`.
        /// </summary>
        [Input("target")]
        public Input<int>? Target { get; set; }

        public WorkloadOptionsAutoscalingArgs()
        {
        }
        public static new WorkloadOptionsAutoscalingArgs Empty => new WorkloadOptionsAutoscalingArgs();
    }
}
