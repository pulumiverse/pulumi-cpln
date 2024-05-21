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

type Org struct {
	pulumi.CustomResourceState

	// The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
	// obtained from the `Org Management & Billing` page.
	AccountId pulumi.StringPtrOutput `pulumi:"accountId"`
	// The configuration settings and parameters related to authentication within the org.
	AuthConfig OrgAuthConfigPtrOutput `pulumi:"authConfig"`
	// The ID, in GUID format, of the org.
	CplnId pulumi.StringOutput `pulumi:"cplnId"`
	// The description of org.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
	// the `superusers` group. The user account used when creating the org will be included in this list.
	Invitees pulumi.StringArrayOutput `pulumi:"invitees"`
	// The name of the org.
	Name pulumi.StringOutput `pulumi:"name"`
	// The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
	Observability OrgObservabilityOutput `pulumi:"observability"`
	Security      OrgSecurityPtrOutput   `pulumi:"security"`
	// Full link to this resource. Can be referenced by other resources.
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
	// The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
	SessionTimeoutSeconds pulumi.IntPtrOutput `pulumi:"sessionTimeoutSeconds"`
	// Status of the org.
	Statuses OrgStatusArrayOutput `pulumi:"statuses"`
	// Key-value map of the org's tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewOrg registers a new resource with the given unique name, arguments, and options.
func NewOrg(ctx *pulumi.Context,
	name string, args *OrgArgs, opts ...pulumi.ResourceOption) (*Org, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Observability == nil {
		return nil, errors.New("invalid value for required argument 'Observability'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Org
	err := ctx.RegisterResource("cpln:index/org:Org", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOrg gets an existing Org resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrg(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OrgState, opts ...pulumi.ResourceOption) (*Org, error) {
	var resource Org
	err := ctx.ReadResource("cpln:index/org:Org", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Org resources.
type orgState struct {
	// The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
	// obtained from the `Org Management & Billing` page.
	AccountId *string `pulumi:"accountId"`
	// The configuration settings and parameters related to authentication within the org.
	AuthConfig *OrgAuthConfig `pulumi:"authConfig"`
	// The ID, in GUID format, of the org.
	CplnId *string `pulumi:"cplnId"`
	// The description of org.
	Description *string `pulumi:"description"`
	// When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
	// the `superusers` group. The user account used when creating the org will be included in this list.
	Invitees []string `pulumi:"invitees"`
	// The name of the org.
	Name *string `pulumi:"name"`
	// The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
	Observability *OrgObservability `pulumi:"observability"`
	Security      *OrgSecurity      `pulumi:"security"`
	// Full link to this resource. Can be referenced by other resources.
	SelfLink *string `pulumi:"selfLink"`
	// The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
	SessionTimeoutSeconds *int `pulumi:"sessionTimeoutSeconds"`
	// Status of the org.
	Statuses []OrgStatus `pulumi:"statuses"`
	// Key-value map of the org's tags.
	Tags map[string]string `pulumi:"tags"`
}

type OrgState struct {
	// The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
	// obtained from the `Org Management & Billing` page.
	AccountId pulumi.StringPtrInput
	// The configuration settings and parameters related to authentication within the org.
	AuthConfig OrgAuthConfigPtrInput
	// The ID, in GUID format, of the org.
	CplnId pulumi.StringPtrInput
	// The description of org.
	Description pulumi.StringPtrInput
	// When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
	// the `superusers` group. The user account used when creating the org will be included in this list.
	Invitees pulumi.StringArrayInput
	// The name of the org.
	Name pulumi.StringPtrInput
	// The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
	Observability OrgObservabilityPtrInput
	Security      OrgSecurityPtrInput
	// Full link to this resource. Can be referenced by other resources.
	SelfLink pulumi.StringPtrInput
	// The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
	SessionTimeoutSeconds pulumi.IntPtrInput
	// Status of the org.
	Statuses OrgStatusArrayInput
	// Key-value map of the org's tags.
	Tags pulumi.StringMapInput
}

func (OrgState) ElementType() reflect.Type {
	return reflect.TypeOf((*orgState)(nil)).Elem()
}

type orgArgs struct {
	// The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
	// obtained from the `Org Management & Billing` page.
	AccountId *string `pulumi:"accountId"`
	// The configuration settings and parameters related to authentication within the org.
	AuthConfig *OrgAuthConfig `pulumi:"authConfig"`
	// The description of org.
	Description *string `pulumi:"description"`
	// When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
	// the `superusers` group. The user account used when creating the org will be included in this list.
	Invitees []string `pulumi:"invitees"`
	// The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
	Observability OrgObservability `pulumi:"observability"`
	Security      *OrgSecurity     `pulumi:"security"`
	// The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
	SessionTimeoutSeconds *int `pulumi:"sessionTimeoutSeconds"`
	// Key-value map of the org's tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Org resource.
type OrgArgs struct {
	// The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
	// obtained from the `Org Management & Billing` page.
	AccountId pulumi.StringPtrInput
	// The configuration settings and parameters related to authentication within the org.
	AuthConfig OrgAuthConfigPtrInput
	// The description of org.
	Description pulumi.StringPtrInput
	// When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
	// the `superusers` group. The user account used when creating the org will be included in this list.
	Invitees pulumi.StringArrayInput
	// The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
	Observability OrgObservabilityInput
	Security      OrgSecurityPtrInput
	// The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
	SessionTimeoutSeconds pulumi.IntPtrInput
	// Key-value map of the org's tags.
	Tags pulumi.StringMapInput
}

func (OrgArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*orgArgs)(nil)).Elem()
}

type OrgInput interface {
	pulumi.Input

	ToOrgOutput() OrgOutput
	ToOrgOutputWithContext(ctx context.Context) OrgOutput
}

func (*Org) ElementType() reflect.Type {
	return reflect.TypeOf((**Org)(nil)).Elem()
}

func (i *Org) ToOrgOutput() OrgOutput {
	return i.ToOrgOutputWithContext(context.Background())
}

func (i *Org) ToOrgOutputWithContext(ctx context.Context) OrgOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrgOutput)
}

func (i *Org) ToOutput(ctx context.Context) pulumix.Output[*Org] {
	return pulumix.Output[*Org]{
		OutputState: i.ToOrgOutputWithContext(ctx).OutputState,
	}
}

// OrgArrayInput is an input type that accepts OrgArray and OrgArrayOutput values.
// You can construct a concrete instance of `OrgArrayInput` via:
//
//	OrgArray{ OrgArgs{...} }
type OrgArrayInput interface {
	pulumi.Input

	ToOrgArrayOutput() OrgArrayOutput
	ToOrgArrayOutputWithContext(context.Context) OrgArrayOutput
}

type OrgArray []OrgInput

func (OrgArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Org)(nil)).Elem()
}

func (i OrgArray) ToOrgArrayOutput() OrgArrayOutput {
	return i.ToOrgArrayOutputWithContext(context.Background())
}

func (i OrgArray) ToOrgArrayOutputWithContext(ctx context.Context) OrgArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrgArrayOutput)
}

func (i OrgArray) ToOutput(ctx context.Context) pulumix.Output[[]*Org] {
	return pulumix.Output[[]*Org]{
		OutputState: i.ToOrgArrayOutputWithContext(ctx).OutputState,
	}
}

// OrgMapInput is an input type that accepts OrgMap and OrgMapOutput values.
// You can construct a concrete instance of `OrgMapInput` via:
//
//	OrgMap{ "key": OrgArgs{...} }
type OrgMapInput interface {
	pulumi.Input

	ToOrgMapOutput() OrgMapOutput
	ToOrgMapOutputWithContext(context.Context) OrgMapOutput
}

type OrgMap map[string]OrgInput

func (OrgMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Org)(nil)).Elem()
}

func (i OrgMap) ToOrgMapOutput() OrgMapOutput {
	return i.ToOrgMapOutputWithContext(context.Background())
}

func (i OrgMap) ToOrgMapOutputWithContext(ctx context.Context) OrgMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrgMapOutput)
}

func (i OrgMap) ToOutput(ctx context.Context) pulumix.Output[map[string]*Org] {
	return pulumix.Output[map[string]*Org]{
		OutputState: i.ToOrgMapOutputWithContext(ctx).OutputState,
	}
}

type OrgOutput struct{ *pulumi.OutputState }

func (OrgOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Org)(nil)).Elem()
}

func (o OrgOutput) ToOrgOutput() OrgOutput {
	return o
}

func (o OrgOutput) ToOrgOutputWithContext(ctx context.Context) OrgOutput {
	return o
}

func (o OrgOutput) ToOutput(ctx context.Context) pulumix.Output[*Org] {
	return pulumix.Output[*Org]{
		OutputState: o.OutputState,
	}
}

// The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
// obtained from the `Org Management & Billing` page.
func (o OrgOutput) AccountId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Org) pulumi.StringPtrOutput { return v.AccountId }).(pulumi.StringPtrOutput)
}

// The configuration settings and parameters related to authentication within the org.
func (o OrgOutput) AuthConfig() OrgAuthConfigPtrOutput {
	return o.ApplyT(func(v *Org) OrgAuthConfigPtrOutput { return v.AuthConfig }).(OrgAuthConfigPtrOutput)
}

// The ID, in GUID format, of the org.
func (o OrgOutput) CplnId() pulumi.StringOutput {
	return o.ApplyT(func(v *Org) pulumi.StringOutput { return v.CplnId }).(pulumi.StringOutput)
}

// The description of org.
func (o OrgOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Org) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
// the `superusers` group. The user account used when creating the org will be included in this list.
func (o OrgOutput) Invitees() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Org) pulumi.StringArrayOutput { return v.Invitees }).(pulumi.StringArrayOutput)
}

// The name of the org.
func (o OrgOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Org) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
func (o OrgOutput) Observability() OrgObservabilityOutput {
	return o.ApplyT(func(v *Org) OrgObservabilityOutput { return v.Observability }).(OrgObservabilityOutput)
}

func (o OrgOutput) Security() OrgSecurityPtrOutput {
	return o.ApplyT(func(v *Org) OrgSecurityPtrOutput { return v.Security }).(OrgSecurityPtrOutput)
}

// Full link to this resource. Can be referenced by other resources.
func (o OrgOutput) SelfLink() pulumi.StringOutput {
	return o.ApplyT(func(v *Org) pulumi.StringOutput { return v.SelfLink }).(pulumi.StringOutput)
}

// The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
func (o OrgOutput) SessionTimeoutSeconds() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Org) pulumi.IntPtrOutput { return v.SessionTimeoutSeconds }).(pulumi.IntPtrOutput)
}

// Status of the org.
func (o OrgOutput) Statuses() OrgStatusArrayOutput {
	return o.ApplyT(func(v *Org) OrgStatusArrayOutput { return v.Statuses }).(OrgStatusArrayOutput)
}

// Key-value map of the org's tags.
func (o OrgOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Org) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

type OrgArrayOutput struct{ *pulumi.OutputState }

func (OrgArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Org)(nil)).Elem()
}

func (o OrgArrayOutput) ToOrgArrayOutput() OrgArrayOutput {
	return o
}

func (o OrgArrayOutput) ToOrgArrayOutputWithContext(ctx context.Context) OrgArrayOutput {
	return o
}

func (o OrgArrayOutput) ToOutput(ctx context.Context) pulumix.Output[[]*Org] {
	return pulumix.Output[[]*Org]{
		OutputState: o.OutputState,
	}
}

func (o OrgArrayOutput) Index(i pulumi.IntInput) OrgOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Org {
		return vs[0].([]*Org)[vs[1].(int)]
	}).(OrgOutput)
}

type OrgMapOutput struct{ *pulumi.OutputState }

func (OrgMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Org)(nil)).Elem()
}

func (o OrgMapOutput) ToOrgMapOutput() OrgMapOutput {
	return o
}

func (o OrgMapOutput) ToOrgMapOutputWithContext(ctx context.Context) OrgMapOutput {
	return o
}

func (o OrgMapOutput) ToOutput(ctx context.Context) pulumix.Output[map[string]*Org] {
	return pulumix.Output[map[string]*Org]{
		OutputState: o.OutputState,
	}
}

func (o OrgMapOutput) MapIndex(k pulumi.StringInput) OrgOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Org {
		return vs[0].(map[string]*Org)[vs[1].(string)]
	}).(OrgOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OrgInput)(nil)).Elem(), &Org{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrgArrayInput)(nil)).Elem(), OrgArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrgMapInput)(nil)).Elem(), OrgMap{})
	pulumi.RegisterOutputType(OrgOutput{})
	pulumi.RegisterOutputType(OrgArrayOutput{})
	pulumi.RegisterOutputType(OrgMapOutput{})
}
