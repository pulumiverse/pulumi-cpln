// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cpln

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-cpln/sdk/go/cpln/internal"
)

type AuditContext struct {
	pulumi.CustomResourceState

	// The ID, in GUID format, of the Audit Context.
	CplnId pulumi.StringOutput `pulumi:"cplnId"`
	// Description of the Audit Context.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Name of the Audit Context.
	Name pulumi.StringOutput `pulumi:"name"`
	// Full link to this resource. Can be referenced by other resources.
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
	// Key-value map of resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewAuditContext registers a new resource with the given unique name, arguments, and options.
func NewAuditContext(ctx *pulumi.Context,
	name string, args *AuditContextArgs, opts ...pulumi.ResourceOption) (*AuditContext, error) {
	if args == nil {
		args = &AuditContextArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AuditContext
	err := ctx.RegisterResource("cpln:index/auditContext:AuditContext", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAuditContext gets an existing AuditContext resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAuditContext(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AuditContextState, opts ...pulumi.ResourceOption) (*AuditContext, error) {
	var resource AuditContext
	err := ctx.ReadResource("cpln:index/auditContext:AuditContext", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AuditContext resources.
type auditContextState struct {
	// The ID, in GUID format, of the Audit Context.
	CplnId *string `pulumi:"cplnId"`
	// Description of the Audit Context.
	Description *string `pulumi:"description"`
	// Name of the Audit Context.
	Name *string `pulumi:"name"`
	// Full link to this resource. Can be referenced by other resources.
	SelfLink *string `pulumi:"selfLink"`
	// Key-value map of resource tags.
	Tags map[string]string `pulumi:"tags"`
}

type AuditContextState struct {
	// The ID, in GUID format, of the Audit Context.
	CplnId pulumi.StringPtrInput
	// Description of the Audit Context.
	Description pulumi.StringPtrInput
	// Name of the Audit Context.
	Name pulumi.StringPtrInput
	// Full link to this resource. Can be referenced by other resources.
	SelfLink pulumi.StringPtrInput
	// Key-value map of resource tags.
	Tags pulumi.StringMapInput
}

func (AuditContextState) ElementType() reflect.Type {
	return reflect.TypeOf((*auditContextState)(nil)).Elem()
}

type auditContextArgs struct {
	// Description of the Audit Context.
	Description *string `pulumi:"description"`
	// Name of the Audit Context.
	Name *string `pulumi:"name"`
	// Key-value map of resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a AuditContext resource.
type AuditContextArgs struct {
	// Description of the Audit Context.
	Description pulumi.StringPtrInput
	// Name of the Audit Context.
	Name pulumi.StringPtrInput
	// Key-value map of resource tags.
	Tags pulumi.StringMapInput
}

func (AuditContextArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*auditContextArgs)(nil)).Elem()
}

type AuditContextInput interface {
	pulumi.Input

	ToAuditContextOutput() AuditContextOutput
	ToAuditContextOutputWithContext(ctx context.Context) AuditContextOutput
}

func (*AuditContext) ElementType() reflect.Type {
	return reflect.TypeOf((**AuditContext)(nil)).Elem()
}

func (i *AuditContext) ToAuditContextOutput() AuditContextOutput {
	return i.ToAuditContextOutputWithContext(context.Background())
}

func (i *AuditContext) ToAuditContextOutputWithContext(ctx context.Context) AuditContextOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AuditContextOutput)
}

// AuditContextArrayInput is an input type that accepts AuditContextArray and AuditContextArrayOutput values.
// You can construct a concrete instance of `AuditContextArrayInput` via:
//
//	AuditContextArray{ AuditContextArgs{...} }
type AuditContextArrayInput interface {
	pulumi.Input

	ToAuditContextArrayOutput() AuditContextArrayOutput
	ToAuditContextArrayOutputWithContext(context.Context) AuditContextArrayOutput
}

type AuditContextArray []AuditContextInput

func (AuditContextArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AuditContext)(nil)).Elem()
}

func (i AuditContextArray) ToAuditContextArrayOutput() AuditContextArrayOutput {
	return i.ToAuditContextArrayOutputWithContext(context.Background())
}

func (i AuditContextArray) ToAuditContextArrayOutputWithContext(ctx context.Context) AuditContextArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AuditContextArrayOutput)
}

// AuditContextMapInput is an input type that accepts AuditContextMap and AuditContextMapOutput values.
// You can construct a concrete instance of `AuditContextMapInput` via:
//
//	AuditContextMap{ "key": AuditContextArgs{...} }
type AuditContextMapInput interface {
	pulumi.Input

	ToAuditContextMapOutput() AuditContextMapOutput
	ToAuditContextMapOutputWithContext(context.Context) AuditContextMapOutput
}

type AuditContextMap map[string]AuditContextInput

func (AuditContextMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AuditContext)(nil)).Elem()
}

func (i AuditContextMap) ToAuditContextMapOutput() AuditContextMapOutput {
	return i.ToAuditContextMapOutputWithContext(context.Background())
}

func (i AuditContextMap) ToAuditContextMapOutputWithContext(ctx context.Context) AuditContextMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AuditContextMapOutput)
}

type AuditContextOutput struct{ *pulumi.OutputState }

func (AuditContextOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AuditContext)(nil)).Elem()
}

func (o AuditContextOutput) ToAuditContextOutput() AuditContextOutput {
	return o
}

func (o AuditContextOutput) ToAuditContextOutputWithContext(ctx context.Context) AuditContextOutput {
	return o
}

// The ID, in GUID format, of the Audit Context.
func (o AuditContextOutput) CplnId() pulumi.StringOutput {
	return o.ApplyT(func(v *AuditContext) pulumi.StringOutput { return v.CplnId }).(pulumi.StringOutput)
}

// Description of the Audit Context.
func (o AuditContextOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AuditContext) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Name of the Audit Context.
func (o AuditContextOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AuditContext) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Full link to this resource. Can be referenced by other resources.
func (o AuditContextOutput) SelfLink() pulumi.StringOutput {
	return o.ApplyT(func(v *AuditContext) pulumi.StringOutput { return v.SelfLink }).(pulumi.StringOutput)
}

// Key-value map of resource tags.
func (o AuditContextOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *AuditContext) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

type AuditContextArrayOutput struct{ *pulumi.OutputState }

func (AuditContextArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AuditContext)(nil)).Elem()
}

func (o AuditContextArrayOutput) ToAuditContextArrayOutput() AuditContextArrayOutput {
	return o
}

func (o AuditContextArrayOutput) ToAuditContextArrayOutputWithContext(ctx context.Context) AuditContextArrayOutput {
	return o
}

func (o AuditContextArrayOutput) Index(i pulumi.IntInput) AuditContextOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AuditContext {
		return vs[0].([]*AuditContext)[vs[1].(int)]
	}).(AuditContextOutput)
}

type AuditContextMapOutput struct{ *pulumi.OutputState }

func (AuditContextMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AuditContext)(nil)).Elem()
}

func (o AuditContextMapOutput) ToAuditContextMapOutput() AuditContextMapOutput {
	return o
}

func (o AuditContextMapOutput) ToAuditContextMapOutputWithContext(ctx context.Context) AuditContextMapOutput {
	return o
}

func (o AuditContextMapOutput) MapIndex(k pulumi.StringInput) AuditContextOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AuditContext {
		return vs[0].(map[string]*AuditContext)[vs[1].(string)]
	}).(AuditContextOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AuditContextInput)(nil)).Elem(), &AuditContext{})
	pulumi.RegisterInputType(reflect.TypeOf((*AuditContextArrayInput)(nil)).Elem(), AuditContextArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AuditContextMapInput)(nil)).Elem(), AuditContextMap{})
	pulumi.RegisterOutputType(AuditContextOutput{})
	pulumi.RegisterOutputType(AuditContextArrayOutput{})
	pulumi.RegisterOutputType(AuditContextMapOutput{})
}
