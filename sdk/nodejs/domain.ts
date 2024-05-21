// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class Domain extends pulumi.CustomResource {
    /**
     * Get an existing Domain resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DomainState, opts?: pulumi.CustomResourceOptions): Domain {
        return new Domain(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cpln:index/domain:Domain';

    /**
     * Returns true if the given object is an instance of Domain.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Domain {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Domain.__pulumiType;
    }

    /**
     * The ID, in GUID format, of the Domain.
     */
    public /*out*/ readonly cplnId!: pulumi.Output<string>;
    /**
     * Description of the domain name.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Domain name. (e.g., `example.com` / `test.example.com`). Control Plane will validate the existence of the domain with
     * DNS. Create and Update will fail if the required DNS entries cannot be validated.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    /**
     * Domain specificiation.
     */
    public readonly spec!: pulumi.Output<outputs.DomainSpec>;
    public /*out*/ readonly statuses!: pulumi.Output<outputs.DomainStatus[]>;
    /**
     * Key-value map of resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a Domain resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DomainArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DomainArgs | DomainState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DomainState | undefined;
            resourceInputs["cplnId"] = state ? state.cplnId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["selfLink"] = state ? state.selfLink : undefined;
            resourceInputs["spec"] = state ? state.spec : undefined;
            resourceInputs["statuses"] = state ? state.statuses : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as DomainArgs | undefined;
            if ((!args || args.spec === undefined) && !opts.urn) {
                throw new Error("Missing required property 'spec'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["spec"] = args ? args.spec : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["cplnId"] = undefined /*out*/;
            resourceInputs["selfLink"] = undefined /*out*/;
            resourceInputs["statuses"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Domain.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Domain resources.
 */
export interface DomainState {
    /**
     * The ID, in GUID format, of the Domain.
     */
    cplnId?: pulumi.Input<string>;
    /**
     * Description of the domain name.
     */
    description?: pulumi.Input<string>;
    /**
     * Domain name. (e.g., `example.com` / `test.example.com`). Control Plane will validate the existence of the domain with
     * DNS. Create and Update will fail if the required DNS entries cannot be validated.
     */
    name?: pulumi.Input<string>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    selfLink?: pulumi.Input<string>;
    /**
     * Domain specificiation.
     */
    spec?: pulumi.Input<inputs.DomainSpec>;
    statuses?: pulumi.Input<pulumi.Input<inputs.DomainStatus>[]>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a Domain resource.
 */
export interface DomainArgs {
    /**
     * Description of the domain name.
     */
    description?: pulumi.Input<string>;
    /**
     * Domain name. (e.g., `example.com` / `test.example.com`). Control Plane will validate the existence of the domain with
     * DNS. Create and Update will fail if the required DNS entries cannot be validated.
     */
    name?: pulumi.Input<string>;
    /**
     * Domain specificiation.
     */
    spec: pulumi.Input<inputs.DomainSpec>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
