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

    public sealed class Mk8sTritonProviderConnectionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("account", required: true)]
        public Input<string> Account { get; set; } = null!;

        [Input("privateKeySecretLink", required: true)]
        public Input<string> PrivateKeySecretLink { get; set; } = null!;

        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        [Input("user")]
        public Input<string>? User { get; set; }

        public Mk8sTritonProviderConnectionGetArgs()
        {
        }
        public static new Mk8sTritonProviderConnectionGetArgs Empty => new Mk8sTritonProviderConnectionGetArgs();
    }
}