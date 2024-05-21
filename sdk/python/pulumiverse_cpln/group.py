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

__all__ = ['GroupArgs', 'Group']

@pulumi.input_type
class GroupArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 identity_matcher: Optional[pulumi.Input['GroupIdentityMatcherArgs']] = None,
                 member_query: Optional[pulumi.Input['GroupMemberQueryArgs']] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 service_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 user_ids_and_emails: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a Group resource.
        :param pulumi.Input[str] description: Description of Group.
        :param pulumi.Input['GroupIdentityMatcherArgs'] identity_matcher: Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
               for managing the grouping of users logged-in with SAML providers.
        :param pulumi.Input['GroupMemberQueryArgs'] member_query: A predefined set of criteria or conditions used to query and retrieve members within the group.
        :param pulumi.Input[str] name: Name of the Group.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] service_accounts: List of service accounts that exists within the configured org. Group membership will fail if the service account does
               not exits within the org.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] user_ids_and_emails: List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
               if the user ID / email does not exist within the org.
        """
        GroupArgs._configure(
            lambda key, value: pulumi.set(__self__, key, value),
            description=description,
            identity_matcher=identity_matcher,
            member_query=member_query,
            name=name,
            service_accounts=service_accounts,
            tags=tags,
            user_ids_and_emails=user_ids_and_emails,
        )
    @staticmethod
    def _configure(
             _setter: Callable[[Any, Any], None],
             description: Optional[pulumi.Input[str]] = None,
             identity_matcher: Optional[pulumi.Input['GroupIdentityMatcherArgs']] = None,
             member_query: Optional[pulumi.Input['GroupMemberQueryArgs']] = None,
             name: Optional[pulumi.Input[str]] = None,
             service_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
             tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
             user_ids_and_emails: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
             opts: Optional[pulumi.ResourceOptions]=None,
             **kwargs):
        if 'identityMatcher' in kwargs:
            identity_matcher = kwargs['identityMatcher']
        if 'memberQuery' in kwargs:
            member_query = kwargs['memberQuery']
        if 'serviceAccounts' in kwargs:
            service_accounts = kwargs['serviceAccounts']
        if 'userIdsAndEmails' in kwargs:
            user_ids_and_emails = kwargs['userIdsAndEmails']

        if description is not None:
            _setter("description", description)
        if identity_matcher is not None:
            _setter("identity_matcher", identity_matcher)
        if member_query is not None:
            _setter("member_query", member_query)
        if name is not None:
            _setter("name", name)
        if service_accounts is not None:
            _setter("service_accounts", service_accounts)
        if tags is not None:
            _setter("tags", tags)
        if user_ids_and_emails is not None:
            _setter("user_ids_and_emails", user_ids_and_emails)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of Group.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="identityMatcher")
    def identity_matcher(self) -> Optional[pulumi.Input['GroupIdentityMatcherArgs']]:
        """
        Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
        for managing the grouping of users logged-in with SAML providers.
        """
        return pulumi.get(self, "identity_matcher")

    @identity_matcher.setter
    def identity_matcher(self, value: Optional[pulumi.Input['GroupIdentityMatcherArgs']]):
        pulumi.set(self, "identity_matcher", value)

    @property
    @pulumi.getter(name="memberQuery")
    def member_query(self) -> Optional[pulumi.Input['GroupMemberQueryArgs']]:
        """
        A predefined set of criteria or conditions used to query and retrieve members within the group.
        """
        return pulumi.get(self, "member_query")

    @member_query.setter
    def member_query(self, value: Optional[pulumi.Input['GroupMemberQueryArgs']]):
        pulumi.set(self, "member_query", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the Group.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="serviceAccounts")
    def service_accounts(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of service accounts that exists within the configured org. Group membership will fail if the service account does
        not exits within the org.
        """
        return pulumi.get(self, "service_accounts")

    @service_accounts.setter
    def service_accounts(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "service_accounts", value)

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
    @pulumi.getter(name="userIdsAndEmails")
    def user_ids_and_emails(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
        if the user ID / email does not exist within the org.
        """
        return pulumi.get(self, "user_ids_and_emails")

    @user_ids_and_emails.setter
    def user_ids_and_emails(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "user_ids_and_emails", value)


@pulumi.input_type
class _GroupState:
    def __init__(__self__, *,
                 cpln_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 identity_matcher: Optional[pulumi.Input['GroupIdentityMatcherArgs']] = None,
                 member_query: Optional[pulumi.Input['GroupMemberQueryArgs']] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 origin: Optional[pulumi.Input[str]] = None,
                 self_link: Optional[pulumi.Input[str]] = None,
                 service_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 user_ids_and_emails: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering Group resources.
        :param pulumi.Input[str] cpln_id: The ID, in GUID format, of the Group.
        :param pulumi.Input[str] description: Description of Group.
        :param pulumi.Input['GroupIdentityMatcherArgs'] identity_matcher: Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
               for managing the grouping of users logged-in with SAML providers.
        :param pulumi.Input['GroupMemberQueryArgs'] member_query: A predefined set of criteria or conditions used to query and retrieve members within the group.
        :param pulumi.Input[str] name: Name of the Group.
        :param pulumi.Input[str] origin: Origin of the service account. Either `builtin` or `default`.
        :param pulumi.Input[str] self_link: Fully qualified link to the this group.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] service_accounts: List of service accounts that exists within the configured org. Group membership will fail if the service account does
               not exits within the org.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] user_ids_and_emails: List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
               if the user ID / email does not exist within the org.
        """
        _GroupState._configure(
            lambda key, value: pulumi.set(__self__, key, value),
            cpln_id=cpln_id,
            description=description,
            identity_matcher=identity_matcher,
            member_query=member_query,
            name=name,
            origin=origin,
            self_link=self_link,
            service_accounts=service_accounts,
            tags=tags,
            user_ids_and_emails=user_ids_and_emails,
        )
    @staticmethod
    def _configure(
             _setter: Callable[[Any, Any], None],
             cpln_id: Optional[pulumi.Input[str]] = None,
             description: Optional[pulumi.Input[str]] = None,
             identity_matcher: Optional[pulumi.Input['GroupIdentityMatcherArgs']] = None,
             member_query: Optional[pulumi.Input['GroupMemberQueryArgs']] = None,
             name: Optional[pulumi.Input[str]] = None,
             origin: Optional[pulumi.Input[str]] = None,
             self_link: Optional[pulumi.Input[str]] = None,
             service_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
             tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
             user_ids_and_emails: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
             opts: Optional[pulumi.ResourceOptions]=None,
             **kwargs):
        if 'cplnId' in kwargs:
            cpln_id = kwargs['cplnId']
        if 'identityMatcher' in kwargs:
            identity_matcher = kwargs['identityMatcher']
        if 'memberQuery' in kwargs:
            member_query = kwargs['memberQuery']
        if 'selfLink' in kwargs:
            self_link = kwargs['selfLink']
        if 'serviceAccounts' in kwargs:
            service_accounts = kwargs['serviceAccounts']
        if 'userIdsAndEmails' in kwargs:
            user_ids_and_emails = kwargs['userIdsAndEmails']

        if cpln_id is not None:
            _setter("cpln_id", cpln_id)
        if description is not None:
            _setter("description", description)
        if identity_matcher is not None:
            _setter("identity_matcher", identity_matcher)
        if member_query is not None:
            _setter("member_query", member_query)
        if name is not None:
            _setter("name", name)
        if origin is not None:
            _setter("origin", origin)
        if self_link is not None:
            _setter("self_link", self_link)
        if service_accounts is not None:
            _setter("service_accounts", service_accounts)
        if tags is not None:
            _setter("tags", tags)
        if user_ids_and_emails is not None:
            _setter("user_ids_and_emails", user_ids_and_emails)

    @property
    @pulumi.getter(name="cplnId")
    def cpln_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID, in GUID format, of the Group.
        """
        return pulumi.get(self, "cpln_id")

    @cpln_id.setter
    def cpln_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cpln_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of Group.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="identityMatcher")
    def identity_matcher(self) -> Optional[pulumi.Input['GroupIdentityMatcherArgs']]:
        """
        Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
        for managing the grouping of users logged-in with SAML providers.
        """
        return pulumi.get(self, "identity_matcher")

    @identity_matcher.setter
    def identity_matcher(self, value: Optional[pulumi.Input['GroupIdentityMatcherArgs']]):
        pulumi.set(self, "identity_matcher", value)

    @property
    @pulumi.getter(name="memberQuery")
    def member_query(self) -> Optional[pulumi.Input['GroupMemberQueryArgs']]:
        """
        A predefined set of criteria or conditions used to query and retrieve members within the group.
        """
        return pulumi.get(self, "member_query")

    @member_query.setter
    def member_query(self, value: Optional[pulumi.Input['GroupMemberQueryArgs']]):
        pulumi.set(self, "member_query", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the Group.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def origin(self) -> Optional[pulumi.Input[str]]:
        """
        Origin of the service account. Either `builtin` or `default`.
        """
        return pulumi.get(self, "origin")

    @origin.setter
    def origin(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "origin", value)

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> Optional[pulumi.Input[str]]:
        """
        Fully qualified link to the this group.
        """
        return pulumi.get(self, "self_link")

    @self_link.setter
    def self_link(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "self_link", value)

    @property
    @pulumi.getter(name="serviceAccounts")
    def service_accounts(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of service accounts that exists within the configured org. Group membership will fail if the service account does
        not exits within the org.
        """
        return pulumi.get(self, "service_accounts")

    @service_accounts.setter
    def service_accounts(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "service_accounts", value)

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
    @pulumi.getter(name="userIdsAndEmails")
    def user_ids_and_emails(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
        if the user ID / email does not exist within the org.
        """
        return pulumi.get(self, "user_ids_and_emails")

    @user_ids_and_emails.setter
    def user_ids_and_emails(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "user_ids_and_emails", value)


class Group(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 identity_matcher: Optional[pulumi.Input[pulumi.InputType['GroupIdentityMatcherArgs']]] = None,
                 member_query: Optional[pulumi.Input[pulumi.InputType['GroupMemberQueryArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 service_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 user_ids_and_emails: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Create a Group resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of Group.
        :param pulumi.Input[pulumi.InputType['GroupIdentityMatcherArgs']] identity_matcher: Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
               for managing the grouping of users logged-in with SAML providers.
        :param pulumi.Input[pulumi.InputType['GroupMemberQueryArgs']] member_query: A predefined set of criteria or conditions used to query and retrieve members within the group.
        :param pulumi.Input[str] name: Name of the Group.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] service_accounts: List of service accounts that exists within the configured org. Group membership will fail if the service account does
               not exits within the org.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] user_ids_and_emails: List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
               if the user ID / email does not exist within the org.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[GroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a Group resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param GroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(GroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            kwargs = kwargs or {}
            def _setter(key, value):
                kwargs[key] = value
            GroupArgs._configure(_setter, **kwargs)
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 identity_matcher: Optional[pulumi.Input[pulumi.InputType['GroupIdentityMatcherArgs']]] = None,
                 member_query: Optional[pulumi.Input[pulumi.InputType['GroupMemberQueryArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 service_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 user_ids_and_emails: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = GroupArgs.__new__(GroupArgs)

            __props__.__dict__["description"] = description
            if identity_matcher is not None and not isinstance(identity_matcher, GroupIdentityMatcherArgs):
                identity_matcher = identity_matcher or {}
                def _setter(key, value):
                    identity_matcher[key] = value
                GroupIdentityMatcherArgs._configure(_setter, **identity_matcher)
            __props__.__dict__["identity_matcher"] = identity_matcher
            if member_query is not None and not isinstance(member_query, GroupMemberQueryArgs):
                member_query = member_query or {}
                def _setter(key, value):
                    member_query[key] = value
                GroupMemberQueryArgs._configure(_setter, **member_query)
            __props__.__dict__["member_query"] = member_query
            __props__.__dict__["name"] = name
            __props__.__dict__["service_accounts"] = service_accounts
            __props__.__dict__["tags"] = tags
            __props__.__dict__["user_ids_and_emails"] = user_ids_and_emails
            __props__.__dict__["cpln_id"] = None
            __props__.__dict__["origin"] = None
            __props__.__dict__["self_link"] = None
        super(Group, __self__).__init__(
            'cpln:index/group:Group',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cpln_id: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            identity_matcher: Optional[pulumi.Input[pulumi.InputType['GroupIdentityMatcherArgs']]] = None,
            member_query: Optional[pulumi.Input[pulumi.InputType['GroupMemberQueryArgs']]] = None,
            name: Optional[pulumi.Input[str]] = None,
            origin: Optional[pulumi.Input[str]] = None,
            self_link: Optional[pulumi.Input[str]] = None,
            service_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            user_ids_and_emails: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'Group':
        """
        Get an existing Group resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cpln_id: The ID, in GUID format, of the Group.
        :param pulumi.Input[str] description: Description of Group.
        :param pulumi.Input[pulumi.InputType['GroupIdentityMatcherArgs']] identity_matcher: Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
               for managing the grouping of users logged-in with SAML providers.
        :param pulumi.Input[pulumi.InputType['GroupMemberQueryArgs']] member_query: A predefined set of criteria or conditions used to query and retrieve members within the group.
        :param pulumi.Input[str] name: Name of the Group.
        :param pulumi.Input[str] origin: Origin of the service account. Either `builtin` or `default`.
        :param pulumi.Input[str] self_link: Fully qualified link to the this group.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] service_accounts: List of service accounts that exists within the configured org. Group membership will fail if the service account does
               not exits within the org.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Key-value map of resource tags.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] user_ids_and_emails: List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
               if the user ID / email does not exist within the org.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _GroupState.__new__(_GroupState)

        __props__.__dict__["cpln_id"] = cpln_id
        __props__.__dict__["description"] = description
        __props__.__dict__["identity_matcher"] = identity_matcher
        __props__.__dict__["member_query"] = member_query
        __props__.__dict__["name"] = name
        __props__.__dict__["origin"] = origin
        __props__.__dict__["self_link"] = self_link
        __props__.__dict__["service_accounts"] = service_accounts
        __props__.__dict__["tags"] = tags
        __props__.__dict__["user_ids_and_emails"] = user_ids_and_emails
        return Group(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="cplnId")
    def cpln_id(self) -> pulumi.Output[str]:
        """
        The ID, in GUID format, of the Group.
        """
        return pulumi.get(self, "cpln_id")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of Group.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="identityMatcher")
    def identity_matcher(self) -> pulumi.Output[Optional['outputs.GroupIdentityMatcher']]:
        """
        Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
        for managing the grouping of users logged-in with SAML providers.
        """
        return pulumi.get(self, "identity_matcher")

    @property
    @pulumi.getter(name="memberQuery")
    def member_query(self) -> pulumi.Output[Optional['outputs.GroupMemberQuery']]:
        """
        A predefined set of criteria or conditions used to query and retrieve members within the group.
        """
        return pulumi.get(self, "member_query")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the Group.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def origin(self) -> pulumi.Output[str]:
        """
        Origin of the service account. Either `builtin` or `default`.
        """
        return pulumi.get(self, "origin")

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> pulumi.Output[str]:
        """
        Fully qualified link to the this group.
        """
        return pulumi.get(self, "self_link")

    @property
    @pulumi.getter(name="serviceAccounts")
    def service_accounts(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        List of service accounts that exists within the configured org. Group membership will fail if the service account does
        not exits within the org.
        """
        return pulumi.get(self, "service_accounts")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Key-value map of resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="userIdsAndEmails")
    def user_ids_and_emails(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
        if the user ID / email does not exist within the org.
        """
        return pulumi.get(self, "user_ids_and_emails")

