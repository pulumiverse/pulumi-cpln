// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class CloudAccountAzure
    {
        /// <summary>
        /// Full link to an Azure secret. (e.g., /org/ORG_NAME/secret/AZURE_SECRET).
        /// </summary>
        public readonly string SecretLink;

        [OutputConstructor]
        private CloudAccountAzure(string secretLink)
        {
            SecretLink = secretLink;
        }
    }
}
