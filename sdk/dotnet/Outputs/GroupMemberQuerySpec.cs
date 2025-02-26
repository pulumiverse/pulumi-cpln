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
    public sealed class GroupMemberQuerySpec
    {
        /// <summary>
        /// Type of match. Available values: `all`, `any`, `none`. Default: `all`.
        /// </summary>
        public readonly string? Match;
        /// <summary>
        /// Terms can only contain one of the following attributes: `property`, `rel`, `tag`.
        /// </summary>
        public readonly ImmutableArray<Outputs.GroupMemberQuerySpecTerm> Terms;

        [OutputConstructor]
        private GroupMemberQuerySpec(
            string? match,

            ImmutableArray<Outputs.GroupMemberQuerySpecTerm> terms)
        {
            Match = match;
            Terms = terms;
        }
    }
}
