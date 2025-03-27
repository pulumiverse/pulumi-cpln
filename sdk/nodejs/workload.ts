// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class Workload extends pulumi.CustomResource {
    /**
     * Get an existing Workload resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: WorkloadState, opts?: pulumi.CustomResourceOptions): Workload {
        return new Workload(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cpln:index/workload:Workload';

    /**
     * Returns true if the given object is an instance of Workload.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Workload {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Workload.__pulumiType;
    }

    /**
     * An isolated and lightweight runtime environment that encapsulates an application and its dependencies.
     */
    public readonly containers!: pulumi.Output<outputs.WorkloadContainer[]>;
    /**
     * The ID, in GUID format, of the Workload.
     */
    public /*out*/ readonly cplnId!: pulumi.Output<string>;
    /**
     * Description of the Workload.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Extra Kubernetes modifications. Only used for BYOK.
     */
    public readonly extras!: pulumi.Output<string | undefined>;
    /**
     * Control of inbound and outbound access to the workload for external (public) and internal (service to service) traffic.
     * Access is restricted by default.
     */
    public readonly firewallSpec!: pulumi.Output<outputs.WorkloadFirewallSpec | undefined>;
    /**
     * Name of the associated GVC.
     */
    public readonly gvc!: pulumi.Output<string>;
    /**
     * Full link to an Identity.
     */
    public readonly identityLink!: pulumi.Output<string | undefined>;
    /**
     * [Cron Job Reference Page](https://docs.controlplane.com/reference/workload#cron).
     */
    public readonly job!: pulumi.Output<outputs.WorkloadJob | undefined>;
    public readonly loadBalancer!: pulumi.Output<outputs.WorkloadLoadBalancer | undefined>;
    public readonly localOptions!: pulumi.Output<outputs.WorkloadLocalOption[] | undefined>;
    /**
     * Name of the Workload.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Configurable settings or parameters that allow fine-tuning and customization of the behavior, performance, and
     * characteristics of the workload.
     */
    public readonly options!: pulumi.Output<outputs.WorkloadOptions | undefined>;
    /**
     * Defines the parameters for updating applications and services, including settings for minimum readiness, unavailable
     * replicas, surge replicas, and scaling policies.
     */
    public readonly rolloutOptions!: pulumi.Output<outputs.WorkloadRolloutOptions | undefined>;
    /**
     * Allows for the configuration of the `file system group id` and `geo location`
     */
    public readonly securityOptions!: pulumi.Output<outputs.WorkloadSecurityOptions | undefined>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    public readonly sidecar!: pulumi.Output<outputs.WorkloadSidecar | undefined>;
    /**
     * Status of the workload.
     */
    public /*out*/ readonly statuses!: pulumi.Output<outputs.WorkloadStatus[]>;
    /**
     * Workload will automatically redeploy when one of the container images is updated in the container registry. Default:
     * false.
     */
    public readonly supportDynamicTags!: pulumi.Output<boolean | undefined>;
    /**
     * Key-value map of resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Workload Type. Either `serverless`, `standard`, `stateful`, or `cron`.
     */
    public readonly type!: pulumi.Output<string>;

    /**
     * Create a Workload resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WorkloadArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: WorkloadArgs | WorkloadState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as WorkloadState | undefined;
            resourceInputs["containers"] = state ? state.containers : undefined;
            resourceInputs["cplnId"] = state ? state.cplnId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["extras"] = state ? state.extras : undefined;
            resourceInputs["firewallSpec"] = state ? state.firewallSpec : undefined;
            resourceInputs["gvc"] = state ? state.gvc : undefined;
            resourceInputs["identityLink"] = state ? state.identityLink : undefined;
            resourceInputs["job"] = state ? state.job : undefined;
            resourceInputs["loadBalancer"] = state ? state.loadBalancer : undefined;
            resourceInputs["localOptions"] = state ? state.localOptions : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["options"] = state ? state.options : undefined;
            resourceInputs["rolloutOptions"] = state ? state.rolloutOptions : undefined;
            resourceInputs["securityOptions"] = state ? state.securityOptions : undefined;
            resourceInputs["selfLink"] = state ? state.selfLink : undefined;
            resourceInputs["sidecar"] = state ? state.sidecar : undefined;
            resourceInputs["statuses"] = state ? state.statuses : undefined;
            resourceInputs["supportDynamicTags"] = state ? state.supportDynamicTags : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as WorkloadArgs | undefined;
            if ((!args || args.containers === undefined) && !opts.urn) {
                throw new Error("Missing required property 'containers'");
            }
            if ((!args || args.gvc === undefined) && !opts.urn) {
                throw new Error("Missing required property 'gvc'");
            }
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            resourceInputs["containers"] = args ? args.containers : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["extras"] = args ? args.extras : undefined;
            resourceInputs["firewallSpec"] = args ? args.firewallSpec : undefined;
            resourceInputs["gvc"] = args ? args.gvc : undefined;
            resourceInputs["identityLink"] = args ? args.identityLink : undefined;
            resourceInputs["job"] = args ? args.job : undefined;
            resourceInputs["loadBalancer"] = args ? args.loadBalancer : undefined;
            resourceInputs["localOptions"] = args ? args.localOptions : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["options"] = args ? args.options : undefined;
            resourceInputs["rolloutOptions"] = args ? args.rolloutOptions : undefined;
            resourceInputs["securityOptions"] = args ? args.securityOptions : undefined;
            resourceInputs["sidecar"] = args ? args.sidecar : undefined;
            resourceInputs["supportDynamicTags"] = args ? args.supportDynamicTags : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["cplnId"] = undefined /*out*/;
            resourceInputs["selfLink"] = undefined /*out*/;
            resourceInputs["statuses"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Workload.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Workload resources.
 */
export interface WorkloadState {
    /**
     * An isolated and lightweight runtime environment that encapsulates an application and its dependencies.
     */
    containers?: pulumi.Input<pulumi.Input<inputs.WorkloadContainer>[]>;
    /**
     * The ID, in GUID format, of the Workload.
     */
    cplnId?: pulumi.Input<string>;
    /**
     * Description of the Workload.
     */
    description?: pulumi.Input<string>;
    /**
     * Extra Kubernetes modifications. Only used for BYOK.
     */
    extras?: pulumi.Input<string>;
    /**
     * Control of inbound and outbound access to the workload for external (public) and internal (service to service) traffic.
     * Access is restricted by default.
     */
    firewallSpec?: pulumi.Input<inputs.WorkloadFirewallSpec>;
    /**
     * Name of the associated GVC.
     */
    gvc?: pulumi.Input<string>;
    /**
     * Full link to an Identity.
     */
    identityLink?: pulumi.Input<string>;
    /**
     * [Cron Job Reference Page](https://docs.controlplane.com/reference/workload#cron).
     */
    job?: pulumi.Input<inputs.WorkloadJob>;
    loadBalancer?: pulumi.Input<inputs.WorkloadLoadBalancer>;
    localOptions?: pulumi.Input<pulumi.Input<inputs.WorkloadLocalOption>[]>;
    /**
     * Name of the Workload.
     */
    name?: pulumi.Input<string>;
    /**
     * Configurable settings or parameters that allow fine-tuning and customization of the behavior, performance, and
     * characteristics of the workload.
     */
    options?: pulumi.Input<inputs.WorkloadOptions>;
    /**
     * Defines the parameters for updating applications and services, including settings for minimum readiness, unavailable
     * replicas, surge replicas, and scaling policies.
     */
    rolloutOptions?: pulumi.Input<inputs.WorkloadRolloutOptions>;
    /**
     * Allows for the configuration of the `file system group id` and `geo location`
     */
    securityOptions?: pulumi.Input<inputs.WorkloadSecurityOptions>;
    /**
     * Full link to this resource. Can be referenced by other resources.
     */
    selfLink?: pulumi.Input<string>;
    sidecar?: pulumi.Input<inputs.WorkloadSidecar>;
    /**
     * Status of the workload.
     */
    statuses?: pulumi.Input<pulumi.Input<inputs.WorkloadStatus>[]>;
    /**
     * Workload will automatically redeploy when one of the container images is updated in the container registry. Default:
     * false.
     */
    supportDynamicTags?: pulumi.Input<boolean>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Workload Type. Either `serverless`, `standard`, `stateful`, or `cron`.
     */
    type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Workload resource.
 */
export interface WorkloadArgs {
    /**
     * An isolated and lightweight runtime environment that encapsulates an application and its dependencies.
     */
    containers: pulumi.Input<pulumi.Input<inputs.WorkloadContainer>[]>;
    /**
     * Description of the Workload.
     */
    description?: pulumi.Input<string>;
    /**
     * Extra Kubernetes modifications. Only used for BYOK.
     */
    extras?: pulumi.Input<string>;
    /**
     * Control of inbound and outbound access to the workload for external (public) and internal (service to service) traffic.
     * Access is restricted by default.
     */
    firewallSpec?: pulumi.Input<inputs.WorkloadFirewallSpec>;
    /**
     * Name of the associated GVC.
     */
    gvc: pulumi.Input<string>;
    /**
     * Full link to an Identity.
     */
    identityLink?: pulumi.Input<string>;
    /**
     * [Cron Job Reference Page](https://docs.controlplane.com/reference/workload#cron).
     */
    job?: pulumi.Input<inputs.WorkloadJob>;
    loadBalancer?: pulumi.Input<inputs.WorkloadLoadBalancer>;
    localOptions?: pulumi.Input<pulumi.Input<inputs.WorkloadLocalOption>[]>;
    /**
     * Name of the Workload.
     */
    name?: pulumi.Input<string>;
    /**
     * Configurable settings or parameters that allow fine-tuning and customization of the behavior, performance, and
     * characteristics of the workload.
     */
    options?: pulumi.Input<inputs.WorkloadOptions>;
    /**
     * Defines the parameters for updating applications and services, including settings for minimum readiness, unavailable
     * replicas, surge replicas, and scaling policies.
     */
    rolloutOptions?: pulumi.Input<inputs.WorkloadRolloutOptions>;
    /**
     * Allows for the configuration of the `file system group id` and `geo location`
     */
    securityOptions?: pulumi.Input<inputs.WorkloadSecurityOptions>;
    sidecar?: pulumi.Input<inputs.WorkloadSidecar>;
    /**
     * Workload will automatically redeploy when one of the container images is updated in the container registry. Default:
     * false.
     */
    supportDynamicTags?: pulumi.Input<boolean>;
    /**
     * Key-value map of resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Workload Type. Either `serverless`, `standard`, `stateful`, or `cron`.
     */
    type: pulumi.Input<string>;
}
