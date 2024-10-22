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

// Manages an org's IpSet.
//
// ## Declaration
//
// ### Required
//
// - **name** (String) Name of the IpSet.
//
// ### Optional
//
// - **description** - (String) Description of the IpSet.
// - **tags** (Map of String) Key-value map of resource tags.
// - **link** (String) The self link of a workload.
// - **location** (Block List) (see below).
//
// <a id="nestedblock--location"></a>
//
// ### `location`
//
// Required:
//
// - **name** (String) The self link of a location.
// - **retention_policy** (String) Exactly one of: `keep` and `free`.
//
// ## Outputs
//
// The following attributes are exported:
//
// - **cpln_id** (String) The ID, in GUID format, of the IpSet.
// - **self_link** (String) Full link to this resource. Can be referenced by other resources.
// - **status** (Block List, Max: 1) (see below).
//
// <a id="nestedblock--status"></a>
//
// ### `status`
//
// Status of the IpSet.
//
// Read-Only:
//
// - **ip_address** (Block List) (see below)
// - **error** (String)
//
// <a id="nestedblock--status--ip_address"></a>
//
// ### `status.ip_address`
//
// - **name** (String)
// - **ip** (String)
// - **id** (String)
// - **state** (String)
// - **created** (String)
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
//			_, err := cpln.NewIpSet(ctx, "new", &cpln.IpSetArgs{
//				Description: pulumi.String("example"),
//				Link:        pulumi.String("SELF_LINK_TO_WORKLOAD"),
//				Locations: cpln.IpSetLocationArray{
//					&cpln.IpSetLocationArgs{
//						Name:            pulumi.String("SELF_LINK_TO_LOCATION"),
//						RetentionPolicy: pulumi.String("keep"),
//					},
//				},
//				Tags: pulumi.StringMap{
//					"terraform_generated": pulumi.String("true"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type IpSet struct {
	pulumi.CustomResourceState

	// The ID, in GUID format, of the IpSet.
	CplnId pulumi.StringOutput `pulumi:"cplnId"`
	// Description of the IpSet.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The self link of a workload.
	Link      pulumi.StringPtrOutput   `pulumi:"link"`
	Locations IpSetLocationArrayOutput `pulumi:"locations"`
	// Name of the IpSet.
	Name pulumi.StringOutput `pulumi:"name"`
	// Full link to this resource. Can be referenced by other resources.
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
	// Status of the IpSet.
	Statuses IpSetStatusArrayOutput `pulumi:"statuses"`
	// Key-value map of resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewIpSet registers a new resource with the given unique name, arguments, and options.
func NewIpSet(ctx *pulumi.Context,
	name string, args *IpSetArgs, opts ...pulumi.ResourceOption) (*IpSet, error) {
	if args == nil {
		args = &IpSetArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IpSet
	err := ctx.RegisterResource("cpln:index/ipSet:IpSet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIpSet gets an existing IpSet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIpSet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IpSetState, opts ...pulumi.ResourceOption) (*IpSet, error) {
	var resource IpSet
	err := ctx.ReadResource("cpln:index/ipSet:IpSet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IpSet resources.
type ipSetState struct {
	// The ID, in GUID format, of the IpSet.
	CplnId *string `pulumi:"cplnId"`
	// Description of the IpSet.
	Description *string `pulumi:"description"`
	// The self link of a workload.
	Link      *string         `pulumi:"link"`
	Locations []IpSetLocation `pulumi:"locations"`
	// Name of the IpSet.
	Name *string `pulumi:"name"`
	// Full link to this resource. Can be referenced by other resources.
	SelfLink *string `pulumi:"selfLink"`
	// Status of the IpSet.
	Statuses []IpSetStatus `pulumi:"statuses"`
	// Key-value map of resource tags.
	Tags map[string]string `pulumi:"tags"`
}

type IpSetState struct {
	// The ID, in GUID format, of the IpSet.
	CplnId pulumi.StringPtrInput
	// Description of the IpSet.
	Description pulumi.StringPtrInput
	// The self link of a workload.
	Link      pulumi.StringPtrInput
	Locations IpSetLocationArrayInput
	// Name of the IpSet.
	Name pulumi.StringPtrInput
	// Full link to this resource. Can be referenced by other resources.
	SelfLink pulumi.StringPtrInput
	// Status of the IpSet.
	Statuses IpSetStatusArrayInput
	// Key-value map of resource tags.
	Tags pulumi.StringMapInput
}

func (IpSetState) ElementType() reflect.Type {
	return reflect.TypeOf((*ipSetState)(nil)).Elem()
}

type ipSetArgs struct {
	// Description of the IpSet.
	Description *string `pulumi:"description"`
	// The self link of a workload.
	Link      *string         `pulumi:"link"`
	Locations []IpSetLocation `pulumi:"locations"`
	// Name of the IpSet.
	Name *string `pulumi:"name"`
	// Key-value map of resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a IpSet resource.
type IpSetArgs struct {
	// Description of the IpSet.
	Description pulumi.StringPtrInput
	// The self link of a workload.
	Link      pulumi.StringPtrInput
	Locations IpSetLocationArrayInput
	// Name of the IpSet.
	Name pulumi.StringPtrInput
	// Key-value map of resource tags.
	Tags pulumi.StringMapInput
}

func (IpSetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ipSetArgs)(nil)).Elem()
}

type IpSetInput interface {
	pulumi.Input

	ToIpSetOutput() IpSetOutput
	ToIpSetOutputWithContext(ctx context.Context) IpSetOutput
}

func (*IpSet) ElementType() reflect.Type {
	return reflect.TypeOf((**IpSet)(nil)).Elem()
}

func (i *IpSet) ToIpSetOutput() IpSetOutput {
	return i.ToIpSetOutputWithContext(context.Background())
}

func (i *IpSet) ToIpSetOutputWithContext(ctx context.Context) IpSetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpSetOutput)
}

func (i *IpSet) ToOutput(ctx context.Context) pulumix.Output[*IpSet] {
	return pulumix.Output[*IpSet]{
		OutputState: i.ToIpSetOutputWithContext(ctx).OutputState,
	}
}

// IpSetArrayInput is an input type that accepts IpSetArray and IpSetArrayOutput values.
// You can construct a concrete instance of `IpSetArrayInput` via:
//
//	IpSetArray{ IpSetArgs{...} }
type IpSetArrayInput interface {
	pulumi.Input

	ToIpSetArrayOutput() IpSetArrayOutput
	ToIpSetArrayOutputWithContext(context.Context) IpSetArrayOutput
}

type IpSetArray []IpSetInput

func (IpSetArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IpSet)(nil)).Elem()
}

func (i IpSetArray) ToIpSetArrayOutput() IpSetArrayOutput {
	return i.ToIpSetArrayOutputWithContext(context.Background())
}

func (i IpSetArray) ToIpSetArrayOutputWithContext(ctx context.Context) IpSetArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpSetArrayOutput)
}

func (i IpSetArray) ToOutput(ctx context.Context) pulumix.Output[[]*IpSet] {
	return pulumix.Output[[]*IpSet]{
		OutputState: i.ToIpSetArrayOutputWithContext(ctx).OutputState,
	}
}

// IpSetMapInput is an input type that accepts IpSetMap and IpSetMapOutput values.
// You can construct a concrete instance of `IpSetMapInput` via:
//
//	IpSetMap{ "key": IpSetArgs{...} }
type IpSetMapInput interface {
	pulumi.Input

	ToIpSetMapOutput() IpSetMapOutput
	ToIpSetMapOutputWithContext(context.Context) IpSetMapOutput
}

type IpSetMap map[string]IpSetInput

func (IpSetMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IpSet)(nil)).Elem()
}

func (i IpSetMap) ToIpSetMapOutput() IpSetMapOutput {
	return i.ToIpSetMapOutputWithContext(context.Background())
}

func (i IpSetMap) ToIpSetMapOutputWithContext(ctx context.Context) IpSetMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpSetMapOutput)
}

func (i IpSetMap) ToOutput(ctx context.Context) pulumix.Output[map[string]*IpSet] {
	return pulumix.Output[map[string]*IpSet]{
		OutputState: i.ToIpSetMapOutputWithContext(ctx).OutputState,
	}
}

type IpSetOutput struct{ *pulumi.OutputState }

func (IpSetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IpSet)(nil)).Elem()
}

func (o IpSetOutput) ToIpSetOutput() IpSetOutput {
	return o
}

func (o IpSetOutput) ToIpSetOutputWithContext(ctx context.Context) IpSetOutput {
	return o
}

func (o IpSetOutput) ToOutput(ctx context.Context) pulumix.Output[*IpSet] {
	return pulumix.Output[*IpSet]{
		OutputState: o.OutputState,
	}
}

// The ID, in GUID format, of the IpSet.
func (o IpSetOutput) CplnId() pulumi.StringOutput {
	return o.ApplyT(func(v *IpSet) pulumi.StringOutput { return v.CplnId }).(pulumi.StringOutput)
}

// Description of the IpSet.
func (o IpSetOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IpSet) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// The self link of a workload.
func (o IpSetOutput) Link() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IpSet) pulumi.StringPtrOutput { return v.Link }).(pulumi.StringPtrOutput)
}

func (o IpSetOutput) Locations() IpSetLocationArrayOutput {
	return o.ApplyT(func(v *IpSet) IpSetLocationArrayOutput { return v.Locations }).(IpSetLocationArrayOutput)
}

// Name of the IpSet.
func (o IpSetOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *IpSet) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Full link to this resource. Can be referenced by other resources.
func (o IpSetOutput) SelfLink() pulumi.StringOutput {
	return o.ApplyT(func(v *IpSet) pulumi.StringOutput { return v.SelfLink }).(pulumi.StringOutput)
}

// Status of the IpSet.
func (o IpSetOutput) Statuses() IpSetStatusArrayOutput {
	return o.ApplyT(func(v *IpSet) IpSetStatusArrayOutput { return v.Statuses }).(IpSetStatusArrayOutput)
}

// Key-value map of resource tags.
func (o IpSetOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *IpSet) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

type IpSetArrayOutput struct{ *pulumi.OutputState }

func (IpSetArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IpSet)(nil)).Elem()
}

func (o IpSetArrayOutput) ToIpSetArrayOutput() IpSetArrayOutput {
	return o
}

func (o IpSetArrayOutput) ToIpSetArrayOutputWithContext(ctx context.Context) IpSetArrayOutput {
	return o
}

func (o IpSetArrayOutput) ToOutput(ctx context.Context) pulumix.Output[[]*IpSet] {
	return pulumix.Output[[]*IpSet]{
		OutputState: o.OutputState,
	}
}

func (o IpSetArrayOutput) Index(i pulumi.IntInput) IpSetOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IpSet {
		return vs[0].([]*IpSet)[vs[1].(int)]
	}).(IpSetOutput)
}

type IpSetMapOutput struct{ *pulumi.OutputState }

func (IpSetMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IpSet)(nil)).Elem()
}

func (o IpSetMapOutput) ToIpSetMapOutput() IpSetMapOutput {
	return o
}

func (o IpSetMapOutput) ToIpSetMapOutputWithContext(ctx context.Context) IpSetMapOutput {
	return o
}

func (o IpSetMapOutput) ToOutput(ctx context.Context) pulumix.Output[map[string]*IpSet] {
	return pulumix.Output[map[string]*IpSet]{
		OutputState: o.OutputState,
	}
}

func (o IpSetMapOutput) MapIndex(k pulumi.StringInput) IpSetOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IpSet {
		return vs[0].(map[string]*IpSet)[vs[1].(string)]
	}).(IpSetOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IpSetInput)(nil)).Elem(), &IpSet{})
	pulumi.RegisterInputType(reflect.TypeOf((*IpSetArrayInput)(nil)).Elem(), IpSetArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IpSetMapInput)(nil)).Elem(), IpSetMap{})
	pulumi.RegisterOutputType(IpSetOutput{})
	pulumi.RegisterOutputType(IpSetArrayOutput{})
	pulumi.RegisterOutputType(IpSetMapOutput{})
}
