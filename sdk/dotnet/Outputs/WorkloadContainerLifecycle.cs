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
    public sealed class WorkloadContainerLifecycle
    {
        public readonly Outputs.WorkloadContainerLifecyclePostStart? PostStart;
        public readonly Outputs.WorkloadContainerLifecyclePreStop? PreStop;

        [OutputConstructor]
        private WorkloadContainerLifecycle(
            Outputs.WorkloadContainerLifecyclePostStart? postStart,

            Outputs.WorkloadContainerLifecyclePreStop? preStop)
        {
            PostStart = postStart;
            PreStop = preStop;
        }
    }
}
