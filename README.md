# Control Plane (cpln) Resource Provider

The Control Plane Resource Provider lets you manage [Control Plane](https://controlplane.com/) resources.

## Installing

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

```bash
npm install @pulumiverse/cpln
```

or `yarn`:

```bash
yarn add @pulumiverse/cpln
```

### Python

To use from Python, install using `pip`:

```bash
pip install pulumiverse-cpln
```

### Go

To use from Go, use `go get` to grab the latest version of the library:

```bash
go get github.com/pulumiverse/pulumi-cpln/sdk/go/...
```

### .NET

To use from .NET, install using `dotnet add package`:

```bash
dotnet add package Pulumiverse.cpln
```

## Configuration

The following configuration points are available for the `cpln` provider:

- `cpln:org` - The Control Plane org that this provider will perform actions against
- `cpln:endpoint` - The Control Plane Data Service API endpoint
- `cpln:profile` - The user/service account profile that this provider will use to authenticate to the data service
- `cpln:token` - A generated token that can be used to authenticate to the data service API
- `cpln:refreshToken` - A generated token that can be used to authenticate to the data service API

## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/cpln/api-docs/).
