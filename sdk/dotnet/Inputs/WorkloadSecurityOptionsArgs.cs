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

    public sealed class WorkloadSecurityOptionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("_sentinel")]
        public Input<bool>? _sentinel { get; set; }

        [Input("fileSystemGroupId")]
        public Input<int>? FileSystemGroupId { get; set; }

        public WorkloadSecurityOptionsArgs()
        {
        }
        public static new WorkloadSecurityOptionsArgs Empty => new WorkloadSecurityOptionsArgs();
    }
}
