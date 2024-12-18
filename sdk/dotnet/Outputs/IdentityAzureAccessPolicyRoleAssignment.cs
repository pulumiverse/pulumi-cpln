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
    public sealed class IdentityAzureAccessPolicyRoleAssignment
    {
        public readonly bool? _sentinel;
        public readonly ImmutableArray<string> Roles;
        public readonly string? Scope;

        [OutputConstructor]
        private IdentityAzureAccessPolicyRoleAssignment(
            bool? _sentinel,

            ImmutableArray<string> roles,

            string? scope)
        {
            this._sentinel = _sentinel;
            Roles = roles;
            Scope = scope;
        }
    }
}
