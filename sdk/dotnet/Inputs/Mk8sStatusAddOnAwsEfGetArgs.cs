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

    public sealed class Mk8sStatusAddOnAwsEfGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("trustPolicy")]
        public Input<string>? TrustPolicy { get; set; }

        public Mk8sStatusAddOnAwsEfGetArgs()
        {
        }
        public static new Mk8sStatusAddOnAwsEfGetArgs Empty => new Mk8sStatusAddOnAwsEfGetArgs();
    }
}