// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Outputs
{

    [OutputType]
    public sealed class OrgLoggingCloudWatchLogging
    {
        public readonly string Credentials;
        public readonly string GroupName;
        public readonly string Region;
        public readonly int? RetentionDays;
        public readonly string StreamName;

        [OutputConstructor]
        private OrgLoggingCloudWatchLogging(
            string credentials,

            string groupName,

            string region,

            int? retentionDays,

            string streamName)
        {
            Credentials = credentials;
            GroupName = groupName;
            Region = region;
            RetentionDays = retentionDays;
            StreamName = streamName;
        }
    }
}