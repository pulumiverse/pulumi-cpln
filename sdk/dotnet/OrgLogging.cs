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
    [CplnResourceType("cpln:index/orgLogging:OrgLogging")]
    public partial class OrgLogging : global::Pulumi.CustomResource
    {
        [Output("cloudWatchLoggings")]
        public Output<ImmutableArray<Outputs.OrgLoggingCloudWatchLogging>> CloudWatchLoggings { get; private set; } = null!;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/coralogix)
        /// </summary>
        [Output("coralogixLoggings")]
        public Output<ImmutableArray<Outputs.OrgLoggingCoralogixLogging>> CoralogixLoggings { get; private set; } = null!;

        /// <summary>
        /// The ID, in GUID format, of the Org.
        /// </summary>
        [Output("cplnId")]
        public Output<string> CplnId { get; private set; } = null!;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/datadog)
        /// </summary>
        [Output("datadogLoggings")]
        public Output<ImmutableArray<Outputs.OrgLoggingDatadogLogging>> DatadogLoggings { get; private set; } = null!;

        /// <summary>
        /// Description of the Org.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// For logging and analyzing data within an org using Elastic Logging.
        /// </summary>
        [Output("elasticLoggings")]
        public Output<ImmutableArray<Outputs.OrgLoggingElasticLogging>> ElasticLoggings { get; private set; } = null!;

        [Output("fluentdLoggings")]
        public Output<ImmutableArray<Outputs.OrgLoggingFluentdLogging>> FluentdLoggings { get; private set; } = null!;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/logz-io)
        /// </summary>
        [Output("logzioLoggings")]
        public Output<ImmutableArray<Outputs.OrgLoggingLogzioLogging>> LogzioLoggings { get; private set; } = null!;

        /// <summary>
        /// Name of the Org.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/s3)
        /// </summary>
        [Output("s3Loggings")]
        public Output<ImmutableArray<Outputs.OrgLoggingS3Logging>> S3Loggings { get; private set; } = null!;

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        [Output("stackdriverLoggings")]
        public Output<ImmutableArray<Outputs.OrgLoggingStackdriverLogging>> StackdriverLoggings { get; private set; } = null!;

        [Output("syslogLoggings")]
        public Output<ImmutableArray<Outputs.OrgLoggingSyslogLogging>> SyslogLoggings { get; private set; } = null!;

        /// <summary>
        /// Key-value map of resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a OrgLogging resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OrgLogging(string name, OrgLoggingArgs? args = null, CustomResourceOptions? options = null)
            : base("cpln:index/orgLogging:OrgLogging", name, args ?? new OrgLoggingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OrgLogging(string name, Input<string> id, OrgLoggingState? state = null, CustomResourceOptions? options = null)
            : base("cpln:index/orgLogging:OrgLogging", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OrgLogging resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OrgLogging Get(string name, Input<string> id, OrgLoggingState? state = null, CustomResourceOptions? options = null)
        {
            return new OrgLogging(name, id, state, options);
        }
    }

    public sealed class OrgLoggingArgs : global::Pulumi.ResourceArgs
    {
        [Input("cloudWatchLoggings")]
        private InputList<Inputs.OrgLoggingCloudWatchLoggingArgs>? _cloudWatchLoggings;
        public InputList<Inputs.OrgLoggingCloudWatchLoggingArgs> CloudWatchLoggings
        {
            get => _cloudWatchLoggings ?? (_cloudWatchLoggings = new InputList<Inputs.OrgLoggingCloudWatchLoggingArgs>());
            set => _cloudWatchLoggings = value;
        }

        [Input("coralogixLoggings")]
        private InputList<Inputs.OrgLoggingCoralogixLoggingArgs>? _coralogixLoggings;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/coralogix)
        /// </summary>
        public InputList<Inputs.OrgLoggingCoralogixLoggingArgs> CoralogixLoggings
        {
            get => _coralogixLoggings ?? (_coralogixLoggings = new InputList<Inputs.OrgLoggingCoralogixLoggingArgs>());
            set => _coralogixLoggings = value;
        }

        [Input("datadogLoggings")]
        private InputList<Inputs.OrgLoggingDatadogLoggingArgs>? _datadogLoggings;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/datadog)
        /// </summary>
        public InputList<Inputs.OrgLoggingDatadogLoggingArgs> DatadogLoggings
        {
            get => _datadogLoggings ?? (_datadogLoggings = new InputList<Inputs.OrgLoggingDatadogLoggingArgs>());
            set => _datadogLoggings = value;
        }

        [Input("elasticLoggings")]
        private InputList<Inputs.OrgLoggingElasticLoggingArgs>? _elasticLoggings;

        /// <summary>
        /// For logging and analyzing data within an org using Elastic Logging.
        /// </summary>
        public InputList<Inputs.OrgLoggingElasticLoggingArgs> ElasticLoggings
        {
            get => _elasticLoggings ?? (_elasticLoggings = new InputList<Inputs.OrgLoggingElasticLoggingArgs>());
            set => _elasticLoggings = value;
        }

        [Input("fluentdLoggings")]
        private InputList<Inputs.OrgLoggingFluentdLoggingArgs>? _fluentdLoggings;
        public InputList<Inputs.OrgLoggingFluentdLoggingArgs> FluentdLoggings
        {
            get => _fluentdLoggings ?? (_fluentdLoggings = new InputList<Inputs.OrgLoggingFluentdLoggingArgs>());
            set => _fluentdLoggings = value;
        }

        [Input("logzioLoggings")]
        private InputList<Inputs.OrgLoggingLogzioLoggingArgs>? _logzioLoggings;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/logz-io)
        /// </summary>
        public InputList<Inputs.OrgLoggingLogzioLoggingArgs> LogzioLoggings
        {
            get => _logzioLoggings ?? (_logzioLoggings = new InputList<Inputs.OrgLoggingLogzioLoggingArgs>());
            set => _logzioLoggings = value;
        }

        [Input("s3Loggings")]
        private InputList<Inputs.OrgLoggingS3LoggingArgs>? _s3Loggings;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/s3)
        /// </summary>
        public InputList<Inputs.OrgLoggingS3LoggingArgs> S3Loggings
        {
            get => _s3Loggings ?? (_s3Loggings = new InputList<Inputs.OrgLoggingS3LoggingArgs>());
            set => _s3Loggings = value;
        }

        [Input("stackdriverLoggings")]
        private InputList<Inputs.OrgLoggingStackdriverLoggingArgs>? _stackdriverLoggings;
        public InputList<Inputs.OrgLoggingStackdriverLoggingArgs> StackdriverLoggings
        {
            get => _stackdriverLoggings ?? (_stackdriverLoggings = new InputList<Inputs.OrgLoggingStackdriverLoggingArgs>());
            set => _stackdriverLoggings = value;
        }

        [Input("syslogLoggings")]
        private InputList<Inputs.OrgLoggingSyslogLoggingArgs>? _syslogLoggings;
        public InputList<Inputs.OrgLoggingSyslogLoggingArgs> SyslogLoggings
        {
            get => _syslogLoggings ?? (_syslogLoggings = new InputList<Inputs.OrgLoggingSyslogLoggingArgs>());
            set => _syslogLoggings = value;
        }

        public OrgLoggingArgs()
        {
        }
        public static new OrgLoggingArgs Empty => new OrgLoggingArgs();
    }

    public sealed class OrgLoggingState : global::Pulumi.ResourceArgs
    {
        [Input("cloudWatchLoggings")]
        private InputList<Inputs.OrgLoggingCloudWatchLoggingGetArgs>? _cloudWatchLoggings;
        public InputList<Inputs.OrgLoggingCloudWatchLoggingGetArgs> CloudWatchLoggings
        {
            get => _cloudWatchLoggings ?? (_cloudWatchLoggings = new InputList<Inputs.OrgLoggingCloudWatchLoggingGetArgs>());
            set => _cloudWatchLoggings = value;
        }

        [Input("coralogixLoggings")]
        private InputList<Inputs.OrgLoggingCoralogixLoggingGetArgs>? _coralogixLoggings;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/coralogix)
        /// </summary>
        public InputList<Inputs.OrgLoggingCoralogixLoggingGetArgs> CoralogixLoggings
        {
            get => _coralogixLoggings ?? (_coralogixLoggings = new InputList<Inputs.OrgLoggingCoralogixLoggingGetArgs>());
            set => _coralogixLoggings = value;
        }

        /// <summary>
        /// The ID, in GUID format, of the Org.
        /// </summary>
        [Input("cplnId")]
        public Input<string>? CplnId { get; set; }

        [Input("datadogLoggings")]
        private InputList<Inputs.OrgLoggingDatadogLoggingGetArgs>? _datadogLoggings;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/datadog)
        /// </summary>
        public InputList<Inputs.OrgLoggingDatadogLoggingGetArgs> DatadogLoggings
        {
            get => _datadogLoggings ?? (_datadogLoggings = new InputList<Inputs.OrgLoggingDatadogLoggingGetArgs>());
            set => _datadogLoggings = value;
        }

        /// <summary>
        /// Description of the Org.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("elasticLoggings")]
        private InputList<Inputs.OrgLoggingElasticLoggingGetArgs>? _elasticLoggings;

        /// <summary>
        /// For logging and analyzing data within an org using Elastic Logging.
        /// </summary>
        public InputList<Inputs.OrgLoggingElasticLoggingGetArgs> ElasticLoggings
        {
            get => _elasticLoggings ?? (_elasticLoggings = new InputList<Inputs.OrgLoggingElasticLoggingGetArgs>());
            set => _elasticLoggings = value;
        }

        [Input("fluentdLoggings")]
        private InputList<Inputs.OrgLoggingFluentdLoggingGetArgs>? _fluentdLoggings;
        public InputList<Inputs.OrgLoggingFluentdLoggingGetArgs> FluentdLoggings
        {
            get => _fluentdLoggings ?? (_fluentdLoggings = new InputList<Inputs.OrgLoggingFluentdLoggingGetArgs>());
            set => _fluentdLoggings = value;
        }

        [Input("logzioLoggings")]
        private InputList<Inputs.OrgLoggingLogzioLoggingGetArgs>? _logzioLoggings;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/logz-io)
        /// </summary>
        public InputList<Inputs.OrgLoggingLogzioLoggingGetArgs> LogzioLoggings
        {
            get => _logzioLoggings ?? (_logzioLoggings = new InputList<Inputs.OrgLoggingLogzioLoggingGetArgs>());
            set => _logzioLoggings = value;
        }

        /// <summary>
        /// Name of the Org.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("s3Loggings")]
        private InputList<Inputs.OrgLoggingS3LoggingGetArgs>? _s3Loggings;

        /// <summary>
        /// [Documentation Reference](https://docs.controlplane.com/external-logging/s3)
        /// </summary>
        public InputList<Inputs.OrgLoggingS3LoggingGetArgs> S3Loggings
        {
            get => _s3Loggings ?? (_s3Loggings = new InputList<Inputs.OrgLoggingS3LoggingGetArgs>());
            set => _s3Loggings = value;
        }

        /// <summary>
        /// Full link to this resource. Can be referenced by other resources.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        [Input("stackdriverLoggings")]
        private InputList<Inputs.OrgLoggingStackdriverLoggingGetArgs>? _stackdriverLoggings;
        public InputList<Inputs.OrgLoggingStackdriverLoggingGetArgs> StackdriverLoggings
        {
            get => _stackdriverLoggings ?? (_stackdriverLoggings = new InputList<Inputs.OrgLoggingStackdriverLoggingGetArgs>());
            set => _stackdriverLoggings = value;
        }

        [Input("syslogLoggings")]
        private InputList<Inputs.OrgLoggingSyslogLoggingGetArgs>? _syslogLoggings;
        public InputList<Inputs.OrgLoggingSyslogLoggingGetArgs> SyslogLoggings
        {
            get => _syslogLoggings ?? (_syslogLoggings = new InputList<Inputs.OrgLoggingSyslogLoggingGetArgs>());
            set => _syslogLoggings = value;
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

        public OrgLoggingState()
        {
        }
        public static new OrgLoggingState Empty => new OrgLoggingState();
    }
}
