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

    public sealed class WorkloadStatusArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Canonical endpoint for the workload.
        /// </summary>
        [Input("canonicalEndpoint")]
        public Input<string>? CanonicalEndpoint { get; set; }

        /// <summary>
        /// Current amount of replicas deployed.
        /// </summary>
        [Input("currentReplicaCount")]
        public Input<int>? CurrentReplicaCount { get; set; }

        /// <summary>
        /// Endpoint for the workload.
        /// </summary>
        [Input("endpoint")]
        public Input<string>? Endpoint { get; set; }

        [Input("healthChecks")]
        private InputList<Inputs.WorkloadStatusHealthCheckArgs>? _healthChecks;

        /// <summary>
        /// Current health status.
        /// </summary>
        public InputList<Inputs.WorkloadStatusHealthCheckArgs> HealthChecks
        {
            get => _healthChecks ?? (_healthChecks = new InputList<Inputs.WorkloadStatusHealthCheckArgs>());
            set => _healthChecks = value;
        }

        /// <summary>
        /// Internal hostname for the workload. Used for service-to-service requests.
        /// </summary>
        [Input("internalName")]
        public Input<string>? InternalName { get; set; }

        [Input("loadBalancers")]
        private InputList<Inputs.WorkloadStatusLoadBalancerArgs>? _loadBalancers;
        public InputList<Inputs.WorkloadStatusLoadBalancerArgs> LoadBalancers
        {
            get => _loadBalancers ?? (_loadBalancers = new InputList<Inputs.WorkloadStatusLoadBalancerArgs>());
            set => _loadBalancers = value;
        }

        /// <summary>
        /// ID of the parent object.
        /// </summary>
        [Input("parentId")]
        public Input<string>? ParentId { get; set; }

        [Input("resolvedImages")]
        private InputList<Inputs.WorkloadStatusResolvedImageArgs>? _resolvedImages;

        /// <summary>
        /// Resolved images for workloads with dynamic tags enabled.
        /// </summary>
        public InputList<Inputs.WorkloadStatusResolvedImageArgs> ResolvedImages
        {
            get => _resolvedImages ?? (_resolvedImages = new InputList<Inputs.WorkloadStatusResolvedImageArgs>());
            set => _resolvedImages = value;
        }

        public WorkloadStatusArgs()
        {
        }
        public static new WorkloadStatusArgs Empty => new WorkloadStatusArgs();
    }
}
