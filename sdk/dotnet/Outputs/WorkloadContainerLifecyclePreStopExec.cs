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
    public sealed class WorkloadContainerLifecyclePreStopExec
    {
        /// <summary>
        /// Command and arguments executed immediately before the container is stopped.
        /// </summary>
        public readonly ImmutableArray<string> Commands;

        [OutputConstructor]
        private WorkloadContainerLifecyclePreStopExec(ImmutableArray<string> commands)
        {
            Commands = commands;
        }
    }
}
