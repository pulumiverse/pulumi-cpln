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
    public sealed class OrgSecurity
    {
        public readonly bool? _sentinel;
        public readonly Outputs.OrgSecurityThreatDetection? ThreatDetection;

        [OutputConstructor]
        private OrgSecurity(
            bool? _sentinel,

            Outputs.OrgSecurityThreatDetection? threatDetection)
        {
            this._sentinel = _sentinel;
            ThreatDetection = threatDetection;
        }
    }
}
