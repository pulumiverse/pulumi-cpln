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

    public sealed class OrgLoggingElasticLoggingAwsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Full Link to a secret of type `aws`.
        /// </summary>
        [Input("credentials", required: true)]
        public Input<string> Credentials { get; set; } = null!;

        /// <summary>
        /// A valid AWS ElasticSearch hostname (must end with es.amazonaws.com).
        /// </summary>
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        /// <summary>
        /// Logging Index.
        /// </summary>
        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        /// <summary>
        /// Port. Default: 443
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// Valid AWS region.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        /// <summary>
        /// Logging Type.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public OrgLoggingElasticLoggingAwsArgs()
        {
        }
        public static new OrgLoggingElasticLoggingAwsArgs Empty => new OrgLoggingElasticLoggingAwsArgs();
    }
}
