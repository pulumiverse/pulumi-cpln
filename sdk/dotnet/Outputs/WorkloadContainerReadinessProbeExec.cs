// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Outputs
{

    [OutputType]
    public sealed class WorkloadContainerReadinessProbeExec
    {
        public readonly ImmutableArray<string> Commands;

        [OutputConstructor]
        private WorkloadContainerReadinessProbeExec(ImmutableArray<string> commands)
        {
            Commands = commands;
        }
    }
}
