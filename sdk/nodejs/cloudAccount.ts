// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class CloudAccount extends pulumi.CustomResource {
    /**
     * Get an existing CloudAccount resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CloudAccountState, opts?: pulumi.CustomResourceOptions): CloudAccount {
        return new CloudAccount(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cpln:index/cloudAccount:CloudAccount';

    /**
     * Returns true if the given object is an instance of CloudAccount.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CloudAccount {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CloudAccount.__pulumiType;
    }

    /**
     * Contains AWS cloud account configuration.
     */
    public readonly aws!: pulumi.Output<outputs.CloudAccountAws | undefined>;
    /**
     * Contains Azure cloud account configuration.
     */
    public readonly azure!: pulumi.Output<outputs.CloudAccountAzure | undefined>;
    /**
     * The ID, in GUID format, of the Cloud Account.
     */
    public /*out*/ readonly cplnId!: pulumi.Output<string>;
    /**
     * Description of the Cloud Account.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Contains GCP cloud account configuration.
     */
    public readonly gcp!: pulumi.Output<outputs.CloudAccountGcp | undefined>;
    public /*out*/ readonly gcpRoles!: pulumi.Output<string[]>;
    /**
     * GCP service account name used during the configuration of the cloud account at GCP.
     */
    public /*out*/ readonly gcpServiceAccountName!: pulumi.Output<string>;
    /**
     * Name of the Cloud Account.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly ngs!: pulumi.Output<outputs.CloudAccountNgs | undefined>;
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    /**
     * Key-value map of resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a CloudAccount resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CloudAccountArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CloudAccountArgs | CloudAccountState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CloudAccountState | undefined;
            resourceInputs["aws"] = state ? state.aws : undefined;
            resourceInputs["azure"] = state ? state.azure : undefined;
            resourceInputs["cplnId"] = state ? state.cplnId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["gcp"] = state ? state.gcp : undefined;
            resourceInputs["gcpRoles"] = state ? state.gcpRoles : undefined;
            resourceInputs["gcpServiceAccountName"] = state ? state.gcpServiceAccountName : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["ngs"] = state ? state.ngs : undefined;
            resourceInputs["selfLink"] = state ? state.selfLink : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as CloudAccountArgs | undefined;
            resourceInputs["aws"] = args ? args.aws : undefined;
            resourceInputs["azure"] = args ? args.azure : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["gcp"] = args ? args.gcp : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["ngs"] = args ? args.ngs : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["cplnId"] = undefined /*out*/;
            resourceInputs["gcpRoles"] = undefined /*out*/;
            resourceInputs["gcpServiceAccountName"] = undefined /*out*/;
            resourceInputs["selfLink"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CloudAccount.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CloudAccount resources.
 */
export interface CloudAccountState {
    /**
     * Contains AWS cloud account configuration.
     */
    aws?: pulumi.Input<inputs.CloudAccountAws>;
    /**
     * Contains Azure cloud account configuration.
     */
    azure?: pulumi.Input<inputs.CloudAccountAzure>;
    /**
     * The ID, in GUID format, of the Cloud Account.
     */
    cplnId?: pulumi.Input<string>;
    /**
     * Description of the Cloud Account.
     */
    description?: pulumi.Input<string>;
    /**
     * Contains GCP cloud account configuration.
     */
    gcp?: pulumi.Input<inputs.CloudAccountGcp>;
    gcpRoles?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * GCP service account name used during the configuration of the cloud account at GCP.
     */
    gcpServiceAccountName?: pulumi.Input<string>;
    /**
     * Name of the Cloud Account.
     */
    name?: pulumi.Input<string>;
    ngs?: pulumi.Input<inputs.CloudAccountNgs>;
    selfLink?: pulumi.Input<string>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a CloudAccount resource.
 */
export interface CloudAccountArgs {
    /**
     * Contains AWS cloud account configuration.
     */
    aws?: pulumi.Input<inputs.CloudAccountAws>;
    /**
     * Contains Azure cloud account configuration.
     */
    azure?: pulumi.Input<inputs.CloudAccountAzure>;
    /**
     * Description of the Cloud Account.
     */
    description?: pulumi.Input<string>;
    /**
     * Contains GCP cloud account configuration.
     */
    gcp?: pulumi.Input<inputs.CloudAccountGcp>;
    /**
     * Name of the Cloud Account.
     */
    name?: pulumi.Input<string>;
    ngs?: pulumi.Input<inputs.CloudAccountNgs>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
