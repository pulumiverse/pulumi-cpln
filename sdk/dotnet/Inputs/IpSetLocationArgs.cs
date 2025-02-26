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

    public sealed class IpSetLocationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The self link of a location.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("retentionPolicy", required: true)]
        public Input<string> RetentionPolicy { get; set; } = null!;

        public IpSetLocationArgs()
        {
        }
        public static new IpSetLocationArgs Empty => new IpSetLocationArgs();
    }
}
