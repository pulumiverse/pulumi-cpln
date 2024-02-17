# cpln Resource Provider

The cpln Resource Provider lets you manage [Control Plane](https://controlplane.com/) resources.

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
pip install pulumi_cpln
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

- `cpln:domain` - domain used to connect to the cpln instance
- `cpln:insecure` - use insecure connection
- `cpln:jwtProfileFile` - path to the file containing credentials to connect to cpln. Either `jwtProfileFile` or `jwtProfileJson`
- `cpln:jwtProfileJson` - JSON value of credentials to connect to cpln. Either `jwtProfileFile` or `jwtProfileJson` is required
- `cpln:port` - used port if not the default ports 80 or 443 are configured
- `cpln:token` - path to the file containing credentials to connect to cpln

## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/cpln/api-docs/).
