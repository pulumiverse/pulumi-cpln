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

    public sealed class VolumeSetMountOptionsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// For volume sets using the shared file system, this object specifies the CPU and memory resources allotted to each mount point.
        /// </summary>
        [Input("resources")]
        public Input<Inputs.VolumeSetMountOptionsResourcesGetArgs>? Resources { get; set; }

        public VolumeSetMountOptionsGetArgs()
        {
        }
        public static new VolumeSetMountOptionsGetArgs Empty => new VolumeSetMountOptionsGetArgs();
    }
}
