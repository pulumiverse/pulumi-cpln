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

    public sealed class GetImagesQuerySpecTermArgs : global::Pulumi.InvokeArgs
    {
        [Input("op")]
        public string? Op { get; set; }

        [Input("property")]
        public string? Property { get; set; }

        [Input("tag")]
        public string? Tag { get; set; }

        [Input("value")]
        public string? Value { get; set; }

        public GetImagesQuerySpecTermArgs()
        {
        }
        public static new GetImagesQuerySpecTermArgs Empty => new GetImagesQuerySpecTermArgs();
    }
}
