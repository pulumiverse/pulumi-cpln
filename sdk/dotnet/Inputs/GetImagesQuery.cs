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

    public sealed class GetImagesQueryArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Type of fetch. Specify either: `links` or `items`. Default: `items`.
        /// </summary>
        [Input("fetch")]
        public string? Fetch { get; set; }

        [Input("spec")]
        public Inputs.GetImagesQuerySpecArgs? Spec { get; set; }

        public GetImagesQueryArgs()
        {
        }
        public static new GetImagesQueryArgs Empty => new GetImagesQueryArgs();
    }
}
