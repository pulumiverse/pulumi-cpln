// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cpln

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-cpln/sdk/go/cpln/internal"
)

// Use this data source to access information about an existing [Global Virtual Cloud (GVC)](https://docs.controlplane.com/reference/gvc) within Control Plane.
//
// ## Required
//
// - **name** (String) Name of the GVC.
//
// ## Outputs
//
// The following attributes are exported:
//
// - **cpln_id** (String) The ID, in GUID format, of the GVC.
// - **name** (String) Name of the GVC.
// - **alias** (String) The alias name of the GVC.
// - **description** (String) Description of the GVC.
// - **tags** (Map of String) Key-value map of resource tags.
// - **self_link** (String) Full link to this resource. Can be referenced by other resources.
// - **domain** (String) Custom domain name used by associated workloads.
// - **locations** (List of String) A list of [locations](https://docs.controlplane.com/reference/location#current) making up the Global Virtual Cloud.
// - **pull_secrets** (List of String) A list of [pull secret](https://docs.controlplane.com/reference/gvc#pull-secrets) names used to authenticate to any private image repository referenced by Workloads within the GVC.
// - **lightstep_tracing** (Block List, Max: 1) (see below).
// - **otel_tracing** (Block List, Max: 1) (see below).
// - **controlplane_tracing** (Block List, Max: 1) (see below).
// - **load_balancer** (Block List, Max: 1) (see below).
//
// <a id="nestedblock--lightstep_tracing"></a>
//
// ### `lightstepTracing`
//
// - **sampling** (Int) Sampling percentage.
// - **endpoint** (String) Tracing Endpoint Workload. Either the canonical endpoint or the internal endpoint.
// - **credentials** (String) Full link to referenced Opaque Secret.
//
// <a id="nestedblock--otel_tracing"></a>
//
// ### `otelTracing`
//
// - **sampling** (Int) Determines what percentage of requests should be traced.
// - **endpoint** (String) Tracing Endpoint Workload. Either the canonical endpoint or internal endpoint.
// - **custom_tags** (Map of String) Key-value map of custom tags.
//
// <a id="nestedblock--controlplane_tracing"></a>
//
// ### `controlplaneTracing`
//
// - **sampling** (Int) Determines what percentage of requests should be traced.
// - **custom_tags** (Map of String) Key-value map of custom tags.
//
// <a id="nestedblock--load_balancer"></a>
//
// ### `loadBalancer`
//
// - **dedicated** (Boolean) Creates a dedicated load balancer in each location and enables additional Domain features: custom ports, protocols and wildcard hostnames. Charges apply for each location.
//
// - **trusted_proxies** (Int) Controls the address used for request logging and for setting the X-Envoy-External-Address header. If set to 1, then the last address in an existing X-Forwarded-For header will be used in place of the source client IP address. If set to 2, then the second to last address in an existing X-Forwarded-For header will be used in place of the source client IP address. If the XFF header does not have at least two addresses or does not exist then the source client IP address will be used instead.
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
//			gvc, err := cpln.LookupGvc(ctx, &cpln.LookupGvcArgs{
//				Name: "gvc-example",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("gvcId", gvc.Id)
//			ctx.Export("gvcLocations", gvc.Locations)
//			return nil
//		})
//	}
//
// ```
func LookupGvc(ctx *pulumi.Context, args *LookupGvcArgs, opts ...pulumi.InvokeOption) (*LookupGvcResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupGvcResult
	err := ctx.Invoke("cpln:index/getGvc:getGvc", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getGvc.
type LookupGvcArgs struct {
	ControlplaneTracing *GetGvcControlplaneTracing `pulumi:"controlplaneTracing"`
	// Deprecated: Selecting a domain on a GVC will be deprecated in the future. Use the 'cpln_domain resource' instead.
	Domain               *string                 `pulumi:"domain"`
	EndpointNamingFormat *string                 `pulumi:"endpointNamingFormat"`
	Env                  map[string]string       `pulumi:"env"`
	LightstepTracing     *GetGvcLightstepTracing `pulumi:"lightstepTracing"`
	LoadBalancer         *GetGvcLoadBalancer     `pulumi:"loadBalancer"`
	Locations            []string                `pulumi:"locations"`
	Name                 string                  `pulumi:"name"`
	OtelTracing          *GetGvcOtelTracing      `pulumi:"otelTracing"`
	PullSecrets          []string                `pulumi:"pullSecrets"`
	Sidecar              *GetGvcSidecar          `pulumi:"sidecar"`
	Tags                 map[string]string       `pulumi:"tags"`
}

// A collection of values returned by getGvc.
type LookupGvcResult struct {
	Alias               string                     `pulumi:"alias"`
	ControlplaneTracing *GetGvcControlplaneTracing `pulumi:"controlplaneTracing"`
	CplnId              string                     `pulumi:"cplnId"`
	Description         string                     `pulumi:"description"`
	// Deprecated: Selecting a domain on a GVC will be deprecated in the future. Use the 'cpln_domain resource' instead.
	Domain               *string                 `pulumi:"domain"`
	EndpointNamingFormat string                  `pulumi:"endpointNamingFormat"`
	Env                  map[string]string       `pulumi:"env"`
	Id                   string                  `pulumi:"id"`
	LightstepTracing     *GetGvcLightstepTracing `pulumi:"lightstepTracing"`
	LoadBalancer         *GetGvcLoadBalancer     `pulumi:"loadBalancer"`
	Locations            []string                `pulumi:"locations"`
	Name                 string                  `pulumi:"name"`
	OtelTracing          *GetGvcOtelTracing      `pulumi:"otelTracing"`
	PullSecrets          []string                `pulumi:"pullSecrets"`
	SelfLink             string                  `pulumi:"selfLink"`
	Sidecar              *GetGvcSidecar          `pulumi:"sidecar"`
	Tags                 map[string]string       `pulumi:"tags"`
}

func LookupGvcOutput(ctx *pulumi.Context, args LookupGvcOutputArgs, opts ...pulumi.InvokeOption) LookupGvcResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupGvcResultOutput, error) {
			args := v.(LookupGvcArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("cpln:index/getGvc:getGvc", args, LookupGvcResultOutput{}, options).(LookupGvcResultOutput), nil
		}).(LookupGvcResultOutput)
}

// A collection of arguments for invoking getGvc.
type LookupGvcOutputArgs struct {
	ControlplaneTracing GetGvcControlplaneTracingPtrInput `pulumi:"controlplaneTracing"`
	// Deprecated: Selecting a domain on a GVC will be deprecated in the future. Use the 'cpln_domain resource' instead.
	Domain               pulumi.StringPtrInput          `pulumi:"domain"`
	EndpointNamingFormat pulumi.StringPtrInput          `pulumi:"endpointNamingFormat"`
	Env                  pulumi.StringMapInput          `pulumi:"env"`
	LightstepTracing     GetGvcLightstepTracingPtrInput `pulumi:"lightstepTracing"`
	LoadBalancer         GetGvcLoadBalancerPtrInput     `pulumi:"loadBalancer"`
	Locations            pulumi.StringArrayInput        `pulumi:"locations"`
	Name                 pulumi.StringInput             `pulumi:"name"`
	OtelTracing          GetGvcOtelTracingPtrInput      `pulumi:"otelTracing"`
	PullSecrets          pulumi.StringArrayInput        `pulumi:"pullSecrets"`
	Sidecar              GetGvcSidecarPtrInput          `pulumi:"sidecar"`
	Tags                 pulumi.StringMapInput          `pulumi:"tags"`
}

func (LookupGvcOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupGvcArgs)(nil)).Elem()
}

// A collection of values returned by getGvc.
type LookupGvcResultOutput struct{ *pulumi.OutputState }

func (LookupGvcResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupGvcResult)(nil)).Elem()
}

func (o LookupGvcResultOutput) ToLookupGvcResultOutput() LookupGvcResultOutput {
	return o
}

func (o LookupGvcResultOutput) ToLookupGvcResultOutputWithContext(ctx context.Context) LookupGvcResultOutput {
	return o
}

func (o LookupGvcResultOutput) Alias() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGvcResult) string { return v.Alias }).(pulumi.StringOutput)
}

func (o LookupGvcResultOutput) ControlplaneTracing() GetGvcControlplaneTracingPtrOutput {
	return o.ApplyT(func(v LookupGvcResult) *GetGvcControlplaneTracing { return v.ControlplaneTracing }).(GetGvcControlplaneTracingPtrOutput)
}

func (o LookupGvcResultOutput) CplnId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGvcResult) string { return v.CplnId }).(pulumi.StringOutput)
}

func (o LookupGvcResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGvcResult) string { return v.Description }).(pulumi.StringOutput)
}

// Deprecated: Selecting a domain on a GVC will be deprecated in the future. Use the 'cpln_domain resource' instead.
func (o LookupGvcResultOutput) Domain() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupGvcResult) *string { return v.Domain }).(pulumi.StringPtrOutput)
}

func (o LookupGvcResultOutput) EndpointNamingFormat() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGvcResult) string { return v.EndpointNamingFormat }).(pulumi.StringOutput)
}

func (o LookupGvcResultOutput) Env() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupGvcResult) map[string]string { return v.Env }).(pulumi.StringMapOutput)
}

func (o LookupGvcResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGvcResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupGvcResultOutput) LightstepTracing() GetGvcLightstepTracingPtrOutput {
	return o.ApplyT(func(v LookupGvcResult) *GetGvcLightstepTracing { return v.LightstepTracing }).(GetGvcLightstepTracingPtrOutput)
}

func (o LookupGvcResultOutput) LoadBalancer() GetGvcLoadBalancerPtrOutput {
	return o.ApplyT(func(v LookupGvcResult) *GetGvcLoadBalancer { return v.LoadBalancer }).(GetGvcLoadBalancerPtrOutput)
}

func (o LookupGvcResultOutput) Locations() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupGvcResult) []string { return v.Locations }).(pulumi.StringArrayOutput)
}

func (o LookupGvcResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGvcResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupGvcResultOutput) OtelTracing() GetGvcOtelTracingPtrOutput {
	return o.ApplyT(func(v LookupGvcResult) *GetGvcOtelTracing { return v.OtelTracing }).(GetGvcOtelTracingPtrOutput)
}

func (o LookupGvcResultOutput) PullSecrets() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupGvcResult) []string { return v.PullSecrets }).(pulumi.StringArrayOutput)
}

func (o LookupGvcResultOutput) SelfLink() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGvcResult) string { return v.SelfLink }).(pulumi.StringOutput)
}

func (o LookupGvcResultOutput) Sidecar() GetGvcSidecarPtrOutput {
	return o.ApplyT(func(v LookupGvcResult) *GetGvcSidecar { return v.Sidecar }).(GetGvcSidecarPtrOutput)
}

func (o LookupGvcResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupGvcResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupGvcResultOutput{})
}
