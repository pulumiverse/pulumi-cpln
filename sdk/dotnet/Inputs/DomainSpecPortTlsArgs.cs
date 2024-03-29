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

    public sealed class DomainSpecPortTlsArgs : global::Pulumi.ResourceArgs
    {
        [Input("cipherSuites")]
        private InputList<string>? _cipherSuites;
        public InputList<string> CipherSuites
        {
            get => _cipherSuites ?? (_cipherSuites = new InputList<string>());
            set => _cipherSuites = value;
        }

        [Input("clientCertificate")]
        public Input<Inputs.DomainSpecPortTlsClientCertificateArgs>? ClientCertificate { get; set; }

        [Input("minProtocolVersion")]
        public Input<string>? MinProtocolVersion { get; set; }

        [Input("serverCertificate")]
        public Input<Inputs.DomainSpecPortTlsServerCertificateArgs>? ServerCertificate { get; set; }

        public DomainSpecPortTlsArgs()
        {
        }
        public static new DomainSpecPortTlsArgs Empty => new DomainSpecPortTlsArgs();
    }
}
