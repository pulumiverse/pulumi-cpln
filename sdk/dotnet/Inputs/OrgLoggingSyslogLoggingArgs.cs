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

    public sealed class OrgLoggingSyslogLoggingArgs : global::Pulumi.ResourceArgs
    {
        [Input("format")]
        public Input<string>? Format { get; set; }

        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("severity")]
        public Input<int>? Severity { get; set; }

        public OrgLoggingSyslogLoggingArgs()
        {
        }
        public static new OrgLoggingSyslogLoggingArgs Empty => new OrgLoggingSyslogLoggingArgs();
    }
}
