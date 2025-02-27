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

    public sealed class VolumeSetSnapshotsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, a volume snapshot will be created immediately before deletion of any volume in this set. Default: `true`
        /// </summary>
        [Input("createFinalSnapshot")]
        public Input<bool>? CreateFinalSnapshot { get; set; }

        /// <summary>
        /// The default retention period for volume snapshots. This string should contain a floating point number followed by either d, h, or m. For example, "10d" would retain snapshots for 10 days.
        /// </summary>
        [Input("retentionDuration")]
        public Input<string>? RetentionDuration { get; set; }

        /// <summary>
        /// A standard cron schedule expression used to determine when a snapshot will be taken. (i.e., `0 * * * *` Every hour). Note: snapshots cannot be scheduled more often than once per hour.
        /// </summary>
        [Input("schedule")]
        public Input<string>? Schedule { get; set; }

        public VolumeSetSnapshotsArgs()
        {
        }
        public static new VolumeSetSnapshotsArgs Empty => new VolumeSetSnapshotsArgs();
    }
}
