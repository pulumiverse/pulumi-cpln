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
    public sealed class IdentityGcpAccessPolicy
    {
        /// <summary>
        /// The association or connection between a particular identity, such as a user or a group, and a set of permissions or roles within the system.
        /// </summary>
        public readonly ImmutableArray<Outputs.IdentityGcpAccessPolicyBinding> Bindings;
        /// <summary>
        /// Full link to referenced cloud account.
        /// </summary>
        public readonly string CloudAccountLink;
        /// <summary>
        /// Comma delimited list of GCP scope URLs.
        /// </summary>
        public readonly ImmutableArray<string> Scopes;
        /// <summary>
        /// Name of existing GCP service account.
        /// </summary>
        public readonly string? ServiceAccount;

        [OutputConstructor]
        private IdentityGcpAccessPolicy(
            ImmutableArray<Outputs.IdentityGcpAccessPolicyBinding> bindings,

            string cloudAccountLink,

            ImmutableArray<string> scopes,

            string? serviceAccount)
        {
            Bindings = bindings;
            CloudAccountLink = cloudAccountLink;
            Scopes = scopes;
            ServiceAccount = serviceAccount;
        }
    }
}
