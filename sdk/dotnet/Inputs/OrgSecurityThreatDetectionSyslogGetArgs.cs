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

    public sealed class OrgSecurityThreatDetectionSyslogGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The hostname to send syslog messages to.
        /// </summary>
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        /// <summary>
        /// The port to send syslog messages to.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// The transport-layer protocol to send the syslog messages over. If TCP is chosen, messages will be sent with TLS. Default: `tcp`.
        /// </summary>
        [Input("transport")]
        public Input<string>? Transport { get; set; }

        public OrgSecurityThreatDetectionSyslogGetArgs()
        {
        }
        public static new OrgSecurityThreatDetectionSyslogGetArgs Empty => new OrgSecurityThreatDetectionSyslogGetArgs();
    }
}
