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

    public sealed class OrgAuthConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("domainAutoMembers", required: true)]
        private InputList<string>? _domainAutoMembers;

        /// <summary>
        /// List of domains which will auto-provision users when authenticating using SAML.
        /// </summary>
        public InputList<string> DomainAutoMembers
        {
            get => _domainAutoMembers ?? (_domainAutoMembers = new InputList<string>());
            set => _domainAutoMembers = value;
        }

        /// <summary>
        /// Enforce SAML only authentication.
        /// </summary>
        [Input("samlOnly")]
        public Input<bool>? SamlOnly { get; set; }

        public OrgAuthConfigArgs()
        {
        }
        public static new OrgAuthConfigArgs Empty => new OrgAuthConfigArgs();
    }
}
