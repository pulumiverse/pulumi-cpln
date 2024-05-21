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

    public sealed class Mk8sStatusAddOnArgs : global::Pulumi.ResourceArgs
    {
        [Input("awsEcrs")]
        private InputList<Inputs.Mk8sStatusAddOnAwsEcrArgs>? _awsEcrs;
        public InputList<Inputs.Mk8sStatusAddOnAwsEcrArgs> AwsEcrs
        {
            get => _awsEcrs ?? (_awsEcrs = new InputList<Inputs.Mk8sStatusAddOnAwsEcrArgs>());
            set => _awsEcrs = value;
        }

        [Input("awsEfs")]
        private InputList<Inputs.Mk8sStatusAddOnAwsEfArgs>? _awsEfs;
        public InputList<Inputs.Mk8sStatusAddOnAwsEfArgs> AwsEfs
        {
            get => _awsEfs ?? (_awsEfs = new InputList<Inputs.Mk8sStatusAddOnAwsEfArgs>());
            set => _awsEfs = value;
        }

        [Input("awsElbs")]
        private InputList<Inputs.Mk8sStatusAddOnAwsElbArgs>? _awsElbs;
        public InputList<Inputs.Mk8sStatusAddOnAwsElbArgs> AwsElbs
        {
            get => _awsElbs ?? (_awsElbs = new InputList<Inputs.Mk8sStatusAddOnAwsElbArgs>());
            set => _awsElbs = value;
        }

        [Input("awsWorkloadIdentities")]
        private InputList<Inputs.Mk8sStatusAddOnAwsWorkloadIdentityArgs>? _awsWorkloadIdentities;
        public InputList<Inputs.Mk8sStatusAddOnAwsWorkloadIdentityArgs> AwsWorkloadIdentities
        {
            get => _awsWorkloadIdentities ?? (_awsWorkloadIdentities = new InputList<Inputs.Mk8sStatusAddOnAwsWorkloadIdentityArgs>());
            set => _awsWorkloadIdentities = value;
        }

        [Input("dashboards")]
        private InputList<Inputs.Mk8sStatusAddOnDashboardArgs>? _dashboards;
        public InputList<Inputs.Mk8sStatusAddOnDashboardArgs> Dashboards
        {
            get => _dashboards ?? (_dashboards = new InputList<Inputs.Mk8sStatusAddOnDashboardArgs>());
            set => _dashboards = value;
        }

        [Input("logs")]
        private InputList<Inputs.Mk8sStatusAddOnLogArgs>? _logs;
        public InputList<Inputs.Mk8sStatusAddOnLogArgs> Logs
        {
            get => _logs ?? (_logs = new InputList<Inputs.Mk8sStatusAddOnLogArgs>());
            set => _logs = value;
        }

        [Input("metrics")]
        private InputList<Inputs.Mk8sStatusAddOnMetricArgs>? _metrics;
        public InputList<Inputs.Mk8sStatusAddOnMetricArgs> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<Inputs.Mk8sStatusAddOnMetricArgs>());
            set => _metrics = value;
        }

        public Mk8sStatusAddOnArgs()
        {
        }
        public static new Mk8sStatusAddOnArgs Empty => new Mk8sStatusAddOnArgs();
    }
}