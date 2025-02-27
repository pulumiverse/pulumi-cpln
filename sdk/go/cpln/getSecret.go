// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cpln

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-cpln/sdk/go/cpln/internal"
)

// Use this data source to access information about a [Secret](https://docs.controlplane.com/reference/secret) within Control Plane.
//
// ## Required
//
// - **name** (String) Name of the secret.
//
// ## Outputs
//
// The following attributes are exported:
//
// - **cpln_id** (String) The ID, in GUID format, of the secret.
// - **name** (String) Name of the secret.
// - **description** (String) Description of the secret.
// - **tags** (Map of String) Key-value map of resource tags.
// - **self_link** (String) Full link to this resource. Can be referenced by other resources.
// - **secret_link** (String) Output used when linking a secret to an environment variable or volume, in the format: `cpln://secret/SECRET_NAME`.
// - **dictionary_as_envs** (Map of String) If a dictionary secret is defined, this output will be a key-value map in the following format: `key = cpln://secret/SECRET_NAME.key`.
// - **aws** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#aws).
// - **azure_connector** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#azure-connector).
// - **azure_sdk** (String, Sensitive) JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#azure).
// - **dictionary** (Map of String) List of unique key-value pairs. [Reference Page](https://docs.controlplane.com/reference/secret#dictionary).
// - **docker** (String, Sensitive) JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#docker).
// - **ecr** (Block List, Max: 1) (see below).
// - **gcp** (String, Sensitive) JSON string containing the GCP secret. [Reference Page](https://docs.controlplane.com/reference/secret#gcp)
// - **keypair** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#keypair).
// - **nats_account** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#nats-account).
// - **opaque** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#opaque).
// - **tls** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#tls).
// - **userpass** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#username).
//
// <a id="nestedblock--aws"></a>
//
// ### `aws`
//
// Optional:
//
// - **access_key** (String, Sensitive) Access Key provided by AWS.
// - **role_arn** (String) Role ARN provided by AWS.
// - **secret_key** (String, Sensitive) Secret Key provided by AWS.
// - **external_id** (String) AWS IAM Role External ID.
//
// <a id="nestedblock--azure_connector"></a>
//
// ### `azureConnector`
//
// Optional:
//
// - **code** (String, Sensitive) Code/Key to authenticate to deployment URL.
// - **url** (String, Sensitive) Deployment URL.
//
// <a id="nestedblock--ecr"></a>
//
// ### `ecr`
//
// [Reference Page](https://docs.controlplane.com/reference/secret#ecr)
//
// Optional:
//
// - **access_key** (String) Access Key provided by AWS.
// - **repos** (Set of String) List of ECR repositories.
// - **role_arn** (String) Role ARN provided by AWS.
// - **secret_key** (String, Sensitive) Secret Key provided by AWS.
// - **external_id** (String) AWS IAM Role External ID. Used when setting up cross-account access to your ECR repositories.
//
// <a id="nestedblock--keypair"></a>
//
// ### `keypair`
//
// Optional:
//
// - **passphrase** (String, Sensitive) Passphrase for private key.
// - **public_key** (String) Public Key.
// - **secret_key** (String, Sensitive) Secret/Private Key.
//
// <a id="nestedblock--nats-account"></a>
//
// ### `natsAccount`
//
// Required:
//
// - **account_id** (String) Account ID.
// - **private_key** (String) Private Key.
//
// <a id="nestedblock--opaque"></a>
//
// ### `opaque`
//
// Optional:
//
// - **encoding** (String) Available encodings: `plain`, `base64`. Default: `plain`.
// - **payload** (String, Sensitive) Plain text or base64 encoded string. Use `encoding` attribute to specify encoding.
//
// <a id="nestedblock--tls"></a>
//
// ### `tls`
//
// Optional:
//
// - **cert** (String) Public Certificate.
// - **chain** (String) Chain Certificate.
// - **key** (String, Sensitive) Private Certificate.
//
// <a id="nestedblock--userpass"></a>
//
// ### `userpass`
//
// Optional:
//
// - **encoding** (String) Available encodings: `plain`, `base64`. Default: `plain`.
// - **password** (String, Sensitive) Password.
// - **username** (String) Username.
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
//			example, err := cpln.LookupSecret(ctx, &cpln.LookupSecretArgs{
//				Name: "example-secret-opaque",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("example-secret-payload", example.Opaque.Payload)
//			return nil
//		})
//	}
//
// ```
func LookupSecret(ctx *pulumi.Context, args *LookupSecretArgs, opts ...pulumi.InvokeOption) (*LookupSecretResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupSecretResult
	err := ctx.Invoke("cpln:index/getSecret:getSecret", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSecret.
type LookupSecretArgs struct {
	Aws            *GetSecretAws            `pulumi:"aws"`
	AzureConnector *GetSecretAzureConnector `pulumi:"azureConnector"`
	AzureSdk       *string                  `pulumi:"azureSdk"`
	Description    *string                  `pulumi:"description"`
	Dictionary     map[string]string        `pulumi:"dictionary"`
	Docker         *string                  `pulumi:"docker"`
	Ecr            *GetSecretEcr            `pulumi:"ecr"`
	Gcp            *string                  `pulumi:"gcp"`
	Keypair        *GetSecretKeypair        `pulumi:"keypair"`
	Name           string                   `pulumi:"name"`
	NatsAccount    *GetSecretNatsAccount    `pulumi:"natsAccount"`
	Opaque         *GetSecretOpaque         `pulumi:"opaque"`
	Tags           map[string]string        `pulumi:"tags"`
	Tls            *GetSecretTls            `pulumi:"tls"`
	Userpass       *GetSecretUserpass       `pulumi:"userpass"`
}

// A collection of values returned by getSecret.
type LookupSecretResult struct {
	Aws              *GetSecretAws            `pulumi:"aws"`
	AzureConnector   *GetSecretAzureConnector `pulumi:"azureConnector"`
	AzureSdk         *string                  `pulumi:"azureSdk"`
	CplnId           string                   `pulumi:"cplnId"`
	Description      *string                  `pulumi:"description"`
	Dictionary       map[string]string        `pulumi:"dictionary"`
	DictionaryAsEnvs map[string]string        `pulumi:"dictionaryAsEnvs"`
	Docker           *string                  `pulumi:"docker"`
	Ecr              *GetSecretEcr            `pulumi:"ecr"`
	Gcp              *string                  `pulumi:"gcp"`
	// The provider-assigned unique ID for this managed resource.
	Id          string                `pulumi:"id"`
	Keypair     *GetSecretKeypair     `pulumi:"keypair"`
	Name        string                `pulumi:"name"`
	NatsAccount *GetSecretNatsAccount `pulumi:"natsAccount"`
	Opaque      *GetSecretOpaque      `pulumi:"opaque"`
	SecretLink  string                `pulumi:"secretLink"`
	SelfLink    string                `pulumi:"selfLink"`
	Tags        map[string]string     `pulumi:"tags"`
	Tls         *GetSecretTls         `pulumi:"tls"`
	Userpass    *GetSecretUserpass    `pulumi:"userpass"`
}

func LookupSecretOutput(ctx *pulumi.Context, args LookupSecretOutputArgs, opts ...pulumi.InvokeOption) LookupSecretResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupSecretResultOutput, error) {
			args := v.(LookupSecretArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("cpln:index/getSecret:getSecret", args, LookupSecretResultOutput{}, options).(LookupSecretResultOutput), nil
		}).(LookupSecretResultOutput)
}

// A collection of arguments for invoking getSecret.
type LookupSecretOutputArgs struct {
	Aws            GetSecretAwsPtrInput            `pulumi:"aws"`
	AzureConnector GetSecretAzureConnectorPtrInput `pulumi:"azureConnector"`
	AzureSdk       pulumi.StringPtrInput           `pulumi:"azureSdk"`
	Description    pulumi.StringPtrInput           `pulumi:"description"`
	Dictionary     pulumi.StringMapInput           `pulumi:"dictionary"`
	Docker         pulumi.StringPtrInput           `pulumi:"docker"`
	Ecr            GetSecretEcrPtrInput            `pulumi:"ecr"`
	Gcp            pulumi.StringPtrInput           `pulumi:"gcp"`
	Keypair        GetSecretKeypairPtrInput        `pulumi:"keypair"`
	Name           pulumi.StringInput              `pulumi:"name"`
	NatsAccount    GetSecretNatsAccountPtrInput    `pulumi:"natsAccount"`
	Opaque         GetSecretOpaquePtrInput         `pulumi:"opaque"`
	Tags           pulumi.StringMapInput           `pulumi:"tags"`
	Tls            GetSecretTlsPtrInput            `pulumi:"tls"`
	Userpass       GetSecretUserpassPtrInput       `pulumi:"userpass"`
}

func (LookupSecretOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSecretArgs)(nil)).Elem()
}

// A collection of values returned by getSecret.
type LookupSecretResultOutput struct{ *pulumi.OutputState }

func (LookupSecretResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSecretResult)(nil)).Elem()
}

func (o LookupSecretResultOutput) ToLookupSecretResultOutput() LookupSecretResultOutput {
	return o
}

func (o LookupSecretResultOutput) ToLookupSecretResultOutputWithContext(ctx context.Context) LookupSecretResultOutput {
	return o
}

func (o LookupSecretResultOutput) Aws() GetSecretAwsPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *GetSecretAws { return v.Aws }).(GetSecretAwsPtrOutput)
}

func (o LookupSecretResultOutput) AzureConnector() GetSecretAzureConnectorPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *GetSecretAzureConnector { return v.AzureConnector }).(GetSecretAzureConnectorPtrOutput)
}

func (o LookupSecretResultOutput) AzureSdk() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *string { return v.AzureSdk }).(pulumi.StringPtrOutput)
}

func (o LookupSecretResultOutput) CplnId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSecretResult) string { return v.CplnId }).(pulumi.StringOutput)
}

func (o LookupSecretResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o LookupSecretResultOutput) Dictionary() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupSecretResult) map[string]string { return v.Dictionary }).(pulumi.StringMapOutput)
}

func (o LookupSecretResultOutput) DictionaryAsEnvs() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupSecretResult) map[string]string { return v.DictionaryAsEnvs }).(pulumi.StringMapOutput)
}

func (o LookupSecretResultOutput) Docker() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *string { return v.Docker }).(pulumi.StringPtrOutput)
}

func (o LookupSecretResultOutput) Ecr() GetSecretEcrPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *GetSecretEcr { return v.Ecr }).(GetSecretEcrPtrOutput)
}

func (o LookupSecretResultOutput) Gcp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *string { return v.Gcp }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupSecretResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSecretResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupSecretResultOutput) Keypair() GetSecretKeypairPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *GetSecretKeypair { return v.Keypair }).(GetSecretKeypairPtrOutput)
}

func (o LookupSecretResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSecretResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupSecretResultOutput) NatsAccount() GetSecretNatsAccountPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *GetSecretNatsAccount { return v.NatsAccount }).(GetSecretNatsAccountPtrOutput)
}

func (o LookupSecretResultOutput) Opaque() GetSecretOpaquePtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *GetSecretOpaque { return v.Opaque }).(GetSecretOpaquePtrOutput)
}

func (o LookupSecretResultOutput) SecretLink() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSecretResult) string { return v.SecretLink }).(pulumi.StringOutput)
}

func (o LookupSecretResultOutput) SelfLink() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSecretResult) string { return v.SelfLink }).(pulumi.StringOutput)
}

func (o LookupSecretResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupSecretResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

func (o LookupSecretResultOutput) Tls() GetSecretTlsPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *GetSecretTls { return v.Tls }).(GetSecretTlsPtrOutput)
}

func (o LookupSecretResultOutput) Userpass() GetSecretUserpassPtrOutput {
	return o.ApplyT(func(v LookupSecretResult) *GetSecretUserpass { return v.Userpass }).(GetSecretUserpassPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupSecretResultOutput{})
}
