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
    public sealed class Mk8sAddOnsAwsEfs
    {
        public readonly bool? _sentinel;
        /// <summary>
        /// Use this role for EFS interaction.
        /// </summary>
        public readonly string? RoleArn;

        [OutputConstructor]
        private Mk8sAddOnsAwsEfs(
            bool? _sentinel,

            string? roleArn)
        {
            this._sentinel = _sentinel;
            RoleArn = roleArn;
        }
    }
}
