// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln
{
    public static class GetImage
    {
        /// <summary>
        /// Use this data source to access information about an [Image](https://docs.controlplane.com/reference/image) within Control Plane.
        /// 
        /// ## Required
        /// 
        /// - **name** (String) Name of the image. If the tag of the image is not specified, the latest image will be fetched for this data source.
        /// 
        /// ## Outputs
        /// 
        /// The following attributes are exported:
        /// 
        /// - **cpln_id** (String) The ID, in GUID format, of the Image.
        /// - **name** (String) Name of the Image.
        /// - **tags** (Map of String) Key-value map of resource tags.
        /// - **self_link** (String) Full link to this resource. Can be referenced by other resources.
        /// - **tag** (String) Tag of the image.
        /// - **repository** (String) Respository name of the image.
        /// - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
        /// - **manifest** (Block List, Max: 1) (see below)
        /// 
        /// &lt;a id="nestedblock--manifest"&gt;&lt;/a&gt;
        /// 
        /// ### `manifest`
        /// 
        ///  The manifest provides configuration and layers information about the image. It plays a crucial role in the Docker image distribution system, enabling image creation, verification, and replication in a consistent and secure manner.
        /// 
        /// - **config** (Block List, Max: 1) (see below).
        /// - **layers** (Block List) (see below).
        /// - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
        /// - **schema_version** (Number) The version of the Docker Image Manifest format.
        /// 
        /// &lt;a id="nestedblock--config--layers"&gt;&lt;/a&gt;
        /// 
        /// ### `config` and `layers`
        /// 
        /// The config is a JSON blob that contains the image configuration data which includes environment variables, default command to run, and other settings necessary to run the container based on this image.
        /// 
        /// Layers lists the digests of the image's layers. These layers are filesystem changes or additions made in each step of the Docker image's creation process. The layers are stored separately and pulled as needed, which allows for efficient storage and transfer of images. Each layer is represented by a SHA256 digest, ensuring the integrity and authenticity of the image.
        /// 
        /// - **size** (Number) The size of the image or layer in bytes. This helps in estimating the space required and the download time.
        /// - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
        /// - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Cpln = Pulumi.Cpln;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var image_name_only = Cpln.GetImage.Invoke(new()
        ///     {
        ///         Name = "IMAGE_NAME",
        ///     });
        /// 
        ///     var image_name_with_tag = Cpln.GetImage.Invoke(new()
        ///     {
        ///         Name = "IMAGE_NAME:TAG",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["latestImage"] = image_name_only,
        ///         ["specificImage"] = image_name_with_tag,
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetImageResult> InvokeAsync(GetImageArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetImageResult>("cpln:index/getImage:getImage", args ?? new GetImageArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to access information about an [Image](https://docs.controlplane.com/reference/image) within Control Plane.
        /// 
        /// ## Required
        /// 
        /// - **name** (String) Name of the image. If the tag of the image is not specified, the latest image will be fetched for this data source.
        /// 
        /// ## Outputs
        /// 
        /// The following attributes are exported:
        /// 
        /// - **cpln_id** (String) The ID, in GUID format, of the Image.
        /// - **name** (String) Name of the Image.
        /// - **tags** (Map of String) Key-value map of resource tags.
        /// - **self_link** (String) Full link to this resource. Can be referenced by other resources.
        /// - **tag** (String) Tag of the image.
        /// - **repository** (String) Respository name of the image.
        /// - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
        /// - **manifest** (Block List, Max: 1) (see below)
        /// 
        /// &lt;a id="nestedblock--manifest"&gt;&lt;/a&gt;
        /// 
        /// ### `manifest`
        /// 
        ///  The manifest provides configuration and layers information about the image. It plays a crucial role in the Docker image distribution system, enabling image creation, verification, and replication in a consistent and secure manner.
        /// 
        /// - **config** (Block List, Max: 1) (see below).
        /// - **layers** (Block List) (see below).
        /// - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
        /// - **schema_version** (Number) The version of the Docker Image Manifest format.
        /// 
        /// &lt;a id="nestedblock--config--layers"&gt;&lt;/a&gt;
        /// 
        /// ### `config` and `layers`
        /// 
        /// The config is a JSON blob that contains the image configuration data which includes environment variables, default command to run, and other settings necessary to run the container based on this image.
        /// 
        /// Layers lists the digests of the image's layers. These layers are filesystem changes or additions made in each step of the Docker image's creation process. The layers are stored separately and pulled as needed, which allows for efficient storage and transfer of images. Each layer is represented by a SHA256 digest, ensuring the integrity and authenticity of the image.
        /// 
        /// - **size** (Number) The size of the image or layer in bytes. This helps in estimating the space required and the download time.
        /// - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
        /// - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Cpln = Pulumi.Cpln;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var image_name_only = Cpln.GetImage.Invoke(new()
        ///     {
        ///         Name = "IMAGE_NAME",
        ///     });
        /// 
        ///     var image_name_with_tag = Cpln.GetImage.Invoke(new()
        ///     {
        ///         Name = "IMAGE_NAME:TAG",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["latestImage"] = image_name_only,
        ///         ["specificImage"] = image_name_with_tag,
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetImageResult> Invoke(GetImageInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetImageResult>("cpln:index/getImage:getImage", args ?? new GetImageInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetImageArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetImageArgs()
        {
        }
        public static new GetImageArgs Empty => new GetImageArgs();
    }

    public sealed class GetImageInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetImageInvokeArgs()
        {
        }
        public static new GetImageInvokeArgs Empty => new GetImageInvokeArgs();
    }


    [OutputType]
    public sealed class GetImageResult
    {
        public readonly string CplnId;
        public readonly string Digest;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetImageManifestResult> Manifests;
        public readonly string Name;
        public readonly string Repository;
        public readonly string SelfLink;
        public readonly string Tag;
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetImageResult(
            string cplnId,

            string digest,

            string id,

            ImmutableArray<Outputs.GetImageManifestResult> manifests,

            string name,

            string repository,

            string selfLink,

            string tag,

            ImmutableDictionary<string, string> tags)
        {
            CplnId = cplnId;
            Digest = digest;
            Id = id;
            Manifests = manifests;
            Name = name;
            Repository = repository;
            SelfLink = selfLink;
            Tag = tag;
            Tags = tags;
        }
    }
}
