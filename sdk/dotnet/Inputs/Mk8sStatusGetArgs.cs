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

    public sealed class Mk8sStatusGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("addOns")]
        private InputList<Inputs.Mk8sStatusAddOnGetArgs>? _addOns;
        public InputList<Inputs.Mk8sStatusAddOnGetArgs> AddOns
        {
            get => _addOns ?? (_addOns = new InputList<Inputs.Mk8sStatusAddOnGetArgs>());
            set => _addOns = value;
        }

        [Input("homeLocation")]
        public Input<string>? HomeLocation { get; set; }

        [Input("oidcProviderUrl")]
        public Input<string>? OidcProviderUrl { get; set; }

        [Input("serverUrl")]
        public Input<string>? ServerUrl { get; set; }

        public Mk8sStatusGetArgs()
        {
        }
        public static new Mk8sStatusGetArgs Empty => new Mk8sStatusGetArgs();
    }
}
