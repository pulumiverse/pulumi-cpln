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

    public sealed class Mk8sAddOnsAzureAcrGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        public Mk8sAddOnsAzureAcrGetArgs()
        {
        }
        public static new Mk8sAddOnsAzureAcrGetArgs Empty => new Mk8sAddOnsAzureAcrGetArgs();
    }
}
