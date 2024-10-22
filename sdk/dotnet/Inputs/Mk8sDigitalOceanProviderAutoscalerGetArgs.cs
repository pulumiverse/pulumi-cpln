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

    public sealed class Mk8sDigitalOceanProviderAutoscalerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("expanders", required: true)]
        private InputList<string>? _expanders;
        public InputList<string> Expanders
        {
            get => _expanders ?? (_expanders = new InputList<string>());
            set => _expanders = value;
        }

        [Input("unneededTime")]
        public Input<string>? UnneededTime { get; set; }

        [Input("unreadyTime")]
        public Input<string>? UnreadyTime { get; set; }

        [Input("utilizationThreshold")]
        public Input<double>? UtilizationThreshold { get; set; }

        public Mk8sDigitalOceanProviderAutoscalerGetArgs()
        {
        }
        public static new Mk8sDigitalOceanProviderAutoscalerGetArgs Empty => new Mk8sDigitalOceanProviderAutoscalerGetArgs();
    }
}
