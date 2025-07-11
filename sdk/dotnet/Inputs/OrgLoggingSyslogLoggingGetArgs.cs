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

    public sealed class OrgLoggingSyslogLoggingGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Log Format. Valid values: RFC3164 or RFC5424.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// Hostname of Syslog Endpoint.
        /// </summary>
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        /// <summary>
        /// Log Mode. Valid values: TCP, TLS, or UDP.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        /// <summary>
        /// Port of Syslog Endpoint.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// Severity Level. See documentation for details. Valid values: 0 to 7.
        /// </summary>
        [Input("severity")]
        public Input<int>? Severity { get; set; }

        public OrgLoggingSyslogLoggingGetArgs()
        {
        }
        public static new OrgLoggingSyslogLoggingGetArgs Empty => new OrgLoggingSyslogLoggingGetArgs();
    }
}
