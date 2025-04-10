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

    public sealed class GetSecretTlsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Public Certificate.
        /// </summary>
        [Input("cert", required: true)]
        public string Cert { get; set; } = null!;

        /// <summary>
        /// Chain Certificate.
        /// </summary>
        [Input("chain")]
        public string? Chain { get; set; }

        [Input("key", required: true)]
        private string? _key;

        /// <summary>
        /// Private Certificate.
        /// </summary>
        public string? Key
        {
            get => _key;
            set => _key = value;
        }

        public GetSecretTlsArgs()
        {
        }
        public static new GetSecretTlsArgs Empty => new GetSecretTlsArgs();
    }
}
