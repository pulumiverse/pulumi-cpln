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

    public sealed class WorkloadSecurityOptionsGeoLocationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("headers")]
        public Input<Inputs.WorkloadSecurityOptionsGeoLocationHeadersGetArgs>? Headers { get; set; }

        public WorkloadSecurityOptionsGeoLocationGetArgs()
        {
        }
        public static new WorkloadSecurityOptionsGeoLocationGetArgs Empty => new WorkloadSecurityOptionsGeoLocationGetArgs();
    }
}
