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

    public sealed class Mk8sGenericProviderNodePoolTaintGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("effect")]
        public Input<string>? Effect { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public Mk8sGenericProviderNodePoolTaintGetArgs()
        {
        }
        public static new Mk8sGenericProviderNodePoolTaintGetArgs Empty => new Mk8sGenericProviderNodePoolTaintGetArgs();
    }
}
