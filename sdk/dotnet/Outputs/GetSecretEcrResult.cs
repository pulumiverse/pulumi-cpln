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
    public sealed class GetSecretEcrResult
    {
        public readonly string AccessKey;
        public readonly string? ExternalId;
        public readonly ImmutableArray<string> Repos;
        public readonly string? RoleArn;
        public readonly string SecretKey;

        [OutputConstructor]
        private GetSecretEcrResult(
            string accessKey,

            string? externalId,

            ImmutableArray<string> repos,

            string? roleArn,

            string secretKey)
        {
            AccessKey = accessKey;
            ExternalId = externalId;
            Repos = repos;
            RoleArn = roleArn;
            SecretKey = secretKey;
        }
    }
}