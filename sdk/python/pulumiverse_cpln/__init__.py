# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from .agent import *
from .audit_context import *
from .cloud_account import *
from .domain import *
from .domain_route import *
from .get_cloud_account import *
from .get_gvc import *
from .get_image import *
from .get_images import *
from .get_location import *
from .get_locations import *
from .get_org import *
from .group import *
from .gvc import *
from .identity import *
from .location import *
from .mk8s import *
from .org import *
from .org_logging import *
from .org_tracing import *
from .policy import *
from .provider import *
from .secret import *
from .service_account import *
from .service_account_key import *
from .volume_set import *
from .workload import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumiverse_cpln.config as __config
    config = __config
else:
    config = _utilities.lazy_import('pulumiverse_cpln.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "cpln",
  "mod": "index/agent",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/agent:Agent": "Agent"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/auditContext",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/auditContext:AuditContext": "AuditContext"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/cloudAccount",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/cloudAccount:CloudAccount": "CloudAccount"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/domain",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/domain:Domain": "Domain"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/domainRoute",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/domainRoute:DomainRoute": "DomainRoute"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/group",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/group:Group": "Group"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/gvc",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/gvc:Gvc": "Gvc"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/identity",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/identity:Identity": "Identity"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/location",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/location:Location": "Location"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/mk8s",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/mk8s:Mk8s": "Mk8s"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/org",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/org:Org": "Org"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/orgLogging",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/orgLogging:OrgLogging": "OrgLogging"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/orgTracing",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/orgTracing:OrgTracing": "OrgTracing"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/policy",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/policy:Policy": "Policy"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/secret",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/secret:Secret": "Secret"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/serviceAccount",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/serviceAccount:ServiceAccount": "ServiceAccount"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/serviceAccountKey",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/serviceAccountKey:ServiceAccountKey": "ServiceAccountKey"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/volumeSet",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/volumeSet:VolumeSet": "VolumeSet"
  }
 },
 {
  "pkg": "cpln",
  "mod": "index/workload",
  "fqn": "pulumiverse_cpln",
  "classes": {
   "cpln:index/workload:Workload": "Workload"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "cpln",
  "token": "pulumi:providers:cpln",
  "fqn": "pulumiverse_cpln",
  "class": "Provider"
 }
]
"""
)
