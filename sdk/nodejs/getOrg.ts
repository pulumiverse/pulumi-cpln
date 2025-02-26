// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Output the ID and name of the current [org](https://docs.controlplane.com/reference/org).
 *
 * ## Outputs
 *
 * The following attributes are exported:
 *
 * - **cpln_id** (String) The ID, in GUID format, of the org.
 * - **name** (String) The name of org.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cpln from "@pulumi/cpln";
 *
 * const org = cpln.getOrg({});
 * export const orgId = org.then(org => org.id);
 * export const orgName = org.then(org => org.name);
 * ```
 */
export function getOrg(opts?: pulumi.InvokeOptions): Promise<GetOrgResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("cpln:index/getOrg:getOrg", {
    }, opts);
}

/**
 * A collection of values returned by getOrg.
 */
export interface GetOrgResult {
    readonly cplnId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
}
/**
 * Output the ID and name of the current [org](https://docs.controlplane.com/reference/org).
 *
 * ## Outputs
 *
 * The following attributes are exported:
 *
 * - **cpln_id** (String) The ID, in GUID format, of the org.
 * - **name** (String) The name of org.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cpln from "@pulumi/cpln";
 *
 * const org = cpln.getOrg({});
 * export const orgId = org.then(org => org.id);
 * export const orgName = org.then(org => org.name);
 * ```
 */
export function getOrgOutput(opts?: pulumi.InvokeOptions): pulumi.Output<GetOrgResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("cpln:index/getOrg:getOrg", {
    }, opts);
}
