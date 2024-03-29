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
    public sealed class OrgLoggingElasticLoggingElasticCloud
    {
        public readonly string CloudId;
        public readonly string Credentials;
        public readonly string Index;
        public readonly string Type;

        [OutputConstructor]
        private OrgLoggingElasticLoggingElasticCloud(
            string cloudId,

            string credentials,

            string index,

            string type)
        {
            CloudId = cloudId;
            Credentials = credentials;
            Index = index;
            Type = type;
        }
    }
}
