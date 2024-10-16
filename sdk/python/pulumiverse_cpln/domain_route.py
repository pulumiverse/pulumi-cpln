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

__all__ = ['DomainRouteArgs', 'DomainRoute']

@pulumi.input_type
class DomainRouteArgs:
    def __init__(__self__, *,
                 domain_link: pulumi.Input[str],
                 workload_link: pulumi.Input[str],
                 domain_port: Optional[pulumi.Input[int]] = None,
                 headers: Optional[pulumi.Input['DomainRouteHeadersArgs']] = None,
                 host_prefix: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 prefix: Optional[pulumi.Input[str]] = None,
                 regex: Optional[pulumi.Input[str]] = None,
                 replace_prefix: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a DomainRoute resource.
        :param pulumi.Input[str] domain_link: The self link of the domain to add the route to.
        :param pulumi.Input[str] workload_link: The link of the workload to map the prefix to.
        :param pulumi.Input[int] domain_port: The port the route corresponds to. Default: 443
        :param pulumi.Input['DomainRouteHeadersArgs'] headers: Modify the headers for all http requests for this route.
        :param pulumi.Input[str] host_prefix: This option allows forwarding traffic for different host headers to different workloads. This will only be used when the
               target GVC has dedicated load balancing enabled and the Domain is configured for wildcard support. Please contact us on
               Slack or at support@controlplane.com for additional details.
        :param pulumi.Input[int] port: For the linked workload, the port to route traffic to.
        :param pulumi.Input[str] prefix: The path will match any unmatched path prefixes for the subdomain.
        :param pulumi.Input[str] regex: Used to match URI paths. Uses the google re2 regex syntax.
        :param pulumi.Input[str] replace_prefix: A path prefix can be configured to be replaced when forwarding the request to the Workload.
        """
        DomainRouteArgs._configure(
            lambda key, value: pulumi.set(__self__, key, value),
            domain_link=domain_link,
            workload_link=workload_link,
            domain_port=domain_port,
            headers=headers,
            host_prefix=host_prefix,
            port=port,
            prefix=prefix,
            regex=regex,
            replace_prefix=replace_prefix,
        )
    @staticmethod
    def _configure(
             _setter: Callable[[Any, Any], None],
             domain_link: pulumi.Input[str],
             workload_link: pulumi.Input[str],
             domain_port: Optional[pulumi.Input[int]] = None,
             headers: Optional[pulumi.Input['DomainRouteHeadersArgs']] = None,
             host_prefix: Optional[pulumi.Input[str]] = None,
             port: Optional[pulumi.Input[int]] = None,
             prefix: Optional[pulumi.Input[str]] = None,
             regex: Optional[pulumi.Input[str]] = None,
             replace_prefix: Optional[pulumi.Input[str]] = None,
             opts: Optional[pulumi.ResourceOptions]=None,
             **kwargs):
        if 'domainLink' in kwargs:
            domain_link = kwargs['domainLink']
        if 'workloadLink' in kwargs:
            workload_link = kwargs['workloadLink']
        if 'domainPort' in kwargs:
            domain_port = kwargs['domainPort']
        if 'hostPrefix' in kwargs:
            host_prefix = kwargs['hostPrefix']
        if 'replacePrefix' in kwargs:
            replace_prefix = kwargs['replacePrefix']

        _setter("domain_link", domain_link)
        _setter("workload_link", workload_link)
        if domain_port is not None:
            _setter("domain_port", domain_port)
        if headers is not None:
            _setter("headers", headers)
        if host_prefix is not None:
            _setter("host_prefix", host_prefix)
        if port is not None:
            _setter("port", port)
        if prefix is not None:
            _setter("prefix", prefix)
        if regex is not None:
            _setter("regex", regex)
        if replace_prefix is not None:
            _setter("replace_prefix", replace_prefix)

    @property
    @pulumi.getter(name="domainLink")
    def domain_link(self) -> pulumi.Input[str]:
        """
        The self link of the domain to add the route to.
        """
        return pulumi.get(self, "domain_link")

    @domain_link.setter
    def domain_link(self, value: pulumi.Input[str]):
        pulumi.set(self, "domain_link", value)

    @property
    @pulumi.getter(name="workloadLink")
    def workload_link(self) -> pulumi.Input[str]:
        """
        The link of the workload to map the prefix to.
        """
        return pulumi.get(self, "workload_link")

    @workload_link.setter
    def workload_link(self, value: pulumi.Input[str]):
        pulumi.set(self, "workload_link", value)

    @property
    @pulumi.getter(name="domainPort")
    def domain_port(self) -> Optional[pulumi.Input[int]]:
        """
        The port the route corresponds to. Default: 443
        """
        return pulumi.get(self, "domain_port")

    @domain_port.setter
    def domain_port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "domain_port", value)

    @property
    @pulumi.getter
    def headers(self) -> Optional[pulumi.Input['DomainRouteHeadersArgs']]:
        """
        Modify the headers for all http requests for this route.
        """
        return pulumi.get(self, "headers")

    @headers.setter
    def headers(self, value: Optional[pulumi.Input['DomainRouteHeadersArgs']]):
        pulumi.set(self, "headers", value)

    @property
    @pulumi.getter(name="hostPrefix")
    def host_prefix(self) -> Optional[pulumi.Input[str]]:
        """
        This option allows forwarding traffic for different host headers to different workloads. This will only be used when the
        target GVC has dedicated load balancing enabled and the Domain is configured for wildcard support. Please contact us on
        Slack or at support@controlplane.com for additional details.
        """
        return pulumi.get(self, "host_prefix")

    @host_prefix.setter
    def host_prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_prefix", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        """
        For the linked workload, the port to route traffic to.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter
    def prefix(self) -> Optional[pulumi.Input[str]]:
        """
        The path will match any unmatched path prefixes for the subdomain.
        """
        return pulumi.get(self, "prefix")

    @prefix.setter
    def prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "prefix", value)

    @property
    @pulumi.getter
    def regex(self) -> Optional[pulumi.Input[str]]:
        """
        Used to match URI paths. Uses the google re2 regex syntax.
        """
        return pulumi.get(self, "regex")

    @regex.setter
    def regex(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "regex", value)

    @property
    @pulumi.getter(name="replacePrefix")
    def replace_prefix(self) -> Optional[pulumi.Input[str]]:
        """
        A path prefix can be configured to be replaced when forwarding the request to the Workload.
        """
        return pulumi.get(self, "replace_prefix")

    @replace_prefix.setter
    def replace_prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "replace_prefix", value)


@pulumi.input_type
class _DomainRouteState:
    def __init__(__self__, *,
                 domain_link: Optional[pulumi.Input[str]] = None,
                 domain_port: Optional[pulumi.Input[int]] = None,
                 headers: Optional[pulumi.Input['DomainRouteHeadersArgs']] = None,
                 host_prefix: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 prefix: Optional[pulumi.Input[str]] = None,
                 regex: Optional[pulumi.Input[str]] = None,
                 replace_prefix: Optional[pulumi.Input[str]] = None,
                 workload_link: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DomainRoute resources.
        :param pulumi.Input[str] domain_link: The self link of the domain to add the route to.
        :param pulumi.Input[int] domain_port: The port the route corresponds to. Default: 443
        :param pulumi.Input['DomainRouteHeadersArgs'] headers: Modify the headers for all http requests for this route.
        :param pulumi.Input[str] host_prefix: This option allows forwarding traffic for different host headers to different workloads. This will only be used when the
               target GVC has dedicated load balancing enabled and the Domain is configured for wildcard support. Please contact us on
               Slack or at support@controlplane.com for additional details.
        :param pulumi.Input[int] port: For the linked workload, the port to route traffic to.
        :param pulumi.Input[str] prefix: The path will match any unmatched path prefixes for the subdomain.
        :param pulumi.Input[str] regex: Used to match URI paths. Uses the google re2 regex syntax.
        :param pulumi.Input[str] replace_prefix: A path prefix can be configured to be replaced when forwarding the request to the Workload.
        :param pulumi.Input[str] workload_link: The link of the workload to map the prefix to.
        """
        _DomainRouteState._configure(
            lambda key, value: pulumi.set(__self__, key, value),
            domain_link=domain_link,
            domain_port=domain_port,
            headers=headers,
            host_prefix=host_prefix,
            port=port,
            prefix=prefix,
            regex=regex,
            replace_prefix=replace_prefix,
            workload_link=workload_link,
        )
    @staticmethod
    def _configure(
             _setter: Callable[[Any, Any], None],
             domain_link: Optional[pulumi.Input[str]] = None,
             domain_port: Optional[pulumi.Input[int]] = None,
             headers: Optional[pulumi.Input['DomainRouteHeadersArgs']] = None,
             host_prefix: Optional[pulumi.Input[str]] = None,
             port: Optional[pulumi.Input[int]] = None,
             prefix: Optional[pulumi.Input[str]] = None,
             regex: Optional[pulumi.Input[str]] = None,
             replace_prefix: Optional[pulumi.Input[str]] = None,
             workload_link: Optional[pulumi.Input[str]] = None,
             opts: Optional[pulumi.ResourceOptions]=None,
             **kwargs):
        if 'domainLink' in kwargs:
            domain_link = kwargs['domainLink']
        if 'domainPort' in kwargs:
            domain_port = kwargs['domainPort']
        if 'hostPrefix' in kwargs:
            host_prefix = kwargs['hostPrefix']
        if 'replacePrefix' in kwargs:
            replace_prefix = kwargs['replacePrefix']
        if 'workloadLink' in kwargs:
            workload_link = kwargs['workloadLink']

        if domain_link is not None:
            _setter("domain_link", domain_link)
        if domain_port is not None:
            _setter("domain_port", domain_port)
        if headers is not None:
            _setter("headers", headers)
        if host_prefix is not None:
            _setter("host_prefix", host_prefix)
        if port is not None:
            _setter("port", port)
        if prefix is not None:
            _setter("prefix", prefix)
        if regex is not None:
            _setter("regex", regex)
        if replace_prefix is not None:
            _setter("replace_prefix", replace_prefix)
        if workload_link is not None:
            _setter("workload_link", workload_link)

    @property
    @pulumi.getter(name="domainLink")
    def domain_link(self) -> Optional[pulumi.Input[str]]:
        """
        The self link of the domain to add the route to.
        """
        return pulumi.get(self, "domain_link")

    @domain_link.setter
    def domain_link(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "domain_link", value)

    @property
    @pulumi.getter(name="domainPort")
    def domain_port(self) -> Optional[pulumi.Input[int]]:
        """
        The port the route corresponds to. Default: 443
        """
        return pulumi.get(self, "domain_port")

    @domain_port.setter
    def domain_port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "domain_port", value)

    @property
    @pulumi.getter
    def headers(self) -> Optional[pulumi.Input['DomainRouteHeadersArgs']]:
        """
        Modify the headers for all http requests for this route.
        """
        return pulumi.get(self, "headers")

    @headers.setter
    def headers(self, value: Optional[pulumi.Input['DomainRouteHeadersArgs']]):
        pulumi.set(self, "headers", value)

    @property
    @pulumi.getter(name="hostPrefix")
    def host_prefix(self) -> Optional[pulumi.Input[str]]:
        """
        This option allows forwarding traffic for different host headers to different workloads. This will only be used when the
        target GVC has dedicated load balancing enabled and the Domain is configured for wildcard support. Please contact us on
        Slack or at support@controlplane.com for additional details.
        """
        return pulumi.get(self, "host_prefix")

    @host_prefix.setter
    def host_prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_prefix", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        """
        For the linked workload, the port to route traffic to.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter
    def prefix(self) -> Optional[pulumi.Input[str]]:
        """
        The path will match any unmatched path prefixes for the subdomain.
        """
        return pulumi.get(self, "prefix")

    @prefix.setter
    def prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "prefix", value)

    @property
    @pulumi.getter
    def regex(self) -> Optional[pulumi.Input[str]]:
        """
        Used to match URI paths. Uses the google re2 regex syntax.
        """
        return pulumi.get(self, "regex")

    @regex.setter
    def regex(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "regex", value)

    @property
    @pulumi.getter(name="replacePrefix")
    def replace_prefix(self) -> Optional[pulumi.Input[str]]:
        """
        A path prefix can be configured to be replaced when forwarding the request to the Workload.
        """
        return pulumi.get(self, "replace_prefix")

    @replace_prefix.setter
    def replace_prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "replace_prefix", value)

    @property
    @pulumi.getter(name="workloadLink")
    def workload_link(self) -> Optional[pulumi.Input[str]]:
        """
        The link of the workload to map the prefix to.
        """
        return pulumi.get(self, "workload_link")

    @workload_link.setter
    def workload_link(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "workload_link", value)


class DomainRoute(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain_link: Optional[pulumi.Input[str]] = None,
                 domain_port: Optional[pulumi.Input[int]] = None,
                 headers: Optional[pulumi.Input[pulumi.InputType['DomainRouteHeadersArgs']]] = None,
                 host_prefix: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 prefix: Optional[pulumi.Input[str]] = None,
                 regex: Optional[pulumi.Input[str]] = None,
                 replace_prefix: Optional[pulumi.Input[str]] = None,
                 workload_link: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a DomainRoute resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain_link: The self link of the domain to add the route to.
        :param pulumi.Input[int] domain_port: The port the route corresponds to. Default: 443
        :param pulumi.Input[pulumi.InputType['DomainRouteHeadersArgs']] headers: Modify the headers for all http requests for this route.
        :param pulumi.Input[str] host_prefix: This option allows forwarding traffic for different host headers to different workloads. This will only be used when the
               target GVC has dedicated load balancing enabled and the Domain is configured for wildcard support. Please contact us on
               Slack or at support@controlplane.com for additional details.
        :param pulumi.Input[int] port: For the linked workload, the port to route traffic to.
        :param pulumi.Input[str] prefix: The path will match any unmatched path prefixes for the subdomain.
        :param pulumi.Input[str] regex: Used to match URI paths. Uses the google re2 regex syntax.
        :param pulumi.Input[str] replace_prefix: A path prefix can be configured to be replaced when forwarding the request to the Workload.
        :param pulumi.Input[str] workload_link: The link of the workload to map the prefix to.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DomainRouteArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a DomainRoute resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param DomainRouteArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DomainRouteArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            kwargs = kwargs or {}
            def _setter(key, value):
                kwargs[key] = value
            DomainRouteArgs._configure(_setter, **kwargs)
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain_link: Optional[pulumi.Input[str]] = None,
                 domain_port: Optional[pulumi.Input[int]] = None,
                 headers: Optional[pulumi.Input[pulumi.InputType['DomainRouteHeadersArgs']]] = None,
                 host_prefix: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 prefix: Optional[pulumi.Input[str]] = None,
                 regex: Optional[pulumi.Input[str]] = None,
                 replace_prefix: Optional[pulumi.Input[str]] = None,
                 workload_link: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DomainRouteArgs.__new__(DomainRouteArgs)

            if domain_link is None and not opts.urn:
                raise TypeError("Missing required property 'domain_link'")
            __props__.__dict__["domain_link"] = domain_link
            __props__.__dict__["domain_port"] = domain_port
            if headers is not None and not isinstance(headers, DomainRouteHeadersArgs):
                headers = headers or {}
                def _setter(key, value):
                    headers[key] = value
                DomainRouteHeadersArgs._configure(_setter, **headers)
            __props__.__dict__["headers"] = headers
            __props__.__dict__["host_prefix"] = host_prefix
            __props__.__dict__["port"] = port
            __props__.__dict__["prefix"] = prefix
            __props__.__dict__["regex"] = regex
            __props__.__dict__["replace_prefix"] = replace_prefix
            if workload_link is None and not opts.urn:
                raise TypeError("Missing required property 'workload_link'")
            __props__.__dict__["workload_link"] = workload_link
        super(DomainRoute, __self__).__init__(
            'cpln:index/domainRoute:DomainRoute',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            domain_link: Optional[pulumi.Input[str]] = None,
            domain_port: Optional[pulumi.Input[int]] = None,
            headers: Optional[pulumi.Input[pulumi.InputType['DomainRouteHeadersArgs']]] = None,
            host_prefix: Optional[pulumi.Input[str]] = None,
            port: Optional[pulumi.Input[int]] = None,
            prefix: Optional[pulumi.Input[str]] = None,
            regex: Optional[pulumi.Input[str]] = None,
            replace_prefix: Optional[pulumi.Input[str]] = None,
            workload_link: Optional[pulumi.Input[str]] = None) -> 'DomainRoute':
        """
        Get an existing DomainRoute resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain_link: The self link of the domain to add the route to.
        :param pulumi.Input[int] domain_port: The port the route corresponds to. Default: 443
        :param pulumi.Input[pulumi.InputType['DomainRouteHeadersArgs']] headers: Modify the headers for all http requests for this route.
        :param pulumi.Input[str] host_prefix: This option allows forwarding traffic for different host headers to different workloads. This will only be used when the
               target GVC has dedicated load balancing enabled and the Domain is configured for wildcard support. Please contact us on
               Slack or at support@controlplane.com for additional details.
        :param pulumi.Input[int] port: For the linked workload, the port to route traffic to.
        :param pulumi.Input[str] prefix: The path will match any unmatched path prefixes for the subdomain.
        :param pulumi.Input[str] regex: Used to match URI paths. Uses the google re2 regex syntax.
        :param pulumi.Input[str] replace_prefix: A path prefix can be configured to be replaced when forwarding the request to the Workload.
        :param pulumi.Input[str] workload_link: The link of the workload to map the prefix to.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DomainRouteState.__new__(_DomainRouteState)

        __props__.__dict__["domain_link"] = domain_link
        __props__.__dict__["domain_port"] = domain_port
        __props__.__dict__["headers"] = headers
        __props__.__dict__["host_prefix"] = host_prefix
        __props__.__dict__["port"] = port
        __props__.__dict__["prefix"] = prefix
        __props__.__dict__["regex"] = regex
        __props__.__dict__["replace_prefix"] = replace_prefix
        __props__.__dict__["workload_link"] = workload_link
        return DomainRoute(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="domainLink")
    def domain_link(self) -> pulumi.Output[str]:
        """
        The self link of the domain to add the route to.
        """
        return pulumi.get(self, "domain_link")

    @property
    @pulumi.getter(name="domainPort")
    def domain_port(self) -> pulumi.Output[Optional[int]]:
        """
        The port the route corresponds to. Default: 443
        """
        return pulumi.get(self, "domain_port")

    @property
    @pulumi.getter
    def headers(self) -> pulumi.Output[Optional['outputs.DomainRouteHeaders']]:
        """
        Modify the headers for all http requests for this route.
        """
        return pulumi.get(self, "headers")

    @property
    @pulumi.getter(name="hostPrefix")
    def host_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        This option allows forwarding traffic for different host headers to different workloads. This will only be used when the
        target GVC has dedicated load balancing enabled and the Domain is configured for wildcard support. Please contact us on
        Slack or at support@controlplane.com for additional details.
        """
        return pulumi.get(self, "host_prefix")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[Optional[int]]:
        """
        For the linked workload, the port to route traffic to.
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter
    def prefix(self) -> pulumi.Output[Optional[str]]:
        """
        The path will match any unmatched path prefixes for the subdomain.
        """
        return pulumi.get(self, "prefix")

    @property
    @pulumi.getter
    def regex(self) -> pulumi.Output[Optional[str]]:
        """
        Used to match URI paths. Uses the google re2 regex syntax.
        """
        return pulumi.get(self, "regex")

    @property
    @pulumi.getter(name="replacePrefix")
    def replace_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        A path prefix can be configured to be replaced when forwarding the request to the Workload.
        """
        return pulumi.get(self, "replace_prefix")

    @property
    @pulumi.getter(name="workloadLink")
    def workload_link(self) -> pulumi.Output[str]:
        """
        The link of the workload to map the prefix to.
        """
        return pulumi.get(self, "workload_link")

