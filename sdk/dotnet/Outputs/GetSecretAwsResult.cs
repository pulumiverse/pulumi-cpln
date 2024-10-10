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
    public sealed class GetSecretAwsResult
    {
        public readonly string AccessKey;
        public readonly string? ExternalId;
        public readonly string? RoleArn;
        public readonly string SecretKey;

        [OutputConstructor]
        private GetSecretAwsResult(
            string accessKey,

            string? externalId,

            string? roleArn,

            string secretKey)
        {
            AccessKey = accessKey;
            ExternalId = externalId;
            RoleArn = roleArn;
            SecretKey = secretKey;
        }
    }
}
