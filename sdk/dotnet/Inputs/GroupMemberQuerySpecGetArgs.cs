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

    public sealed class GroupMemberQuerySpecGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("match")]
        public Input<string>? Match { get; set; }

        [Input("terms")]
        private InputList<Inputs.GroupMemberQuerySpecTermGetArgs>? _terms;
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
