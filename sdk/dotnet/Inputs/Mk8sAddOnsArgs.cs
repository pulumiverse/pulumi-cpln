// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class Mk8sAddOnsArgs : global::Pulumi.ResourceArgs
    {
        [Input("awsEcr")]
        public Input<Inputs.Mk8sAddOnsAwsEcrArgs>? AwsEcr { get; set; }

        [Input("awsEfs")]
        public Input<Inputs.Mk8sAddOnsAwsEfsArgs>? AwsEfs { get; set; }

        [Input("awsElb")]
        public Input<Inputs.Mk8sAddOnsAwsElbArgs>? AwsElb { get; set; }

        [Input("awsWorkloadIdentity")]
        public Input<bool>? AwsWorkloadIdentity { get; set; }

        [Input("azureAcr")]
        public Input<Inputs.Mk8sAddOnsAzureAcrArgs>? AzureAcr { get; set; }

        [Input("azureWorkloadIdentity")]
        public Input<Inputs.Mk8sAddOnsAzureWorkloadIdentityArgs>? AzureWorkloadIdentity { get; set; }

        [Input("dashboard")]
        public Input<bool>? Dashboard { get; set; }

        [Input("localPathStorage")]
        public Input<bool>? LocalPathStorage { get; set; }

        [Input("logs")]
        public Input<Inputs.Mk8sAddOnsLogsArgs>? Logs { get; set; }

        [Input("metrics")]
        public Input<Inputs.Mk8sAddOnsMetricsArgs>? Metrics { get; set; }

        [Input("nvidia")]
        public Input<Inputs.Mk8sAddOnsNvidiaArgs>? Nvidia { get; set; }

        public Mk8sAddOnsArgs()
        {
        }
        public static new Mk8sAddOnsArgs Empty => new Mk8sAddOnsArgs();
    }
}
