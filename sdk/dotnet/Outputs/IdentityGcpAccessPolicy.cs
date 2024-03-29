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
    public sealed class IdentityGcpAccessPolicy
    {
        public readonly ImmutableArray<Outputs.IdentityGcpAccessPolicyBinding> Bindings;
        public readonly string CloudAccountLink;
        public readonly string? Scopes;
        public readonly string? ServiceAccount;

        [OutputConstructor]
        private IdentityGcpAccessPolicy(
            ImmutableArray<Outputs.IdentityGcpAccessPolicyBinding> bindings,

            string cloudAccountLink,

            string? scopes,

            string? serviceAccount)
        {
            Bindings = bindings;
            CloudAccountLink = cloudAccountLink;
            Scopes = scopes;
            ServiceAccount = serviceAccount;
        }
    }
}
