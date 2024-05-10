// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class Secret extends pulumi.CustomResource {
    /**
     * Get an existing Secret resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SecretState, opts?: pulumi.CustomResourceOptions): Secret {
        return new Secret(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cpln:index/secret:Secret';

    /**
     * Returns true if the given object is an instance of Secret.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Secret {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Secret.__pulumiType;
    }

    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#aws).
     */
    public readonly aws!: pulumi.Output<outputs.SecretAws | undefined>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#azure-connector).
     */
    public readonly azureConnector!: pulumi.Output<outputs.SecretAzureConnector | undefined>;
    /**
     * JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#azure).
     */
    public readonly azureSdk!: pulumi.Output<string | undefined>;
    /**
     * The ID, in GUID format, of the Secret.
     */
    public /*out*/ readonly cplnId!: pulumi.Output<string>;
    /**
     * Description of the Secret.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * List of unique key-value pairs. [Reference Page](https://docs.controlplane.com/reference/secret#dictionary).
     */
    public readonly dictionary!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * If a dictionary secret is defined, this output will be a key-value map in the following format: `key =
     * cpln://secret/SECRET_NAME.key`.
     */
    public /*out*/ readonly dictionaryAsEnvs!: pulumi.Output<{[key: string]: any}>;
    /**
     * JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#docker).
     */
    public readonly docker!: pulumi.Output<string | undefined>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#ecr)
     */
    public readonly ecr!: pulumi.Output<outputs.SecretEcr | undefined>;
    /**
     * JSON string containing the GCP secret. [Reference Page](https://docs.controlplane.com/reference/secret#gcp)
     */
    public readonly gcp!: pulumi.Output<string | undefined>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#keypair).
     */
    public readonly keypair!: pulumi.Output<outputs.SecretKeypair | undefined>;
    /**
     * Name of the secret.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#nats-account).
     */
    public readonly natsAccount!: pulumi.Output<outputs.SecretNatsAccount | undefined>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#opaque).
     */
    public readonly opaque!: pulumi.Output<outputs.SecretOpaque | undefined>;
    /**
     * Output used when linking a secret to an environment variable or volume.
     */
    public /*out*/ readonly secretLink!: pulumi.Output<string>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    /**
     * Key-value map of resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#tls).
     */
    public readonly tls!: pulumi.Output<outputs.SecretTls | undefined>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#username).
     */
    public readonly userpass!: pulumi.Output<outputs.SecretUserpass | undefined>;

    /**
     * Create a Secret resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: SecretArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SecretArgs | SecretState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SecretState | undefined;
            resourceInputs["aws"] = state ? state.aws : undefined;
            resourceInputs["azureConnector"] = state ? state.azureConnector : undefined;
            resourceInputs["azureSdk"] = state ? state.azureSdk : undefined;
            resourceInputs["cplnId"] = state ? state.cplnId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["dictionary"] = state ? state.dictionary : undefined;
            resourceInputs["dictionaryAsEnvs"] = state ? state.dictionaryAsEnvs : undefined;
            resourceInputs["docker"] = state ? state.docker : undefined;
            resourceInputs["ecr"] = state ? state.ecr : undefined;
            resourceInputs["gcp"] = state ? state.gcp : undefined;
            resourceInputs["keypair"] = state ? state.keypair : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["natsAccount"] = state ? state.natsAccount : undefined;
            resourceInputs["opaque"] = state ? state.opaque : undefined;
            resourceInputs["secretLink"] = state ? state.secretLink : undefined;
            resourceInputs["selfLink"] = state ? state.selfLink : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["tls"] = state ? state.tls : undefined;
            resourceInputs["userpass"] = state ? state.userpass : undefined;
        } else {
            const args = argsOrState as SecretArgs | undefined;
            resourceInputs["aws"] = args ? args.aws : undefined;
            resourceInputs["azureConnector"] = args ? args.azureConnector : undefined;
            resourceInputs["azureSdk"] = args?.azureSdk ? pulumi.secret(args.azureSdk) : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["dictionary"] = args ? args.dictionary : undefined;
            resourceInputs["docker"] = args?.docker ? pulumi.secret(args.docker) : undefined;
            resourceInputs["ecr"] = args ? args.ecr : undefined;
            resourceInputs["gcp"] = args?.gcp ? pulumi.secret(args.gcp) : undefined;
            resourceInputs["keypair"] = args ? args.keypair : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["natsAccount"] = args ? args.natsAccount : undefined;
            resourceInputs["opaque"] = args ? args.opaque : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["tls"] = args ? args.tls : undefined;
            resourceInputs["userpass"] = args ? args.userpass : undefined;
            resourceInputs["cplnId"] = undefined /*out*/;
            resourceInputs["dictionaryAsEnvs"] = undefined /*out*/;
            resourceInputs["secretLink"] = undefined /*out*/;
            resourceInputs["selfLink"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["azureSdk", "docker", "gcp"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(Secret.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Secret resources.
 */
export interface SecretState {
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#aws).
     */
    aws?: pulumi.Input<inputs.SecretAws>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#azure-connector).
     */
    azureConnector?: pulumi.Input<inputs.SecretAzureConnector>;
    /**
     * JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#azure).
     */
    azureSdk?: pulumi.Input<string>;
    /**
     * The ID, in GUID format, of the Secret.
     */
    cplnId?: pulumi.Input<string>;
    /**
     * Description of the Secret.
     */
    description?: pulumi.Input<string>;
    /**
     * List of unique key-value pairs. [Reference Page](https://docs.controlplane.com/reference/secret#dictionary).
     */
    dictionary?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * If a dictionary secret is defined, this output will be a key-value map in the following format: `key =
     * cpln://secret/SECRET_NAME.key`.
     */
    dictionaryAsEnvs?: pulumi.Input<{[key: string]: any}>;
    /**
     * JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#docker).
     */
    docker?: pulumi.Input<string>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#ecr)
     */
    ecr?: pulumi.Input<inputs.SecretEcr>;
    /**
     * JSON string containing the GCP secret. [Reference Page](https://docs.controlplane.com/reference/secret#gcp)
     */
    gcp?: pulumi.Input<string>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#keypair).
     */
    keypair?: pulumi.Input<inputs.SecretKeypair>;
    /**
     * Name of the secret.
     */
    name?: pulumi.Input<string>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#nats-account).
     */
    natsAccount?: pulumi.Input<inputs.SecretNatsAccount>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#opaque).
     */
    opaque?: pulumi.Input<inputs.SecretOpaque>;
    /**
     * Output used when linking a secret to an environment variable or volume.
     */
    secretLink?: pulumi.Input<string>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    selfLink?: pulumi.Input<string>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#tls).
     */
    tls?: pulumi.Input<inputs.SecretTls>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#username).
     */
    userpass?: pulumi.Input<inputs.SecretUserpass>;
}

/**
 * The set of arguments for constructing a Secret resource.
 */
export interface SecretArgs {
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#aws).
     */
    aws?: pulumi.Input<inputs.SecretAws>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#azure-connector).
     */
    azureConnector?: pulumi.Input<inputs.SecretAzureConnector>;
    /**
     * JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#azure).
     */
    azureSdk?: pulumi.Input<string>;
    /**
     * Description of the Secret.
     */
    description?: pulumi.Input<string>;
    /**
     * List of unique key-value pairs. [Reference Page](https://docs.controlplane.com/reference/secret#dictionary).
     */
    dictionary?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#docker).
     */
    docker?: pulumi.Input<string>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#ecr)
     */
    ecr?: pulumi.Input<inputs.SecretEcr>;
    /**
     * JSON string containing the GCP secret. [Reference Page](https://docs.controlplane.com/reference/secret#gcp)
     */
    gcp?: pulumi.Input<string>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#keypair).
     */
    keypair?: pulumi.Input<inputs.SecretKeypair>;
    /**
     * Name of the secret.
     */
    name?: pulumi.Input<string>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#nats-account).
     */
    natsAccount?: pulumi.Input<inputs.SecretNatsAccount>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#opaque).
     */
    opaque?: pulumi.Input<inputs.SecretOpaque>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#tls).
     */
    tls?: pulumi.Input<inputs.SecretTls>;
    /**
     * [Reference Page](https://docs.controlplane.com/reference/secret#username).
     */
    userpass?: pulumi.Input<inputs.SecretUserpass>;
}
