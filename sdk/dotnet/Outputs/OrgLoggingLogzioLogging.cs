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
    public sealed class OrgLoggingLogzioLogging
    {
        /// <summary>
        /// Full link to referenced Opaque Secret.
        /// </summary>
        public readonly string Credentials;
        /// <summary>
        /// Logzio listener host URI.
        /// </summary>
        public readonly string ListenerHost;

        [OutputConstructor]
        private OrgLoggingLogzioLogging(
            string credentials,

            string listenerHost)
        {
            Credentials = credentials;
            ListenerHost = listenerHost;
        }
    }
}
