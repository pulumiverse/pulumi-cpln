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

    public sealed class GetOrgSecurityThreatDetectionSyslogArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The hostname to send syslog messages to.
        /// </summary>
        [Input("host", required: true)]
        public string Host { get; set; } = null!;

        /// <summary>
        /// The port to send syslog messages to.
        /// </summary>
        [Input("port", required: true)]
        public int Port { get; set; }

        /// <summary>
        /// The transport-layer protocol to send the syslog messages over. If TCP is chosen, messages will be sent with TLS. Default: `tcp`.
        /// </summary>
        [Input("transport", required: true)]
        public string Transport { get; set; } = null!;

        public GetOrgSecurityThreatDetectionSyslogArgs()
        {
        }
        public static new GetOrgSecurityThreatDetectionSyslogArgs Empty => new GetOrgSecurityThreatDetectionSyslogArgs();
    }
}
