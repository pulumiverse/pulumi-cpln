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

    public sealed class Mk8sOblivusProviderUnmanagedNodePoolTaintGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("effect")]
        public Input<string>? Effect { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public Mk8sOblivusProviderUnmanagedNodePoolTaintGetArgs()
        {
        }
        public static new Mk8sOblivusProviderUnmanagedNodePoolTaintGetArgs Empty => new Mk8sOblivusProviderUnmanagedNodePoolTaintGetArgs();
    }
}
