// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class Mk8sAzureProviderNodePoolOverrideImageArgs : global::Pulumi.ResourceArgs
    {
        [Input("recommended")]
        public Input<string>? Recommended { get; set; }

        [Input("reference")]
        public Input<Inputs.Mk8sAzureProviderNodePoolOverrideImageReferenceArgs>? Reference { get; set; }

        public Mk8sAzureProviderNodePoolOverrideImageArgs()
        {
        }
        public static new Mk8sAzureProviderNodePoolOverrideImageArgs Empty => new Mk8sAzureProviderNodePoolOverrideImageArgs();
    }
}
