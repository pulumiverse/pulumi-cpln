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

    public sealed class WorkloadFirewallSpecGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("_sentinel")]
        public Input<bool>? _sentinel { get; set; }

        [Input("external")]
        public Input<Inputs.WorkloadFirewallSpecExternalGetArgs>? External { get; set; }

        [Input("internal")]
        public Input<Inputs.WorkloadFirewallSpecInternalGetArgs>? Internal { get; set; }

        public WorkloadFirewallSpecGetArgs()
        {
        }
        public static new WorkloadFirewallSpecGetArgs Empty => new WorkloadFirewallSpecGetArgs();
    }
}
