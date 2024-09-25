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
    [CplnResourceType("cpln:index/location:Location")]
    public partial class Location : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Cloud Provider of the location.
        /// </summary>
        [Output("cloudProvider")]
        public Output<string> CloudProvider { get; private set; } = null!;

        /// <summary>
        /// The ID, in GUID format, of the location.
        /// </summary>
        [Output("cplnId")]
        public Output<string> CplnId { get; private set; } = null!;

        /// <summary>
        /// Description of the location.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Indication if location is enabled.
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        [Output("geos")]
        public Output<ImmutableArray<Outputs.LocationGeo>> Geos { get; private set; } = null!;

        /// <summary>
        /// A list of IP ranges of the location.
        /// </summary>
        [Output("ipRanges")]
        public Output<ImmutableArray<string>> IpRanges { get; private set; } = null!;

        /// <summary>
        /// Name of the Location.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Region of the location.
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

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
        /// Create a Location resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Location(string name, LocationArgs args, CustomResourceOptions? options = null)
            : base("cpln:index/location:Location", name, args ?? new LocationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Location(string name, Input<string> id, LocationState? state = null, CustomResourceOptions? options = null)
            : base("cpln:index/location:Location", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Location resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Location Get(string name, Input<string> id, LocationState? state = null, CustomResourceOptions? options = null)
        {
            return new Location(name, id, state, options);
        }
    }

    public sealed class LocationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indication if location is enabled.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Name of the Location.
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

        public LocationArgs()
        {
        }
        public static new LocationArgs Empty => new LocationArgs();
    }

    public sealed class LocationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cloud Provider of the location.
        /// </summary>
        [Input("cloudProvider")]
        public Input<string>? CloudProvider { get; set; }

        /// <summary>
        /// The ID, in GUID format, of the location.
        /// </summary>
        [Input("cplnId")]
        public Input<string>? CplnId { get; set; }

        /// <summary>
        /// Description of the location.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Indication if location is enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("geos")]
        private InputList<Inputs.LocationGeoGetArgs>? _geos;
        public InputList<Inputs.LocationGeoGetArgs> Geos
        {
            get => _geos ?? (_geos = new InputList<Inputs.LocationGeoGetArgs>());
            set => _geos = value;
        }

        [Input("ipRanges")]
        private InputList<string>? _ipRanges;

        /// <summary>
        /// A list of IP ranges of the location.
        /// </summary>
        public InputList<string> IpRanges
        {
            get => _ipRanges ?? (_ipRanges = new InputList<string>());
            set => _ipRanges = value;
        }

        /// <summary>
        /// Name of the Location.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Region of the location.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

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

        public LocationState()
        {
        }
        public static new LocationState Empty => new LocationState();
    }
}
