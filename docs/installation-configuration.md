---
title: Control Plane (cpln) Installation & Configuration
meta_desc: Information on how to install the Control Plane (cpln) provider.
layout: installation
---

## Installation

The Pulumi Control Plane (cpln) provider is available as a package in all Pulumi languages:

* JavaScript/TypeScript: [`@pulumiserve/cpln`](https://www.npmjs.com/package/@pulumiverse/cpln)
* Python: [`pulumiverse_cpln`](https://pypi.org/project/pulumiverse-cpln/)
* Go: [`github.com/pulumiverse/pulumi-cpln/sdk/go/cpln`](https://pkg.go.dev/github.com/pulumiverse/pulumi-cpln/sdk)
* .NET: [`Pulumiverse.cpln`](https://www.nuget.org/packages/Pulumiverse.cpln)

## Setup

To provision resources with the Pulumi Control Plane (cpln) provider, you need to [authenticate with one of the available options](https://registry.terraform.io/providers/controlplane-com/cpln/latest/docs#authentication).

## Configuration Options

Use `pulumi config set cpln:<option>`.

| Option | Required/Optional | Description |
|-----|------|----|
| `org`| Required | The Control Plane org that this provider will perform actions against. Can be specified with the `CPLN_ORG` environment variable. |
| `endpoint`| Optional | The Control Plane Data Service API endpoint. Default is: `https://api.cpln.io`. Can be specified with the `CPLN_ENDPOINT` environment variable |
| `profile`| Optional | The user/service account profile that this provider will use to authenticate to the data service. Can be specified with the `CPLN_PROFILE` environment variable. |
| `token`| Optional | A generated token that can be used to authenticate to the data service API. Can be specified with the `CPLN_TOKEN` environment variable |
| `refreshToken`| Optional | A generated token that can be used to authenticate to the data service API. Can be specified with the `CPLN_REFRESH_TOKEN` environment variable. Used when the provider is required to create an org or update the `authConfig` property. Refer to the [auth docs](https://registry.terraform.io/providers/controlplane-com/cpln/latest/docs#authentication) on how to obtain the refresh token. |