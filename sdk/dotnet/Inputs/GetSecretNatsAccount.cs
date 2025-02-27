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

    public sealed class GetSecretNatsAccountArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Account ID.
        /// </summary>
        [Input("accountId", required: true)]
        public string AccountId { get; set; } = null!;

        [Input("privateKey", required: true)]
        private string? _privateKey;

        /// <summary>
        /// Private Key.
        /// </summary>
        public string? PrivateKey
        {
            get => _privateKey;
            set => _privateKey = value;
        }

        public GetSecretNatsAccountArgs()
        {
        }
        public static new GetSecretNatsAccountArgs Empty => new GetSecretNatsAccountArgs();
    }
}
