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
    [CplnResourceType("cpln:index/org:Org")]
    public partial class Org : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
        /// obtained from the `Org Management &amp; Billing` page.
        /// </summary>
        [Output("accountId")]
        public Output<string?> AccountId { get; private set; } = null!;

        [Output("authConfig")]
        public Output<Outputs.OrgAuthConfig?> AuthConfig { get; private set; } = null!;

        /// <summary>
        /// The ID, in GUID format, of the org.
        /// </summary>
        [Output("cplnId")]
        public Output<string> CplnId { get; private set; } = null!;

        /// <summary>
        /// The description of org.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
        /// the `superusers` group. The user account used when creating the org will be included in this list.
        /// </summary>
        [Output("invitees")]
        public Output<ImmutableArray<string>> Invitees { get; private set; } = null!;

        /// <summary>
        /// The name of the org.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
        /// </summary>
        [Output("observability")]
        public Output<Outputs.OrgObservability> Observability { get; private set; } = null!;

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
        /// </summary>
        [Output("sessionTimeoutSeconds")]
        public Output<int?> SessionTimeoutSeconds { get; private set; } = null!;

        /// <summary>
        /// Status of the org.
        /// </summary>
        [Output("statuses")]
        public Output<ImmutableArray<Outputs.OrgStatus>> Statuses { get; private set; } = null!;

        /// <summary>
        /// Key-value map of the org's tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Org resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Org(string name, OrgArgs args, CustomResourceOptions? options = null)
            : base("cpln:index/org:Org", name, args ?? new OrgArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Org(string name, Input<string> id, OrgState? state = null, CustomResourceOptions? options = null)
            : base("cpln:index/org:Org", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Org resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Org Get(string name, Input<string> id, OrgState? state = null, CustomResourceOptions? options = null)
        {
            return new Org(name, id, state, options);
        }
    }

    public sealed class OrgArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
        /// obtained from the `Org Management &amp; Billing` page.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        [Input("authConfig")]
        public Input<Inputs.OrgAuthConfigArgs>? AuthConfig { get; set; }

        /// <summary>
        /// The description of org.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("invitees")]
        private InputList<string>? _invitees;

        /// <summary>
        /// When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
        /// the `superusers` group. The user account used when creating the org will be included in this list.
        /// </summary>
        public InputList<string> Invitees
        {
            get => _invitees ?? (_invitees = new InputList<string>());
            set => _invitees = value;
        }

        /// <summary>
        /// The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
        /// </summary>
        [Input("observability", required: true)]
        public Input<Inputs.OrgObservabilityArgs> Observability { get; set; } = null!;

        /// <summary>
        /// The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
        /// </summary>
        [Input("sessionTimeoutSeconds")]
        public Input<int>? SessionTimeoutSeconds { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value map of the org's tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public OrgArgs()
        {
        }
        public static new OrgArgs Empty => new OrgArgs();
    }

    public sealed class OrgState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The associated account ID that will be used when creating the org. Only used on org creation. The account ID can be
        /// obtained from the `Org Management &amp; Billing` page.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        [Input("authConfig")]
        public Input<Inputs.OrgAuthConfigGetArgs>? AuthConfig { get; set; }

        /// <summary>
        /// The ID, in GUID format, of the org.
        /// </summary>
        [Input("cplnId")]
        public Input<string>? CplnId { get; set; }

        /// <summary>
        /// The description of org.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("invitees")]
        private InputList<string>? _invitees;

        /// <summary>
        /// When an org is created, the list of email addresses which will receive an invitation to join the org and be assigned to
        /// the `superusers` group. The user account used when creating the org will be included in this list.
        /// </summary>
        public InputList<string> Invitees
        {
            get => _invitees ?? (_invitees = new InputList<string>());
            set => _invitees = value;
        }

        /// <summary>
        /// The name of the org.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The retention period (in days) for logs, metrics, and traces. Charges apply for storage beyond the 30 day default.
        /// </summary>
        [Input("observability")]
        public Input<Inputs.OrgObservabilityGetArgs>? Observability { get; set; }

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        /// <summary>
        /// The idle time (in seconds) in which the console UI will automatically sign-out the user. Default: 900 (15 minutes)
        /// </summary>
        [Input("sessionTimeoutSeconds")]
        public Input<int>? SessionTimeoutSeconds { get; set; }

        [Input("statuses")]
        private InputList<Inputs.OrgStatusGetArgs>? _statuses;

        /// <summary>
        /// Status of the org.
        /// </summary>
        public InputList<Inputs.OrgStatusGetArgs> Statuses
        {
            get => _statuses ?? (_statuses = new InputList<Inputs.OrgStatusGetArgs>());
            set => _statuses = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value map of the org's tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public OrgState()
        {
        }
        public static new OrgState Empty => new OrgState();
    }
}
