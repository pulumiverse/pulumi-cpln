// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
    public sealed class Mk8sStatusAddOnAwsWorkloadIdentityOidcProviderConfig
    {
        public readonly string? Audience;
        public readonly string? ProviderUrl;

        [OutputConstructor]
        private Mk8sStatusAddOnAwsWorkloadIdentityOidcProviderConfig(
            string? audience,

            string? providerUrl)
        {
            Audience = audience;
            ProviderUrl = providerUrl;
        }
    }
}
