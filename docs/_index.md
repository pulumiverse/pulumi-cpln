---
title: cpln
meta_desc: Provides an overview of the cpln Provider for Pulumi.
layout: overview
---

The cpln provider for Pulumi can be used to provision any of the cloud resources available in [Control Plane](https://controlplane.com/).
The cpln provider must be configured with credentials to deploy and update resources in cpln.

## Example

{{< chooser language "typescript,python,go,csharp" >}}
{{% choosable language typescript %}}

```typescript
import * as cpln from "@pulumiverse/cpln";
const db = new cpln.Org("example", {
    name: "example",
});
```

{{% /choosable %}}
{{% choosable language python %}}

```python
import pulumiverse_cpln as cpln

db = cpln.Database("example",
    name="example"
)
```

{{% /choosable %}}
{{% choosable language go %}}

```go
import (
	"fmt"
	cpln "github.com/pulumiverse/pulumi-cpln/sdk/go/cpln"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {

		org, err := cpln.NewOrg(ctx, "example", &cpln.OrgArgs{
            Name: pulumi.String("example"),
		})
		if err != nil {
			return fmt.Errorf("error creating org: %v", err)
		}

		ctx.Export("orgId", org.Id)

		return nil
	})
}
```

{{% /choosable %}}
{{% choosable language csharp %}}

```csharp
using Pulumi;
using Pulumiverse.cpln;

class cpln : Stack
{
    public cpln()
    {
        var org = new Org("example", new OrgArgs{
            Name: "example"
        });
    }
}
```

{{% /choosable %}}

{{< /chooser >}}