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

    public sealed class Mk8sAddOnsAwsEcrGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("_sentinel")]
        public Input<bool>? _sentinel { get; set; }

        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        public Mk8sAddOnsAwsEcrGetArgs()
        {
        }
        public static new Mk8sAddOnsAwsEcrGetArgs Empty => new Mk8sAddOnsAwsEcrGetArgs();
    }
}
