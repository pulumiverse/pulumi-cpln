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

    public sealed class OrgSecurityThreatDetectionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("minimumSeverity")]
        public Input<string>? MinimumSeverity { get; set; }

        [Input("syslog")]
        public Input<Inputs.OrgSecurityThreatDetectionSyslogGetArgs>? Syslog { get; set; }

        public OrgSecurityThreatDetectionGetArgs()
        {
        }
        public static new OrgSecurityThreatDetectionGetArgs Empty => new OrgSecurityThreatDetectionGetArgs();
    }
}
