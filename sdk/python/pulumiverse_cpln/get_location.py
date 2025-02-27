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

__all__ = [
    'GetLocationResult',
    'AwaitableGetLocationResult',
    'get_location',
    'get_location_output',
]

@pulumi.output_type
class GetLocationResult:
    """
    A collection of values returned by getLocation.
    """
    def __init__(__self__, cloud_provider=None, cpln_id=None, description=None, enabled=None, geos=None, id=None, ip_ranges=None, name=None, region=None, self_link=None, tags=None):
        if cloud_provider and not isinstance(cloud_provider, str):
            raise TypeError("Expected argument 'cloud_provider' to be a str")
        pulumi.set(__self__, "cloud_provider", cloud_provider)
        if cpln_id and not isinstance(cpln_id, str):
            raise TypeError("Expected argument 'cpln_id' to be a str")
        pulumi.set(__self__, "cpln_id", cpln_id)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if enabled and not isinstance(enabled, bool):
            raise TypeError("Expected argument 'enabled' to be a bool")
        pulumi.set(__self__, "enabled", enabled)
        if geos and not isinstance(geos, list):
            raise TypeError("Expected argument 'geos' to be a list")
        pulumi.set(__self__, "geos", geos)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ip_ranges and not isinstance(ip_ranges, list):
            raise TypeError("Expected argument 'ip_ranges' to be a list")
        pulumi.set(__self__, "ip_ranges", ip_ranges)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if region and not isinstance(region, str):
            raise TypeError("Expected argument 'region' to be a str")
        pulumi.set(__self__, "region", region)
        if self_link and not isinstance(self_link, str):
            raise TypeError("Expected argument 'self_link' to be a str")
        pulumi.set(__self__, "self_link", self_link)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="cloudProvider")
    def cloud_provider(self) -> str:
        return pulumi.get(self, "cloud_provider")

    @property
    @pulumi.getter(name="cplnId")
    def cpln_id(self) -> str:
        return pulumi.get(self, "cpln_id")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enabled(self) -> bool:
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def geos(self) -> Sequence['outputs.GetLocationGeoResult']:
        return pulumi.get(self, "geos")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="ipRanges")
    def ip_ranges(self) -> Sequence[str]:
        return pulumi.get(self, "ip_ranges")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def region(self) -> str:
        return pulumi.get(self, "region")

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> str:
        return pulumi.get(self, "self_link")

    @property
    @pulumi.getter
    def tags(self) -> Mapping[str, str]:
        return pulumi.get(self, "tags")


class AwaitableGetLocationResult(GetLocationResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetLocationResult(
            cloud_provider=self.cloud_provider,
            cpln_id=self.cpln_id,
            description=self.description,
            enabled=self.enabled,
            geos=self.geos,
            id=self.id,
            ip_ranges=self.ip_ranges,
            name=self.name,
            region=self.region,
            self_link=self.self_link,
            tags=self.tags)


def get_location(name: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetLocationResult:
    """
    Use this data source to access information about a [Location](https://docs.controlplane.com/reference/location) within Control Plane.

    ## Required

    - **name** (String) Name of the location (i.e. `aws-us-west-2`).

    ## Outputs

    The following attributes are exported:

    - **cpln_id** (String) The ID, in GUID format, of the location.
    - **name** (String) Name of the location.
    - **description** (String) Description of the location.
    - **tags** (Map of String) Key-value map of resource tags.
    - **cloud_provider** (String) Cloud Provider of the location.
    - **region** (String) Region of the location.
    - **enabled** (Boolean) Indication if location is enabled.
    - **geo** (Block List, Max: 1) (see below)
    - **ip_ranges** (List of String) A list of IP ranges of the location.
    - **self_link** (String) Full link to this resource. Can be referenced by other resources.

    <a id="nestedblock--geo"></a>

    ### `geo`

    Location geographical details

    - **lat** (Number) Latitude.
    - **lon** (Number) Longitude.
    - **country** (String) Country.
    - **state** (String) State.
    - **city** (String) City.
    - **continent** (String) Continent.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_cpln as cpln

    location_location = cpln.get_location(name="aws-us-west-2")
    pulumi.export("location", location_location)
    pulumi.export("locationEnabled", location_location.enabled)
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('cpln:index/getLocation:getLocation', __args__, opts=opts, typ=GetLocationResult).value

    return AwaitableGetLocationResult(
        cloud_provider=pulumi.get(__ret__, 'cloud_provider'),
        cpln_id=pulumi.get(__ret__, 'cpln_id'),
        description=pulumi.get(__ret__, 'description'),
        enabled=pulumi.get(__ret__, 'enabled'),
        geos=pulumi.get(__ret__, 'geos'),
        id=pulumi.get(__ret__, 'id'),
        ip_ranges=pulumi.get(__ret__, 'ip_ranges'),
        name=pulumi.get(__ret__, 'name'),
        region=pulumi.get(__ret__, 'region'),
        self_link=pulumi.get(__ret__, 'self_link'),
        tags=pulumi.get(__ret__, 'tags'))
def get_location_output(name: Optional[pulumi.Input[str]] = None,
                        opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetLocationResult]:
    """
    Use this data source to access information about a [Location](https://docs.controlplane.com/reference/location) within Control Plane.

    ## Required

    - **name** (String) Name of the location (i.e. `aws-us-west-2`).

    ## Outputs

    The following attributes are exported:

    - **cpln_id** (String) The ID, in GUID format, of the location.
    - **name** (String) Name of the location.
    - **description** (String) Description of the location.
    - **tags** (Map of String) Key-value map of resource tags.
    - **cloud_provider** (String) Cloud Provider of the location.
    - **region** (String) Region of the location.
    - **enabled** (Boolean) Indication if location is enabled.
    - **geo** (Block List, Max: 1) (see below)
    - **ip_ranges** (List of String) A list of IP ranges of the location.
    - **self_link** (String) Full link to this resource. Can be referenced by other resources.

    <a id="nestedblock--geo"></a>

    ### `geo`

    Location geographical details

    - **lat** (Number) Latitude.
    - **lon** (Number) Longitude.
    - **country** (String) Country.
    - **state** (String) State.
    - **city** (String) City.
    - **continent** (String) Continent.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_cpln as cpln

    location_location = cpln.get_location(name="aws-us-west-2")
    pulumi.export("location", location_location)
    pulumi.export("locationEnabled", location_location.enabled)
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('cpln:index/getLocation:getLocation', __args__, opts=opts, typ=GetLocationResult)
    return __ret__.apply(lambda __response__: GetLocationResult(
        cloud_provider=pulumi.get(__response__, 'cloud_provider'),
        cpln_id=pulumi.get(__response__, 'cpln_id'),
        description=pulumi.get(__response__, 'description'),
        enabled=pulumi.get(__response__, 'enabled'),
        geos=pulumi.get(__response__, 'geos'),
        id=pulumi.get(__response__, 'id'),
        ip_ranges=pulumi.get(__response__, 'ip_ranges'),
        name=pulumi.get(__response__, 'name'),
        region=pulumi.get(__response__, 'region'),
        self_link=pulumi.get(__response__, 'self_link'),
        tags=pulumi.get(__response__, 'tags')))
