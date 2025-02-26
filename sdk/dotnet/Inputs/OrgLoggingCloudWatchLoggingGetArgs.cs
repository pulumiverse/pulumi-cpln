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

    public sealed class OrgLoggingCloudWatchLoggingGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Full Link to a secret of type `opaque`.
        /// </summary>
        [Input("credentials", required: true)]
        public Input<string> Credentials { get; set; } = null!;

        [Input("extractFields")]
        private InputMap<string>? _extractFields;

        /// <summary>
        /// Enable custom data extraction from log entries for enhanced querying and analysis.
        /// </summary>
        public InputMap<string> ExtractFields
        {
            get => _extractFields ?? (_extractFields = new InputMap<string>());
            set => _extractFields = value;
        }

        /// <summary>
        /// A container for log streams with common settings like retention. Used to categorize logs by application or service type.
        /// </summary>
        [Input("groupName", required: true)]
        public Input<string> GroupName { get; set; } = null!;

        /// <summary>
        /// Valid AWS region.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        /// <summary>
        /// Length, in days, for how log data is kept before it is automatically deleted.
        /// </summary>
        [Input("retentionDays")]
        public Input<int>? RetentionDays { get; set; }

        /// <summary>
        /// A sequence of log events from the same source within a log group. Typically represents individual instances of services or applications.
        /// </summary>
        [Input("streamName", required: true)]
        public Input<string> StreamName { get; set; } = null!;

        public OrgLoggingCloudWatchLoggingGetArgs()
        {
        }
        public static new OrgLoggingCloudWatchLoggingGetArgs Empty => new OrgLoggingCloudWatchLoggingGetArgs();
    }
}
