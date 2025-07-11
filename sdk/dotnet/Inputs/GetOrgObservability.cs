// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class GetOrgObservabilityArgs : global::Pulumi.InvokeArgs
    {
        [Input("defaultAlertEmails", required: true)]
        private List<string>? _defaultAlertEmails;

        /// <summary>
        /// These emails are configured as alert recipients in Grafana when the 'grafana-default-email' contact delivery type is 'Email'.
        /// </summary>
        public List<string> DefaultAlertEmails
        {
            get => _defaultAlertEmails ?? (_defaultAlertEmails = new List<string>());
            set => _defaultAlertEmails = value;
        }

        /// <summary>
        /// Log retention days. Default: 30
        /// </summary>
        [Input("logsRetentionDays", required: true)]
        public int LogsRetentionDays { get; set; }

        /// <summary>
        /// Metrics retention days. Default: 30
        /// </summary>
        [Input("metricsRetentionDays", required: true)]
        public int MetricsRetentionDays { get; set; }

        /// <summary>
        /// Traces retention days. Default: 30
        /// </summary>
        [Input("tracesRetentionDays", required: true)]
        public int TracesRetentionDays { get; set; }

        public GetOrgObservabilityArgs()
        {
        }
        public static new GetOrgObservabilityArgs Empty => new GetOrgObservabilityArgs();
    }
}
