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

    public sealed class Mk8sLambdalabsProviderArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoscaler")]
        public Input<Inputs.Mk8sLambdalabsProviderAutoscalerArgs>? Autoscaler { get; set; }

        [Input("fileSystems")]
        private InputList<string>? _fileSystems;
        public InputList<string> FileSystems
        {
            get => _fileSystems ?? (_fileSystems = new InputList<string>());
            set => _fileSystems = value;
        }

        [Input("nodePools")]
        private InputList<Inputs.Mk8sLambdalabsProviderNodePoolArgs>? _nodePools;

        /// <summary>
        /// List of node pools.
        /// </summary>
        public InputList<Inputs.Mk8sLambdalabsProviderNodePoolArgs> NodePools
        {
            get => _nodePools ?? (_nodePools = new InputList<Inputs.Mk8sLambdalabsProviderNodePoolArgs>());
            set => _nodePools = value;
        }

        /// <summary>
        /// Optional shell script that will be run before K8s is installed. Supports SSM.
        /// </summary>
        [Input("preInstallScript")]
        public Input<string>? PreInstallScript { get; set; }

        /// <summary>
        /// Region where the cluster nodes will live.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        /// <summary>
        /// SSH key name for accessing deployed nodes.
        /// </summary>
        [Input("sshKey", required: true)]
        public Input<string> SshKey { get; set; } = null!;

        /// <summary>
        /// Link to a secret holding Lambdalabs access key.
        /// </summary>
        [Input("tokenSecretLink", required: true)]
        public Input<string> TokenSecretLink { get; set; } = null!;

        [Input("unmanagedNodePools")]
        private InputList<Inputs.Mk8sLambdalabsProviderUnmanagedNodePoolArgs>? _unmanagedNodePools;
        public InputList<Inputs.Mk8sLambdalabsProviderUnmanagedNodePoolArgs> UnmanagedNodePools
        {
            get => _unmanagedNodePools ?? (_unmanagedNodePools = new InputList<Inputs.Mk8sLambdalabsProviderUnmanagedNodePoolArgs>());
            set => _unmanagedNodePools = value;
        }

        public Mk8sLambdalabsProviderArgs()
        {
        }
        public static new Mk8sLambdalabsProviderArgs Empty => new Mk8sLambdalabsProviderArgs();
    }
}
