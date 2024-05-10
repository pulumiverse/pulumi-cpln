// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cpln

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumix"
	"github.com/pulumiverse/pulumi-cpln/sdk/go/cpln/internal"
)

// Use this data source to access information about all [Locations](https://docs.controlplane.com/reference/location) within Control Plane.
//
// ## Outputs
//
// The following attributes are exported:
//
// - **locations** (Block List) (see below).
//
// <a id="nestedblock--locations"></a>
//
// ### `locations`
//
// - **cpln_id** (String) The ID, in GUID format, of the location.
// - **name** (String) Name of the location.
// - **description** (String) Description of the location.
// - **tags** (Map of String) Key-value map of resource tags.
// - **cloud_provider** (String) Cloud Provider of the location.
// - **region** (String) Region of the location.
// - **enabled** (Boolean) Indication if location is enabled.
// - **geo** (Block List, Max: 1) (see below)
// - **ip_ranges** (List of String) A list of IP ranges of the location.
// - **self_link** (String) Full link to this resource. Can be referenced by other resources.
//
// <a id="nestedblock--geo"></a>
//
// ### `geo`
//
// # Location geographical details
//
// - **lat** (Number) Latitude.
// - **lon** (Number) Longitude.
// - **country** (String) Country.
// - **state** (String) State.
// - **city** (String) City.
// - **continent** (String) Continent.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/pulumiverse/pulumi-cpln/sdk/go/cpln"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			locationsLocations, err := cpln.GetLocations(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("locations", locationsLocations.Locations)
//			return nil
//		})
//	}
//
// ```
func GetLocations(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetLocationsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetLocationsResult
	err := ctx.Invoke("cpln:index/getLocations:getLocations", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getLocations.
type GetLocationsResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id        string                 `pulumi:"id"`
	Locations []GetLocationsLocation `pulumi:"locations"`
}

func GetLocationsOutput(ctx *pulumi.Context, opts ...pulumi.InvokeOption) GetLocationsResultOutput {
	return pulumi.ToOutput(0).ApplyT(func(int) (GetLocationsResult, error) {
		r, err := GetLocations(ctx, opts...)
		var s GetLocationsResult
		if r != nil {
			s = *r
		}
		return s, err
	}).(GetLocationsResultOutput)
}

// A collection of values returned by getLocations.
type GetLocationsResultOutput struct{ *pulumi.OutputState }

func (GetLocationsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetLocationsResult)(nil)).Elem()
}

func (o GetLocationsResultOutput) ToGetLocationsResultOutput() GetLocationsResultOutput {
	return o
}

func (o GetLocationsResultOutput) ToGetLocationsResultOutputWithContext(ctx context.Context) GetLocationsResultOutput {
	return o
}

func (o GetLocationsResultOutput) ToOutput(ctx context.Context) pulumix.Output[GetLocationsResult] {
	return pulumix.Output[GetLocationsResult]{
		OutputState: o.OutputState,
	}
}

// The provider-assigned unique ID for this managed resource.
func (o GetLocationsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetLocationsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetLocationsResultOutput) Locations() GetLocationsLocationArrayOutput {
	return o.ApplyT(func(v GetLocationsResult) []GetLocationsLocation { return v.Locations }).(GetLocationsLocationArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetLocationsResultOutput{})
}
