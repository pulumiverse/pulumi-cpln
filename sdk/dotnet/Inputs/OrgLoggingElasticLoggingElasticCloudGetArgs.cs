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

    public sealed class OrgLoggingElasticLoggingElasticCloudGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// [Cloud ID](https://www.elastic.co/guide/en/cloud/current/ec-cloud-id.html)
        /// </summary>
        [Input("cloudId", required: true)]
        public Input<string> CloudId { get; set; } = null!;

        /// <summary>
        /// Full Link to a secret of type `userpass`.
        /// </summary>
        [Input("credentials", required: true)]
        public Input<string> Credentials { get; set; } = null!;

        /// <summary>
        /// Logging Index.
        /// </summary>
        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        /// <summary>
        /// Logging Type.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public OrgLoggingElasticLoggingElasticCloudGetArgs()
        {
        }
        public static new OrgLoggingElasticLoggingElasticCloudGetArgs Empty => new OrgLoggingElasticLoggingElasticCloudGetArgs();
    }
}
