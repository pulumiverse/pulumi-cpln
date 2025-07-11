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
    public sealed class GetImagesImageResult
    {
        /// <summary>
        /// The ID, in GUID format, of the image.
        /// </summary>
        public readonly string CplnId;
        /// <summary>
        /// A unique SHA256 hash used to identify a specific image version within the image registry.
        /// </summary>
        public readonly string Digest;
        /// <summary>
        /// The manifest provides configuration and layers information about the image. It plays a crucial role in the Docker image distribution system, enabling image creation, verification, and replication in a consistent and secure manner.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetImagesImageManifestResult> Manifests;
        /// <summary>
        /// Name of the image.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Respository name of the image.
        /// </summary>
        public readonly string Repository;
        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        public readonly string SelfLink;
        /// <summary>
        /// Tag of the image.
        /// </summary>
        public readonly string Tag;
        /// <summary>
        /// Key-value map of resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetImagesImageResult(
            string cplnId,

            string digest,

            ImmutableArray<Outputs.GetImagesImageManifestResult> manifests,

            string name,

            string repository,

            string selfLink,

            string tag,

            ImmutableDictionary<string, string> tags)
        {
            CplnId = cplnId;
            Digest = digest;
            Manifests = manifests;
            Name = name;
            Repository = repository;
            SelfLink = selfLink;
            Tag = tag;
            Tags = tags;
        }
    }
}
