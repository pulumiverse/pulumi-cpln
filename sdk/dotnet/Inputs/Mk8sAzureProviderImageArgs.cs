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

    public sealed class Mk8sAzureProviderImageArgs : global::Pulumi.ResourceArgs
    {
        [Input("recommended")]
        public Input<string>? Recommended { get; set; }

        [Input("reference")]
        public Input<Inputs.Mk8sAzureProviderImageReferenceArgs>? Reference { get; set; }

        public Mk8sAzureProviderImageArgs()
        {
        }
        public static new Mk8sAzureProviderImageArgs Empty => new Mk8sAzureProviderImageArgs();
    }
}
