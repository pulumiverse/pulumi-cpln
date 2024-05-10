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

    public sealed class WorkloadOptionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoscaling")]
        public Input<Inputs.WorkloadOptionsAutoscalingGetArgs>? Autoscaling { get; set; }

        [Input("capacityAi")]
        public Input<bool>? CapacityAi { get; set; }

        [Input("debug")]
        public Input<bool>? Debug { get; set; }

        [Input("suspend")]
        public Input<bool>? Suspend { get; set; }

        [Input("timeoutSeconds")]
        public Input<int>? TimeoutSeconds { get; set; }

        public WorkloadOptionsGetArgs()
        {
        }
        public static new WorkloadOptionsGetArgs Empty => new WorkloadOptionsGetArgs();
    }
}
