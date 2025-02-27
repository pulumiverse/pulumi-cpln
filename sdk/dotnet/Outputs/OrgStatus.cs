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
    public sealed class OrgStatus
    {
        /// <summary>
        /// The link of the account the org belongs to.
        /// </summary>
        public readonly string? AccountLink;
        /// <summary>
        /// Indicates whether the org is active or not.
        /// </summary>
        public readonly bool? Active;

        [OutputConstructor]
        private OrgStatus(
            string? accountLink,

            bool? active)
        {
            AccountLink = accountLink;
            Active = active;
        }
    }
}
