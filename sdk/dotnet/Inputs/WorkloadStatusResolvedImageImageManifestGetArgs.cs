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

    public sealed class WorkloadStatusResolvedImageImageManifestGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A SHA256 hash that uniquely identifies the specific image manifest.
        /// </summary>
        [Input("digest")]
        public Input<string>? Digest { get; set; }

        /// <summary>
        /// The name and tag of the resolved image.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// The MIME type used in the Docker Registry HTTP API to specify the format of the data being sent or received. Docker uses media types to distinguish between different kinds of JSON objects and binary data formats within the registry protocol, enabling the Docker client and registry to understand and process different components of Docker images correctly.
        /// </summary>
        [Input("mediaType")]
        public Input<string>? MediaType { get; set; }

        [Input("platform")]
        private InputMap<string>? _platform;

        /// <summary>
        /// Key-value map of strings. The combination of the operating system and architecture for which the image is built.
        /// </summary>
        public InputMap<string> Platform
        {
            get => _platform ?? (_platform = new InputMap<string>());
            set => _platform = value;
        }

        public WorkloadStatusResolvedImageImageManifestGetArgs()
        {
        }
        public static new WorkloadStatusResolvedImageImageManifestGetArgs Empty => new WorkloadStatusResolvedImageImageManifestGetArgs();
    }
}
