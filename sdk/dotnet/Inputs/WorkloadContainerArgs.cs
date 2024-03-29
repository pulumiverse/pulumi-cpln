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

    public sealed class WorkloadContainerArgs : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("command")]
        public Input<string>? Command { get; set; }

        [Input("cpu")]
        public Input<string>? Cpu { get; set; }

        [Input("env")]
        private InputMap<string>? _env;
        public InputMap<string> Env
        {
            get => _env ?? (_env = new InputMap<string>());
            set => _env = value;
        }

        [Input("gpuNvidia")]
        public Input<Inputs.WorkloadContainerGpuNvidiaArgs>? GpuNvidia { get; set; }

        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        [Input("inheritEnv")]
        public Input<bool>? InheritEnv { get; set; }

        [Input("lifecycle")]
        public Input<Inputs.WorkloadContainerLifecycleArgs>? Lifecycle { get; set; }

        [Input("livenessProbe")]
        public Input<Inputs.WorkloadContainerLivenessProbeArgs>? LivenessProbe { get; set; }

        [Input("memory")]
        public Input<string>? Memory { get; set; }

        [Input("metrics")]
        public Input<Inputs.WorkloadContainerMetricsArgs>? Metrics { get; set; }

        [Input("minCpu")]
        public Input<string>? MinCpu { get; set; }

        [Input("minMemory")]
        public Input<string>? MinMemory { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("ports")]
        private InputList<Inputs.WorkloadContainerPortArgs>? _ports;
        public InputList<Inputs.WorkloadContainerPortArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.WorkloadContainerPortArgs>());
            set => _ports = value;
        }

        [Input("readinessProbe")]
        public Input<Inputs.WorkloadContainerReadinessProbeArgs>? ReadinessProbe { get; set; }

        [Input("volumes")]
        private InputList<Inputs.WorkloadContainerVolumeArgs>? _volumes;
        public InputList<Inputs.WorkloadContainerVolumeArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Inputs.WorkloadContainerVolumeArgs>());
            set => _volumes = value;
        }

        [Input("workingDirectory")]
        public Input<string>? WorkingDirectory { get; set; }

        public WorkloadContainerArgs()
        {
        }
        public static new WorkloadContainerArgs Empty => new WorkloadContainerArgs();
    }
}
