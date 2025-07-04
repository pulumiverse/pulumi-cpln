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

    public sealed class GetOrgSecurityThreatDetectionArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Indicates whether threat detection should be forwarded or not.
        /// </summary>
        [Input("enabled", required: true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Any threats with this severity and more severe will be sent. Others will be ignored. Valid values: `warning`, `error`, or `critical`.
        /// </summary>
        [Input("minimumSeverity")]
        public string? MinimumSeverity { get; set; }

        /// <summary>
        /// Configuration for syslog forwarding.
        /// </summary>
        [Input("syslog")]
        public Inputs.GetOrgSecurityThreatDetectionSyslogArgs? Syslog { get; set; }

        public GetOrgSecurityThreatDetectionArgs()
        {
        }
        public static new GetOrgSecurityThreatDetectionArgs Empty => new GetOrgSecurityThreatDetectionArgs();
    }
}
