// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to access information about a [Secret](https://docs.controlplane.com/reference/secret) within Control Plane.
 *
 * ## Required
 *
 * - **name** (String) Name of the secret.
 *
 * ## Outputs
 *
 * The following attributes are exported:
 *
 * - **cpln_id** (String) The ID, in GUID format, of the secret.
 * - **name** (String) Name of the secret.
 * - **description** (String) Description of the secret.
 * - **tags** (Map of String) Key-value map of resource tags.
 * - **self_link** (String) Full link to this resource. Can be referenced by other resources.
 * - **secret_link** (String) Output used when linking a secret to an environment variable or volume, in the format: `cpln://secret/SECRET_NAME`.
 * - **dictionary_as_envs** (Map of String) If a dictionary secret is defined, this output will be a key-value map in the following format: `key = cpln://secret/SECRET_NAME.key`.
 * - **aws** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#aws).
 * - **azure_connector** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#azure-connector).
 * - **azure_sdk** (String, Sensitive) JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#azure).
 * - **dictionary** (Map of String) List of unique key-value pairs. [Reference Page](https://docs.controlplane.com/reference/secret#dictionary).
 * - **docker** (String, Sensitive) JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#docker).
 * - **ecr** (Block List, Max: 1) (see below).
 * - **gcp** (String, Sensitive) JSON string containing the GCP secret. [Reference Page](https://docs.controlplane.com/reference/secret#gcp)
 * - **keypair** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#keypair).
 * - **nats_account** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#nats-account).
 * - **opaque** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#opaque).
 * - **tls** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#tls).
 * - **userpass** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#username).
 *
 * <a id="nestedblock--aws"></a>
 *
 * ### `aws`
 *
 * Optional:
 *
 * - **access_key** (String, Sensitive) Access Key provided by AWS.
 * - **role_arn** (String) Role ARN provided by AWS.
 * - **secret_key** (String, Sensitive) Secret Key provided by AWS.
 * - **external_id** (String) AWS IAM Role External ID.
 *
 * <a id="nestedblock--azure_connector"></a>
 *
 * ### `azureConnector`
 *
 * Optional:
 *
 * - **code** (String, Sensitive) Code/Key to authenticate to deployment URL.
 * - **url** (String, Sensitive) Deployment URL.
 *
 * <a id="nestedblock--ecr"></a>
 *
 * ### `ecr`
 *
 * [Reference Page](https://docs.controlplane.com/reference/secret#ecr)
 *
 * Optional:
 *
 * - **access_key** (String) Access Key provided by AWS.
 * - **repos** (Set of String) List of ECR repositories.
 * - **role_arn** (String) Role ARN provided by AWS.
 * - **secret_key** (String, Sensitive) Secret Key provided by AWS.
 * - **external_id** (String) AWS IAM Role External ID. Used when setting up cross-account access to your ECR repositories.
 *
 * <a id="nestedblock--keypair"></a>
 *
 * ### `keypair`
 *
 * Optional:
 *
 * - **passphrase** (String, Sensitive) Passphrase for private key.
 * - **public_key** (String) Public Key.
 * - **secret_key** (String, Sensitive) Secret/Private Key.
 *
 * <a id="nestedblock--nats-account"></a>
 *
 * ### `natsAccount`
 *
 * Required:
 *
 * - **account_id** (String) Account ID.
 * - **private_key** (String) Private Key.
 *
 * <a id="nestedblock--opaque"></a>
 *
 * ### `opaque`
 *
 * Optional:
 *
 * - **encoding** (String) Available encodings: `plain`, `base64`. Default: `plain`.
 * - **payload** (String, Sensitive) Plain text or base64 encoded string. Use `encoding` attribute to specify encoding.
 *
 * <a id="nestedblock--tls"></a>
 *
 * ### `tls`
 *
 * Optional:
 *
 * - **cert** (String) Public Certificate.
 * - **chain** (String) Chain Certificate.
 * - **key** (String, Sensitive) Private Certificate.
 *
 * <a id="nestedblock--userpass"></a>
 *
 * ### `userpass`
 *
 * Optional:
 *
 * - **encoding** (String) Available encodings: `plain`, `base64`. Default: `plain`.
 * - **password** (String, Sensitive) Password.
 * - **username** (String) Username.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cpln from "@pulumi/cpln";
 *
 * export = async () => {
 *     const example = await cpln.getSecret({
 *         name: "example-secret-opaque",
 *     });
 *     return {
 *         "example-secret-payload": example.opaque?.payload,
 *     };
 * }
 * ```
 */
export function getSecret(args: GetSecretArgs, opts?: pulumi.InvokeOptions): Promise<GetSecretResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("cpln:index/getSecret:getSecret", {
        "aws": args.aws,
        "azureConnector": args.azureConnector,
        "azureSdk": args.azureSdk,
        "description": args.description,
        "dictionary": args.dictionary,
        "docker": args.docker,
        "ecr": args.ecr,
        "gcp": args.gcp,
        "keypair": args.keypair,
        "name": args.name,
        "natsAccount": args.natsAccount,
        "opaque": args.opaque,
        "tags": args.tags,
        "tls": args.tls,
        "userpass": args.userpass,
    }, opts);
}

/**
 * A collection of arguments for invoking getSecret.
 */
export interface GetSecretArgs {
    aws?: inputs.GetSecretAws;
    azureConnector?: inputs.GetSecretAzureConnector;
    azureSdk?: string;
    description?: string;
    dictionary?: {[key: string]: string};
    docker?: string;
    ecr?: inputs.GetSecretEcr;
    gcp?: string;
    keypair?: inputs.GetSecretKeypair;
    name: string;
    natsAccount?: inputs.GetSecretNatsAccount;
    opaque?: inputs.GetSecretOpaque;
    tags?: {[key: string]: string};
    tls?: inputs.GetSecretTls;
    userpass?: inputs.GetSecretUserpass;
}

/**
 * A collection of values returned by getSecret.
 */
export interface GetSecretResult {
    readonly aws?: outputs.GetSecretAws;
    readonly azureConnector?: outputs.GetSecretAzureConnector;
    readonly azureSdk?: string;
    readonly cplnId: string;
    readonly description?: string;
    readonly dictionary?: {[key: string]: string};
    readonly dictionaryAsEnvs: {[key: string]: any};
    readonly docker?: string;
    readonly ecr?: outputs.GetSecretEcr;
    readonly gcp?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly keypair?: outputs.GetSecretKeypair;
    readonly name: string;
    readonly natsAccount?: outputs.GetSecretNatsAccount;
    readonly opaque?: outputs.GetSecretOpaque;
    readonly secretLink: string;
    readonly selfLink: string;
    readonly tags?: {[key: string]: string};
    readonly tls?: outputs.GetSecretTls;
    readonly userpass?: outputs.GetSecretUserpass;
}
/**
 * Use this data source to access information about a [Secret](https://docs.controlplane.com/reference/secret) within Control Plane.
 *
 * ## Required
 *
 * - **name** (String) Name of the secret.
 *
 * ## Outputs
 *
 * The following attributes are exported:
 *
 * - **cpln_id** (String) The ID, in GUID format, of the secret.
 * - **name** (String) Name of the secret.
 * - **description** (String) Description of the secret.
 * - **tags** (Map of String) Key-value map of resource tags.
 * - **self_link** (String) Full link to this resource. Can be referenced by other resources.
 * - **secret_link** (String) Output used when linking a secret to an environment variable or volume, in the format: `cpln://secret/SECRET_NAME`.
 * - **dictionary_as_envs** (Map of String) If a dictionary secret is defined, this output will be a key-value map in the following format: `key = cpln://secret/SECRET_NAME.key`.
 * - **aws** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#aws).
 * - **azure_connector** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#azure-connector).
 * - **azure_sdk** (String, Sensitive) JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#azure).
 * - **dictionary** (Map of String) List of unique key-value pairs. [Reference Page](https://docs.controlplane.com/reference/secret#dictionary).
 * - **docker** (String, Sensitive) JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#docker).
 * - **ecr** (Block List, Max: 1) (see below).
 * - **gcp** (String, Sensitive) JSON string containing the GCP secret. [Reference Page](https://docs.controlplane.com/reference/secret#gcp)
 * - **keypair** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#keypair).
 * - **nats_account** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#nats-account).
 * - **opaque** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#opaque).
 * - **tls** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#tls).
 * - **userpass** (Block List, Max: 1) (see below) [Reference Page](https://docs.controlplane.com/reference/secret#username).
 *
 * <a id="nestedblock--aws"></a>
 *
 * ### `aws`
 *
 * Optional:
 *
 * - **access_key** (String, Sensitive) Access Key provided by AWS.
 * - **role_arn** (String) Role ARN provided by AWS.
 * - **secret_key** (String, Sensitive) Secret Key provided by AWS.
 * - **external_id** (String) AWS IAM Role External ID.
 *
 * <a id="nestedblock--azure_connector"></a>
 *
 * ### `azureConnector`
 *
 * Optional:
 *
 * - **code** (String, Sensitive) Code/Key to authenticate to deployment URL.
 * - **url** (String, Sensitive) Deployment URL.
 *
 * <a id="nestedblock--ecr"></a>
 *
 * ### `ecr`
 *
 * [Reference Page](https://docs.controlplane.com/reference/secret#ecr)
 *
 * Optional:
 *
 * - **access_key** (String) Access Key provided by AWS.
 * - **repos** (Set of String) List of ECR repositories.
 * - **role_arn** (String) Role ARN provided by AWS.
 * - **secret_key** (String, Sensitive) Secret Key provided by AWS.
 * - **external_id** (String) AWS IAM Role External ID. Used when setting up cross-account access to your ECR repositories.
 *
 * <a id="nestedblock--keypair"></a>
 *
 * ### `keypair`
 *
 * Optional:
 *
 * - **passphrase** (String, Sensitive) Passphrase for private key.
 * - **public_key** (String) Public Key.
 * - **secret_key** (String, Sensitive) Secret/Private Key.
 *
 * <a id="nestedblock--nats-account"></a>
 *
 * ### `natsAccount`
 *
 * Required:
 *
 * - **account_id** (String) Account ID.
 * - **private_key** (String) Private Key.
 *
 * <a id="nestedblock--opaque"></a>
 *
 * ### `opaque`
 *
 * Optional:
 *
 * - **encoding** (String) Available encodings: `plain`, `base64`. Default: `plain`.
 * - **payload** (String, Sensitive) Plain text or base64 encoded string. Use `encoding` attribute to specify encoding.
 *
 * <a id="nestedblock--tls"></a>
 *
 * ### `tls`
 *
 * Optional:
 *
 * - **cert** (String) Public Certificate.
 * - **chain** (String) Chain Certificate.
 * - **key** (String, Sensitive) Private Certificate.
 *
 * <a id="nestedblock--userpass"></a>
 *
 * ### `userpass`
 *
 * Optional:
 *
 * - **encoding** (String) Available encodings: `plain`, `base64`. Default: `plain`.
 * - **password** (String, Sensitive) Password.
 * - **username** (String) Username.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cpln from "@pulumi/cpln";
 *
 * export = async () => {
 *     const example = await cpln.getSecret({
 *         name: "example-secret-opaque",
 *     });
 *     return {
 *         "example-secret-payload": example.opaque?.payload,
 *     };
 * }
 * ```
 */
export function getSecretOutput(args: GetSecretOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSecretResult> {
    return pulumi.output(args).apply((a: any) => getSecret(a, opts))
}

/**
 * A collection of arguments for invoking getSecret.
 */
export interface GetSecretOutputArgs {
    aws?: pulumi.Input<inputs.GetSecretAwsArgs>;
    azureConnector?: pulumi.Input<inputs.GetSecretAzureConnectorArgs>;
    azureSdk?: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    dictionary?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    docker?: pulumi.Input<string>;
    ecr?: pulumi.Input<inputs.GetSecretEcrArgs>;
    gcp?: pulumi.Input<string>;
    keypair?: pulumi.Input<inputs.GetSecretKeypairArgs>;
    name: pulumi.Input<string>;
    natsAccount?: pulumi.Input<inputs.GetSecretNatsAccountArgs>;
    opaque?: pulumi.Input<inputs.GetSecretOpaqueArgs>;
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    tls?: pulumi.Input<inputs.GetSecretTlsArgs>;
    userpass?: pulumi.Input<inputs.GetSecretUserpassArgs>;
}
