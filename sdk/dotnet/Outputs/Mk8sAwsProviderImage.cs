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
    public sealed class Mk8sAwsProviderImage
    {
        public readonly string? Exact;
        public readonly string? Recommended;

        [OutputConstructor]
        private Mk8sAwsProviderImage(
            string? exact,

            string? recommended)
        {
            Exact = exact;
            Recommended = recommended;
        }
    }
}
