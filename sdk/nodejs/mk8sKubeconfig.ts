// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Obtain the Cluster’s Kubeconfig.
 *
 * ## Declaration
 *
 * ### Required
 *
 * - **name** (String) Name of the Mk8s.
 *
 * > **Note** Only one of the below can be included in the resource.
 *
 * - **profile** (String) The name of the cpln profile used to generate the kubeconfig file for authenticating with your Kubernetes cluster.
 * - **service_account** (String) The name of an existing service account for which a key will be generated, enabling kubeconfig-based authentication with your Kubernetes cluster.
 *
 * ## Outputs
 *
 * The following attributes are exported:
 *
 * - **kubeconfig** (String) The Kubeconfig in YAML format.
 *
 * ## Example Usage
 *
 * ### Profile
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cpln from "@pulumiverse/cpln";
 *
 * export = async () => {
 *     const _new = new cpln.Mk8sKubeconfig("new", {profile: "default"});
 *     return {
 *         "generic-cluster-kubeconfig": _new.kubeconfig,
 *     };
 * }
 * ```
 *
 * ### Service Account
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cpln from "@pulumiverse/cpln";
 *
 * export = async () => {
 *     const _new = new cpln.Mk8sKubeconfig("new", {serviceAccount: "devops-sa"});
 *     return {
 *         "generic-cluster-kubeconfig": _new.kubeconfig,
 *     };
 * }
 * ```
 */
export class Mk8sKubeconfig extends pulumi.CustomResource {
    /**
     * Get an existing Mk8sKubeconfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: Mk8sKubeconfigState, opts?: pulumi.CustomResourceOptions): Mk8sKubeconfig {
        return new Mk8sKubeconfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cpln:index/mk8sKubeconfig:Mk8sKubeconfig';

    /**
     * Returns true if the given object is an instance of Mk8sKubeconfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Mk8sKubeconfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Mk8sKubeconfig.__pulumiType;
    }

    /**
     * The Kubeconfig of your MK8s cluster in YAML format.
     */
    public /*out*/ readonly kubeconfig!: pulumi.Output<string>;
    /**
     * Name of the MK8s to create the Kubeconfig for.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Profile name to extract the token from.
     */
    public readonly profile!: pulumi.Output<string | undefined>;
    /**
     * A service account to add a key to.
     */
    public readonly serviceAccount!: pulumi.Output<string | undefined>;

    /**
     * Create a Mk8sKubeconfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: Mk8sKubeconfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: Mk8sKubeconfigArgs | Mk8sKubeconfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as Mk8sKubeconfigState | undefined;
            resourceInputs["kubeconfig"] = state ? state.kubeconfig : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["profile"] = state ? state.profile : undefined;
            resourceInputs["serviceAccount"] = state ? state.serviceAccount : undefined;
        } else {
            const args = argsOrState as Mk8sKubeconfigArgs | undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["profile"] = args ? args.profile : undefined;
            resourceInputs["serviceAccount"] = args ? args.serviceAccount : undefined;
            resourceInputs["kubeconfig"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["kubeconfig"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(Mk8sKubeconfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Mk8sKubeconfig resources.
 */
export interface Mk8sKubeconfigState {
    /**
     * The Kubeconfig of your MK8s cluster in YAML format.
     */
    kubeconfig?: pulumi.Input<string>;
    /**
     * Name of the MK8s to create the Kubeconfig for.
     */
    name?: pulumi.Input<string>;
    /**
     * Profile name to extract the token from.
     */
    profile?: pulumi.Input<string>;
    /**
     * A service account to add a key to.
     */
    serviceAccount?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Mk8sKubeconfig resource.
 */
export interface Mk8sKubeconfigArgs {
    /**
     * Name of the MK8s to create the Kubeconfig for.
     */
    name?: pulumi.Input<string>;
    /**
     * Profile name to extract the token from.
     */
    profile?: pulumi.Input<string>;
    /**
     * A service account to add a key to.
     */
    serviceAccount?: pulumi.Input<string>;
}
