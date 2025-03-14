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

    public sealed class GetSecretUserpassArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Available encodings: `plain`, `base64`. Default: `plain`.
        /// </summary>
        [Input("encoding")]
        public string? Encoding { get; set; }

        [Input("password", required: true)]
        private string? _password;

        /// <summary>
        /// Password.
        /// </summary>
        public string? Password
        {
            get => _password;
            set => _password = value;
        }

        /// <summary>
        /// Username.
        /// </summary>
        [Input("username", required: true)]
        public string Username { get; set; } = null!;

        public GetSecretUserpassArgs()
        {
        }
        public static new GetSecretUserpassArgs Empty => new GetSecretUserpassArgs();
    }
}
