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

    public sealed class PolicyTargetQuerySpecTermGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of query operation. Available values: `=`, `&gt;`, `&gt;=`, `&lt;`, `&lt;=`, `!=`, `exists`, `!exists`. Default: `=`.
        /// </summary>
        [Input("op")]
        public Input<string>? Op { get; set; }

        /// <summary>
        /// Property to use for query evaluation.
        /// </summary>
        [Input("property")]
        public Input<string>? Property { get; set; }

        [Input("rel")]
        public Input<string>? Rel { get; set; }

        /// <summary>
        /// Tag key to use for query evaluation.
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        /// <summary>
        /// Testing value for query evaluation.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public PolicyTargetQuerySpecTermGetArgs()
        {
        }
        public static new PolicyTargetQuerySpecTermGetArgs Empty => new PolicyTargetQuerySpecTermGetArgs();
    }
}
