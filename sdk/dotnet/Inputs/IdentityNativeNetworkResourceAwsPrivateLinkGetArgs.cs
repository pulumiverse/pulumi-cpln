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

    public sealed class IdentityNativeNetworkResourceAwsPrivateLinkGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Endpoint service name.
        /// </summary>
        [Input("endpointServiceName", required: true)]
        public Input<string> EndpointServiceName { get; set; } = null!;

        public IdentityNativeNetworkResourceAwsPrivateLinkGetArgs()
        {
        }
        public static new IdentityNativeNetworkResourceAwsPrivateLinkGetArgs Empty => new IdentityNativeNetworkResourceAwsPrivateLinkGetArgs();
    }
}
