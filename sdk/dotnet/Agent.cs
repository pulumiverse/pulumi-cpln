// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln
{
    [CplnResourceType("cpln:index/agent:Agent")]
    public partial class Agent : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The ID, in GUID format, of the Agent.
        /// </summary>
        [Output("cplnId")]
        public Output<string> CplnId { get; private set; } = null!;

        /// <summary>
        /// Description of the Agent.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Name of the Agent.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// Key-value map of resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>> Tags { get; private set; } = null!;

        /// <summary>
        /// The JSON output needed when creating an agent.
        /// </summary>
        [Output("userData")]
        public Output<string> UserData { get; private set; } = null!;


        /// <summary>
        /// Create a Agent resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Agent(string name, AgentArgs? args = null, CustomResourceOptions? options = null)
            : base("cpln:index/agent:Agent", name, args ?? new AgentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Agent(string name, Input<string> id, AgentState? state = null, CustomResourceOptions? options = null)
            : base("cpln:index/agent:Agent", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
                AdditionalSecretOutputs =
                {
                    "userData",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Agent resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Agent Get(string name, Input<string> id, AgentState? state = null, CustomResourceOptions? options = null)
        {
            return new Agent(name, id, state, options);
        }
    }

    public sealed class AgentArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the Agent.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Name of the Agent.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value map of resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public AgentArgs()
        {
        }
        public static new AgentArgs Empty => new AgentArgs();
    }

    public sealed class AgentState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID, in GUID format, of the Agent.
        /// </summary>
        [Input("cplnId")]
        public Input<string>? CplnId { get; set; }

        /// <summary>
        /// Description of the Agent.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Name of the Agent.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value map of resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        [Input("userData")]
        private Input<string>? _userData;

        /// <summary>
        /// The JSON output needed when creating an agent.
        /// </summary>
        public Input<string>? UserData
        {
            get => _userData;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _userData = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public AgentState()
        {
        }
        public static new AgentState Empty => new AgentState();
    }
}
