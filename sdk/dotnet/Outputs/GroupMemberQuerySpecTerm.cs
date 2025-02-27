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
    public sealed class GroupMemberQuerySpecTerm
    {
        /// <summary>
        /// Type of query operation. Available values: `=`, `&gt;`, `&gt;=`, `&lt;`, `&lt;=`, `!=`, `exists`, `!exists`. Default: `=`.
        /// </summary>
        public readonly string? Op;
        /// <summary>
        /// Property to use for query evaluation.
        /// </summary>
        public readonly string? Property;
        public readonly string? Rel;
        /// <summary>
        /// Tag key to use for query evaluation.
        /// </summary>
        public readonly string? Tag;
        /// <summary>
        /// Testing value for query evaluation.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private GroupMemberQuerySpecTerm(
            string? op,

            string? property,

            string? rel,

            string? tag,

            string? value)
        {
            Op = op;
            Property = property;
            Rel = rel;
            Tag = tag;
            Value = value;
        }
    }
}
