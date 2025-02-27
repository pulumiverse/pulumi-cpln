# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import sys
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
if sys.version_info >= (3, 11):
    from typing import NotRequired, TypedDict, TypeAlias
else:
    from typing_extensions import NotRequired, TypedDict, TypeAlias
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = [
    'GetImagesResult',
    'AwaitableGetImagesResult',
    'get_images',
    'get_images_output',
]

@pulumi.output_type
class GetImagesResult:
    """
    A collection of values returned by getImages.
    """
    def __init__(__self__, id=None, images=None, query=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if images and not isinstance(images, list):
            raise TypeError("Expected argument 'images' to be a list")
        pulumi.set(__self__, "images", images)
        if query and not isinstance(query, dict):
            raise TypeError("Expected argument 'query' to be a dict")
        pulumi.set(__self__, "query", query)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def images(self) -> Sequence['outputs.GetImagesImageResult']:
        return pulumi.get(self, "images")

    @property
    @pulumi.getter
    def query(self) -> Optional['outputs.GetImagesQueryResult']:
        return pulumi.get(self, "query")


class AwaitableGetImagesResult(GetImagesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetImagesResult(
            id=self.id,
            images=self.images,
            query=self.query)


def get_images(query: Optional[Union['GetImagesQueryArgs', 'GetImagesQueryArgsDict']] = None,
               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetImagesResult:
    """
    Use this data source to access information about all [Images](https://docs.controlplane.com/reference/image) within Control Plane.

    ## Optional

    - **query** (Block List, Max: 1) (see below).

    <a id="nestedblock--query"></a>

    ### `query`

    Optional:

    - **fetch** (String) Type of fetch. Specify either: `links` or `items`. Default: `items`.
    - **spec** (Block List, Max: 1) (see below).

    <a id="nestedblock--query--spec"></a>

    ### `query.spec`

    Optional:

    - **match** (String) Type of match. Available values: `all`, `any`, `none`. Default: `all`.
    - **terms** (Block List) (see below).

    <a id="nestedblock--query--spec--terms"></a>

    ### `query.spec.terms`

    <!-- Terms can only contain one of the following attributes: `property`, `rel`, `tag`. -->

    Terms can only contain one of the following attributes: `property`, `rel`, `tag`.

    Optional:

    - **op** (String) Type of query operation. Available values: `=`, `>`, `>=`, `<`, `<=`, `!=`, `exists`, `!exists`. Default: `=`.

    - **property** (String) Property to use for query evaluation.
    - **rel** (String) Rel to use use for query evaluation.
    - **tag** (String) Tag key to use for query evaluation.
    - **value** (String) Testing value for query evaluation.

    ## Outputs

    The following attributes are exported:

    - **images** (Block List) (see below).

    <a id="nestedblock--images"></a>

    ### `images`

    - **cpln_id** (String) The ID, in GUID format, of the Image.
    - **name** (String) Name of the Image.
    - **tags** (Map of String) Key-value map of resource tags.
    - **self_link** (String) Full link to this resource. Can be referenced by other resources.
    - **tag** (String) Tag of the image.
    - **repository** (String) Respository name of the image.
    - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
    - **manifest** (Block List, Max: 1) (see below)

    <a id="nestedblock--manifest"></a>

    ### `manifest`

     The manifest provides configuration and layers information about the image. It plays a crucial role in the Docker image distribution system, enabling image creation, verification, and replication in a consistent and secure manner.

    - **config** (Block List, Max: 1) (see below).
    - **layers** (Block List) (see below).
    - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
    - **schema_version** (Number) The version of the Docker Image Manifest format.

    <a id="nestedblock--config--layers"></a>

    ### `config` and `layers`

    The config is a JSON blob that contains the image configuration data which includes environment variables, default command to run, and other settings necessary to run the container based on this image.

    Layers lists the digests of the image's layers. These layers are filesystem changes or additions made in each step of the Docker image's creation process. The layers are stored separately and pulled as needed, which allows for efficient storage and transfer of images. Each layer is represented by a SHA256 digest, ensuring the integrity and authenticity of the image.

    - **size** (Number) The size of the image or layer in bytes. This helps in estimating the space required and the download time.
    - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
    - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
    """
    __args__ = dict()
    __args__['query'] = query
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('cpln:index/getImages:getImages', __args__, opts=opts, typ=GetImagesResult).value

    return AwaitableGetImagesResult(
        id=pulumi.get(__ret__, 'id'),
        images=pulumi.get(__ret__, 'images'),
        query=pulumi.get(__ret__, 'query'))
def get_images_output(query: Optional[pulumi.Input[Optional[Union['GetImagesQueryArgs', 'GetImagesQueryArgsDict']]]] = None,
                      opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetImagesResult]:
    """
    Use this data source to access information about all [Images](https://docs.controlplane.com/reference/image) within Control Plane.

    ## Optional

    - **query** (Block List, Max: 1) (see below).

    <a id="nestedblock--query"></a>

    ### `query`

    Optional:

    - **fetch** (String) Type of fetch. Specify either: `links` or `items`. Default: `items`.
    - **spec** (Block List, Max: 1) (see below).

    <a id="nestedblock--query--spec"></a>

    ### `query.spec`

    Optional:

    - **match** (String) Type of match. Available values: `all`, `any`, `none`. Default: `all`.
    - **terms** (Block List) (see below).

    <a id="nestedblock--query--spec--terms"></a>

    ### `query.spec.terms`

    <!-- Terms can only contain one of the following attributes: `property`, `rel`, `tag`. -->

    Terms can only contain one of the following attributes: `property`, `rel`, `tag`.

    Optional:

    - **op** (String) Type of query operation. Available values: `=`, `>`, `>=`, `<`, `<=`, `!=`, `exists`, `!exists`. Default: `=`.

    - **property** (String) Property to use for query evaluation.
    - **rel** (String) Rel to use use for query evaluation.
    - **tag** (String) Tag key to use for query evaluation.
    - **value** (String) Testing value for query evaluation.

    ## Outputs

    The following attributes are exported:

    - **images** (Block List) (see below).

    <a id="nestedblock--images"></a>

    ### `images`

    - **cpln_id** (String) The ID, in GUID format, of the Image.
    - **name** (String) Name of the Image.
    - **tags** (Map of String) Key-value map of resource tags.
    - **self_link** (String) Full link to this resource. Can be referenced by other resources.
    - **tag** (String) Tag of the image.
    - **repository** (String) Respository name of the image.
    - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
    - **manifest** (Block List, Max: 1) (see below)

    <a id="nestedblock--manifest"></a>

    ### `manifest`

     The manifest provides configuration and layers information about the image. It plays a crucial role in the Docker image distribution system, enabling image creation, verification, and replication in a consistent and secure manner.

    - **config** (Block List, Max: 1) (see below).
    - **layers** (Block List) (see below).
    - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
    - **schema_version** (Number) The version of the Docker Image Manifest format.

    <a id="nestedblock--config--layers"></a>

    ### `config` and `layers`

    The config is a JSON blob that contains the image configuration data which includes environment variables, default command to run, and other settings necessary to run the container based on this image.

    Layers lists the digests of the image's layers. These layers are filesystem changes or additions made in each step of the Docker image's creation process. The layers are stored separately and pulled as needed, which allows for efficient storage and transfer of images. Each layer is represented by a SHA256 digest, ensuring the integrity and authenticity of the image.

    - **size** (Number) The size of the image or layer in bytes. This helps in estimating the space required and the download time.
    - **digest** (String) A unique SHA256 hash used to identify a specific image version within the image registry.
    - **media_type** (String) Specifies the type of the content represented in the manifest, allowing Docker clients and registries to understand how to handle the document correctly.
    """
    __args__ = dict()
    __args__['query'] = query
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('cpln:index/getImages:getImages', __args__, opts=opts, typ=GetImagesResult)
    return __ret__.apply(lambda __response__: GetImagesResult(
        id=pulumi.get(__response__, 'id'),
        images=pulumi.get(__response__, 'images'),
        query=pulumi.get(__response__, 'query')))
