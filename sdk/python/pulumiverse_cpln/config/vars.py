# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins
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
from .. import _utilities

import types

__config__ = pulumi.Config('cpln')


class _ExportableConfig(types.ModuleType):
    @property
    def endpoint(self) -> Optional[str]:
        """
        The Control Plane Data Service API endpoint. Default is: https://api.cpln.io. Can be specified with the CPLN_ENDPOINT
        environment variable.
        """
        return __config__.get('endpoint')

    @property
    def org(self) -> Optional[str]:
        """
        The Control Plane org that this provider will perform actions against. Can be specified with the CPLN_ORG environment
        variable.
        """
        return __config__.get('org')

    @property
    def profile(self) -> Optional[str]:
        """
        The user/service account profile that this provider will use to authenticate to the data service. Can be specified with
        the CPLN_PROFILE environment variable.
        """
        return __config__.get('profile')

    @property
    def refresh_token(self) -> Optional[str]:
        """
        A generated token that can be used to authenticate to the data service API. Can be specified with the CPLN_REFRESH_TOKEN
        environment variable. Used when the provider is required to create an org or update the auth_config property. Refer to
        the section above on how to obtain the refresh token.
        """
        return __config__.get('refreshToken')

    @property
    def token(self) -> Optional[str]:
        """
        A generated token that can be used to authenticate to the data service API. Can be specified with the CPLN_TOKEN
        environment variable.
        """
        return __config__.get('token')

