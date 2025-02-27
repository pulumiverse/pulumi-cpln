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
    public sealed class GetImagesImageManifestConfigResult
    {
        /// <summary>
        /// A unique SHA256 hash used to identify a specific image version within the image registry.
        /// </summary>
        public readonly string Digest;
        /// <summary>
        /// Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
        /// </summary>
        public readonly string MediaType;
        /// <summary>
        /// The size of the image or layer in bytes. This helps in estimating the space required and the download time.
        /// </summary>
        public readonly int Size;

        [OutputConstructor]
        private GetImagesImageManifestConfigResult(
            string digest,

            string mediaType,

            int size)
        {
            Digest = digest;
            MediaType = mediaType;
            Size = size;
        }
    }
}
