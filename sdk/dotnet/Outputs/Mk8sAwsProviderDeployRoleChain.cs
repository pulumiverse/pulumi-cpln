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
    public sealed class Mk8sAwsProviderDeployRoleChain
    {
        public readonly string? ExternalId;
        public readonly string RoleArn;
        public readonly string? SessionNamePrefix;

        [OutputConstructor]
        private Mk8sAwsProviderDeployRoleChain(
            string? externalId,

            string roleArn,

            string? sessionNamePrefix)
        {
            ExternalId = externalId;
            RoleArn = roleArn;
            SessionNamePrefix = sessionNamePrefix;
        }
    }
}