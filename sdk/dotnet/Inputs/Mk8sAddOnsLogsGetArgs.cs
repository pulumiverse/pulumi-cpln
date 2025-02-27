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

    public sealed class Mk8sAddOnsLogsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Collect k8s audit log as log events.
        /// </summary>
        [Input("auditEnabled")]
        public Input<bool>? AuditEnabled { get; set; }

        [Input("excludeNamespaces")]
        public Input<string>? ExcludeNamespaces { get; set; }

        [Input("includeNamespaces")]
        public Input<string>? IncludeNamespaces { get; set; }

        [Input("placeholderAttribute")]
        public Input<bool>? PlaceholderAttribute { get; set; }

        public Mk8sAddOnsLogsGetArgs()
        {
        }
        public static new Mk8sAddOnsLogsGetArgs Empty => new Mk8sAddOnsLogsGetArgs();
    }
}
