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

    public sealed class WorkloadFirewallSpecInternalArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Used to control the internal firewall configuration and mutual tls. Allowed Values: "none", "same-gvc", "same-org", "workload-list".
        /// </summary>
        [Input("inboundAllowType")]
        public Input<string>? InboundAllowType { get; set; }

        [Input("inboundAllowWorkloads")]
        private InputList<string>? _inboundAllowWorkloads;

        /// <summary>
        /// A list of specific workloads which are allowed to access this workload internally. This list is only used if the 'inboundAllowType' is set to 'workload-list'.
        /// </summary>
        public InputList<string> InboundAllowWorkloads
        {
            get => _inboundAllowWorkloads ?? (_inboundAllowWorkloads = new InputList<string>());
            set => _inboundAllowWorkloads = value;
        }

        public WorkloadFirewallSpecInternalArgs()
        {
        }
        public static new WorkloadFirewallSpecInternalArgs Empty => new WorkloadFirewallSpecInternalArgs();
    }
}
