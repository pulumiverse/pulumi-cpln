// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln
{
    /// <summary>
    /// Manages an org's [Custom Location](https://docs.controlplane.com/reference/location#byok-locations).
    /// 
    /// ## Declaration
    /// 
    /// ### Required
    /// 
    /// - **name** (String) Name of the Custom Location.
    /// - **enabled** (Boolean) Indication if custom location is enabled.
    /// - **cloud_provider** (String) Provider of the custom location, must be `byok`.
    /// 
    /// ### Optional
    /// 
    /// - **tags** (Map of String) Key-value map of resource tags.
    /// - **description** - (String) Description of Custom Location.
    /// 
    /// ## Outputs
    /// 
    /// - **cpln_id** (String) The ID, in GUID format, of the custom location.
    /// - **self_link** (String) Full link to this resource. Can be referenced by other resources.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Cpln = Pulumiverse.Cpln;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var example = new Cpln.CustomLocation("example", new()
    ///     {
    ///         CloudProvider = "byok",
    ///         Description = "custom location description",
    ///         Enabled = true,
    ///         Tags = 
    ///         {
    ///             { "baz", "qux" },
    ///             { "foo", "bar" },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [CplnResourceType("cpln:index/customLocation:CustomLocation")]
    public partial class CustomLocation : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Cloud Provider of the custom location.
        /// </summary>
        [Output("cloudProvider")]
        public Output<string> CloudProvider { get; private set; } = null!;

        /// <summary>
        /// The ID, in GUID format, of the custom location.
        /// </summary>
        [Output("cplnId")]
        public Output<string> CplnId { get; private set; } = null!;

        /// <summary>
        /// Description of the custom location.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Indication if the custom location is enabled.
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Name of the custom location.
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
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a CustomLocation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CustomLocation(string name, CustomLocationArgs args, CustomResourceOptions? options = null)
            : base("cpln:index/customLocation:CustomLocation", name, args ?? new CustomLocationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CustomLocation(string name, Input<string> id, CustomLocationState? state = null, CustomResourceOptions? options = null)
            : base("cpln:index/customLocation:CustomLocation", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CustomLocation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CustomLocation Get(string name, Input<string> id, CustomLocationState? state = null, CustomResourceOptions? options = null)
        {
            return new CustomLocation(name, id, state, options);
        }
    }

    public sealed class CustomLocationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cloud Provider of the custom location.
        /// </summary>
        [Input("cloudProvider", required: true)]
        public Input<string> CloudProvider { get; set; } = null!;

        /// <summary>
        /// Description of the custom location.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Indication if the custom location is enabled.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Name of the custom location.
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

        public CustomLocationArgs()
        {
        }
        public static new CustomLocationArgs Empty => new CustomLocationArgs();
    }

    public sealed class CustomLocationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cloud Provider of the custom location.
        /// </summary>
        [Input("cloudProvider")]
        public Input<string>? CloudProvider { get; set; }

        /// <summary>
        /// The ID, in GUID format, of the custom location.
        /// </summary>
        [Input("cplnId")]
        public Input<string>? CplnId { get; set; }

        /// <summary>
        /// Description of the custom location.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Indication if the custom location is enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Name of the custom location.
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

        public CustomLocationState()
        {
        }
        public static new CustomLocationState Empty => new CustomLocationState();
    }
}
