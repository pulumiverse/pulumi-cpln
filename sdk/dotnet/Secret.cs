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
    [CplnResourceType("cpln:index/secret:Secret")]
    public partial class Secret : global::Pulumi.CustomResource
    {
        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#aws).
        /// </summary>
        [Output("aws")]
        public Output<Outputs.SecretAws?> Aws { get; private set; } = null!;

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#azure-connector).
        /// </summary>
        [Output("azureConnector")]
        public Output<Outputs.SecretAzureConnector?> AzureConnector { get; private set; } = null!;

        /// <summary>
        /// JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#azure).
        /// </summary>
        [Output("azureSdk")]
        public Output<string?> AzureSdk { get; private set; } = null!;

        /// <summary>
        /// The ID, in GUID format, of the Secret.
        /// </summary>
        [Output("cplnId")]
        public Output<string> CplnId { get; private set; } = null!;

        /// <summary>
        /// Description of the Secret.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// List of unique key-value pairs. [Reference Page](https://docs.controlplane.com/reference/secret#dictionary).
        /// </summary>
        [Output("dictionary")]
        public Output<ImmutableDictionary<string, string>?> Dictionary { get; private set; } = null!;

        /// <summary>
        /// If a dictionary secret is defined, this output will be a key-value map in the following format: `key =
        /// cpln://secret/SECRET_NAME.key`.
        /// </summary>
        [Output("dictionaryAsEnvs")]
        public Output<ImmutableDictionary<string, object>> DictionaryAsEnvs { get; private set; } = null!;

        /// <summary>
        /// JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#docker).
        /// </summary>
        [Output("docker")]
        public Output<string?> Docker { get; private set; } = null!;

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#ecr)
        /// </summary>
        [Output("ecr")]
        public Output<Outputs.SecretEcr?> Ecr { get; private set; } = null!;

        /// <summary>
        /// JSON string containing the GCP secret. [Reference Page](https://docs.controlplane.com/reference/secret#gcp)
        /// </summary>
        [Output("gcp")]
        public Output<string?> Gcp { get; private set; } = null!;

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#keypair).
        /// </summary>
        [Output("keypair")]
        public Output<Outputs.SecretKeypair?> Keypair { get; private set; } = null!;

        /// <summary>
        /// Name of the secret.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#nats-account).
        /// </summary>
        [Output("natsAccount")]
        public Output<Outputs.SecretNatsAccount?> NatsAccount { get; private set; } = null!;

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#opaque).
        /// </summary>
        [Output("opaque")]
        public Output<Outputs.SecretOpaque?> Opaque { get; private set; } = null!;

        /// <summary>
        /// Output used when linking a secret to an environment variable or volume.
        /// </summary>
        [Output("secretLink")]
        public Output<string> SecretLink { get; private set; } = null!;

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
        /// [Reference Page](https://docs.controlplane.com/reference/secret#tls).
        /// </summary>
        [Output("tls")]
        public Output<Outputs.SecretTls?> Tls { get; private set; } = null!;

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#username).
        /// </summary>
        [Output("userpass")]
        public Output<Outputs.SecretUserpass?> Userpass { get; private set; } = null!;


        /// <summary>
        /// Create a Secret resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Secret(string name, SecretArgs? args = null, CustomResourceOptions? options = null)
            : base("cpln:index/secret:Secret", name, args ?? new SecretArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Secret(string name, Input<string> id, SecretState? state = null, CustomResourceOptions? options = null)
            : base("cpln:index/secret:Secret", name, state, MakeResourceOptions(options, id))
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
                    "azureSdk",
                    "docker",
                    "gcp",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Secret resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Secret Get(string name, Input<string> id, SecretState? state = null, CustomResourceOptions? options = null)
        {
            return new Secret(name, id, state, options);
        }
    }

    public sealed class SecretArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#aws).
        /// </summary>
        [Input("aws")]
        public Input<Inputs.SecretAwsArgs>? Aws { get; set; }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#azure-connector).
        /// </summary>
        [Input("azureConnector")]
        public Input<Inputs.SecretAzureConnectorArgs>? AzureConnector { get; set; }

        [Input("azureSdk")]
        private Input<string>? _azureSdk;

        /// <summary>
        /// JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#azure).
        /// </summary>
        public Input<string>? AzureSdk
        {
            get => _azureSdk;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _azureSdk = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Description of the Secret.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("dictionary")]
        private InputMap<string>? _dictionary;

        /// <summary>
        /// List of unique key-value pairs. [Reference Page](https://docs.controlplane.com/reference/secret#dictionary).
        /// </summary>
        public InputMap<string> Dictionary
        {
            get => _dictionary ?? (_dictionary = new InputMap<string>());
            set => _dictionary = value;
        }

        [Input("docker")]
        private Input<string>? _docker;

        /// <summary>
        /// JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#docker).
        /// </summary>
        public Input<string>? Docker
        {
            get => _docker;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _docker = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#ecr)
        /// </summary>
        [Input("ecr")]
        public Input<Inputs.SecretEcrArgs>? Ecr { get; set; }

        [Input("gcp")]
        private Input<string>? _gcp;

        /// <summary>
        /// JSON string containing the GCP secret. [Reference Page](https://docs.controlplane.com/reference/secret#gcp)
        /// </summary>
        public Input<string>? Gcp
        {
            get => _gcp;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _gcp = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#keypair).
        /// </summary>
        [Input("keypair")]
        public Input<Inputs.SecretKeypairArgs>? Keypair { get; set; }

        /// <summary>
        /// Name of the secret.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#nats-account).
        /// </summary>
        [Input("natsAccount")]
        public Input<Inputs.SecretNatsAccountArgs>? NatsAccount { get; set; }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#opaque).
        /// </summary>
        [Input("opaque")]
        public Input<Inputs.SecretOpaqueArgs>? Opaque { get; set; }

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
        /// [Reference Page](https://docs.controlplane.com/reference/secret#tls).
        /// </summary>
        [Input("tls")]
        public Input<Inputs.SecretTlsArgs>? Tls { get; set; }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#username).
        /// </summary>
        [Input("userpass")]
        public Input<Inputs.SecretUserpassArgs>? Userpass { get; set; }

        public SecretArgs()
        {
        }
        public static new SecretArgs Empty => new SecretArgs();
    }

    public sealed class SecretState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#aws).
        /// </summary>
        [Input("aws")]
        public Input<Inputs.SecretAwsGetArgs>? Aws { get; set; }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#azure-connector).
        /// </summary>
        [Input("azureConnector")]
        public Input<Inputs.SecretAzureConnectorGetArgs>? AzureConnector { get; set; }

        [Input("azureSdk")]
        private Input<string>? _azureSdk;

        /// <summary>
        /// JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#azure).
        /// </summary>
        public Input<string>? AzureSdk
        {
            get => _azureSdk;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _azureSdk = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The ID, in GUID format, of the Secret.
        /// </summary>
        [Input("cplnId")]
        public Input<string>? CplnId { get; set; }

        /// <summary>
        /// Description of the Secret.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("dictionary")]
        private InputMap<string>? _dictionary;

        /// <summary>
        /// List of unique key-value pairs. [Reference Page](https://docs.controlplane.com/reference/secret#dictionary).
        /// </summary>
        public InputMap<string> Dictionary
        {
            get => _dictionary ?? (_dictionary = new InputMap<string>());
            set => _dictionary = value;
        }

        [Input("dictionaryAsEnvs")]
        private InputMap<object>? _dictionaryAsEnvs;

        /// <summary>
        /// If a dictionary secret is defined, this output will be a key-value map in the following format: `key =
        /// cpln://secret/SECRET_NAME.key`.
        /// </summary>
        public InputMap<object> DictionaryAsEnvs
        {
            get => _dictionaryAsEnvs ?? (_dictionaryAsEnvs = new InputMap<object>());
            set => _dictionaryAsEnvs = value;
        }

        [Input("docker")]
        private Input<string>? _docker;

        /// <summary>
        /// JSON string containing the Docker secret. [Reference Page](https://docs.controlplane.com/reference/secret#docker).
        /// </summary>
        public Input<string>? Docker
        {
            get => _docker;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _docker = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#ecr)
        /// </summary>
        [Input("ecr")]
        public Input<Inputs.SecretEcrGetArgs>? Ecr { get; set; }

        [Input("gcp")]
        private Input<string>? _gcp;

        /// <summary>
        /// JSON string containing the GCP secret. [Reference Page](https://docs.controlplane.com/reference/secret#gcp)
        /// </summary>
        public Input<string>? Gcp
        {
            get => _gcp;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _gcp = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#keypair).
        /// </summary>
        [Input("keypair")]
        public Input<Inputs.SecretKeypairGetArgs>? Keypair { get; set; }

        /// <summary>
        /// Name of the secret.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#nats-account).
        /// </summary>
        [Input("natsAccount")]
        public Input<Inputs.SecretNatsAccountGetArgs>? NatsAccount { get; set; }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#opaque).
        /// </summary>
        [Input("opaque")]
        public Input<Inputs.SecretOpaqueGetArgs>? Opaque { get; set; }

        /// <summary>
        /// Output used when linking a secret to an environment variable or volume.
        /// </summary>
        [Input("secretLink")]
        public Input<string>? SecretLink { get; set; }

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

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#tls).
        /// </summary>
        [Input("tls")]
        public Input<Inputs.SecretTlsGetArgs>? Tls { get; set; }

        /// <summary>
        /// [Reference Page](https://docs.controlplane.com/reference/secret#username).
        /// </summary>
        [Input("userpass")]
        public Input<Inputs.SecretUserpassGetArgs>? Userpass { get; set; }

        public SecretState()
        {
        }
        public static new SecretState Empty => new SecretState();
    }
}
