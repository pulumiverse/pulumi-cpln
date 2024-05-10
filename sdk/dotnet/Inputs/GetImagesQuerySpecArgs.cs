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

    public sealed class GetImagesQuerySpecInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("match")]
        public Input<string>? Match { get; set; }

        [Input("terms")]
        private InputList<Inputs.GetImagesQuerySpecTermInputArgs>? _terms;
        public InputList<Inputs.GetImagesQuerySpecTermInputArgs> Terms
        {
            get => _terms ?? (_terms = new InputList<Inputs.GetImagesQuerySpecTermInputArgs>());
            set => _terms = value;
        }

        public GetImagesQuerySpecInputArgs()
        {
        }
        public static new GetImagesQuerySpecInputArgs Empty => new GetImagesQuerySpecInputArgs();
    }
}