// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Use this data source to access information about an existing [Cloud Account](https://docs.controlplane.com/reference/cloudaccount) within Control Plane.
 *
 * ## Outputs
 *
 * - **aws_identifiers** (String)
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cpln from "@pulumi/cpln";
 *
 * const _this = cpln.getCloudAccount({});
 * export const cloudAccount = _this.then(_this => _this.awsIdentifiers);
 * ```
 */
export function getCloudAccount(opts?: pulumi.InvokeOptions): Promise<GetCloudAccountResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("cpln:index/getCloudAccount:getCloudAccount", {
    }, opts);
}

/**
 * A collection of values returned by getCloudAccount.
 */
export interface GetCloudAccountResult {
    readonly awsIdentifiers: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
/**
 * Use this data source to access information about an existing [Cloud Account](https://docs.controlplane.com/reference/cloudaccount) within Control Plane.
 *
 * ## Outputs
 *
 * - **aws_identifiers** (String)
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cpln from "@pulumi/cpln";
 *
 * const _this = cpln.getCloudAccount({});
 * export const cloudAccount = _this.then(_this => _this.awsIdentifiers);
 * ```
 */
export function getCloudAccountOutput(opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetCloudAccountResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("cpln:index/getCloudAccount:getCloudAccount", {
    }, opts);
}
