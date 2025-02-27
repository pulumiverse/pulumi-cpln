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

    public sealed class OrgLoggingElasticLoggingGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// For targeting Amazon Web Services (AWS) ElasticSearch.
        /// </summary>
        [Input("aws")]
        public Input<Inputs.OrgLoggingElasticLoggingAwsGetArgs>? Aws { get; set; }

        /// <summary>
        /// For targeting Elastic Cloud.
        /// </summary>
        [Input("elasticCloud")]
        public Input<Inputs.OrgLoggingElasticLoggingElasticCloudGetArgs>? ElasticCloud { get; set; }

        /// <summary>
        /// For targeting generic Elastic Search providers.
        /// </summary>
        [Input("generic")]
        public Input<Inputs.OrgLoggingElasticLoggingGenericGetArgs>? Generic { get; set; }

        [Input("placeholderAttribute")]
        public Input<bool>? PlaceholderAttribute { get; set; }

        public OrgLoggingElasticLoggingGetArgs()
        {
        }
        public static new OrgLoggingElasticLoggingGetArgs Empty => new OrgLoggingElasticLoggingGetArgs();
    }
}
