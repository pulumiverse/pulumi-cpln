---
# *** WARNING: This file was auto-generated. Do not edit by hand unless you're certain you know what you are doing! ***
title: Control Plane Provider
meta_desc: Provides an overview on how to configure the Pulumi Control Plane provider.
layout: package
---

## Installation

The Control Plane provider is available as a package in all Pulumi languages:

* JavaScript/TypeScript: [`@pulumi/cpln`](https://www.npmjs.com/package/@pulumi/cpln)
* Python: [`pulumi-cpln`](https://pypi.org/project/pulumi-cpln/)
* Go: [`github.com/pulumiverse/pulumi-cpln/sdk/go/cpln`](https://github.com/pulumi/pulumi-cpln)
* .NET: [`Pulumi.Cpln`](https://www.nuget.org/packages/Pulumi.Cpln)
* Java: [`com.pulumi/cpln`](https://central.sonatype.com/artifact/com.pulumi/cpln)

## Overview

The Control Plane Pulumi Provider Plugin enables the scaffolding of any Control Plane object as code using HCL. It enables infrastructure as code with all the added benefit of the global virtual cloud (GVC). You can build your VPCs, subnets, databases, queues, caches, etc. and overlay them with a multi-cloud/multi-region universal compute workloads that span regions and clouds. Nearly everything you can do using the Control Plane CLI, UI or API is available using Pulumi.

Each header below (i.e., `cpln.Agent`) corresponds to a resource within the Control Plane Pulumi provider.
## Authentication

Authenticate using one of the following methods:

`1. CLI`
- [Install the CLI](https://docs.controlplane.com/reference/cli#installation) and execute the command `cpln login`. After a successful login, the Pulumi provider will use the `default` profile to authenticate. To use a different profile, set the `profile` variable when initializing the provider or set the `CPLN_PROFILE` environment variable.

`2. Token`
- The `token` variable can be set when initializing the provider or by setting the `CPLN_TOKEN` environment variable.
- The value of `token` can be either:
  - The output of running the command `cpln profile token PROFILE_NAME`, or
  - In the case of a [Service Account](https://docs.controlplane.com/reference/serviceaccount), the value of one of it's [keys](https://docs.controlplane.com/reference/serviceaccount#keys)

`3. Refresh Token`
- The `refreshToken` variable is used when the provider is required to create an org or update the `authConfig` property using the `cpln.Org` resource. The `refreshToken` variable can be set when initializing the provider or by setting the `CPLN_REFRESH_TOKEN` environment variable.
- When creating an org, the `refreshToken` **must** belong to a user that has the `orgCreator` role for the associated account.
- When updating the org `authConfig` property, the `refreshToken` **must** belong to a user that was authenticated using SAML.
- The `refreshToken` can be obtained by following these steps:
  - Using the CLI, authenticate with a user account by executing `cpln login`.
  - Browser to the path `~/.config/cpln/profiles`. This path will contain JSON files corresponding to the name of the profile (i.e., `default.json`).
  - The contents of the JSON file will contain a key named `refreshToken`. Use the value of this key for the `refreshToken` variable.

> **Note** To perform automated tasks using Pulumi, the preferred method is to use a `Service Account` and one of it's `keys` as the `token` value.
## Provider Declaration
### Required

- **org** (String) The Control Plane org that this provider will perform actions against. Can be specified with the `CPLN_ORG` environment variable.

- **endpoint** (String) The Control Plane Data Service API endpoint. Default is: `https://api.cpln.io`. Can be specified with the `CPLN_ENDPOINT` environment variable.
- **profile** (String) The user/service account profile that this provider will use to authenticate to the data service. Can be specified with the `CPLN_PROFILE` environment variable.
- **token** (String) A generated token that can be used to authenticate to the data service API. Can be specified with the `CPLN_TOKEN` environment variable.
- **refresh_token** (String) A generated token that can be used to authenticate to the data service API. Can be specified with the `CPLN_REFRESH_TOKEN` environment variable. Used when the provider is required to create an org or update the `authConfig` property. Refer to the section above on how to obtain the refresh token.

> **Note** If the `token` or `refreshToken` value is empty, the Control Plane CLI (cpln) must be installed and the `cpln login` command must be used to authenticate.