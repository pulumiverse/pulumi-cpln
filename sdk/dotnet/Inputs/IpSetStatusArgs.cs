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

    public sealed class IpSetStatusArgs : global::Pulumi.ResourceArgs
    {
        [Input("error")]
        public Input<string>? Error { get; set; }

        [Input("ipAddresses")]
        private InputList<Inputs.IpSetStatusIpAddressArgs>? _ipAddresses;
        public InputList<Inputs.IpSetStatusIpAddressArgs> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<Inputs.IpSetStatusIpAddressArgs>());
            set => _ipAddresses = value;
        }

        public IpSetStatusArgs()
        {
        }
        public static new IpSetStatusArgs Empty => new IpSetStatusArgs();
    }
}
