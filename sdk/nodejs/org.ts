// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class Org extends pulumi.CustomResource {
    /**
     * Get an existing Org resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OrgState, opts?: pulumi.CustomResourceOptions): Org {
        return new Org(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cpln:index/org:Org';

    /**
     * Returns true if the given object is an instance of Org.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Org {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Org.__pulumiType;
    }

    /**
     * The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
     * obtained from the `Org Management & Billing` page.
     */
    public readonly accountId!: pulumi.Output<string>;
    /**
     * The configuration settings and parameters related to authentication within the org.
     */
    public readonly authConfig!: pulumi.Output<outputs.OrgAuthConfig | undefined>;
    /**
     * The ID, in GUID format, of the Organization.
     */
    public /*out*/ readonly cplnId!: pulumi.Output<string>;
    /**
     * Description of the Organization.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
     * the `superusers` group. The user account used when creating the org will be included in this list.
     */
    public readonly invitees!: pulumi.Output<string[]>;
    /**
     * Name of the Organization.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
     */
    public readonly observability!: pulumi.Output<outputs.OrgObservability | undefined>;
    public readonly security!: pulumi.Output<outputs.OrgSecurity | undefined>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    /**
     * The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
     */
    public readonly sessionTimeoutSeconds!: pulumi.Output<number>;
    /**
     * Status of the org.
     */
    public /*out*/ readonly statuses!: pulumi.Output<outputs.OrgStatus[]>;
    /**
     * Key-value map of resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string}>;

    /**
     * Create a Org resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: OrgArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OrgArgs | OrgState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as OrgState | undefined;
            resourceInputs["accountId"] = state ? state.accountId : undefined;
            resourceInputs["authConfig"] = state ? state.authConfig : undefined;
            resourceInputs["cplnId"] = state ? state.cplnId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["invitees"] = state ? state.invitees : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["observability"] = state ? state.observability : undefined;
            resourceInputs["security"] = state ? state.security : undefined;
            resourceInputs["selfLink"] = state ? state.selfLink : undefined;
            resourceInputs["sessionTimeoutSeconds"] = state ? state.sessionTimeoutSeconds : undefined;
            resourceInputs["statuses"] = state ? state.statuses : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as OrgArgs | undefined;
            resourceInputs["accountId"] = args ? args.accountId : undefined;
            resourceInputs["authConfig"] = args ? args.authConfig : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["invitees"] = args ? args.invitees : undefined;
            resourceInputs["observability"] = args ? args.observability : undefined;
            resourceInputs["security"] = args ? args.security : undefined;
            resourceInputs["sessionTimeoutSeconds"] = args ? args.sessionTimeoutSeconds : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["cplnId"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["selfLink"] = undefined /*out*/;
            resourceInputs["statuses"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Org.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Org resources.
 */
export interface OrgState {
    /**
     * The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
     * obtained from the `Org Management & Billing` page.
     */
    accountId?: pulumi.Input<string>;
    /**
     * The configuration settings and parameters related to authentication within the org.
     */
    authConfig?: pulumi.Input<inputs.OrgAuthConfig>;
    /**
     * The ID, in GUID format, of the Organization.
     */
    cplnId?: pulumi.Input<string>;
    /**
     * Description of the Organization.
     */
    description?: pulumi.Input<string>;
    /**
     * When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
     * the `superusers` group. The user account used when creating the org will be included in this list.
     */
    invitees?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Name of the Organization.
     */
    name?: pulumi.Input<string>;
    /**
     * The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
     */
    observability?: pulumi.Input<inputs.OrgObservability>;
    security?: pulumi.Input<inputs.OrgSecurity>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    selfLink?: pulumi.Input<string>;
    /**
     * The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
     */
    sessionTimeoutSeconds?: pulumi.Input<number>;
    /**
     * Status of the org.
     */
    statuses?: pulumi.Input<pulumi.Input<inputs.OrgStatus>[]>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a Org resource.
 */
export interface OrgArgs {
    /**
     * The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
     * obtained from the `Org Management & Billing` page.
     */
    accountId?: pulumi.Input<string>;
    /**
     * The configuration settings and parameters related to authentication within the org.
     */
    authConfig?: pulumi.Input<inputs.OrgAuthConfig>;
    /**
     * Description of the Organization.
     */
    description?: pulumi.Input<string>;
    /**
     * When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
     * the `superusers` group. The user account used when creating the org will be included in this list.
     */
    invitees?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
     */
    observability?: pulumi.Input<inputs.OrgObservability>;
    security?: pulumi.Input<inputs.OrgSecurity>;
    /**
     * The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
     */
    sessionTimeoutSeconds?: pulumi.Input<number>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
