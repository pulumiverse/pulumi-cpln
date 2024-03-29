// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Outputs
{

    [OutputType]
    public sealed class IdentityNgsAccessPolicy
    {
        public readonly string CloudAccountLink;
        public readonly int? Data;
        public readonly int? Payload;
        public readonly Outputs.IdentityNgsAccessPolicyPub? Pub;
        public readonly Outputs.IdentityNgsAccessPolicyResp? Resp;
        public readonly Outputs.IdentityNgsAccessPolicySub? Sub;
        public readonly int? Subs;

        [OutputConstructor]
        private IdentityNgsAccessPolicy(
            string cloudAccountLink,

            int? data,

            int? payload,

            Outputs.IdentityNgsAccessPolicyPub? pub,

            Outputs.IdentityNgsAccessPolicyResp? resp,

            Outputs.IdentityNgsAccessPolicySub? sub,

            int? subs)
        {
            CloudAccountLink = cloudAccountLink;
            Data = data;
            Payload = payload;
            Pub = pub;
            Resp = resp;
            Sub = sub;
            Subs = subs;
        }
    }
}
