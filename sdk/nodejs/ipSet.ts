// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Manages an org's IpSet.
 *
 * ## Declaration
 *
 * ### Required
 *
 * - **name** (String) Name of the IpSet.
 *
 * ### Optional
 *
 * - **description** - (String) Description of the IpSet.
 * - **tags** (Map of String) Key-value map of resource tags.
 * - **link** (String) The self link of a workload.
 * - **location** (Block List) (see below).
 *
 * <a id="nestedblock--location"></a>
 *
 * ### `location`
 *
 * Required:
 *
 * - **name** (String) The self link of a location.
 * - **retention_policy** (String) Exactly one of: `keep` and `free`.
 *
 * ## Outputs
 *
 * The following attributes are exported:
 *
 * - **cpln_id** (String) The ID, in GUID format, of the IpSet.
 * - **self_link** (String) Full link to this resource. Can be referenced by other resources.
 * - **status** (Block List, Max: 1) (see below).
 *
 * <a id="nestedblock--status"></a>
 *
 * ### `status`
 *
 * Status of the IpSet.
 *
 * Read-Only:
 *
 * - **ip_address** (Block List) (see below)
 * - **error** (String)
 *
 * <a id="nestedblock--status--ip_address"></a>
 *
 * ### `status.ip_address`
 *
 * - **name** (String)
 * - **ip** (String)
 * - **id** (String)
 * - **state** (String)
 * - **created** (String)
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cpln from "@pulumiverse/cpln";
 *
 * const _new = new cpln.IpSet("new", {
 *     description: "example",
 *     link: "SELF_LINK_TO_WORKLOAD",
 *     locations: [{
 *         name: "SELF_LINK_TO_LOCATION",
 *         retentionPolicy: "keep",
 *     }],
 *     tags: {
 *         terraform_generated: "true",
 *     },
 * });
 * ```
 */
export class IpSet extends pulumi.CustomResource {
    /**
     * Get an existing IpSet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IpSetState, opts?: pulumi.CustomResourceOptions): IpSet {
        return new IpSet(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cpln:index/ipSet:IpSet';

    /**
     * Returns true if the given object is an instance of IpSet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IpSet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IpSet.__pulumiType;
    }

    /**
     * The ID, in GUID format, of the IpSet.
     */
    public /*out*/ readonly cplnId!: pulumi.Output<string>;
    /**
     * Description of the IpSet.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The self link of a workload.
     */
    public readonly link!: pulumi.Output<string | undefined>;
    public readonly locations!: pulumi.Output<outputs.IpSetLocation[] | undefined>;
    /**
     * Name of the IpSet.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    /**
     * Status of the IpSet.
     */
    public /*out*/ readonly statuses!: pulumi.Output<outputs.IpSetStatus[]>;
    /**
     * Key-value map of resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a IpSet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: IpSetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IpSetArgs | IpSetState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as IpSetState | undefined;
            resourceInputs["cplnId"] = state ? state.cplnId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["link"] = state ? state.link : undefined;
            resourceInputs["locations"] = state ? state.locations : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["selfLink"] = state ? state.selfLink : undefined;
            resourceInputs["statuses"] = state ? state.statuses : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as IpSetArgs | undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["link"] = args ? args.link : undefined;
            resourceInputs["locations"] = args ? args.locations : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["cplnId"] = undefined /*out*/;
            resourceInputs["selfLink"] = undefined /*out*/;
            resourceInputs["statuses"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(IpSet.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IpSet resources.
 */
export interface IpSetState {
    /**
     * The ID, in GUID format, of the IpSet.
     */
    cplnId?: pulumi.Input<string>;
    /**
     * Description of the IpSet.
     */
    description?: pulumi.Input<string>;
    /**
     * The self link of a workload.
     */
    link?: pulumi.Input<string>;
    locations?: pulumi.Input<pulumi.Input<inputs.IpSetLocation>[]>;
    /**
     * Name of the IpSet.
     */
    name?: pulumi.Input<string>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    selfLink?: pulumi.Input<string>;
    /**
     * Status of the IpSet.
     */
    statuses?: pulumi.Input<pulumi.Input<inputs.IpSetStatus>[]>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a IpSet resource.
 */
export interface IpSetArgs {
    /**
     * Description of the IpSet.
     */
    description?: pulumi.Input<string>;
    /**
     * The self link of a workload.
     */
    link?: pulumi.Input<string>;
    locations?: pulumi.Input<pulumi.Input<inputs.IpSetLocation>[]>;
    /**
     * Name of the IpSet.
     */
    name?: pulumi.Input<string>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
