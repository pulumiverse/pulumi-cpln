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

__all__ = ['OrgTracingArgs', 'OrgTracing']

@pulumi.input_type
class OrgTracingArgs:
    def __init__(__self__, *,
                 controlplane_tracing: Optional[pulumi.Input['OrgTracingControlplaneTracingArgs']] = None,
                 lightstep_tracing: Optional[pulumi.Input['OrgTracingLightstepTracingArgs']] = None,
                 otel_tracing: Optional[pulumi.Input['OrgTracingOtelTracingArgs']] = None):
        """
        The set of arguments for constructing a OrgTracing resource.
        """
        if controlplane_tracing is not None:
            pulumi.set(__self__, "controlplane_tracing", controlplane_tracing)
        if lightstep_tracing is not None:
            pulumi.set(__self__, "lightstep_tracing", lightstep_tracing)
        if otel_tracing is not None:
            pulumi.set(__self__, "otel_tracing", otel_tracing)

    @property
    @pulumi.getter(name="controlplaneTracing")
    def controlplane_tracing(self) -> Optional[pulumi.Input['OrgTracingControlplaneTracingArgs']]:
        return pulumi.get(self, "controlplane_tracing")

    @controlplane_tracing.setter
    def controlplane_tracing(self, value: Optional[pulumi.Input['OrgTracingControlplaneTracingArgs']]):
        pulumi.set(self, "controlplane_tracing", value)

    @property
    @pulumi.getter(name="lightstepTracing")
    def lightstep_tracing(self) -> Optional[pulumi.Input['OrgTracingLightstepTracingArgs']]:
        return pulumi.get(self, "lightstep_tracing")

    @lightstep_tracing.setter
    def lightstep_tracing(self, value: Optional[pulumi.Input['OrgTracingLightstepTracingArgs']]):
        pulumi.set(self, "lightstep_tracing", value)

    @property
    @pulumi.getter(name="otelTracing")
    def otel_tracing(self) -> Optional[pulumi.Input['OrgTracingOtelTracingArgs']]:
        return pulumi.get(self, "otel_tracing")

    @otel_tracing.setter
    def otel_tracing(self, value: Optional[pulumi.Input['OrgTracingOtelTracingArgs']]):
        pulumi.set(self, "otel_tracing", value)


@pulumi.input_type
class _OrgTracingState:
    def __init__(__self__, *,
                 controlplane_tracing: Optional[pulumi.Input['OrgTracingControlplaneTracingArgs']] = None,
                 cpln_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 lightstep_tracing: Optional[pulumi.Input['OrgTracingLightstepTracingArgs']] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 otel_tracing: Optional[pulumi.Input['OrgTracingOtelTracingArgs']] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering OrgTracing resources.
        :param pulumi.Input[str] cpln_id: The ID, in GUID format, of the org.
        :param pulumi.Input[str] description: The description of org.
        :param pulumi.Input[str] name: The name of the org.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of the org's tags.
        """
        if controlplane_tracing is not None:
            pulumi.set(__self__, "controlplane_tracing", controlplane_tracing)
        if cpln_id is not None:
            pulumi.set(__self__, "cpln_id", cpln_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if lightstep_tracing is not None:
            pulumi.set(__self__, "lightstep_tracing", lightstep_tracing)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if otel_tracing is not None:
            pulumi.set(__self__, "otel_tracing", otel_tracing)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="controlplaneTracing")
    def controlplane_tracing(self) -> Optional[pulumi.Input['OrgTracingControlplaneTracingArgs']]:
        return pulumi.get(self, "controlplane_tracing")

    @controlplane_tracing.setter
    def controlplane_tracing(self, value: Optional[pulumi.Input['OrgTracingControlplaneTracingArgs']]):
        pulumi.set(self, "controlplane_tracing", value)

    @property
    @pulumi.getter(name="cplnId")
    def cpln_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID, in GUID format, of the org.
        """
        return pulumi.get(self, "cpln_id")

    @cpln_id.setter
    def cpln_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cpln_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of org.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="lightstepTracing")
    def lightstep_tracing(self) -> Optional[pulumi.Input['OrgTracingLightstepTracingArgs']]:
        return pulumi.get(self, "lightstep_tracing")

    @lightstep_tracing.setter
    def lightstep_tracing(self, value: Optional[pulumi.Input['OrgTracingLightstepTracingArgs']]):
        pulumi.set(self, "lightstep_tracing", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the org.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="otelTracing")
    def otel_tracing(self) -> Optional[pulumi.Input['OrgTracingOtelTracingArgs']]:
        return pulumi.get(self, "otel_tracing")

    @otel_tracing.setter
    def otel_tracing(self, value: Optional[pulumi.Input['OrgTracingOtelTracingArgs']]):
        pulumi.set(self, "otel_tracing", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Key-value map of the org's tags.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)


class OrgTracing(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 controlplane_tracing: Optional[pulumi.Input[Union['OrgTracingControlplaneTracingArgs', 'OrgTracingControlplaneTracingArgsDict']]] = None,
                 lightstep_tracing: Optional[pulumi.Input[Union['OrgTracingLightstepTracingArgs', 'OrgTracingLightstepTracingArgsDict']]] = None,
                 otel_tracing: Optional[pulumi.Input[Union['OrgTracingOtelTracingArgs', 'OrgTracingOtelTracingArgsDict']]] = None,
                 __props__=None):
        """
        Create a OrgTracing resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[OrgTracingArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a OrgTracing resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param OrgTracingArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(OrgTracingArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 controlplane_tracing: Optional[pulumi.Input[Union['OrgTracingControlplaneTracingArgs', 'OrgTracingControlplaneTracingArgsDict']]] = None,
                 lightstep_tracing: Optional[pulumi.Input[Union['OrgTracingLightstepTracingArgs', 'OrgTracingLightstepTracingArgsDict']]] = None,
                 otel_tracing: Optional[pulumi.Input[Union['OrgTracingOtelTracingArgs', 'OrgTracingOtelTracingArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = OrgTracingArgs.__new__(OrgTracingArgs)

            __props__.__dict__["controlplane_tracing"] = controlplane_tracing
            __props__.__dict__["lightstep_tracing"] = lightstep_tracing
            __props__.__dict__["otel_tracing"] = otel_tracing
            __props__.__dict__["cpln_id"] = None
            __props__.__dict__["description"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["tags"] = None
        super(OrgTracing, __self__).__init__(
            'cpln:index/orgTracing:OrgTracing',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            controlplane_tracing: Optional[pulumi.Input[Union['OrgTracingControlplaneTracingArgs', 'OrgTracingControlplaneTracingArgsDict']]] = None,
            cpln_id: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            lightstep_tracing: Optional[pulumi.Input[Union['OrgTracingLightstepTracingArgs', 'OrgTracingLightstepTracingArgsDict']]] = None,
            name: Optional[pulumi.Input[str]] = None,
            otel_tracing: Optional[pulumi.Input[Union['OrgTracingOtelTracingArgs', 'OrgTracingOtelTracingArgsDict']]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None) -> 'OrgTracing':
        """
        Get an existing OrgTracing resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cpln_id: The ID, in GUID format, of the org.
        :param pulumi.Input[str] description: The description of org.
        :param pulumi.Input[str] name: The name of the org.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of the org's tags.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _OrgTracingState.__new__(_OrgTracingState)

        __props__.__dict__["controlplane_tracing"] = controlplane_tracing
        __props__.__dict__["cpln_id"] = cpln_id
        __props__.__dict__["description"] = description
        __props__.__dict__["lightstep_tracing"] = lightstep_tracing
        __props__.__dict__["name"] = name
        __props__.__dict__["otel_tracing"] = otel_tracing
        __props__.__dict__["tags"] = tags
        return OrgTracing(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="controlplaneTracing")
    def controlplane_tracing(self) -> pulumi.Output[Optional['outputs.OrgTracingControlplaneTracing']]:
        return pulumi.get(self, "controlplane_tracing")

    @property
    @pulumi.getter(name="cplnId")
    def cpln_id(self) -> pulumi.Output[str]:
        """
        The ID, in GUID format, of the org.
        """
        return pulumi.get(self, "cpln_id")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        The description of org.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="lightstepTracing")
    def lightstep_tracing(self) -> pulumi.Output[Optional['outputs.OrgTracingLightstepTracing']]:
        return pulumi.get(self, "lightstep_tracing")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the org.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="otelTracing")
    def otel_tracing(self) -> pulumi.Output[Optional['outputs.OrgTracingOtelTracing']]:
        return pulumi.get(self, "otel_tracing")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Mapping[str, str]]:
        """
        Key-value map of the org's tags.
        """
        return pulumi.get(self, "tags")

