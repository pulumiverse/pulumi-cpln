// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to access information about all [Images](https://docs.controlplane.com/reference/image) within Control Plane.
 *
 * ## Optional
 *
 * - **query** (Block List, Max: 1) (see below).
 *
 * <a id="nestedblock--query"></a>
 *
 * ### `query`
 *
 * Optional:
 *
 * - **fetch** (String) Type of fetch. Specify either: `links` or `items`. Default: `items`.
 * - **spec** (Block List, Max: 1) (see below).
 *
 * <a id="nestedblock--query--spec"></a>
 *
 * ### `query.spec`
 *
 * Optional:
 *
 * - **match** (String) Type of match. Available values: `all`, `any`, `none`. Default: `all`.
 * - **terms** (Block List) (see below).
 *
 * <a id="nestedblock--query--spec--terms"></a>
 *
 * ### `query.spec.terms`
 *
 * <!-- Terms can only contain one of the following attributes: `property`, `rel`, `tag`. -->
 *
 * Terms can only contain one of the following attributes: `property`, `rel`, `tag`.
 *
 * Optional:
 *
 * - **op** (String) Type of query operation. Available values: `=`, `>`, `>=`, `<`, `<=`, `!=`, `exists`, `!exists`. Default: `=`.
 *
 * - **property** (String) Property to use for query evaluation.
 * - **rel** (String) Rel to use use for query evaluation.
 * - **tag** (String) Tag key to use for query evaluation.
 * - **value** (String) Testing value for query evaluation.
 *
 * ## Outputs
 *
 * The following attributes are exported:
 *
 * - **images** (Block List) (see below).
 *
 * <a id="nestedblock--images"></a>
 *
 * ### `images`
 *
 * - **cpln_id** (String) The ID, in GUID format, of the Image.
 * - **name** (String) Name of the Image.
 * - **tags** (Map of String) Key-value map of resource tags.
 * - **self_link** (String) Full link to this resource. Can be referenced by other resources.
 * - **tag** (String) Tag of the image.
 * - **repository** (String) Respository name of the image.
 * - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
 * - **manifest** (Block List, Max: 1) (see below)
 *
 * <a id="nestedblock--manifest"></a>
 *
 * ### `manifest`
 *
 *  The manifest provides configuration and layers information about the image. It plays a crucial role in the Docker image distribution system, enabling image creation, verification, and replication in a consistent and secure manner.
 *
 * - **config** (Block List, Max: 1) (see below).
 * - **layers** (Block List) (see below).
 * - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
 * - **schema_version** (Number) The version of the Docker Image Manifest format.
 *
 * <a id="nestedblock--config--layers"></a>
 *
 * ### `config` and `layers`
 *
 * The config is a JSON blob that contains the image configuration data which includes environment variables, default command to run, and other settings necessary to run the container based on this image.
 *
 * Layers lists the digests of the image's layers. These layers are filesystem changes or additions made in each step of the Docker image's creation process. The layers are stored separately and pulled as needed, which allows for efficient storage and transfer of images. Each layer is represented by a SHA256 digest, ensuring the integrity and authenticity of the image.
 *
 * - **size** (Number) The size of the image or layer in bytes. This helps in estimating the space required and the download time.
 * - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
 * - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
 */
export function getImages(args?: GetImagesArgs, opts?: pulumi.InvokeOptions): Promise<GetImagesResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("cpln:index/getImages:getImages", {
        "queries": args.queries,
    }, opts);
}

/**
 * A collection of arguments for invoking getImages.
 */
export interface GetImagesArgs {
    queries?: inputs.GetImagesQuery[];
}

/**
 * A collection of values returned by getImages.
 */
export interface GetImagesResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly images: outputs.GetImagesImage[];
    readonly queries?: outputs.GetImagesQuery[];
}
/**
 * Use this data source to access information about all [Images](https://docs.controlplane.com/reference/image) within Control Plane.
 *
 * ## Optional
 *
 * - **query** (Block List, Max: 1) (see below).
 *
 * <a id="nestedblock--query"></a>
 *
 * ### `query`
 *
 * Optional:
 *
 * - **fetch** (String) Type of fetch. Specify either: `links` or `items`. Default: `items`.
 * - **spec** (Block List, Max: 1) (see below).
 *
 * <a id="nestedblock--query--spec"></a>
 *
 * ### `query.spec`
 *
 * Optional:
 *
 * - **match** (String) Type of match. Available values: `all`, `any`, `none`. Default: `all`.
 * - **terms** (Block List) (see below).
 *
 * <a id="nestedblock--query--spec--terms"></a>
 *
 * ### `query.spec.terms`
 *
 * <!-- Terms can only contain one of the following attributes: `property`, `rel`, `tag`. -->
 *
 * Terms can only contain one of the following attributes: `property`, `rel`, `tag`.
 *
 * Optional:
 *
 * - **op** (String) Type of query operation. Available values: `=`, `>`, `>=`, `<`, `<=`, `!=`, `exists`, `!exists`. Default: `=`.
 *
 * - **property** (String) Property to use for query evaluation.
 * - **rel** (String) Rel to use use for query evaluation.
 * - **tag** (String) Tag key to use for query evaluation.
 * - **value** (String) Testing value for query evaluation.
 *
 * ## Outputs
 *
 * The following attributes are exported:
 *
 * - **images** (Block List) (see below).
 *
 * <a id="nestedblock--images"></a>
 *
 * ### `images`
 *
 * - **cpln_id** (String) The ID, in GUID format, of the Image.
 * - **name** (String) Name of the Image.
 * - **tags** (Map of String) Key-value map of resource tags.
 * - **self_link** (String) Full link to this resource. Can be referenced by other resources.
 * - **tag** (String) Tag of the image.
 * - **repository** (String) Respository name of the image.
 * - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
 * - **manifest** (Block List, Max: 1) (see below)
 *
 * <a id="nestedblock--manifest"></a>
 *
 * ### `manifest`
 *
 *  The manifest provides configuration and layers information about the image. It plays a crucial role in the Docker image distribution system, enabling image creation, verification, and replication in a consistent and secure manner.
 *
 * - **config** (Block List, Max: 1) (see below).
 * - **layers** (Block List) (see below).
 * - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
 * - **schema_version** (Number) The version of the Docker Image Manifest format.
 *
 * <a id="nestedblock--config--layers"></a>
 *
 * ### `config` and `layers`
 *
 * The config is a JSON blob that contains the image configuration data which includes environment variables, default command to run, and other settings necessary to run the container based on this image.
 *
 * Layers lists the digests of the image's layers. These layers are filesystem changes or additions made in each step of the Docker image's creation process. The layers are stored separately and pulled as needed, which allows for efficient storage and transfer of images. Each layer is represented by a SHA256 digest, ensuring the integrity and authenticity of the image.
 *
 * - **size** (Number) The size of the image or layer in bytes. This helps in estimating the space required and the download time.
 * - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
 * - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
 */
export function getImagesOutput(args?: GetImagesOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetImagesResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("cpln:index/getImages:getImages", {
        "queries": args.queries,
    }, opts);
}

/**
 * A collection of arguments for invoking getImages.
 */
export interface GetImagesOutputArgs {
    queries?: pulumi.Input<pulumi.Input<inputs.GetImagesQueryArgs>[]>;
}
