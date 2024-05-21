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
    /// Manages a Mk8s's [Mk8s](https://docs.controlplane.com/mk8s/overview).
    /// 
    /// ## Declaration
    /// 
    /// ### Required
    /// 
    /// - **name** (String) Name of the Mk8s.
    /// - **version** (String)
    /// 
    /// &gt; **Note** Only one of the providers listed below can be included in a resource.
    /// 
    /// - **generic_provider** (Block List, Max: 1) (see below)
    /// - **hetzner_provider** (Block List, Max: 1) (see below)
    /// - **aws_provider** (Block List, Max: 1) (see below)
    /// 
    /// ### Optional
    /// 
    /// - **description** (String) Description of the Mk8s.
    /// - **tags** (Map of String) Key-value map of resource tags.
    /// - **firewall** (Block List, Max: 1) (see below)
    /// - **add_ons** (Block List, Max: 1) (see below)
    /// 
    /// &lt;a id="nestedblock--generic_provider"&gt;&lt;/a&gt;
    /// 
    /// ### `generic_provider`
    /// 
    /// Required:
    /// 
    /// - **location** (String) Control Plane location that will host the K8S components. Prefer one that is closest to where the nodes are running.
    /// 
    /// Optional:
    /// 
    /// - **networking** (Block List, Max: 1) (see below)
    /// - **node_pool** (Block List) (see below)
    /// 
    /// &lt;a id="nestedblock--generic_provider--networking"&gt;&lt;/a&gt;
    /// 
    /// ### `generic_provider.networking`
    /// 
    /// Optional:
    /// 
    /// - **service_network** (String) The CIDR of the service network.
    /// - **pod_network** (String) The CIDR of the pod network.
    /// 
    /// &lt;a id="nestedblock--generic_provider--node_pool"&gt;&lt;/a&gt;
    /// 
    /// ### `generic_provider.node_pool`
    /// 
    /// List of node pools.
    /// 
    /// Required:
    /// 
    /// - **name** (String)
    /// 
    /// Optional:
    /// 
    /// - **labels** (Map of String) Labels to attach to nodes of a node pool.
    /// - **taint** (Block List) (see below)
    /// 
    /// &lt;a id="nestedblock--generic_provider--node_pool--taint"&gt;&lt;/a&gt;
    /// 
    /// ### `generic_provider.node_pool.taint`
    /// 
    /// Taint for the nodes of a pool.
    /// 
    /// Optional:
    /// 
    /// - **key** (String)
    /// - **value** (String)
    /// - **effect** (String)
    /// 
    /// &lt;a id="nestedblock--hetzner_provider"&gt;&lt;/a&gt;
    /// 
    /// ### `hetzner_provider`
    /// 
    /// Required:
    /// 
    /// - **region** (String) Hetzner region to deploy nodes to.
    /// - **token_secret_link** (String) Link to a secret holding Hetzner access key.
    /// - **network_id** (String) ID of the Hetzner network to deploy nodes to.
    /// 
    /// Optional:
    /// 
    /// - **hetzner_labels** (Map of String) Extra labels to attach to servers.
    /// - **networking** (Block List, Max: 1) (see below)
    /// - **pre_install_script** (String) Optional shell script that will be run before K8S is installed.
    /// - **firewall_id** (String) Optional firewall rule to attach to all nodes.
    /// - **node_pool** (Block List) (see below)
    /// - **dedicated_server_node_pool** (Block List) (see below)
    /// - **image** (String) Default image for all nodes.
    /// - **ssh_key** (String) SSH key name for accessing deployed nodes.
    /// - **autoscaler** (Block List, Max: 1) (see below)
    /// 
    /// &lt;a id="nestedblock--hetzner_provider--node_pool"&gt;&lt;/a&gt;
    /// 
    /// ### `hetzner_provider.node_pool`
    /// 
    /// List of node pools.
    /// 
    /// Required:
    /// 
    /// - **name** (String)
    /// - **server_type** (String)
    /// 
    /// Optional:
    /// 
    /// - **labels** (Map of String) Labels to attach to nodes of a node pool.
    /// - **taint** (Block List) (see below)
    /// - **override_image** (String)
    /// - **min_size** (Number)
    /// - **max_size** (Number)
    /// 
    /// &lt;a id="nestedblock--hetzner_provider--dedicated_server_node_pool"&gt;&lt;/a&gt;
    /// 
    /// ### `hetzner_provider.dedicated_server_node_pool`
    /// 
    /// Node pool that can configure dedicated Hetzner servers.
    /// 
    /// Required:
    /// 
    /// - **name** (String)
    /// 
    /// Optional:
    /// 
    /// - **labels** (Map of String) Labels to attach to nodes of a node pool.
    /// - **taint** (Block List) (see below)
    /// 
    /// &lt;a id="nestedblock--aws_provider"&gt;&lt;/a&gt;
    /// 
    /// ### `aws_provider`
    /// 
    /// Required:
    /// 
    /// - **region** (String) Region where the cluster nodes will live.
    /// - **skip_create_roles** (Boolean) If true, Control Plane will not create any roles.
    /// - **image** (Block List, Max: 1) (see below)
    /// - **deploy_role_arn** (String) Control Plane will set up the cluster by assuming this role.
    /// - **vpc_id** (String) The vpc where nodes will be deployed. Supports SSM.
    /// 
    /// Optional:
    /// 
    /// - **aws_tags** (Map of String) Extra tags to attach to all created objects.
    /// - **networking** (Block List, Max: 1) (see below)
    /// - **pre_install_script** (String) Optional shell script that will be run before K8S is installed. Supports SSM.
    /// - **key_pair** (String) Name of keyPair. Supports SSM
    /// - **disk_encryption_key_arn** (String) KMS key used to encrypt volumes. Supports SSM.
    /// - **security_group_ids** (List of String) Security groups to deploy nodes to. Security groups control if the cluster is multi-zone or single-zon.
    /// - **node_pool** (Block List) (see below)
    /// - **autoscaler** (Block List, Max: 1) (see below)
    /// 
    /// &lt;a id="nestedblock--aws_provider--node_pool"&gt;&lt;/a&gt;
    /// 
    /// ### `aws_provider.node_pool`
    /// 
    /// List of node pools.
    /// 
    /// Required:
    /// 
    /// - **name** (String)
    /// - **instance_types** (List of String)
    /// - **override_image** (Block List, Max: 1) (see below)
    /// - **subnet_ids** (List of String)
    /// 
    /// Optional:
    /// 
    /// - **labels** (Map of String) Labels to attach to nodes of a node pool.
    /// - **taint** (Block List) (see below)
    /// - **boot_disk_size** (Number) Size in GB.
    /// - **min_size** (Number)
    /// - **max_size** (Number)
    /// - **on_demand_base_capacity** (Number)
    /// - **on_demand_percentage_above_base_capacity** (Number)
    /// - **spot_allocation_strategy** (String)
    /// - **extra_security_group_ids** (List of String)
    /// 
    /// &lt;a id="nestedblock--aws_provider--ami"&gt;&lt;/a&gt;
    /// 
    /// ### `ami`
    /// 
    /// Default image for all nodes.
    /// 
    /// Required:
    /// 
    /// &gt; **Note** Only one of the following listed below can be included.
    /// 
    /// - **recommended** (String)
    /// - **exact** (String) Support SSM.
    /// 
    /// &lt;a id="nestedblock--autoscaler"&gt;&lt;/a&gt;
    /// 
    /// ### `autoscaler`
    /// 
    /// Optional:
    /// 
    /// - **expander** (List of String)
    /// - **unneeded_time** (String)
    /// - **unready_time** (String)
    /// - **utilization_threshold** (Float64)
    /// 
    /// &lt;a id="nestedblock--firewall"&gt;&lt;/a&gt;
    /// 
    /// ### `firewall`
    /// 
    /// Allow-list.
    /// 
    /// Required:
    /// 
    /// - **source_cidr** (String)
    /// 
    /// Optional:
    /// 
    /// - **description** (String)
    /// 
    /// &lt;a id="nestedblock--add_ons"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons`
    /// 
    /// Optional:
    /// 
    /// - **dashboard** (Boolean)
    /// - **azure_workload_identity** (Block List, Max: 1) (see below)
    /// - **aws_workload_identity** (Boolean)
    /// - **local_path_storage** (Boolean)
    /// - **metrics** (Block List, Max: 1) (see below)
    /// - **logs** (Block List, Max: 1) (see below)
    /// - **nvidia** (Block List, Max: 1) (see below)
    /// - **aws_efs** (Block List, Max: 1) (see below)
    /// - **aws_ecr** (Block List, Max: 1) (see below)
    /// - **aws_elb** (Block List, Max: 1) (see below)
    /// - **azure_acr** (Block List, Max: 1) (see below)
    /// - **sysbox** (Boolean)
    /// 
    /// &lt;a id="nestedblock--add_ons--azure_workload_identity"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons.azure_workload_identity`
    /// 
    /// Required:
    /// 
    /// - **tenant_id** (String) Tenant ID to use for workload identity.
    /// 
    /// &lt;a id="nestedblock--add_ons--metrics"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons.metrics`
    /// 
    /// Optional:
    /// 
    /// - **kube_state** (Boolean) Enable kube-state metrics.
    /// - **core_dns** (Boolean) Enable scraping of core-dns service.
    /// - **kubelet** (Boolean) Enable scraping kubelet stats.
    /// - **api_server** (Boolean) Enable scraping apiserver stats.
    /// - **node_exporter** (Boolean) Enable collecting node-level stats (disk, network, filesystem, etc).
    /// - **cadvisor** (Boolean) Enable CNI-level container stats.
    /// - **scrape_annotated** (Block List, Max: 1) (see below)
    /// 
    /// &lt;a id="nestedblock--add_ons--metrics--scrape-annotated"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons.metrics.scrape-annotated`
    /// 
    /// Scrape pods annotated with prometheus.io/scrape=true.
    /// 
    /// Optional:
    /// 
    /// - **interval_seconds** (Number)
    /// - **include_namespaces** (String)
    /// - **exclude_namespaces** (String)
    /// - **retain_labels** (String)
    /// 
    /// &lt;a id="nestedblock--add_ons--logs"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons.logs`
    /// 
    /// Optional:
    /// 
    /// - **audit_enabled** (Boolean) Collect k8s audit log as log events.
    /// - **include_namespaces** (String)
    /// - **exclude_namespaces** (String)
    /// 
    /// &lt;a id="nestedblock--add_ons--nvidia"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons.nvidia`
    /// 
    /// Required:
    /// 
    /// - **taint_gpu_nodes** (Boolean)
    /// 
    /// &lt;a id="nestedblock--add_ons--aws--efs"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons.aws_efs`
    /// 
    /// Required:
    /// 
    /// - **role_arn** (String) Use this role for EFS interaction.
    /// 
    /// &lt;a id="nestedblock--add_ons--aws--ecr"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons.aws_ecr`
    /// 
    /// Required:
    /// 
    /// - **role_arn** (String) Role to use when authorizing ECR pulls. Optional on AWS, in which case it will use the instance role to pull.
    /// 
    /// &lt;a id="nestedblock--add_ons--aws--elb"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons.aws_elb`
    /// 
    /// Required:
    /// 
    /// - **role_arn** (String) Role to use when authorizing calls to EC2 ELB. Optional on AWS, when not provided it will create the recommended role.
    /// 
    /// &lt;a id="nestedblock--add_ons--azure_acr"&gt;&lt;/a&gt;
    /// 
    /// ### `add_ons.azure_acr`
    /// 
    /// Required:
    /// 
    /// - **client_id** (String)
    /// 
    /// ## Outputs
    /// 
    /// The following attributes are exported:
    /// 
    /// - **cpln_id** (String) The ID, in GUID format, of the Mk8s.
    /// - **alias** (String) The alias name of the Mk8s.
    /// - **self_link** (String) Full link to this resource. Can be referenced by other resources.
    /// - **status** (Block List, Max: 1) (see below).
    /// 
    /// &lt;a id="nestedblock--status"&gt;&lt;/a&gt;
    /// 
    /// ### `status`
    /// 
    /// Status of the mk8s.
    /// 
    /// Read-Only:
    /// 
    /// - **oidc_provider_url** (String)
    /// - **server_url** (String)
    /// - **home_location** (String)
    /// - **add_ons** (Block List, Max: 1) (see below)
    /// 
    /// &lt;a id="nestedblock--status--add_ons"&gt;&lt;/a&gt;
    /// 
    /// ### `status.add_ons`
    /// 
    /// Read-Only:
    /// 
    /// - **dashboard** (Block List, Max: 1) (see below)
    /// - **aws_workload_identity** (Block List, Max: 1) (see below)
    /// - **metrics** (Block List, Max: 1) (see below)
    /// - **logs** (Block List, Max: 1) (see below)
    /// - **aws_ecr** (Block List, Max: 1) (see below)
    /// - **aws_efs** (Block List, Max: 1) (see below)
    /// - **aws_elb** (Block List, Max: 1) (see below)
    /// 
    /// &lt;a id="nestedblock--status--add_ons--dashobard"&gt;&lt;/a&gt;
    /// 
    /// ### `status.add_ons.dashboard`
    /// 
    /// Read-Only:
    /// 
    /// - **url** (String) Access to dashboard.
    /// 
    /// &lt;a id="nestedblock--status--add_ons--aws_workload_identity"&gt;&lt;/a&gt;
    /// 
    /// ### `status.add_ons.aws_workload_identity`
    /// 
    /// Read-Only:
    /// 
    /// - **oidc_provider_config** (Block List, Max: 1) (see below)
    /// - **trust_policy** (String)
    /// 
    /// &lt;a id="nestedblock--status--add_ons--aws_workload_identity--oidc_provider_config"&gt;&lt;/a&gt;
    /// 
    /// ### `status.add_ons.aws_workload_identity.oidc_provider_config`
    /// 
    /// Read-Only:
    /// 
    /// - **provider_url** (String)
    /// - **audience** (String)
    /// 
    /// &lt;a id="nestedblock--status--add_ons--metrics"&gt;&lt;/a&gt;
    /// 
    /// ### `status.add_ons.metrics`
    /// 
    /// Read-Only:
    /// 
    /// - **prometheus_endpoint** (String)
    /// - **remote_write_config** (String)
    /// 
    /// &lt;a id="nestedblock--status--add_ons--logs"&gt;&lt;/a&gt;
    /// 
    /// ### `status.add_ons.logs`
    /// 
    /// Read-Only:
    /// 
    /// - **loki_address** (String) Loki endpoint to query logs from.
    /// 
    /// &lt;a id="nestedblock--status--add_ons--aws"&gt;&lt;/a&gt;
    /// 
    /// ### `status.add_ons.aws`
    /// 
    /// Read-Only:
    /// 
    /// - **trust_policy** (String)
    /// 
    /// ## Example Usage
    /// </summary>
    [CplnResourceType("cpln:index/mk8s:Mk8s")]
    public partial class Mk8s : global::Pulumi.CustomResource
    {
        [Output("addOns")]
        public Output<Outputs.Mk8sAddOns?> AddOns { get; private set; } = null!;

        /// <summary>
        /// The alias name of the Mk8s.
        /// </summary>
        [Output("alias")]
        public Output<string> Alias { get; private set; } = null!;

        [Output("awsProvider")]
        public Output<Outputs.Mk8sAwsProvider?> AwsProvider { get; private set; } = null!;

        /// <summary>
        /// The ID, in GUID format, of the Mk8s.
        /// </summary>
        [Output("cplnId")]
        public Output<string> CplnId { get; private set; } = null!;

        /// <summary>
        /// Description of the Mk8s.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Allow-list.
        /// </summary>
        [Output("firewalls")]
        public Output<ImmutableArray<Outputs.Mk8sFirewall>> Firewalls { get; private set; } = null!;

        [Output("genericProvider")]
        public Output<Outputs.Mk8sGenericProvider?> GenericProvider { get; private set; } = null!;

        [Output("hetznerProvider")]
        public Output<Outputs.Mk8sHetznerProvider?> HetznerProvider { get; private set; } = null!;

        /// <summary>
        /// Name of the Mk8s.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// Status of the mk8s.
        /// </summary>
        [Output("statuses")]
        public Output<ImmutableArray<Outputs.Mk8sStatus>> Statuses { get; private set; } = null!;

        /// <summary>
        /// Key-value map of resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Mk8s resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Mk8s(string name, Mk8sArgs args, CustomResourceOptions? options = null)
            : base("cpln:index/mk8s:Mk8s", name, args ?? new Mk8sArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Mk8s(string name, Input<string> id, Mk8sState? state = null, CustomResourceOptions? options = null)
            : base("cpln:index/mk8s:Mk8s", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Mk8s resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Mk8s Get(string name, Input<string> id, Mk8sState? state = null, CustomResourceOptions? options = null)
        {
            return new Mk8s(name, id, state, options);
        }
    }

    public sealed class Mk8sArgs : global::Pulumi.ResourceArgs
    {
        [Input("addOns")]
        public Input<Inputs.Mk8sAddOnsArgs>? AddOns { get; set; }

        [Input("awsProvider")]
        public Input<Inputs.Mk8sAwsProviderArgs>? AwsProvider { get; set; }

        /// <summary>
        /// Description of the Mk8s.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("firewalls")]
        private InputList<Inputs.Mk8sFirewallArgs>? _firewalls;

        /// <summary>
        /// Allow-list.
        /// </summary>
        public InputList<Inputs.Mk8sFirewallArgs> Firewalls
        {
            get => _firewalls ?? (_firewalls = new InputList<Inputs.Mk8sFirewallArgs>());
            set => _firewalls = value;
        }

        [Input("genericProvider")]
        public Input<Inputs.Mk8sGenericProviderArgs>? GenericProvider { get; set; }

        [Input("hetznerProvider")]
        public Input<Inputs.Mk8sHetznerProviderArgs>? HetznerProvider { get; set; }

        /// <summary>
        /// Name of the Mk8s.
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

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public Mk8sArgs()
        {
        }
        public static new Mk8sArgs Empty => new Mk8sArgs();
    }

    public sealed class Mk8sState : global::Pulumi.ResourceArgs
    {
        [Input("addOns")]
        public Input<Inputs.Mk8sAddOnsGetArgs>? AddOns { get; set; }

        /// <summary>
        /// The alias name of the Mk8s.
        /// </summary>
        [Input("alias")]
        public Input<string>? Alias { get; set; }

        [Input("awsProvider")]
        public Input<Inputs.Mk8sAwsProviderGetArgs>? AwsProvider { get; set; }

        /// <summary>
        /// The ID, in GUID format, of the Mk8s.
        /// </summary>
        [Input("cplnId")]
        public Input<string>? CplnId { get; set; }

        /// <summary>
        /// Description of the Mk8s.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("firewalls")]
        private InputList<Inputs.Mk8sFirewallGetArgs>? _firewalls;

        /// <summary>
        /// Allow-list.
        /// </summary>
        public InputList<Inputs.Mk8sFirewallGetArgs> Firewalls
        {
            get => _firewalls ?? (_firewalls = new InputList<Inputs.Mk8sFirewallGetArgs>());
            set => _firewalls = value;
        }

        [Input("genericProvider")]
        public Input<Inputs.Mk8sGenericProviderGetArgs>? GenericProvider { get; set; }

        [Input("hetznerProvider")]
        public Input<Inputs.Mk8sHetznerProviderGetArgs>? HetznerProvider { get; set; }

        /// <summary>
        /// Name of the Mk8s.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        [Input("statuses")]
        private InputList<Inputs.Mk8sStatusGetArgs>? _statuses;

        /// <summary>
        /// Status of the mk8s.
        /// </summary>
        public InputList<Inputs.Mk8sStatusGetArgs> Statuses
        {
            get => _statuses ?? (_statuses = new InputList<Inputs.Mk8sStatusGetArgs>());
            set => _statuses = value;
        }

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

        [Input("version")]
        public Input<string>? Version { get; set; }

        public Mk8sState()
        {
        }
        public static new Mk8sState Empty => new Mk8sState();
    }
}
