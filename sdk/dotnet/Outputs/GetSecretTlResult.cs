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
    public sealed class GetSecretTlResult
    {
        /// <summary>
        /// Public Certificate.
        /// </summary>
        public readonly string Cert;
        /// <summary>
        /// Chain Certificate.
        /// </summary>
        public readonly string Chain;
        /// <summary>
        /// Private Certificate.
        /// </summary>
        public readonly string Key;

        [OutputConstructor]
        private GetSecretTlResult(
            string cert,

            string chain,

            string key)
        {
            Cert = cert;
            Chain = chain;
            Key = key;
        }
    }
}
