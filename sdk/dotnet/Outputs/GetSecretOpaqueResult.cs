// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Outputs
{

    [OutputType]
    public sealed class GetSecretOpaqueResult
    {
        /// <summary>
        /// Available encodings: `plain`, `base64`. Default: `plain`.
        /// </summary>
        public readonly string Encoding;
        /// <summary>
        /// Plain text or base64 encoded string. Use `encoding` attribute to specify encoding.
        /// </summary>
        public readonly string Payload;

        [OutputConstructor]
        private GetSecretOpaqueResult(
            string encoding,

            string payload)
        {
            Encoding = encoding;
            Payload = payload;
        }
    }
}
