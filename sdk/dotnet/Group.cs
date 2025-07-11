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
    [CplnResourceType("cpln:index/group:Group")]
    public partial class Group : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The ID, in GUID format, of the Group.
        /// </summary>
        [Output("cplnId")]
        public Output<string> CplnId { get; private set; } = null!;

        /// <summary>
        /// Description of the Group.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
        /// for managing the grouping of users logged-in with SAML providers.
        /// </summary>
        [Output("identityMatcher")]
        public Output<Outputs.GroupIdentityMatcher?> IdentityMatcher { get; private set; } = null!;

        /// <summary>
        /// A predefined set of criteria or conditions used to query and retrieve members within the group.
        /// </summary>
        [Output("memberQuery")]
        public Output<Outputs.GroupMemberQuery?> MemberQuery { get; private set; } = null!;

        /// <summary>
        /// Name of the Group.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Origin of the service account. Either `builtin` or `default`.
        /// </summary>
        [Output("origin")]
        public Output<string> Origin { get; private set; } = null!;

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// List of service accounts that exists within the configured org. Group membership will fail if the service account does
        /// not exits within the org.
        /// </summary>
        [Output("serviceAccounts")]
        public Output<ImmutableArray<string>> ServiceAccounts { get; private set; } = null!;

        /// <summary>
        /// Key-value map of resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>> Tags { get; private set; } = null!;

        /// <summary>
        /// List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
        /// if the user ID / email does not exist within the org.
        /// </summary>
        [Output("userIdsAndEmails")]
        public Output<ImmutableArray<string>> UserIdsAndEmails { get; private set; } = null!;


        /// <summary>
        /// Create a Group resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Group(string name, GroupArgs? args = null, CustomResourceOptions? options = null)
            : base("cpln:index/group:Group", name, args ?? new GroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Group(string name, Input<string> id, GroupState? state = null, CustomResourceOptions? options = null)
            : base("cpln:index/group:Group", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Group resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Group Get(string name, Input<string> id, GroupState? state = null, CustomResourceOptions? options = null)
        {
            return new Group(name, id, state, options);
        }
    }

    public sealed class GroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the Group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
        /// for managing the grouping of users logged-in with SAML providers.
        /// </summary>
        [Input("identityMatcher")]
        public Input<Inputs.GroupIdentityMatcherArgs>? IdentityMatcher { get; set; }

        /// <summary>
        /// A predefined set of criteria or conditions used to query and retrieve members within the group.
        /// </summary>
        [Input("memberQuery")]
        public Input<Inputs.GroupMemberQueryArgs>? MemberQuery { get; set; }

        /// <summary>
        /// Name of the Group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("serviceAccounts")]
        private InputList<string>? _serviceAccounts;

        /// <summary>
        /// List of service accounts that exists within the configured org. Group membership will fail if the service account does
        /// not exits within the org.
        /// </summary>
        public InputList<string> ServiceAccounts
        {
            get => _serviceAccounts ?? (_serviceAccounts = new InputList<string>());
            set => _serviceAccounts = value;
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

        [Input("userIdsAndEmails")]
        private InputList<string>? _userIdsAndEmails;

        /// <summary>
        /// List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
        /// if the user ID / email does not exist within the org.
        /// </summary>
        public InputList<string> UserIdsAndEmails
        {
            get => _userIdsAndEmails ?? (_userIdsAndEmails = new InputList<string>());
            set => _userIdsAndEmails = value;
        }

        public GroupArgs()
        {
        }
        public static new GroupArgs Empty => new GroupArgs();
    }

    public sealed class GroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID, in GUID format, of the Group.
        /// </summary>
        [Input("cplnId")]
        public Input<string>? CplnId { get; set; }

        /// <summary>
        /// Description of the Group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Executes the expression against the users' claims to decide whether a user belongs to this group. This method is useful
        /// for managing the grouping of users logged-in with SAML providers.
        /// </summary>
        [Input("identityMatcher")]
        public Input<Inputs.GroupIdentityMatcherGetArgs>? IdentityMatcher { get; set; }

        /// <summary>
        /// A predefined set of criteria or conditions used to query and retrieve members within the group.
        /// </summary>
        [Input("memberQuery")]
        public Input<Inputs.GroupMemberQueryGetArgs>? MemberQuery { get; set; }

        /// <summary>
        /// Name of the Group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Origin of the service account. Either `builtin` or `default`.
        /// </summary>
        [Input("origin")]
        public Input<string>? Origin { get; set; }

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        [Input("serviceAccounts")]
        private InputList<string>? _serviceAccounts;

        /// <summary>
        /// List of service accounts that exists within the configured org. Group membership will fail if the service account does
        /// not exits within the org.
        /// </summary>
        public InputList<string> ServiceAccounts
        {
            get => _serviceAccounts ?? (_serviceAccounts = new InputList<string>());
            set => _serviceAccounts = value;
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

        [Input("userIdsAndEmails")]
        private InputList<string>? _userIdsAndEmails;

        /// <summary>
        /// List of either the user ID or email address for a user that exists within the configured org. Group membership will fail
        /// if the user ID / email does not exist within the org.
        /// </summary>
        public InputList<string> UserIdsAndEmails
        {
            get => _userIdsAndEmails ?? (_userIdsAndEmails = new InputList<string>());
            set => _userIdsAndEmails = value;
        }

        public GroupState()
        {
        }
        public static new GroupState Empty => new GroupState();
    }
}
