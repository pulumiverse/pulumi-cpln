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

    public sealed class Mk8sAwsProviderImageGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("exact")]
        public Input<string>? Exact { get; set; }

        [Input("recommended")]
        public Input<string>? Recommended { get; set; }

        public Mk8sAwsProviderImageGetArgs()
        {
        }
        public static new Mk8sAwsProviderImageGetArgs Empty => new Mk8sAwsProviderImageGetArgs();
    }
}