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
    [CplnResourceType("cpln:index/volumeSet:VolumeSet")]
    public partial class VolumeSet : global::Pulumi.CustomResource
    {
        [Output("autoscaling")]
        public Output<Outputs.VolumeSetAutoscaling?> Autoscaling { get; private set; } = null!;

        /// <summary>
        /// ID, in GUID format, of the Volume Set.
        /// </summary>
        [Output("cplnId")]
        public Output<string> CplnId { get; private set; } = null!;

        /// <summary>
        /// Description of the Volume Set.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        /// </summary>
        [Output("fileSystemType")]
        public Output<string?> FileSystemType { get; private set; } = null!;

        /// <summary>
        /// Name of the associated GVC.
        /// </summary>
        [Output("gvc")]
        public Output<string> Gvc { get; private set; } = null!;

        /// <summary>
        /// The initial size in GB of volumes in this set. Minimum value: `10`.
        /// </summary>
        [Output("initialCapacity")]
        public Output<int> InitialCapacity { get; private set; } = null!;

        /// <summary>
        /// Name of the Volume Set.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
        /// `high-throughput-ssd`
        /// </summary>
        [Output("performanceClass")]
        public Output<string> PerformanceClass { get; private set; } = null!;

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        [Output("snapshots")]
        public Output<Outputs.VolumeSetSnapshots?> Snapshots { get; private set; } = null!;

        /// <summary>
        /// Status of the Volume Set.
        /// </summary>
        [Output("statuses")]
        public Output<ImmutableArray<Outputs.VolumeSetStatus>> Statuses { get; private set; } = null!;

        /// <summary>
        /// For self-hosted locations only. The storage class used for volumes in this set will be
        /// {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
        /// {performanceClass}-{fileSystemType}
        /// </summary>
        [Output("storageClassSuffix")]
        public Output<string?> StorageClassSuffix { get; private set; } = null!;

        /// <summary>
        /// Key-value map of resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Output used when linking a volume set to a workload.
        /// </summary>
        [Output("volumesetLink")]
        public Output<string> VolumesetLink { get; private set; } = null!;


        /// <summary>
        /// Create a VolumeSet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VolumeSet(string name, VolumeSetArgs args, CustomResourceOptions? options = null)
            : base("cpln:index/volumeSet:VolumeSet", name, args ?? new VolumeSetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VolumeSet(string name, Input<string> id, VolumeSetState? state = null, CustomResourceOptions? options = null)
            : base("cpln:index/volumeSet:VolumeSet", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing VolumeSet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VolumeSet Get(string name, Input<string> id, VolumeSetState? state = null, CustomResourceOptions? options = null)
        {
            return new VolumeSet(name, id, state, options);
        }
    }

    public sealed class VolumeSetArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoscaling")]
        public Input<Inputs.VolumeSetAutoscalingArgs>? Autoscaling { get; set; }

        /// <summary>
        /// Description of the Volume Set.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        /// </summary>
        [Input("fileSystemType")]
        public Input<string>? FileSystemType { get; set; }

        /// <summary>
        /// Name of the associated GVC.
        /// </summary>
        [Input("gvc", required: true)]
        public Input<string> Gvc { get; set; } = null!;

        /// <summary>
        /// The initial size in GB of volumes in this set. Minimum value: `10`.
        /// </summary>
        [Input("initialCapacity", required: true)]
        public Input<int> InitialCapacity { get; set; } = null!;

        /// <summary>
        /// Name of the Volume Set.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
        /// `high-throughput-ssd`
        /// </summary>
        [Input("performanceClass", required: true)]
        public Input<string> PerformanceClass { get; set; } = null!;

        [Input("snapshots")]
        public Input<Inputs.VolumeSetSnapshotsArgs>? Snapshots { get; set; }

        /// <summary>
        /// For self-hosted locations only. The storage class used for volumes in this set will be
        /// {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
        /// {performanceClass}-{fileSystemType}
        /// </summary>
        [Input("storageClassSuffix")]
        public Input<string>? StorageClassSuffix { get; set; }

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

        public VolumeSetArgs()
        {
        }
        public static new VolumeSetArgs Empty => new VolumeSetArgs();
    }

    public sealed class VolumeSetState : global::Pulumi.ResourceArgs
    {
        [Input("autoscaling")]
        public Input<Inputs.VolumeSetAutoscalingGetArgs>? Autoscaling { get; set; }

        /// <summary>
        /// ID, in GUID format, of the Volume Set.
        /// </summary>
        [Input("cplnId")]
        public Input<string>? CplnId { get; set; }

        /// <summary>
        /// Description of the Volume Set.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Each volume set has a single, immutable file system. Valid types: `xfs` or `ext4`
        /// </summary>
        [Input("fileSystemType")]
        public Input<string>? FileSystemType { get; set; }

        /// <summary>
        /// Name of the associated GVC.
        /// </summary>
        [Input("gvc")]
        public Input<string>? Gvc { get; set; }

        /// <summary>
        /// The initial size in GB of volumes in this set. Minimum value: `10`.
        /// </summary>
        [Input("initialCapacity")]
        public Input<int>? InitialCapacity { get; set; }

        /// <summary>
        /// Name of the Volume Set.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Each volume set has a single, immutable, performance class. Valid classes: `general-purpose-ssd` or
        /// `high-throughput-ssd`
        /// </summary>
        [Input("performanceClass")]
        public Input<string>? PerformanceClass { get; set; }

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        [Input("snapshots")]
        public Input<Inputs.VolumeSetSnapshotsGetArgs>? Snapshots { get; set; }

        [Input("statuses")]
        private InputList<Inputs.VolumeSetStatusGetArgs>? _statuses;

        /// <summary>
        /// Status of the Volume Set.
        /// </summary>
        public InputList<Inputs.VolumeSetStatusGetArgs> Statuses
        {
            get => _statuses ?? (_statuses = new InputList<Inputs.VolumeSetStatusGetArgs>());
            set => _statuses = value;
        }

        /// <summary>
        /// For self-hosted locations only. The storage class used for volumes in this set will be
        /// {performanceClass}-{fileSystemType}-{storageClassSuffix} if it exists, otherwise it will be
        /// {performanceClass}-{fileSystemType}
        /// </summary>
        [Input("storageClassSuffix")]
        public Input<string>? StorageClassSuffix { get; set; }

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

        /// <summary>
        /// Output used when linking a volume set to a workload.
        /// </summary>
        [Input("volumesetLink")]
        public Input<string>? VolumesetLink { get; set; }

        public VolumeSetState()
        {
        }
        public static new VolumeSetState Empty => new VolumeSetState();
    }
}
