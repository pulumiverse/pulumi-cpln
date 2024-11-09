// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class VolumeSet extends pulumi.CustomResource {
    /**
     * Get an existing VolumeSet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VolumeSetState, opts?: pulumi.CustomResourceOptions): VolumeSet {
        return new VolumeSet(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cpln:index/volumeSet:VolumeSet';

    /**
     * Returns true if the given object is an instance of VolumeSet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VolumeSet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VolumeSet.__pulumiType;
    }

    /**
     * Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
     */
    public readonly autoscaling!: pulumi.Output<outputs.VolumeSetAutoscaling | undefined>;
    /**
     * ID, in GUID format, of the Volume Set.
     */
    public /*out*/ readonly cplnId!: pulumi.Output<string>;
    /**
     * Description of the Volume Set.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
     */
    public readonly fileSystemType!: pulumi.Output<string | undefined>;
    /**
     * Name of the associated GVC.
     */
    public readonly gvc!: pulumi.Output<string>;
    /**
     * The initial volume size in this set, specified in GB. The minimum size for the performance class `general-purpose-ssd`
     * is `10 GB`, while `high-throughput-ssd` requires at least `200 GB`.
     */
    public readonly initialCapacity!: pulumi.Output<number>;
    /**
     * Name of the Volume Set.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
     * `high-throughput-ssd`
     */
    public readonly performanceClass!: pulumi.Output<string>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    /**
     * Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
     */
    public readonly snapshots!: pulumi.Output<outputs.VolumeSetSnapshots | undefined>;
    /**
     * Status of the Volume Set.
     */
    public /*out*/ readonly statuses!: pulumi.Output<outputs.VolumeSetStatus[]>;
    /**
     * For self-hosted locations only. The storage class used for volumes in this set will be
     * {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
     * {performanceClass}-{fileSystemType}
     */
    public readonly storageClassSuffix!: pulumi.Output<string | undefined>;
    /**
     * Key-value map of resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Output used when linking a volume set to a workload.
     */
    public /*out*/ readonly volumesetLink!: pulumi.Output<string>;

    /**
     * Create a VolumeSet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VolumeSetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VolumeSetArgs | VolumeSetState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VolumeSetState | undefined;
            resourceInputs["autoscaling"] = state ? state.autoscaling : undefined;
            resourceInputs["cplnId"] = state ? state.cplnId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["fileSystemType"] = state ? state.fileSystemType : undefined;
            resourceInputs["gvc"] = state ? state.gvc : undefined;
            resourceInputs["initialCapacity"] = state ? state.initialCapacity : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["performanceClass"] = state ? state.performanceClass : undefined;
            resourceInputs["selfLink"] = state ? state.selfLink : undefined;
            resourceInputs["snapshots"] = state ? state.snapshots : undefined;
            resourceInputs["statuses"] = state ? state.statuses : undefined;
            resourceInputs["storageClassSuffix"] = state ? state.storageClassSuffix : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["volumesetLink"] = state ? state.volumesetLink : undefined;
        } else {
            const args = argsOrState as VolumeSetArgs | undefined;
            if ((!args || args.gvc === undefined) && !opts.urn) {
                throw new Error("Missing required property 'gvc'");
            }
            if ((!args || args.initialCapacity === undefined) && !opts.urn) {
                throw new Error("Missing required property 'initialCapacity'");
            }
            if ((!args || args.performanceClass === undefined) && !opts.urn) {
                throw new Error("Missing required property 'performanceClass'");
            }
            resourceInputs["autoscaling"] = args ? args.autoscaling : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["fileSystemType"] = args ? args.fileSystemType : undefined;
            resourceInputs["gvc"] = args ? args.gvc : undefined;
            resourceInputs["initialCapacity"] = args ? args.initialCapacity : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["performanceClass"] = args ? args.performanceClass : undefined;
            resourceInputs["snapshots"] = args ? args.snapshots : undefined;
            resourceInputs["storageClassSuffix"] = args ? args.storageClassSuffix : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["cplnId"] = undefined /*out*/;
            resourceInputs["selfLink"] = undefined /*out*/;
            resourceInputs["statuses"] = undefined /*out*/;
            resourceInputs["volumesetLink"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(VolumeSet.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VolumeSet resources.
 */
export interface VolumeSetState {
    /**
     * Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
     */
    autoscaling?: pulumi.Input<inputs.VolumeSetAutoscaling>;
    /**
     * ID, in GUID format, of the Volume Set.
     */
    cplnId?: pulumi.Input<string>;
    /**
     * Description of the Volume Set.
     */
    description?: pulumi.Input<string>;
    /**
     * Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
     */
    fileSystemType?: pulumi.Input<string>;
    /**
     * Name of the associated GVC.
     */
    gvc?: pulumi.Input<string>;
    /**
     * The initial volume size in this set, specified in GB. The minimum size for the performance class `general-purpose-ssd`
     * is `10 GB`, while `high-throughput-ssd` requires at least `200 GB`.
     */
    initialCapacity?: pulumi.Input<number>;
    /**
     * Name of the Volume Set.
     */
    name?: pulumi.Input<string>;
    /**
     * Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
     * `high-throughput-ssd`
     */
    performanceClass?: pulumi.Input<string>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    selfLink?: pulumi.Input<string>;
    /**
     * Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
     */
    snapshots?: pulumi.Input<inputs.VolumeSetSnapshots>;
    /**
     * Status of the Volume Set.
     */
    statuses?: pulumi.Input<pulumi.Input<inputs.VolumeSetStatus>[]>;
    /**
     * For self-hosted locations only. The storage class used for volumes in this set will be
     * {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
     * {performanceClass}-{fileSystemType}
     */
    storageClassSuffix?: pulumi.Input<string>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Output used when linking a volume set to a workload.
     */
    volumesetLink?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a VolumeSet resource.
 */
export interface VolumeSetArgs {
    /**
     * Automated adjustment of the volume set's capacity based on predefined metrics or conditions.
     */
    autoscaling?: pulumi.Input<inputs.VolumeSetAutoscaling>;
    /**
     * Description of the Volume Set.
     */
    description?: pulumi.Input<string>;
    /**
     * Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
     */
    fileSystemType?: pulumi.Input<string>;
    /**
     * Name of the associated GVC.
     */
    gvc: pulumi.Input<string>;
    /**
     * The initial volume size in this set, specified in GB. The minimum size for the performance class `general-purpose-ssd`
     * is `10 GB`, while `high-throughput-ssd` requires at least `200 GB`.
     */
    initialCapacity: pulumi.Input<number>;
    /**
     * Name of the Volume Set.
     */
    name?: pulumi.Input<string>;
    /**
     * Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
     * `high-throughput-ssd`
     */
    performanceClass: pulumi.Input<string>;
    /**
     * Point-in-time copies of data stored within the volume set, capturing the state of the data at a specific moment.
     */
    snapshots?: pulumi.Input<inputs.VolumeSetSnapshots>;
    /**
     * For self-hosted locations only. The storage class used for volumes in this set will be
     * {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
     * {performanceClass}-{fileSystemType}
     */
    storageClassSuffix?: pulumi.Input<string>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
