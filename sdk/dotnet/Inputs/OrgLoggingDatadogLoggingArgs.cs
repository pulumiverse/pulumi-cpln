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

    public sealed class OrgLoggingDatadogLoggingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Full link to referenced Opaque Secret.
        /// </summary>
        [Input("credentials", required: true)]
        public Input<string> Credentials { get; set; } = null!;

        /// <summary>
        /// Datadog host URI.
        /// </summary>
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        public OrgLoggingDatadogLoggingArgs()
        {
        }
        public static new OrgLoggingDatadogLoggingArgs Empty => new OrgLoggingDatadogLoggingArgs();
    }
}
