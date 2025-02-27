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

    public sealed class GroupMemberQueryGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of fetch. Specify either: `links` or `items`. Default: `items`.
        /// </summary>
        [Input("fetch")]
        public Input<string>? Fetch { get; set; }

        [Input("spec")]
        public Input<Inputs.GroupMemberQuerySpecGetArgs>? Spec { get; set; }

        public GroupMemberQueryGetArgs()
        {
        }
        public static new GroupMemberQueryGetArgs Empty => new GroupMemberQueryGetArgs();
    }
}
