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
    public sealed class Mk8sAddOnsAzureWorkloadIdentity
    {
        /// <summary>
        /// Tenant ID to use for workload identity.
        /// </summary>
        public readonly string? TenantId;

        [OutputConstructor]
        private Mk8sAddOnsAzureWorkloadIdentity(string? tenantId)
        {
            TenantId = tenantId;
        }
    }
}
