---
title: cpln Installation & Configuration
meta_desc: Information on how to install the cpln provider.
layout: installation
---

## Installation

The Pulumi cpln provider is available as a package in all Pulumi languages:

* JavaScript/TypeScript: [`@pulumiserve/cpln`](https://www.npmjs.com/package/@pulumiverse/cpln)
* Python: [`pulumiverse_cpln`](https://pypi.org/project/pulumiverse-cpln/)
* Go: [`github.com/pulumiverse/pulumi-cpln/sdk/go/cpln`](https://pkg.go.dev/github.com/pulumiverse/pulumi-cpln/sdk)
* .NET: [`Pulumiverse.cpln`](https://www.nuget.org/packages/Pulumiverse.cpln)

## Setup

To provision resources with the Pulumi cpln provider, you need to have a cpln domain and JWT profile.

## Configuration Options

Use `pulumi config set cpln:<option>`.

| Option | Required/Optional | Description |
|-----|------|----|
| `domain`| Required | Domain used to connect to the cpln instance |
| `insecure`| Optional | Use insecure connection |
| `jwtProfileFile`| Optional |  Path to the file containing credentials to connect to cpln. Either `jwtProfileFile` or `jwtProfileJson` is required |
| `jwtProfileJson`| Optional | JSON value of credentials to connect to cpln. Either `jwtProfileFile` or `jwtProfileJson` is required |
| `port`| Optional |  Used port if not the default ports 80 or 443 are configured |
| `jwtProfileJson`| Optional | Domain used to connect to the cpln instance |
| `token`| Optional | Path to the file containing credentials to connect to cpln |