// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Cpln.Inputs
{

    public sealed class IdentityNgsAccessPolicySubArgs : global::Pulumi.ResourceArgs
    {
        [Input("allows")]
        private InputList<string>? _allows;

        /// <summary>
        /// List of allow subjects.
        /// </summary>
        public InputList<string> Allows
        {
            get => _allows ?? (_allows = new InputList<string>());
            set => _allows = value;
        }

        [Input("denies")]
        private InputList<string>? _denies;

        /// <summary>
        /// List of deny subjects.
        /// </summary>
        public InputList<string> Denies
        {
            get => _denies ?? (_denies = new InputList<string>());
            set => _denies = value;
        }

        public IdentityNgsAccessPolicySubArgs()
        {
        }
        public static new IdentityNgsAccessPolicySubArgs Empty => new IdentityNgsAccessPolicySubArgs();
    }
}
