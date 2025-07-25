// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class GroupMemberQuerySpecGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of match. Available values: `all`, `any`, `none`. Default: `all`.
        /// </summary>
        [Input("match")]
        public Input<string>? Match { get; set; }

        [Input("terms")]
        private InputList<Inputs.GroupMemberQuerySpecTermGetArgs>? _terms;

        /// <summary>
        /// Terms can only contain one of the following attributes: `property`, `rel`, `tag`.
        /// </summary>
        public InputList<Inputs.GroupMemberQuerySpecTermGetArgs> Terms
        {
            get => _terms ?? (_terms = new InputList<Inputs.GroupMemberQuerySpecTermGetArgs>());
            set => _terms = value;
        }

        public GroupMemberQuerySpecGetArgs()
        {
        }
        public static new GroupMemberQuerySpecGetArgs Empty => new GroupMemberQuerySpecGetArgs();
    }
}
