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

    public sealed class OrgLoggingElasticLoggingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// For targeting Amazon Web Services (AWS) ElasticSearch.
        /// </summary>
        [Input("aws")]
        public Input<Inputs.OrgLoggingElasticLoggingAwsArgs>? Aws { get; set; }

        /// <summary>
        /// For targeting Elastic Cloud.
        /// </summary>
        [Input("elasticCloud")]
        public Input<Inputs.OrgLoggingElasticLoggingElasticCloudArgs>? ElasticCloud { get; set; }

        /// <summary>
        /// For targeting generic Elastic Search providers.
        /// </summary>
        [Input("generic")]
        public Input<Inputs.OrgLoggingElasticLoggingGenericArgs>? Generic { get; set; }

        [Input("placeholderAttribute")]
        public Input<bool>? PlaceholderAttribute { get; set; }

        public OrgLoggingElasticLoggingArgs()
        {
        }
        public static new OrgLoggingElasticLoggingArgs Empty => new OrgLoggingElasticLoggingArgs();
    }
}
