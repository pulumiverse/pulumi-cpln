# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Callable, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['VolumeSetArgs', 'VolumeSet']

@pulumi.input_type
class VolumeSetArgs:
    def __init__(__self__, *,
                 gvc: pulumi.Input[str],
                 initial_capacity: pulumi.Input[int],
                 performance_class: pulumi.Input[str],
                 autoscaling: Optional[pulumi.Input['VolumeSetAutoscalingArgs']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 file_system_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 snapshots: Optional[pulumi.Input['VolumeSetSnapshotsArgs']] = None,
                 storage_class_suffix: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a VolumeSet resource.
        :param pulumi.Input[str] gvc: Name of the associated GVC.
        :param pulumi.Input[int] initial_capacity: The initial size in GB of volumes in this set. Minimum value: `10`.
        :param pulumi.Input[str] performance_class: Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
               `high-throughput-ssd`
        :param pulumi.Input['VolumeSetAutoscalingArgs'] autoscaling: Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
        :param pulumi.Input[str] description: Description of the Volume Set.
        :param pulumi.Input[str] file_system_type: Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        :param pulumi.Input[str] name: Name of the Volume Set.
        :param pulumi.Input['VolumeSetSnapshotsArgs'] snapshots: Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
        :param pulumi.Input[str] storage_class_suffix: For self-hosted locations only. The storage class used for volumes in this set will be
               {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
               {performanceClass}-{fileSystemType}
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
        """
        VolumeSetArgs._configure(
            lambda key, value: pulumi.set(__self__, key, value),
            gvc=gvc,
            initial_capacity=initial_capacity,
            performance_class=performance_class,
            autoscaling=autoscaling,
            description=description,
            file_system_type=file_system_type,
            name=name,
            snapshots=snapshots,
            storage_class_suffix=storage_class_suffix,
            tags=tags,
        )
    @staticmethod
    def _configure(
             _setter: Callable[[Any, Any], None],
             gvc: pulumi.Input[str],
             initial_capacity: pulumi.Input[int],
             performance_class: pulumi.Input[str],
             autoscaling: Optional[pulumi.Input['VolumeSetAutoscalingArgs']] = None,
             description: Optional[pulumi.Input[str]] = None,
             file_system_type: Optional[pulumi.Input[str]] = None,
             name: Optional[pulumi.Input[str]] = None,
             snapshots: Optional[pulumi.Input['VolumeSetSnapshotsArgs']] = None,
             storage_class_suffix: Optional[pulumi.Input[str]] = None,
             tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
             opts: Optional[pulumi.ResourceOptions]=None,
             **kwargs):
        if 'initialCapacity' in kwargs:
            initial_capacity = kwargs['initialCapacity']
        if 'performanceClass' in kwargs:
            performance_class = kwargs['performanceClass']
        if 'fileSystemType' in kwargs:
            file_system_type = kwargs['fileSystemType']
        if 'storageClassSuffix' in kwargs:
            storage_class_suffix = kwargs['storageClassSuffix']

        _setter("gvc", gvc)
        _setter("initial_capacity", initial_capacity)
        _setter("performance_class", performance_class)
        if autoscaling is not None:
            _setter("autoscaling", autoscaling)
        if description is not None:
            _setter("description", description)
        if file_system_type is not None:
            _setter("file_system_type", file_system_type)
        if name is not None:
            _setter("name", name)
        if snapshots is not None:
            _setter("snapshots", snapshots)
        if storage_class_suffix is not None:
            _setter("storage_class_suffix", storage_class_suffix)
        if tags is not None:
            _setter("tags", tags)

    @property
    @pulumi.getter
    def gvc(self) -> pulumi.Input[str]:
        """
        Name of the associated GVC.
        """
        return pulumi.get(self, "gvc")

    @gvc.setter
    def gvc(self, value: pulumi.Input[str]):
        pulumi.set(self, "gvc", value)

    @property
    @pulumi.getter(name="initialCapacity")
    def initial_capacity(self) -> pulumi.Input[int]:
        """
        The initial size in GB of volumes in this set. Minimum value: `10`.
        """
        return pulumi.get(self, "initial_capacity")

    @initial_capacity.setter
    def initial_capacity(self, value: pulumi.Input[int]):
        pulumi.set(self, "initial_capacity", value)

    @property
    @pulumi.getter(name="performanceClass")
    def performance_class(self) -> pulumi.Input[str]:
        """
        Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
        `high-throughput-ssd`
        """
        return pulumi.get(self, "performance_class")

    @performance_class.setter
    def performance_class(self, value: pulumi.Input[str]):
        pulumi.set(self, "performance_class", value)

    @property
    @pulumi.getter
    def autoscaling(self) -> Optional[pulumi.Input['VolumeSetAutoscalingArgs']]:
        """
        Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
        """
        return pulumi.get(self, "autoscaling")

    @autoscaling.setter
    def autoscaling(self, value: Optional[pulumi.Input['VolumeSetAutoscalingArgs']]):
        pulumi.set(self, "autoscaling", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the Volume Set.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="fileSystemType")
    def file_system_type(self) -> Optional[pulumi.Input[str]]:
        """
        Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        """
        return pulumi.get(self, "file_system_type")

    @file_system_type.setter
    def file_system_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "file_system_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the Volume Set.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def snapshots(self) -> Optional[pulumi.Input['VolumeSetSnapshotsArgs']]:
        """
        Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
        """
        return pulumi.get(self, "snapshots")

    @snapshots.setter
    def snapshots(self, value: Optional[pulumi.Input['VolumeSetSnapshotsArgs']]):
        pulumi.set(self, "snapshots", value)

    @property
    @pulumi.getter(name="storageClassSuffix")
    def storage_class_suffix(self) -> Optional[pulumi.Input[str]]:
        """
        For self-hosted locations only. The storage class used for volumes in this set will be
        {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
        {performanceClass}-{fileSystemType}
        """
        return pulumi.get(self, "storage_class_suffix")

    @storage_class_suffix.setter
    def storage_class_suffix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "storage_class_suffix", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Key-value map of resource tags.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)


@pulumi.input_type
class _VolumeSetState:
    def __init__(__self__, *,
                 autoscaling: Optional[pulumi.Input['VolumeSetAutoscalingArgs']] = None,
                 cpln_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 file_system_type: Optional[pulumi.Input[str]] = None,
                 gvc: Optional[pulumi.Input[str]] = None,
                 initial_capacity: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 performance_class: Optional[pulumi.Input[str]] = None,
                 self_link: Optional[pulumi.Input[str]] = None,
                 snapshots: Optional[pulumi.Input['VolumeSetSnapshotsArgs']] = None,
                 statuses: Optional[pulumi.Input[Sequence[pulumi.Input['VolumeSetStatusArgs']]]] = None,
                 storage_class_suffix: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 volumeset_link: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering VolumeSet resources.
        :param pulumi.Input['VolumeSetAutoscalingArgs'] autoscaling: Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
        :param pulumi.Input[str] cpln_id: ID, in GUID format, of the Volume Set.
        :param pulumi.Input[str] description: Description of the Volume Set.
        :param pulumi.Input[str] file_system_type: Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        :param pulumi.Input[str] gvc: Name of the associated GVC.
        :param pulumi.Input[int] initial_capacity: The initial size in GB of volumes in this set. Minimum value: `10`.
        :param pulumi.Input[str] name: Name of the Volume Set.
        :param pulumi.Input[str] performance_class: Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
               `high-throughput-ssd`
        :param pulumi.Input[str] self_link: Full link to this resource. Can be referenced by other resources.
        :param pulumi.Input['VolumeSetSnapshotsArgs'] snapshots: Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
        :param pulumi.Input[Sequence[pulumi.Input['VolumeSetStatusArgs']]] statuses: Status of the Volume Set.
        :param pulumi.Input[str] storage_class_suffix: For self-hosted locations only. The storage class used for volumes in this set will be
               {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
               {performanceClass}-{fileSystemType}
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
        :param pulumi.Input[str] volumeset_link: Output used when linking a volume set to a workload.
        """
        _VolumeSetState._configure(
            lambda key, value: pulumi.set(__self__, key, value),
            autoscaling=autoscaling,
            cpln_id=cpln_id,
            description=description,
            file_system_type=file_system_type,
            gvc=gvc,
            initial_capacity=initial_capacity,
            name=name,
            performance_class=performance_class,
            self_link=self_link,
            snapshots=snapshots,
            statuses=statuses,
            storage_class_suffix=storage_class_suffix,
            tags=tags,
            volumeset_link=volumeset_link,
        )
    @staticmethod
    def _configure(
             _setter: Callable[[Any, Any], None],
             autoscaling: Optional[pulumi.Input['VolumeSetAutoscalingArgs']] = None,
             cpln_id: Optional[pulumi.Input[str]] = None,
             description: Optional[pulumi.Input[str]] = None,
             file_system_type: Optional[pulumi.Input[str]] = None,
             gvc: Optional[pulumi.Input[str]] = None,
             initial_capacity: Optional[pulumi.Input[int]] = None,
             name: Optional[pulumi.Input[str]] = None,
             performance_class: Optional[pulumi.Input[str]] = None,
             self_link: Optional[pulumi.Input[str]] = None,
             snapshots: Optional[pulumi.Input['VolumeSetSnapshotsArgs']] = None,
             statuses: Optional[pulumi.Input[Sequence[pulumi.Input['VolumeSetStatusArgs']]]] = None,
             storage_class_suffix: Optional[pulumi.Input[str]] = None,
             tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
             volumeset_link: Optional[pulumi.Input[str]] = None,
             opts: Optional[pulumi.ResourceOptions]=None,
             **kwargs):
        if 'cplnId' in kwargs:
            cpln_id = kwargs['cplnId']
        if 'fileSystemType' in kwargs:
            file_system_type = kwargs['fileSystemType']
        if 'initialCapacity' in kwargs:
            initial_capacity = kwargs['initialCapacity']
        if 'performanceClass' in kwargs:
            performance_class = kwargs['performanceClass']
        if 'selfLink' in kwargs:
            self_link = kwargs['selfLink']
        if 'storageClassSuffix' in kwargs:
            storage_class_suffix = kwargs['storageClassSuffix']
        if 'volumesetLink' in kwargs:
            volumeset_link = kwargs['volumesetLink']

        if autoscaling is not None:
            _setter("autoscaling", autoscaling)
        if cpln_id is not None:
            _setter("cpln_id", cpln_id)
        if description is not None:
            _setter("description", description)
        if file_system_type is not None:
            _setter("file_system_type", file_system_type)
        if gvc is not None:
            _setter("gvc", gvc)
        if initial_capacity is not None:
            _setter("initial_capacity", initial_capacity)
        if name is not None:
            _setter("name", name)
        if performance_class is not None:
            _setter("performance_class", performance_class)
        if self_link is not None:
            _setter("self_link", self_link)
        if snapshots is not None:
            _setter("snapshots", snapshots)
        if statuses is not None:
            _setter("statuses", statuses)
        if storage_class_suffix is not None:
            _setter("storage_class_suffix", storage_class_suffix)
        if tags is not None:
            _setter("tags", tags)
        if volumeset_link is not None:
            _setter("volumeset_link", volumeset_link)

    @property
    @pulumi.getter
    def autoscaling(self) -> Optional[pulumi.Input['VolumeSetAutoscalingArgs']]:
        """
        Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
        """
        return pulumi.get(self, "autoscaling")

    @autoscaling.setter
    def autoscaling(self, value: Optional[pulumi.Input['VolumeSetAutoscalingArgs']]):
        pulumi.set(self, "autoscaling", value)

    @property
    @pulumi.getter(name="cplnId")
    def cpln_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID, in GUID format, of the Volume Set.
        """
        return pulumi.get(self, "cpln_id")

    @cpln_id.setter
    def cpln_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cpln_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the Volume Set.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="fileSystemType")
    def file_system_type(self) -> Optional[pulumi.Input[str]]:
        """
        Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        """
        return pulumi.get(self, "file_system_type")

    @file_system_type.setter
    def file_system_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "file_system_type", value)

    @property
    @pulumi.getter
    def gvc(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the associated GVC.
        """
        return pulumi.get(self, "gvc")

    @gvc.setter
    def gvc(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "gvc", value)

    @property
    @pulumi.getter(name="initialCapacity")
    def initial_capacity(self) -> Optional[pulumi.Input[int]]:
        """
        The initial size in GB of volumes in this set. Minimum value: `10`.
        """
        return pulumi.get(self, "initial_capacity")

    @initial_capacity.setter
    def initial_capacity(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "initial_capacity", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the Volume Set.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="performanceClass")
    def performance_class(self) -> Optional[pulumi.Input[str]]:
        """
        Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
        `high-throughput-ssd`
        """
        return pulumi.get(self, "performance_class")

    @performance_class.setter
    def performance_class(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "performance_class", value)

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> Optional[pulumi.Input[str]]:
        """
        Full link to this resource. Can be referenced by other resources.
        """
        return pulumi.get(self, "self_link")

    @self_link.setter
    def self_link(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "self_link", value)

    @property
    @pulumi.getter
    def snapshots(self) -> Optional[pulumi.Input['VolumeSetSnapshotsArgs']]:
        """
        Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
        """
        return pulumi.get(self, "snapshots")

    @snapshots.setter
    def snapshots(self, value: Optional[pulumi.Input['VolumeSetSnapshotsArgs']]):
        pulumi.set(self, "snapshots", value)

    @property
    @pulumi.getter
    def statuses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VolumeSetStatusArgs']]]]:
        """
        Status of the Volume Set.
        """
        return pulumi.get(self, "statuses")

    @statuses.setter
    def statuses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VolumeSetStatusArgs']]]]):
        pulumi.set(self, "statuses", value)

    @property
    @pulumi.getter(name="storageClassSuffix")
    def storage_class_suffix(self) -> Optional[pulumi.Input[str]]:
        """
        For self-hosted locations only. The storage class used for volumes in this set will be
        {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
        {performanceClass}-{fileSystemType}
        """
        return pulumi.get(self, "storage_class_suffix")

    @storage_class_suffix.setter
    def storage_class_suffix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "storage_class_suffix", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Key-value map of resource tags.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="volumesetLink")
    def volumeset_link(self) -> Optional[pulumi.Input[str]]:
        """
        Output used when linking a volume set to a workload.
        """
        return pulumi.get(self, "volumeset_link")

    @volumeset_link.setter
    def volumeset_link(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "volumeset_link", value)


class VolumeSet(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 autoscaling: Optional[pulumi.Input[pulumi.InputType['VolumeSetAutoscalingArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 file_system_type: Optional[pulumi.Input[str]] = None,
                 gvc: Optional[pulumi.Input[str]] = None,
                 initial_capacity: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 performance_class: Optional[pulumi.Input[str]] = None,
                 snapshots: Optional[pulumi.Input[pulumi.InputType['VolumeSetSnapshotsArgs']]] = None,
                 storage_class_suffix: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Create a VolumeSet resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['VolumeSetAutoscalingArgs']] autoscaling: Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
        :param pulumi.Input[str] description: Description of the Volume Set.
        :param pulumi.Input[str] file_system_type: Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        :param pulumi.Input[str] gvc: Name of the associated GVC.
        :param pulumi.Input[int] initial_capacity: The initial size in GB of volumes in this set. Minimum value: `10`.
        :param pulumi.Input[str] name: Name of the Volume Set.
        :param pulumi.Input[str] performance_class: Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
               `high-throughput-ssd`
        :param pulumi.Input[pulumi.InputType['VolumeSetSnapshotsArgs']] snapshots: Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
        :param pulumi.Input[str] storage_class_suffix: For self-hosted locations only. The storage class used for volumes in this set will be
               {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
               {performanceClass}-{fileSystemType}
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VolumeSetArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a VolumeSet resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param VolumeSetArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VolumeSetArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            kwargs = kwargs or {}
            def _setter(key, value):
                kwargs[key] = value
            VolumeSetArgs._configure(_setter, **kwargs)
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 autoscaling: Optional[pulumi.Input[pulumi.InputType['VolumeSetAutoscalingArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 file_system_type: Optional[pulumi.Input[str]] = None,
                 gvc: Optional[pulumi.Input[str]] = None,
                 initial_capacity: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 performance_class: Optional[pulumi.Input[str]] = None,
                 snapshots: Optional[pulumi.Input[pulumi.InputType['VolumeSetSnapshotsArgs']]] = None,
                 storage_class_suffix: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VolumeSetArgs.__new__(VolumeSetArgs)

            if autoscaling is not None and not isinstance(autoscaling, VolumeSetAutoscalingArgs):
                autoscaling = autoscaling or {}
                def _setter(key, value):
                    autoscaling[key] = value
                VolumeSetAutoscalingArgs._configure(_setter, **autoscaling)
            __props__.__dict__["autoscaling"] = autoscaling
            __props__.__dict__["description"] = description
            __props__.__dict__["file_system_type"] = file_system_type
            if gvc is None and not opts.urn:
                raise TypeError("Missing required property 'gvc'")
            __props__.__dict__["gvc"] = gvc
            if initial_capacity is None and not opts.urn:
                raise TypeError("Missing required property 'initial_capacity'")
            __props__.__dict__["initial_capacity"] = initial_capacity
            __props__.__dict__["name"] = name
            if performance_class is None and not opts.urn:
                raise TypeError("Missing required property 'performance_class'")
            __props__.__dict__["performance_class"] = performance_class
            if snapshots is not None and not isinstance(snapshots, VolumeSetSnapshotsArgs):
                snapshots = snapshots or {}
                def _setter(key, value):
                    snapshots[key] = value
                VolumeSetSnapshotsArgs._configure(_setter, **snapshots)
            __props__.__dict__["snapshots"] = snapshots
            __props__.__dict__["storage_class_suffix"] = storage_class_suffix
            __props__.__dict__["tags"] = tags
            __props__.__dict__["cpln_id"] = None
            __props__.__dict__["self_link"] = None
            __props__.__dict__["statuses"] = None
            __props__.__dict__["volumeset_link"] = None
        super(VolumeSet, __self__).__init__(
            'cpln:index/volumeSet:VolumeSet',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            autoscaling: Optional[pulumi.Input[pulumi.InputType['VolumeSetAutoscalingArgs']]] = None,
            cpln_id: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            file_system_type: Optional[pulumi.Input[str]] = None,
            gvc: Optional[pulumi.Input[str]] = None,
            initial_capacity: Optional[pulumi.Input[int]] = None,
            name: Optional[pulumi.Input[str]] = None,
            performance_class: Optional[pulumi.Input[str]] = None,
            self_link: Optional[pulumi.Input[str]] = None,
            snapshots: Optional[pulumi.Input[pulumi.InputType['VolumeSetSnapshotsArgs']]] = None,
            statuses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VolumeSetStatusArgs']]]]] = None,
            storage_class_suffix: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            volumeset_link: Optional[pulumi.Input[str]] = None) -> 'VolumeSet':
        """
        Get an existing VolumeSet resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['VolumeSetAutoscalingArgs']] autoscaling: Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
        :param pulumi.Input[str] cpln_id: ID, in GUID format, of the Volume Set.
        :param pulumi.Input[str] description: Description of the Volume Set.
        :param pulumi.Input[str] file_system_type: Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        :param pulumi.Input[str] gvc: Name of the associated GVC.
        :param pulumi.Input[int] initial_capacity: The initial size in GB of volumes in this set. Minimum value: `10`.
        :param pulumi.Input[str] name: Name of the Volume Set.
        :param pulumi.Input[str] performance_class: Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
               `high-throughput-ssd`
        :param pulumi.Input[str] self_link: Full link to this resource. Can be referenced by other resources.
        :param pulumi.Input[pulumi.InputType['VolumeSetSnapshotsArgs']] snapshots: Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VolumeSetStatusArgs']]]] statuses: Status of the Volume Set.
        :param pulumi.Input[str] storage_class_suffix: For self-hosted locations only. The storage class used for volumes in this set will be
               {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
               {performanceClass}-{fileSystemType}
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
        :param pulumi.Input[str] volumeset_link: Output used when linking a volume set to a workload.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _VolumeSetState.__new__(_VolumeSetState)

        __props__.__dict__["autoscaling"] = autoscaling
        __props__.__dict__["cpln_id"] = cpln_id
        __props__.__dict__["description"] = description
        __props__.__dict__["file_system_type"] = file_system_type
        __props__.__dict__["gvc"] = gvc
        __props__.__dict__["initial_capacity"] = initial_capacity
        __props__.__dict__["name"] = name
        __props__.__dict__["performance_class"] = performance_class
        __props__.__dict__["self_link"] = self_link
        __props__.__dict__["snapshots"] = snapshots
        __props__.__dict__["statuses"] = statuses
        __props__.__dict__["storage_class_suffix"] = storage_class_suffix
        __props__.__dict__["tags"] = tags
        __props__.__dict__["volumeset_link"] = volumeset_link
        return VolumeSet(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def autoscaling(self) -> pulumi.Output[Optional['outputs.VolumeSetAutoscaling']]:
        """
        Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
        """
        return pulumi.get(self, "autoscaling")

    @property
    @pulumi.getter(name="cplnId")
    def cpln_id(self) -> pulumi.Output[str]:
        """
        ID, in GUID format, of the Volume Set.
        """
        return pulumi.get(self, "cpln_id")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of the Volume Set.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="fileSystemType")
    def file_system_type(self) -> pulumi.Output[Optional[str]]:
        """
        Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        """
        return pulumi.get(self, "file_system_type")

    @property
    @pulumi.getter
    def gvc(self) -> pulumi.Output[str]:
        """
        Name of the associated GVC.
        """
        return pulumi.get(self, "gvc")

    @property
    @pulumi.getter(name="initialCapacity")
    def initial_capacity(self) -> pulumi.Output[int]:
        """
        The initial size in GB of volumes in this set. Minimum value: `10`.
        """
        return pulumi.get(self, "initial_capacity")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the Volume Set.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="performanceClass")
    def performance_class(self) -> pulumi.Output[str]:
        """
        Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
        `high-throughput-ssd`
        """
        return pulumi.get(self, "performance_class")

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> pulumi.Output[str]:
        """
        Full link to this resource. Can be referenced by other resources.
        """
        return pulumi.get(self, "self_link")

    @property
    @pulumi.getter
    def snapshots(self) -> pulumi.Output[Optional['outputs.VolumeSetSnapshots']]:
        """
        Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
        """
        return pulumi.get(self, "snapshots")

    @property
    @pulumi.getter
    def statuses(self) -> pulumi.Output[Sequence['outputs.VolumeSetStatus']]:
        """
        Status of the Volume Set.
        """
        return pulumi.get(self, "statuses")

    @property
    @pulumi.getter(name="storageClassSuffix")
    def storage_class_suffix(self) -> pulumi.Output[Optional[str]]:
        """
        For self-hosted locations only. The storage class used for volumes in this set will be
        {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
        {performanceClass}-{fileSystemType}
        """
        return pulumi.get(self, "storage_class_suffix")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Key-value map of resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="volumesetLink")
    def volumeset_link(self) -> pulumi.Output[str]:
        """
        Output used when linking a volume set to a workload.
        """
        return pulumi.get(self, "volumeset_link")

