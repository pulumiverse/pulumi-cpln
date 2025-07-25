// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * The provider type for the cpln package. By default, resources use package-wide configuration
 * settings, however an explicit `Provider` instance may be created and passed during resource
 * construction to achieve fine-grained programmatic control over provider settings. See the
 * [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
 */
export class Provider extends pulumi.ProviderResource {
    /** @internal */
    public static readonly __pulumiType = 'cpln';

    /**
     * Returns true if the given object is an instance of Provider.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Provider {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === "pulumi:providers:" + Provider.__pulumiType;
    }

    /**
     * The Control Plane Data Service API endpoint. Default is: https://api.cpln.io. Can be specified with the CPLN_ENDPOINT
     * environment variable.
     */
    public readonly endpoint!: pulumi.Output<string | undefined>;
    /**
     * The Control Plane org that this provider will perform actions against. Can be specified with the CPLN_ORG environment
     * variable.
     */
    public readonly org!: pulumi.Output<string | undefined>;
    /**
     * The user/service account profile that this provider will use to authenticate to the data service. Can be specified with
     * the CPLN_PROFILE environment variable.
     */
    public readonly profile!: pulumi.Output<string | undefined>;
    /**
     * A generated token that can be used to authenticate to the data service API. Can be specified with the CPLN_REFRESH_TOKEN
     * environment variable. Used when the provider is required to create an org or update the authConfig property. Refer to
     * the section above on how to obtain the refresh token.
     */
    public readonly refreshToken!: pulumi.Output<string | undefined>;
    /**
     * A generated token that can be used to authenticate to the data service API. Can be specified with the CPLN_TOKEN
     * environment variable.
     */
    public readonly token!: pulumi.Output<string | undefined>;

    /**
     * Create a Provider resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ProviderArgs, opts?: pulumi.ResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        {
            resourceInputs["endpoint"] = args ? args.endpoint : undefined;
            resourceInputs["org"] = args ? args.org : undefined;
            resourceInputs["profile"] = args ? args.profile : undefined;
            resourceInputs["refreshToken"] = args?.refreshToken ? pulumi.secret(args.refreshToken) : undefined;
            resourceInputs["token"] = args?.token ? pulumi.secret(args.token) : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["refreshToken", "token"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(Provider.__pulumiType, name, resourceInputs, opts);
    }

    /**
     * This function returns a Terraform config object with terraform-namecased keys,to be used with the Terraform Module Provider.
     */
    terraformConfig(): pulumi.Output<Provider.TerraformConfigResult> {
        return pulumi.runtime.call("pulumi:providers:cpln/terraformConfig", {
            "__self__": this,
        }, this);
    }
}

/**
 * The set of arguments for constructing a Provider resource.
 */
export interface ProviderArgs {
    /**
     * The Control Plane Data Service API endpoint. Default is: https://api.cpln.io. Can be specified with the CPLN_ENDPOINT
     * environment variable.
     */
    endpoint?: pulumi.Input<string>;
    /**
     * The Control Plane org that this provider will perform actions against. Can be specified with the CPLN_ORG environment
     * variable.
     */
    org?: pulumi.Input<string>;
    /**
     * The user/service account profile that this provider will use to authenticate to the data service. Can be specified with
     * the CPLN_PROFILE environment variable.
     */
    profile?: pulumi.Input<string>;
    /**
     * A generated token that can be used to authenticate to the data service API. Can be specified with the CPLN_REFRESH_TOKEN
     * environment variable. Used when the provider is required to create an org or update the authConfig property. Refer to
     * the section above on how to obtain the refresh token.
     */
    refreshToken?: pulumi.Input<string>;
    /**
     * A generated token that can be used to authenticate to the data service API. Can be specified with the CPLN_TOKEN
     * environment variable.
     */
    token?: pulumi.Input<string>;
}

export namespace Provider {
    /**
     * The results of the Provider.terraformConfig method.
     */
    export interface TerraformConfigResult {
        readonly result: {[key: string]: any};
    }

}
