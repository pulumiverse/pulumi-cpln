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

    public sealed class GetSecretOpaqueInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Available encodings: `plain`, `base64`. Default: `plain`.
        /// </summary>
        [Input("encoding", required: true)]
        public Input<string> Encoding { get; set; } = null!;

        [Input("payload", required: true)]
        private Input<string>? _payload;

        /// <summary>
        /// Plain text or base64 encoded string. Use `encoding` attribute to specify encoding.
        /// </summary>
        public Input<string>? Payload
        {
            get => _payload;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _payload = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public GetSecretOpaqueInputArgs()
        {
        }
        public static new GetSecretOpaqueInputArgs Empty => new GetSecretOpaqueInputArgs();
    }
}
