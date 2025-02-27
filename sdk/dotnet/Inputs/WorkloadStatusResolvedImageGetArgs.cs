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

    public sealed class WorkloadStatusResolvedImageGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("images")]
        private InputList<Inputs.WorkloadStatusResolvedImageImageGetArgs>? _images;

        /// <summary>
        /// A list of images that were resolved.
        /// </summary>
        public InputList<Inputs.WorkloadStatusResolvedImageImageGetArgs> Images
        {
            get => _images ?? (_images = new InputList<Inputs.WorkloadStatusResolvedImageImageGetArgs>());
            set => _images = value;
        }

        /// <summary>
        /// UTC Time when the images were resolved.
        /// </summary>
        [Input("resolvedAt")]
        public Input<string>? ResolvedAt { get; set; }

        /// <summary>
        /// Workload version the images were resolved for.
        /// </summary>
        [Input("resolvedForVersion")]
        public Input<int>? ResolvedForVersion { get; set; }

        public WorkloadStatusResolvedImageGetArgs()
        {
        }
        public static new WorkloadStatusResolvedImageGetArgs Empty => new WorkloadStatusResolvedImageGetArgs();
    }
}
