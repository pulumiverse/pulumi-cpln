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

    public sealed class Mk8sStatusAddOnAwsWorkloadIdentityOidcProviderConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("audience")]
        public Input<string>? Audience { get; set; }

        [Input("providerUrl")]
        public Input<string>? ProviderUrl { get; set; }

        public Mk8sStatusAddOnAwsWorkloadIdentityOidcProviderConfigGetArgs()
        {
        }
        public static new Mk8sStatusAddOnAwsWorkloadIdentityOidcProviderConfigGetArgs Empty => new Mk8sStatusAddOnAwsWorkloadIdentityOidcProviderConfigGetArgs();
    }
}
