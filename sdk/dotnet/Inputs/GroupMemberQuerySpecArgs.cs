// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class GroupMemberQuerySpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of match. Available values: `all`, `any`, `none`. Default: `all`.
        /// </summary>
        [Input("match")]
        public Input<string>? Match { get; set; }

        [Input("terms")]
        private InputList<Inputs.GroupMemberQuerySpecTermArgs>? _terms;

        /// <summary>
        /// Terms can only contain one of the following attributes: `property`, `rel`, `tag`.
        /// </summary>
        public InputList<Inputs.GroupMemberQuerySpecTermArgs> Terms
        {
            get => _terms ?? (_terms = new InputList<Inputs.GroupMemberQuerySpecTermArgs>());
            set => _terms = value;
        }

        public GroupMemberQuerySpecArgs()
        {
        }
        public static new GroupMemberQuerySpecArgs Empty => new GroupMemberQuerySpecArgs();
    }
}
