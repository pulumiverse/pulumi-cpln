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

    public sealed class OrgTracingControlplaneTracingGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("customTags")]
        private InputMap<string>? _customTags;

        /// <summary>
        /// Key-value map of custom tags.
        /// </summary>
        public InputMap<string> CustomTags
        {
            get => _customTags ?? (_customTags = new InputMap<string>());
            set => _customTags = value;
        }

        /// <summary>
        /// Determines what percentage of requests should be traced.
        /// </summary>
        [Input("sampling", required: true)]
        public Input<double> Sampling { get; set; } = null!;

        public OrgTracingControlplaneTracingGetArgs()
        {
        }
        public static new OrgTracingControlplaneTracingGetArgs Empty => new OrgTracingControlplaneTracingGetArgs();
    }
}
