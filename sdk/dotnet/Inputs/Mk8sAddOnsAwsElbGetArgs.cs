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

    public sealed class Mk8sAddOnsAwsElbGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("placeholderAttribute")]
        public Input<bool>? PlaceholderAttribute { get; set; }

        /// <summary>
        /// Role to use when authorizing calls to EC2 ELB. Optional on AWS, when not provided it will create the recommended role.
        /// </summary>
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        public Mk8sAddOnsAwsElbGetArgs()
        {
        }
        public static new Mk8sAddOnsAwsElbGetArgs Empty => new Mk8sAddOnsAwsElbGetArgs();
    }
}
