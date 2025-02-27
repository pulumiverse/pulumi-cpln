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

    public sealed class SecretKeypairGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("passphrase")]
        private Input<string>? _passphrase;

        /// <summary>
        /// Passphrase for private key.
        /// </summary>
        public Input<string>? Passphrase
        {
            get => _passphrase;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _passphrase = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Public Key.
        /// </summary>
        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        [Input("secretKey", required: true)]
        private Input<string>? _secretKey;

        /// <summary>
        /// Secret/Private Key.
        /// </summary>
        public Input<string>? SecretKey
        {
            get => _secretKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secretKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public SecretKeypairGetArgs()
        {
        }
        public static new SecretKeypairGetArgs Empty => new SecretKeypairGetArgs();
    }
}
