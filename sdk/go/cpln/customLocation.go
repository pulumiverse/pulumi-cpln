// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cpln

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumix"
	"github.com/pulumiverse/pulumi-cpln/sdk/go/cpln/internal"
)

// Manages an org's [Custom Location](https://docs.controlplane.com/reference/location#byok-locations).
//
// ## Declaration
//
// ### Required
//
// - **name** (String) Name of the Custom Location.
// - **enabled** (Boolean) Indication if custom location is enabled.
// - **cloud_provider** (String) Provider of the custom location, must be `byok`.
//
// ### Optional
//
// - **tags** (Map of String) Key-value map of resource tags.
// - **description** - (String) Description of Custom Location.
//
// ## Outputs
//
// - **cpln_id** (String) The ID, in GUID format, of the custom location.
// - **self_link** (String) Full link to this resource. Can be referenced by other resources.
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
//			_, err := cpln.NewCustomLocation(ctx, "example", &cpln.CustomLocationArgs{
//				CloudProvider: pulumi.String("byok"),
//				Description:   pulumi.String("custom location description"),
//				Enabled:       pulumi.Bool(true),
//				Tags: pulumi.StringMap{
//					"baz": pulumi.String("qux"),
//					"foo": pulumi.String("bar"),
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
type CustomLocation struct {
	pulumi.CustomResourceState

	// Cloud Provider of the custom location.
	CloudProvider pulumi.StringOutput `pulumi:"cloudProvider"`
	// The ID, in GUID format, of the custom location.
	CplnId pulumi.StringOutput `pulumi:"cplnId"`
	// Description of the custom location.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Indication if the custom location is enabled.
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Name of the custom location.
	Name pulumi.StringOutput `pulumi:"name"`
	// Full link to this resource. Can be referenced by other resources.
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
	// Key-value map of resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewCustomLocation registers a new resource with the given unique name, arguments, and options.
func NewCustomLocation(ctx *pulumi.Context,
	name string, args *CustomLocationArgs, opts ...pulumi.ResourceOption) (*CustomLocation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CloudProvider == nil {
		return nil, errors.New("invalid value for required argument 'CloudProvider'")
	}
	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CustomLocation
	err := ctx.RegisterResource("cpln:index/customLocation:CustomLocation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCustomLocation gets an existing CustomLocation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCustomLocation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CustomLocationState, opts ...pulumi.ResourceOption) (*CustomLocation, error) {
	var resource CustomLocation
	err := ctx.ReadResource("cpln:index/customLocation:CustomLocation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CustomLocation resources.
type customLocationState struct {
	// Cloud Provider of the custom location.
	CloudProvider *string `pulumi:"cloudProvider"`
	// The ID, in GUID format, of the custom location.
	CplnId *string `pulumi:"cplnId"`
	// Description of the custom location.
	Description *string `pulumi:"description"`
	// Indication if the custom location is enabled.
	Enabled *bool `pulumi:"enabled"`
	// Name of the custom location.
	Name *string `pulumi:"name"`
	// Full link to this resource. Can be referenced by other resources.
	SelfLink *string `pulumi:"selfLink"`
	// Key-value map of resource tags.
	Tags map[string]string `pulumi:"tags"`
}

type CustomLocationState struct {
	// Cloud Provider of the custom location.
	CloudProvider pulumi.StringPtrInput
	// The ID, in GUID format, of the custom location.
	CplnId pulumi.StringPtrInput
	// Description of the custom location.
	Description pulumi.StringPtrInput
	// Indication if the custom location is enabled.
	Enabled pulumi.BoolPtrInput
	// Name of the custom location.
	Name pulumi.StringPtrInput
	// Full link to this resource. Can be referenced by other resources.
	SelfLink pulumi.StringPtrInput
	// Key-value map of resource tags.
	Tags pulumi.StringMapInput
}

func (CustomLocationState) ElementType() reflect.Type {
	return reflect.TypeOf((*customLocationState)(nil)).Elem()
}

type customLocationArgs struct {
	// Cloud Provider of the custom location.
	CloudProvider string `pulumi:"cloudProvider"`
	// Description of the custom location.
	Description *string `pulumi:"description"`
	// Indication if the custom location is enabled.
	Enabled bool `pulumi:"enabled"`
	// Name of the custom location.
	Name *string `pulumi:"name"`
	// Key-value map of resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a CustomLocation resource.
type CustomLocationArgs struct {
	// Cloud Provider of the custom location.
	CloudProvider pulumi.StringInput
	// Description of the custom location.
	Description pulumi.StringPtrInput
	// Indication if the custom location is enabled.
	Enabled pulumi.BoolInput
	// Name of the custom location.
	Name pulumi.StringPtrInput
	// Key-value map of resource tags.
	Tags pulumi.StringMapInput
}

func (CustomLocationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*customLocationArgs)(nil)).Elem()
}

type CustomLocationInput interface {
	pulumi.Input

	ToCustomLocationOutput() CustomLocationOutput
	ToCustomLocationOutputWithContext(ctx context.Context) CustomLocationOutput
}

func (*CustomLocation) ElementType() reflect.Type {
	return reflect.TypeOf((**CustomLocation)(nil)).Elem()
}

func (i *CustomLocation) ToCustomLocationOutput() CustomLocationOutput {
	return i.ToCustomLocationOutputWithContext(context.Background())
}

func (i *CustomLocation) ToCustomLocationOutputWithContext(ctx context.Context) CustomLocationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CustomLocationOutput)
}

func (i *CustomLocation) ToOutput(ctx context.Context) pulumix.Output[*CustomLocation] {
	return pulumix.Output[*CustomLocation]{
		OutputState: i.ToCustomLocationOutputWithContext(ctx).OutputState,
	}
}

// CustomLocationArrayInput is an input type that accepts CustomLocationArray and CustomLocationArrayOutput values.
// You can construct a concrete instance of `CustomLocationArrayInput` via:
//
//	CustomLocationArray{ CustomLocationArgs{...} }
type CustomLocationArrayInput interface {
	pulumi.Input

	ToCustomLocationArrayOutput() CustomLocationArrayOutput
	ToCustomLocationArrayOutputWithContext(context.Context) CustomLocationArrayOutput
}

type CustomLocationArray []CustomLocationInput

func (CustomLocationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CustomLocation)(nil)).Elem()
}

func (i CustomLocationArray) ToCustomLocationArrayOutput() CustomLocationArrayOutput {
	return i.ToCustomLocationArrayOutputWithContext(context.Background())
}

func (i CustomLocationArray) ToCustomLocationArrayOutputWithContext(ctx context.Context) CustomLocationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CustomLocationArrayOutput)
}

func (i CustomLocationArray) ToOutput(ctx context.Context) pulumix.Output[[]*CustomLocation] {
	return pulumix.Output[[]*CustomLocation]{
		OutputState: i.ToCustomLocationArrayOutputWithContext(ctx).OutputState,
	}
}

// CustomLocationMapInput is an input type that accepts CustomLocationMap and CustomLocationMapOutput values.
// You can construct a concrete instance of `CustomLocationMapInput` via:
//
//	CustomLocationMap{ "key": CustomLocationArgs{...} }
type CustomLocationMapInput interface {
	pulumi.Input

	ToCustomLocationMapOutput() CustomLocationMapOutput
	ToCustomLocationMapOutputWithContext(context.Context) CustomLocationMapOutput
}

type CustomLocationMap map[string]CustomLocationInput

func (CustomLocationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CustomLocation)(nil)).Elem()
}

func (i CustomLocationMap) ToCustomLocationMapOutput() CustomLocationMapOutput {
	return i.ToCustomLocationMapOutputWithContext(context.Background())
}

func (i CustomLocationMap) ToCustomLocationMapOutputWithContext(ctx context.Context) CustomLocationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CustomLocationMapOutput)
}

func (i CustomLocationMap) ToOutput(ctx context.Context) pulumix.Output[map[string]*CustomLocation] {
	return pulumix.Output[map[string]*CustomLocation]{
		OutputState: i.ToCustomLocationMapOutputWithContext(ctx).OutputState,
	}
}

type CustomLocationOutput struct{ *pulumi.OutputState }

func (CustomLocationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CustomLocation)(nil)).Elem()
}

func (o CustomLocationOutput) ToCustomLocationOutput() CustomLocationOutput {
	return o
}

func (o CustomLocationOutput) ToCustomLocationOutputWithContext(ctx context.Context) CustomLocationOutput {
	return o
}

func (o CustomLocationOutput) ToOutput(ctx context.Context) pulumix.Output[*CustomLocation] {
	return pulumix.Output[*CustomLocation]{
		OutputState: o.OutputState,
	}
}

// Cloud Provider of the custom location.
func (o CustomLocationOutput) CloudProvider() pulumi.StringOutput {
	return o.ApplyT(func(v *CustomLocation) pulumi.StringOutput { return v.CloudProvider }).(pulumi.StringOutput)
}

// The ID, in GUID format, of the custom location.
func (o CustomLocationOutput) CplnId() pulumi.StringOutput {
	return o.ApplyT(func(v *CustomLocation) pulumi.StringOutput { return v.CplnId }).(pulumi.StringOutput)
}

// Description of the custom location.
func (o CustomLocationOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CustomLocation) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Indication if the custom location is enabled.
func (o CustomLocationOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *CustomLocation) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Name of the custom location.
func (o CustomLocationOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *CustomLocation) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Full link to this resource. Can be referenced by other resources.
func (o CustomLocationOutput) SelfLink() pulumi.StringOutput {
	return o.ApplyT(func(v *CustomLocation) pulumi.StringOutput { return v.SelfLink }).(pulumi.StringOutput)
}

// Key-value map of resource tags.
func (o CustomLocationOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *CustomLocation) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

type CustomLocationArrayOutput struct{ *pulumi.OutputState }

func (CustomLocationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CustomLocation)(nil)).Elem()
}

func (o CustomLocationArrayOutput) ToCustomLocationArrayOutput() CustomLocationArrayOutput {
	return o
}

func (o CustomLocationArrayOutput) ToCustomLocationArrayOutputWithContext(ctx context.Context) CustomLocationArrayOutput {
	return o
}

func (o CustomLocationArrayOutput) ToOutput(ctx context.Context) pulumix.Output[[]*CustomLocation] {
	return pulumix.Output[[]*CustomLocation]{
		OutputState: o.OutputState,
	}
}

func (o CustomLocationArrayOutput) Index(i pulumi.IntInput) CustomLocationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CustomLocation {
		return vs[0].([]*CustomLocation)[vs[1].(int)]
	}).(CustomLocationOutput)
}

type CustomLocationMapOutput struct{ *pulumi.OutputState }

func (CustomLocationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CustomLocation)(nil)).Elem()
}

func (o CustomLocationMapOutput) ToCustomLocationMapOutput() CustomLocationMapOutput {
	return o
}

func (o CustomLocationMapOutput) ToCustomLocationMapOutputWithContext(ctx context.Context) CustomLocationMapOutput {
	return o
}

func (o CustomLocationMapOutput) ToOutput(ctx context.Context) pulumix.Output[map[string]*CustomLocation] {
	return pulumix.Output[map[string]*CustomLocation]{
		OutputState: o.OutputState,
	}
}

func (o CustomLocationMapOutput) MapIndex(k pulumi.StringInput) CustomLocationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CustomLocation {
		return vs[0].(map[string]*CustomLocation)[vs[1].(string)]
	}).(CustomLocationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CustomLocationInput)(nil)).Elem(), &CustomLocation{})
	pulumi.RegisterInputType(reflect.TypeOf((*CustomLocationArrayInput)(nil)).Elem(), CustomLocationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CustomLocationMapInput)(nil)).Elem(), CustomLocationMap{})
	pulumi.RegisterOutputType(CustomLocationOutput{})
	pulumi.RegisterOutputType(CustomLocationArrayOutput{})
	pulumi.RegisterOutputType(CustomLocationMapOutput{})
}